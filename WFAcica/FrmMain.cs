using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WFAcica
{
    public partial class FrmMain : Form
    {
        public List<TesztKerdes> kerdesek;
        int aktualisKerdes = 0;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnTallozas_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            var res = fbd.ShowDialog();

            if (res == DialogResult.OK)
            {
                lblEleresiUt.Text = fbd.SelectedPath;
                var fileLista = Directory.GetFiles(fbd.SelectedPath);
                lbFileok.Items.Clear();
                lbFileok.Items.AddRange(fileLista);

                var kepek = new List<Image>();
                string tesztEleresiUt = null;

                foreach (var path in fileLista)
                {
                    if (path.EndsWith(".png") || path.EndsWith(".jpg"))
                    {
                        kepek.Add(Image.FromFile(path));
                    }
                    else tesztEleresiUt = path;
                }

                var sr = new StreamReader(tesztEleresiUt, Encoding.UTF8);

                int i = 0;
                kerdesek = new List<TesztKerdes>();
                while (!sr.EndOfStream)
                {
                    var sor = sr.ReadLine().Split(';');

                    kerdesek.Add(new TesztKerdes()
                    {
                        Kerdes = sor[0],
                        Valaszok = new string[] { sor[1], sor[2], sor[3], sor[4], },
                        Kep = kepek[i],
                    });
                    i++;
                }
                SetTesztKerdes(aktualisKerdes);
            }
        }

        private void SetTesztKerdes(int i)
        {
            gbKerdes.Text = kerdesek[i].Kerdes;
            int vi = 0;
            foreach (var rb in gbKerdes.Controls)
            {
                if (rb is RadioButton) (rb as RadioButton).Text = kerdesek[i].Valaszok[vi];
                vi++;
            }
            pbKep.Image = kerdesek[i].Kep;
        }

        private void btnElozo_Click(object sender, EventArgs e)
        {
            if(aktualisKerdes > 0)aktualisKerdes--;
            SetTesztKerdes(aktualisKerdes);
        }

        private void btnKovetkezo_Click(object sender, EventArgs e)
        {
            if (aktualisKerdes < kerdesek.Count - 1) aktualisKerdes++;
            SetTesztKerdes(aktualisKerdes);
        }

        private void btnValasz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ez még nem csinál szart se, fáradt vagyok :(");
        }
    }
}
