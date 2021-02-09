using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml.Linq;
using System.Globalization;

namespace zadanieDodatkowe2
{
    public partial class Okno : Form
    {
        public Okno()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGoldenrodYellow;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += async (sender, e) =>
            {
                string rawxml = e.Result;
                var lista = await saveDataToObjectList(rawxml);
                fillListview(lista);
                button1.Text = "Pobrano dane!";
            };
            
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadStringAsync(new Uri("http://biznes.pap.pl/pl/quotations/continuousQuotations/xml/,"+ DateTime.Now.ToString("yyyy-MM-dd")));
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private  void fillListview(List<Organizacja> organizacje)
        {
             organizacje.ForEach(x => listView1.Items.Add(
                 new ListViewItem(new string[] { x.name, 
                     x.ticker, x.date.ToString("yyyy.MM.dd"), 
                     x.openrate.ToString(), x.rate.ToString(), x.volume.ToString(),
                     x.tournover.ToString(), x.isin.ToString()})));
        }

        private async Task<List<Organizacja>> saveDataToObjectList(string rawxml)
        {
            List<Organizacja> lista = await Task.Run(() => XDocument.Parse(rawxml)
                 .Descendants("SHARES")
                 .Descendants("INSTRUMENT")
                 .Select(x => new Organizacja
                 {
                     name = x.Element("NAME").Value,
                     ticker = x.Element("TICKER").Value,
                     date = DateTime.ParseExact(x.Element("date").Value, "yyyy-MM-dd", CultureInfo.InvariantCulture),
                     openrate = double.Parse(x.Element("OPENRATE").Value, CultureInfo.InvariantCulture),
                     rate = double.Parse(x.Element("RATE").Value, CultureInfo.InvariantCulture),
                     volume = double.Parse(x.Element("VOLUME").Value, CultureInfo.InvariantCulture),
                     tournover = double.Parse(x.Element("TOURNOVER").Value, CultureInfo.InvariantCulture),
                     isin = x.Element("ISIN").Value
                 }).ToList());
            return lista;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
