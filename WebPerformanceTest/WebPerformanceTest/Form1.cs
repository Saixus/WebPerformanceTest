using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebPerformanceTest
{
    public partial class Form1 : Form
    {
        DataTable dtResults;

        public Form1()
        {
            InitializeComponent();

            dtResults = new DataTable("Test Results");
            dtResults.Columns.Add(new DataColumn("ThreadID", typeof(string)));
            dtResults.Columns.Add(new DataColumn("Request Number", typeof(string)));
            dtResults.Columns.Add(new DataColumn("Average request time", typeof(string)));
            dtResults.Columns.Add(new DataColumn("Request State", typeof(string)));
            dtResults.Columns.Add(new DataColumn("Last cycle length", typeof(string)));
            //dtResults.Columns.Add(new DataColumn("Average request time", typeof(string)));

            grdResult.DataSource = dtResults;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            var url = txtURL.Text;
            var headers = txtHEADER.Text.Split('\r');
            var postVal = txtPostValue.Text;
            var requestType = (rbtGET.Checked) ? 1 : 2;

            for (int i = 0; i < int.Parse(txtThreadsCount.Text); ++i)
            {
                Task.Factory.StartNew(() =>
                {
                    var rowResults = dtResults.NewRow();
                    rowResults[0] = Thread.CurrentThread.ManagedThreadId.ToString();

                    lock (dtResults)
                    {
                        dtResults.Rows.Add(rowResults);
                    }

                    int summTime = 0;
                    int count = int.Parse(txtRequestCount.Text);
                    for (int j = 0; j < count; ++j)
                    {
                        var begTime = DateTime.Now;
                        var reqResult = RequestServer(url, requestType, headers, postVal);
                        var tt = (DateTime.Now - begTime).TotalMilliseconds;
                        summTime += (int)Math.Floor(tt);
                        lock (dtResults)
                        {
                            rowResults["Request State"] = reqResult;
                            rowResults["Request Number"] = (j + 1).ToString();
                            rowResults["Average request time"] = (summTime / (j + 1)).ToString();
                            rowResults["Last cycle length"] = tt.ToString();
                        }
                    }
                    lock (dtResults)
                    {
                        rowResults["Average request time"] = (summTime / count).ToString();
                    }
                });
            }

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Thread.Sleep(1000);
                    UpdateGrid();
                }
            });
        }

        public void UpdateGrid()
        {
            //_rtb.Invoke(() => { _rtb.AppendText(string.Format(s, args)); });
            if (grdResult.InvokeRequired)
            {
                // this means we're on the wrong thread!  
                // use BeginInvoke or Invoke to call back on the 
                // correct thread.
                grdResult.Invoke(
                    new RichTextBoxUpdateEventHandler(UpdateGrid), // the method to call back on
                    null);                              // the list of arguments to pass
            }
            else
            {
                grdResult.Update();
                grdResult.Refresh();
            }
        }
        private delegate void RichTextBoxUpdateEventHandler();

        private static string RequestServer(string url, int method, string[] headers, string postValue)
        {
            using (var c = new WebClient())
            {

                foreach (string h in headers)
                {
                    if (!string.IsNullOrEmpty(h))
                    {
                        var hh = h.Split('Ё');
                        c.Headers.Add(hh[0], hh[1]);
                    }
                }

                switch (method)
                {
                    case 1: // GET
                        return c.DownloadString(url);
                    case 2: // POST
                        c.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                        return c.UploadString(url, postValue).ToString();
                }

                return null;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }
    }
}
