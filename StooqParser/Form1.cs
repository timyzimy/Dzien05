using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StooqParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtStop.Value = DateTime.Now;
            dtStart.Value = DateTime.Now.AddMonths(-1);
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            String ticker = tbTicker.Text.ToLower();
            String d1 = dtStart.Value.ToString("yyyyMMdd");
            String d2 = dtStop.Value.ToString("yyyyMMdd");
            String url = String.Format("https://stooq.pl/q/d/l/?s={0}&d1={1}&d2={2}&i=d", 
                                        ticker, d1, d2);

            dgvData.Columns.Add("DATE", "Data");
            dgvData.Columns.Add("CLOSE", "Kurs zamknięcia");
            dgvData.Columns.Add("VOLUME", "Wolumen");

            dgvData.Columns[0].Width = 100;
            dgvData.Columns[1].Width = 300;
            dgvData.Columns[2].Width = 100;

            try
            {
                WebClient webClient = new WebClient();
                //String s = webClient.DownloadString(url);

                webClient.DownloadFile(url, @"c:\tmp\notowania.txt");
                String s = File.ReadAllText(@"c:\tmp\notowania.txt");

                //webClient.DownloadFile("https://cdn.galleries.smcloud.net/t/galleries/gf-Bn4u-rcjk-SgDJ_memy-na-swiatowy-dzien-kota-2020-one-po-prostu-takie-sa-664x0-nocrop.jpg",
                //            @"c:\tmp\kot.jpg");

                string[] lines = s.Split('\n');
                bool firstLine = false;
                foreach (String line in lines)
                {
                    if (!firstLine)
                    {
                        firstLine = true;
                        continue;
                    }
                    string[] items = line.Trim().Split(',');
                    if (items.Length < 6) continue;

                    string[] row = new string[] { items[0], items[4], items[5] };
                    dgvData.Rows.Add(row);
                }
            } catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
