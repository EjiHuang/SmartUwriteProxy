namespace BIMTClassLibrary
{
    partial class frmGoogleSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoogleSearch));
            this.wb_google = new System.Windows.Forms.WebBrowser();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_proxy = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wb_google
            // 
            this.wb_google.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb_google.Location = new System.Drawing.Point(0, 0);
            this.wb_google.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wb_google.MinimumSize = new System.Drawing.Size(23, 28);
            this.wb_google.Name = "wb_google";
            this.wb_google.Size = new System.Drawing.Size(1106, 895);
            this.wb_google.TabIndex = 0;
            this.wb_google.Url = new System.Uri("https://scholar.google.com.hk/schhp?hl=zh-CN", System.UriKind.Absolute);
            this.wb_google.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browser_DocumentCompleted);
            this.wb_google.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_proxy);
            this.splitContainer1.Panel1.Controls.Add(this.btn_right);
            this.splitContainer1.Panel1.Controls.Add(this.btn_left);
            this.splitContainer1.Panel1.Controls.Add(this.txt_url);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.btn_home);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.wb_google);
            this.splitContainer1.Size = new System.Drawing.Size(1106, 934);
            this.splitContainer1.SplitterDistance = 33;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // btn_proxy
            // 
            this.btn_proxy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_proxy.Location = new System.Drawing.Point(1017, 5);
            this.btn_proxy.Name = "btn_proxy";
            this.btn_proxy.Size = new System.Drawing.Size(86, 27);
            this.btn_proxy.TabIndex = 2;
            this.btn_proxy.Text = "代理设置";
            this.btn_proxy.UseVisualStyleBackColor = true;
            this.btn_proxy.Visible = false;
            this.btn_proxy.Click += new System.EventHandler(this.btn_proxy_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(48, 5);
            this.btn_right.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(34, 27);
            this.btn_right.TabIndex = 0;
            this.btn_right.Text = ">";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(8, 5);
            this.btn_left.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(34, 27);
            this.btn_left.TabIndex = 0;
            this.btn_left.Text = "<";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // txt_url
            // 
            this.txt_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_url.Location = new System.Drawing.Point(406, 7);
            this.txt_url.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(697, 23);
            this.txt_url.TabIndex = 1;
            this.txt_url.TextChanged += new System.EventHandler(this.txt_url_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 27);
            this.button2.TabIndex = 0;
            this.button2.Text = "在浏览器中打开";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(180, 5);
            this.btn_home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(86, 27);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "首页";
            this.btn_home.UseVisualStyleBackColor = true;
            // 
            // frmGoogleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 934);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGoogleSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google学术搜索";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGoogleSearch_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb_google;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_proxy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}