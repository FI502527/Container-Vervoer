using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContainerVervoer_Tim.Model;

namespace ContainerVervoer_Tim.Schermen
{
    public partial class ContainersMaker : Form
    {
        ContainersPlaatsen plaatser;
        int nummerContainers = 1;
        public ContainersMaker(ContainersPlaatsen plaatser)
        {
            InitializeComponent();
            this.plaatser = plaatser;
            lbContainers.Items.Clear();

            //Zet details op het scherm
            lblDetails.Text = plaatser.schip.Lengte + " x " + plaatser.schip.Breedte;
            lblGewicht.Text = plaatser.schip.MaxGewicht.ToString() + " Ton";

            //Vul de types box in met standaard waardes
            cbType.DataSource = Enum.GetValues(typeof(Type));
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            bool status = int.TryParse(tbGewicht.Text, out int gewicht);
            if (status)
            {
                Containers container = new Containers(nummerContainers.ToString(), gewicht, (Type)cbType.SelectedValue);
                nummerContainers++;
                lbContainers.Items.Add(container);
                plaatser.containersPlaatsen.Add(container);
            }
            else
            {
                MessageBox.Show("Vul aub alleen nummers in");
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < plaatser.schip.Lengte; a++)
            {
                for (int b = 0; b < plaatser.schip.Breedte; b++)
                {
                    Containers container = new Containers(nummerContainers.ToString(), RandomGewicht(), RandomType());
                    nummerContainers++;

                    int huidigeGewicht = plaatser.containersPlaatsen.Sum(cntrs => cntrs.Gewicht);
                    if (huidigeGewicht + container.Gewicht <= plaatser.schip.MaxGewicht)
                    {
                        lbContainers.Items.Add(container);
                        plaatser.containersPlaatsen.Add(container);
                    }
                }
            }
        }
        private Type RandomType()
        {
            //Kies random type
            //https://stackoverflow.com/questions/3132126/how-do-i-select-a-random-value-from-an-enumeration
            Array waardes = Enum.GetValues(typeof(Type));
            Random random = new Random();
            Type type = (Type)waardes.GetValue(random.Next(waardes.Length));
            return type;
        }
        private int RandomGewicht()
        {
            Random random = new Random();
            int nummer = random.Next(4, 30);
            return nummer;
        }

        private void btnSorteer_Click(object sender, EventArgs e)
        {
            if (plaatser.SorteerContainers())
            {
                SorteerScherm sorteer = new SorteerScherm(plaatser);
                sorteer.Show();
                this.Hide();
                return;
            }
        }
    }
}
