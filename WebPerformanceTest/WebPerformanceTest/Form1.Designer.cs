namespace WebPerformanceTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.rbtGET = new System.Windows.Forms.RadioButton();
            this.rbtPOST = new System.Windows.Forms.RadioButton();
            this.txtHEADER = new System.Windows.Forms.RichTextBox();
            this.txtPostValue = new System.Windows.Forms.RichTextBox();
            this.grdResult = new System.Windows.Forms.DataGridView();
            this.txtRequestCount = new System.Windows.Forms.TextBox();
            this.txtThreadsCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).BeginInit();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(12, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(1032, 20);
            this.txtURL.TabIndex = 0;
            this.txtURL.Text = "https://zyshopper.com/api/shopper/test/refresh";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(1050, 10);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(55, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(1111, 9);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(70, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // rbtGET
            // 
            this.rbtGET.AutoSize = true;
            this.rbtGET.Checked = true;
            this.rbtGET.Location = new System.Drawing.Point(12, 38);
            this.rbtGET.Name = "rbtGET";
            this.rbtGET.Size = new System.Drawing.Size(47, 17);
            this.rbtGET.TabIndex = 3;
            this.rbtGET.Text = "GET";
            this.rbtGET.UseVisualStyleBackColor = true;
            // 
            // rbtPOST
            // 
            this.rbtPOST.AutoSize = true;
            this.rbtPOST.Location = new System.Drawing.Point(65, 38);
            this.rbtPOST.Name = "rbtPOST";
            this.rbtPOST.Size = new System.Drawing.Size(54, 17);
            this.rbtPOST.TabIndex = 4;
            this.rbtPOST.Text = "POST";
            this.rbtPOST.UseVisualStyleBackColor = true;
            // 
            // txtHEADER
            // 
            this.txtHEADER.Location = new System.Drawing.Point(125, 38);
            this.txtHEADER.Name = "txtHEADER";
            this.txtHEADER.Size = new System.Drawing.Size(317, 96);
            this.txtHEADER.TabIndex = 5;
            this.txtHEADER.Text = "";
            // 
            // txtPostValue
            // 
            this.txtPostValue.Location = new System.Drawing.Point(448, 38);
            this.txtPostValue.Name = "txtPostValue";
            this.txtPostValue.Size = new System.Drawing.Size(596, 96);
            this.txtPostValue.TabIndex = 6;
            this.txtPostValue.Text = "";
            // 
            // grdResult
            // 
            this.grdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResult.Location = new System.Drawing.Point(12, 140);
            this.grdResult.Name = "grdResult";
            this.grdResult.Size = new System.Drawing.Size(1169, 251);
            this.grdResult.TabIndex = 7;
            // 
            // txtRequestCount
            // 
            this.txtRequestCount.Location = new System.Drawing.Point(1050, 39);
            this.txtRequestCount.Name = "txtRequestCount";
            this.txtRequestCount.Size = new System.Drawing.Size(131, 20);
            this.txtRequestCount.TabIndex = 8;
            this.txtRequestCount.Text = "50";
            // 
            // txtThreadsCount
            // 
            this.txtThreadsCount.Location = new System.Drawing.Point(1050, 65);
            this.txtThreadsCount.Name = "txtThreadsCount";
            this.txtThreadsCount.Size = new System.Drawing.Size(131, 20);
            this.txtThreadsCount.TabIndex = 9;
            this.txtThreadsCount.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 403);
            this.Controls.Add(this.txtThreadsCount);
            this.Controls.Add(this.txtRequestCount);
            this.Controls.Add(this.grdResult);
            this.Controls.Add(this.txtPostValue);
            this.Controls.Add(this.txtHEADER);
            this.Controls.Add(this.rbtPOST);
            this.Controls.Add(this.rbtGET);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtURL);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RadioButton rbtGET;
        private System.Windows.Forms.RadioButton rbtPOST;
        private System.Windows.Forms.RichTextBox txtHEADER;
        private System.Windows.Forms.RichTextBox txtPostValue;
        private System.Windows.Forms.DataGridView grdResult;
        private System.Windows.Forms.TextBox txtRequestCount;
        private System.Windows.Forms.TextBox txtThreadsCount;
    }
}

