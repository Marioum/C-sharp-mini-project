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
    public partial class gestion_compte : Form
    {
        string login = "";
        public gestion_compte(string l)
        {

            InitializeComponent();
            login = l;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string chaine = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dhib/Desktop/Professeur.accdb";
            OleDbConnection con = new OleDbConnection(chaine);
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "update enseignant set mdp='" + txt_g_password.Text + "',nom=' "+txt_g_family.Text+"',prenom='"+txt_g_name.Text+"', grade='"+txt_g_grade.Text+"' where login='"+login+"'";
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modification Réussi");
                txt_g_password.Text = "";
                txt_g_family.Text = "";
                txt_g_name.Text = "";
                txt_g_grade.Text = "";
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

        private void txt_g_login_TextChanged(object sender, EventArgs e){ }

        private void clear_Click(object sender, EventArgs e)
        {
            this.Hide();
            new gestion_compte(login).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new acceuil(login).Show();
            this.Hide();
        }

    }
}
