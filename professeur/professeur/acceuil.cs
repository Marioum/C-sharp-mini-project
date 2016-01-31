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
    public partial class acceuil : Form
    {
        string nom="";
        string login = "";
        public acceuil(string l){

            login = l;
            string chaine = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dhib/Desktop/Professeur.accdb";
            OleDbConnection con = new OleDbConnection(chaine);
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "select prenom from enseignant where login='" + l + "'";
            try { con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                { nom = (string)dr.GetValue(0);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show("Erreur : " + ex.Message); }
        
            InitializeComponent();
            label2.Text = nom;
            label3.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute ;
        }
        private void label2_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            new gestion_compte(login).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new modules(login).Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new etudiant(login).Show();
            this.Hide();
        }
    }
}
