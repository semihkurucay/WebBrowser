namespace IsTakip
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTxtURL = new System.Windows.Forms.ToolStripTextBox();
            this.tsSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTimer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTxtTime = new System.Windows.Forms.ToolStripTextBox();
            this.tsStratStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHomePage,
            this.toolStripMenuItem2,
            this.tsTxtURL,
            this.tsSearch,
            this.tsRefresh,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.tsTimer,
            this.tsInfo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsHomePage
            // 
            this.tsHomePage.Name = "tsHomePage";
            this.tsHomePage.Size = new System.Drawing.Size(71, 23);
            this.tsHomePage.Text = "Ana Sayfa";
            this.tsHomePage.Click += new System.EventHandler(this.tsHomePage_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(77, 23);
            this.toolStripMenuItem2.Text = "Hızlı Seçim";
            // 
            // tsTxtURL
            // 
            this.tsTxtURL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTxtURL.Name = "tsTxtURL";
            this.tsTxtURL.Size = new System.Drawing.Size(450, 23);
            this.tsTxtURL.DoubleClick += new System.EventHandler(this.tsTxtURL_DoubleClick);
            // 
            // tsSearch
            // 
            this.tsSearch.Name = "tsSearch";
            this.tsSearch.Size = new System.Drawing.Size(37, 23);
            this.tsSearch.Text = "Ara";
            this.tsSearch.ToolTipText = "Arama";
            this.tsSearch.Click += new System.EventHandler(this.tsSearch_Click);
            // 
            // tsRefresh
            // 
            this.tsRefresh.Name = "tsRefresh";
            this.tsRefresh.Size = new System.Drawing.Size(29, 23);
            this.tsRefresh.Text = "↻";
            this.tsRefresh.ToolTipText = "Yenile";
            this.tsRefresh.Click += new System.EventHandler(this.tsRefresh_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(35, 23);
            this.toolStripMenuItem3.Text = "<<";
            this.toolStripMenuItem3.ToolTipText = "Geri Git";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(35, 23);
            this.toolStripMenuItem4.Text = ">>";
            this.toolStripMenuItem4.ToolTipText = "İleri Git";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // tsTimer
            // 
            this.tsTimer.BackColor = System.Drawing.Color.PaleGreen;
            this.tsTimer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTxtTime,
            this.tsStratStop});
            this.tsTimer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsTimer.Name = "tsTimer";
            this.tsTimer.Size = new System.Drawing.Size(38, 23);
            this.tsTimer.Text = "⏱";
            this.tsTimer.ToolTipText = "Oto Yenileme";
            // 
            // tsTxtTime
            // 
            this.tsTxtTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsTxtTime.Name = "tsTxtTime";
            this.tsTxtTime.Size = new System.Drawing.Size(100, 23);
            this.tsTxtTime.Text = "1";
            // 
            // tsStratStop
            // 
            this.tsStratStop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsStratStop.Name = "tsStratStop";
            this.tsStratStop.Size = new System.Drawing.Size(180, 22);
            this.tsStratStop.Text = "Başlat";
            this.tsStratStop.Click += new System.EventHandler(this.tsStratStop_Click);
            // 
            // tsInfo
            // 
            this.tsInfo.BackgroundImage = global::IsTakip.Properties.Resources.icons8_info_480;
            this.tsInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsInfo.Name = "tsInfo";
            this.tsInfo.Size = new System.Drawing.Size(25, 23);
            this.tsInfo.Text = "  ";
            this.tsInfo.ToolTipText = "Bilgilendirme";
            this.tsInfo.Click += new System.EventHandler(this.tsInfo_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 27);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(906, 551);
            this.webView21.TabIndex = 2;
            this.webView21.ZoomFactor = 1D;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 578);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kamu İş Takip";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsHomePage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripTextBox tsTxtURL;
        private System.Windows.Forms.ToolStripMenuItem tsSearch;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.ToolStripMenuItem tsInfo;
        private System.Windows.Forms.ToolStripMenuItem tsRefresh;
        private System.Windows.Forms.ToolStripMenuItem tsTimer;
        private System.Windows.Forms.ToolStripTextBox tsTxtTime;
        private System.Windows.Forms.ToolStripMenuItem tsStratStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

