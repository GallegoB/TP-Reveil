using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{


    public partial class reveil : Form
    {
        //--- Propiétés ---
        private SortedList<DateTime, Rappel> rappels = new SortedList<DateTime, Rappel>();

        //--- constcteur ---
        public reveil()
        {
            InitializeComponent();

        }

        //--- quand on clic sur ajouter ---
        private void btnAjout_Click(object sender, EventArgs e)
        {


            if (this.txtRappel.Text != "")
            {
                DateTime laDate = new DateTime(this.dtpJour.Value.Year, this.dtpJour.Value.Month, this.dtpJour.Value.Day,
                this.dtpHeure.Value.Hour, this.dtpHeure.Value.Minute, 0);

                if (!this.rappels.ContainsKey(laDate))
                {
                    Rappel lerappel = new Rappel(this.txtRappel.Text, laDate, this.cboFrequence.SelectedIndex);
                    this.rappels.Add(laDate, lerappel);
                    this.majListeRappels();
                }
                else
                {

                }
            }
            else
            {

            }
        }

        private void majListeRappels()
        {
            lstEnsemble.Items.Clear();
            foreach (Rappel lerappel in rappels.Values)
            {
                this.lstEnsemble.Items.Add(lerappel.getDate().ToShortDateString() + "" + lerappel.getDate().ToShortDateString() + " : " + lerappel.getLibelle());
            }
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            this.Rappel.clear();
            this.majListeRappels(0);
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (this.lstEnsemble.SelectedIndex != -1)
            {
                this.supprRappel(this.lstEnsemble.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Un élement de la liste doit être sélectionné");
            }

        }
        //--- Suppression d'un rappel suivant son indice ---
        private void supprRappel(int k)
        {
            this.rappels.RemoveAt(k);
            this.majListeRappels(k);
        }
    }
}
