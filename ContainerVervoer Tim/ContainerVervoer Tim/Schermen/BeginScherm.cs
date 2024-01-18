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
    public partial class BeginScherm : Form
    {
        ContainersPlaatsen plaatser;
        public BeginScherm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLengte.Text)|| string.IsNullOrEmpty(tbBreedte.Text) || string.IsNullOrEmpty(tbMax.Text))
            {
                MessageBox.Show("Vul aub alle velden in.", "Verkeerde info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int schipLengte = int.Parse(tbLengte.Text);
                int schipBreedte = int.Parse(tbBreedte.Text);
                int schipMaxGewicht = int.Parse(tbMax.Text);

                if (schipLengte >= 3 && schipBreedte >= 3)
                {
                    plaatser = new ContainersPlaatsen(schipLengte, schipBreedte, schipMaxGewicht);
                    ContainersMaker containersMaker = new ContainersMaker(plaatser);
                    containersMaker.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("Het schip kan niet kleiner zijn dan 3 anders is er geen \"midden\"", "Verkeerde info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
