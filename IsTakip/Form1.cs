using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;
using System.Xml;

namespace IsTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList fav = new ArrayList();
        string[] url;

        private void reading()
        {
            if (!Directory.Exists("C:\\tarayici"))
            {
                Directory.CreateDirectory("C:\\tarayici");
            }

            if (!File.Exists("C:\\tarayici\\adresler.txt"))
            {
                File.Create("C:\\tarayici\\adresler.txt");
            }

            try
            {
                StreamReader sr = new StreamReader("C:\\tarayici\\adresler.txt");
                string line = sr.ReadLine();

                while (line != null)
                {
                    fav.Add(line);
                    line = sr.ReadLine();
                }

                sr.Close();
                url = new string[fav.Count];

                addMenuItem();
            }
            catch
            {
                MessageBox.Show("Hızlı kayıtta veri yok, isterseniz i'den nasıl yapılacağına bakabilirsiniz","Hızlı Kayıt Yok",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }

        private void addMenuItem()
        {
            string text = "";
            string urlText = "";
            int c = 0;

            for (int i = 0; i < fav.Count; i++)
            {
                char[] txt = fav[i].ToString().ToCharArray();

                for (int j = 0; j < txt.Length; j++)
                {
                    if (txt[j] != 'ß' && c == 0)
                    {
                        text += txt[j];
                    }
                    else if (txt[j] != 'ß' && c != 0)
                    {
                        urlText += txt[j];
                    }
                    else
                    {
                        c++;
                    }
                }

                ToolStripMenuItem item = new ToolStripMenuItem();

                url[i] = urlText;
                item.Text = text;
                item.Enabled = true;
                item.Visible = true;
                item.Click += item_Click;
                item.Tag = new { Url = urlText };

                toolStripMenuItem2.DropDownItems.Add(item);

                void item_Click(object sender, EventArgs e)
                {
                    ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;

                    if (clickedItem != null && clickedItem.Tag != null)
                    {
                        var data = (dynamic)clickedItem.Tag;
                        string url = data.Url;

                        webView21.CoreWebView2.Navigate(url);
                        tsTxtURL.Text = url;
                    }
                }

                urlText = "";
                text = "";

                c = 0;
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await InitializeWebView();

            reading();

            webView21.CoreWebView2.Navigate("https://www.google.com");
            tsTxtURL.Text = "https://www.google.com";
        }

        private async Task InitializeWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);

            webView21.CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;

        }

        private void CoreWebView2_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            var currentUrl = webView21.CoreWebView2.Source;
            tsTxtURL.Text = currentUrl;
            Console.WriteLine(currentUrl);
        }

        private void tsHomePage_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.google.com");
            tsTxtURL.Text = "https://www.google.com";
        }

        private void tsSearch_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.google.com/search?q=" + tsTxtURL.Text);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.GoBack();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.GoForward();
        }

        private void tsInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("* 'C:\\tarayici\\adresler.txt' adresine url ekleyin,\n" +
                "* <Gözükecek İsim> ß (alt gr + S) <Site Urlsi> şeklinde url ekleme yapın,\n" +
                "! (Site urlsi başında 'https://' olmak zorunda) !\n" +
                "* Timer dakika cinsinde çalışıyor. 1'den küçük ve sayı dışı değer girmeyin", "Dikkat Edilmesi Gerekenler");
        }

        private void tsRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                webView21.CoreWebView2.Navigate(tsTxtURL.Text);
            }
            catch
            {

            }
        }

        bool timeOpen = true;
        int timeMin = 1;

        private void tsStratStop_Click(object sender, EventArgs e)
        {
            try
            {
                timeMin = int.Parse(tsTxtTime.Text);

                if (timeMin <= 0)
                {
                    MessageBox.Show("Lütfen 1'den küçük değer girmeyin", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tsTxtTime.Text = "1";
                    timeMin = 1;
                }


            }
            catch
            {
                MessageBox.Show("Lütfen sadece sayı girin", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tsTxtTime.Text = "1";
                timeMin = 1;
            }

            if (timeOpen)
            {
                timer1.Start();
                tsTimer.BackColor = Color.Salmon;
                tsStratStop.Text = "Kapat";
                timeOpen = false;
            }
            else
            {
                timer1.Stop();
                tsTimer.BackColor = Color.PaleGreen;
                tsStratStop.Text = "Başlat";
                timeOpen = true;
            }
        }

        int time = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time++ == (timeMin * 60))
            {
                webView21.CoreWebView2.Navigate(tsTxtURL.Text);
                time = 1;
            }
        }

        private void tsTxtURL_DoubleClick(object sender, EventArgs e)
        {
            tsTxtURL.SelectAll();
        }
    }
}
