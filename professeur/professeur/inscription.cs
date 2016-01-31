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
    public partial class inscription : Form
    {
        public inscription()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label2.Text = label3.Text = label4.Text = label5.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string chaine = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dhib/Desktop/Professeur.accdb";
            OleDbConnection con = new OleDbConnection(chaine);

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "Insert into enseignant(login,mdp,nom,prenom,grade) values ('" + txt_insc_login.Text + "','" + txt_insc_password.Text + "','" + txt_insc_family.Text + "','" + txt_insc_name.Text + "','" + txt_insc_grade.Text + "')";
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajout Réussi");
                txt_insc_login.Text = "";
                txt_insc_password.Text = "";
                txt_insc_family.Text = "";
                txt_insc_name.Text = "";
                txt_insc_grade.Text = "";
                con.Close();
                new Form1().Show();
                this.Hide();

            }catch(Exception ex)
            { MessageBox.Show("Erreur" + ex.Message);
            con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
