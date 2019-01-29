namespace NaverToolApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtbSource = new System.Windows.Forms.RichTextBox();
            this.rtbLink = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnPaste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbSource
            // 
            this.rtbSource.BackColor = System.Drawing.SystemColors.Window;
            this.rtbSource.DetectUrls = false;
            this.rtbSource.Location = new System.Drawing.Point(12, 12);
            this.rtbSource.Name = "rtbSource";
            this.rtbSource.Size = new System.Drawing.Size(379, 201);
            this.rtbSource.TabIndex = 0;
            this.rtbSource.Text = resources.GetString("rtbSource.Text");
            this.rtbSource.Click += new System.EventHandler(this.rtbSource_Click);
            // 
            // rtbLink
            // 
            this.rtbLink.Location = new System.Drawing.Point(12, 219);
            this.rtbLink.Name = "rtbLink";
            this.rtbLink.Size = new System.Drawing.Size(379, 201);
            this.rtbLink.TabIndex = 1;
            this.rtbLink.Text = "";
            this.rtbLink.Click += new System.EventHandler(this.rtbLink_Click);
            // 
            // btnGet
            // 
            this.btnGet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGet.Location = new System.Drawing.Point(397, 53);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(122, 35);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Download";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(397, 94);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(122, 35);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export Text File";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(418, 408);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 12);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "@L O N G  K E N J";
            // 
            // btnPaste
            // 
            this.btnPaste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaste.Location = new System.Drawing.Point(397, 12);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(122, 35);
            this.btnPaste.TabIndex = 5;
            this.btnPaste.Text = "Paste Source";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 430);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.rtbLink);
            this.Controls.Add(this.rtbSource);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Naver Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSource;
        private System.Windows.Forms.RichTextBox rtbLink;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnPaste;
    }
}

