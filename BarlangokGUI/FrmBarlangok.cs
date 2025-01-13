using System.Text;

namespace BarlangokGUI
{
    public partial class FrmBarlangok : Form
    {
        const string PATH = "C:\\PROJECTS\\CSHARP25011303\\BarlangokGUI\\RESOURCES\\barlangok.txt";
        List<Barlang> barlangok = [];
        Barlang kijBarlang = null;

        public FrmBarlangok()
        {
            InitializeComponent();
            this.Load += FrmBarlangok_Load;
            btnKereses.Click += BtnKereses_Click;
            btnMentes.Click += BtnMentes_Click;
        }

        private void BtnMentes_Click(object sender, EventArgs e)
        {
            try
            {
                kijBarlang.Hossz = int.Parse(tbxHossz.Text);
                kijBarlang.Melyseg = int.Parse(tbxMely.Text);
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message);
            }
            finally
            {
                EredetiAllapot();
            }
        }

        private void BtnKereses_Click(object? sender, EventArgs e)
        {
            kijBarlang = barlangok.SingleOrDefault(b => b.Azon == int.Parse(tbxAzon.Text));
            if (kijBarlang is null)
            {
                _ = MessageBox.Show("Ezzel az azonosítóval nem létezik barlang!");
                EredetiAllapot();
            }
            else
            {
                lblNev.Text = kijBarlang.Nev;
                tbxHossz.Text = $"{kijBarlang.Hossz}";
                tbxMely.Text = $"{kijBarlang.Melyseg}";
                btnMentes.Enabled = true;
            }
        }

        private void FrmBarlangok_Load(object? sender, EventArgs e)
        {
            using StreamReader sr = new(PATH, Encoding.UTF8);
            _ = sr.ReadLine();
            while (!sr.EndOfStream) barlangok.Add(new(sr.ReadLine()));
        }

        private void EredetiAllapot()
        {
            kijBarlang = null;
            tbxAzon.Text = string.Empty;
            tbxHossz.Text = string.Empty;
            tbxMely.Text = string.Empty;
            lblNev.Text = string.Empty;
            btnMentes.Enabled = false;
        }
    }
}
