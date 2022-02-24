using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;

namespace Parsing
{
    public partial class Form1 : Form
    {
        private string[] patterns;
        private Label[] info;

        private string content;

        public Form1()
        {
            InitializeComponent();
        }

        private void GetStatsBut_Click(object sender, EventArgs e)
        {
            try
            {
                InitData();
                content = ParsingData();
                Fill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void IPTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(IPTextBox.Text, @"[^0-9.]"))
            {
                GetStatsBut.Enabled = true;
            }
            else
                GetStatsBut.Enabled = false;
        }

        private void ShowMapBut_Click(object sender, EventArgs e)
        {
            try
            {
                string latit = SetValue("<latitude>(.*?)</latitude>");
                string longit = SetValue("<longitude>(.*?)</longitude>");
                Uri uri = new Uri($@"https://www.google.ru/maps/@{latit},{longit},13z");
                MapWebB.Visible = true;
                MapWebB.Navigate(uri);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void HideMapBut_Click(object sender, EventArgs e)
        {
            MapWebB.Visible = false;
        }

        private string ParsingData()
        {
            using (WebClient wc = new WebClient())
                return wc.DownloadString($@"http://ipwhois.app/xml/{IPTextBox.Text}");
        }

        private string SetValue(string pattern)
        {
            return Regex.Match(content, pattern).Groups[1].Value;
        }

        private void Fill()
        {
            Reload();
            for (int i = 0; i < info.Length; i++)
                info[i].Text += SetValue(patterns[i]);
            ShowMapBut.Enabled = true;
        }

        private void Reload()
        {
            CountryLab.Text = "Страна: ";
            TimezoneLab.Text = "Местное время: ";
            ContinentLab.Text = "Континент: ";
            RegionLab.Text = "Регион: ";
            CityLab.Text = "Город: ";
            LatitudeLab.Text = "Широта: ";
            LongitudeLab.Text = "Долгота: ";
        }

        private void InitData()
        {
            info = new Label[]
            { CountryLab, TimezoneLab, ContinentLab, RegionLab, CityLab, LatitudeLab, LongitudeLab };

            patterns = new string[]
            {
                "<country>(.*?)</country>",
                "<timezone_gmt>(.*?)</timezone_gmt>",
                "<continent>(.*?)</continent>",
                "<region>(.*?)</region>",
                "<city>(.*?)</city>",
                "<latitude>(.*?)</latitude>",
                "<longitude>(.*?)</longitude>"
            };
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            label2.Text = this.Width.ToString();
        }
    }
}