using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace professeur
{
    
    public partial class nouveau_module : Form
    {
        string login = "";

        public nouveau_module(string l)
        {
            login = l;
            InitializeComponent();
        }

        private int number()
        {

            return 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            date.CustomFormat = "dd/MM/yyyy";
            string chaine = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dhib/Desktop/Professeur.accdb";
            OleDbConnection con = new OleDbConnection(chaine);
            OleDbCommand cmd = con.CreateCommand();

            cmd.CommandText = "Insert into module1(nom_module,coef,anne,semestre,login_enseignant) values ('" + txt_nv_module.Text + "','" + Convert.ToInt32(txt_coef.Text) + "','" + date.Text + "'," + Convert.ToInt32(txt_semestre.Text) + ",'" + login + "')";
          
           
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajout Module Réussi");
                txt_nv_module.Text = "";
                txt_coef.Text = "";
                txt_semestre.Text = "";
                con.Close();
                
                new acceuil(login).Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex.Message);
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new nouveau_module(login).Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new acceuil(login).Show();
            this.Hide();
        }
    }
}
