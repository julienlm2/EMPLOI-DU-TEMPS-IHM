using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EMPLOI_DU_TEMPS_IHM
{
    public partial class Form1 : Form
    {
        
        ServiceReference1.WebService1SoapClient LE_SERVICE = new ServiceReference1.WebService1SoapClient();
        static string cours_choisi;
        static string utilisateurs_choisi;

        public Form1()
        {
            InitializeComponent();
            Data_cours.DataSource = LE_SERVICE.DonneCours();
            Data_Etudiants.DataSource = LE_SERVICE.DonneUtilisateurs();
        }

        private void BTN_COURS_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        

        private void Data_cours_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cours_choisi = Data_cours.CurrentRow.Cells[0].Value.ToString();
            TBX_ID_COURS.Text = cours_choisi;

        }

        private void Data_Etudiants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            utilisateurs_choisi = Data_Etudiants.CurrentRow.Cells[0].Value.ToString();
            TBX_ID_ELEVE.Text = utilisateurs_choisi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int user = int.Parse(cours_choisi);
            int cours = int.Parse(utilisateurs_choisi);
            LE_SERVICE.AddPresence(cours, user);
            MessageBox.Show("Presence ajouté avec succés");
        }
    }
}
