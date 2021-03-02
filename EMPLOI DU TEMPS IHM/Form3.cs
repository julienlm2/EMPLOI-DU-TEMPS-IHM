using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPLOI_DU_TEMPS_IHM
{
    public partial class Form3 : Form
    {

        ServiceReference1.WebService1SoapClient LE_SERVICE = new ServiceReference1.WebService1SoapClient();

        static string cours_choisi;

        public Form3()
        {
            InitializeComponent();

            Data_cours.DataSource = LE_SERVICE.DonneCours();

        }

        private void Data_cours_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                cours_choisi = Data_cours.CurrentRow.Cells[0].Value.ToString();
                TBX_ID_COURS.Text = cours_choisi;
            
            if (cours_choisi != null)
            {
                int id_cours = int.Parse(cours_choisi);
                dataGridView1.DataSource = LE_SERVICE.DONNEPRESENCEAVECIDCOURS(id_cours);
            }
        }

        private void BTN_SUPPRIME_Click(object sender, EventArgs e)
        {
            LE_SERVICE.SupprimePresence();
            MessageBox.Show("Toutes les présences ont été supprimées");
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
