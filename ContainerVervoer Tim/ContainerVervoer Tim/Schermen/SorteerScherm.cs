using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContainerVervoer_Tim.Model;
using static System.Windows.Forms.AxHost;

namespace ContainerVervoer_Tim.Schermen
{
    public partial class SorteerScherm : Form
    {
        private ContainersPlaatsen plaatser;
        public SorteerScherm(ContainersPlaatsen plaatser)
        {
            InitializeComponent();
            this.plaatser = plaatser;
        }

        private void SorteerScherm_Load(object sender, EventArgs e)
        {
            int boxWidth = 75;
            int boxHeight = 50;

            int waarde1 = 0;
            int waarde2 = 0;

            List<Rij> rijen = plaatser.schip.Rijen;
            foreach (Rij rij in rijen)
            {
                List<ContainerStapel> stapels = rij.Stapel;
                foreach (ContainerStapel stapel in stapels)
                {
                    Label nieuweStapel = new Label
                    {
                        ForeColor = Color.Black,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Text = "Stapel: " + waarde1 + " x " + waarde2,
                        BackColor = SystemColors.Menu,
                        Size = new Size(boxWidth, boxHeight),
                        Location = new Point((boxWidth + 5) * waarde1 + 5, (boxHeight + 5) * waarde2 + 5)
                    };
                    nieuweStapel.Click += new EventHandler(LaatInfoZien);
                    Controls.Add(nieuweStapel);
                    waarde2++;
                }
                waarde1++;
                waarde2 = 0;
            }
        }
        private void LaatInfoZien(object sender, EventArgs e)
        {
            Label label = sender as Label;

            if (label != null)
            {
                int x = int.Parse(label.Text.Substring(8, 2));
                int z = int.Parse(label.Text.Substring(12));

                Rij rij = plaatser.schip.Rijen[x];
                ContainerStapel stapel = rij.Stapel[z];
                string textOutput = "";
                foreach (Containers containers in stapel.Containers)
                {
                    textOutput += containers.ToString() + "\n";
                }

                MessageBox.Show(textOutput, "Stapel: " + x + " - " + z, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
