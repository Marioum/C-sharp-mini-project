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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateMyPasswordTextBox();
        }
        public void CreateMyPasswordTextBox()
        {
            // Create an instance of the TextBox control.
            TextBox txt_password2 = new TextBox();
            // Set the maximum length of text in the control to eight.
            txt_password2.MaxLength = 16;
            // Assign the asterisk to be the password character.
            txt_password2.PasswordChar = '*';
            // Change all text entered to be lowercase.
            txt_password2.CharacterCasing = CharacterCasing.Lower;
            // Align the text in the center of the TextBox control.
            txt_password2.TextAlign = HorizontalAlignment.Center;
        }

        private void label2_Click(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            string mdp="";
            string chaine = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dhib/Desktop/Professeur.accdb";
            OleDbConnection con = new OleDbConnection(chaine);
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "select mdp from enseignant where login='" + txt_login.Text + "'";

            try { con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                { mdp = (string)dr.GetValue(0);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show("Erreur : " + ex.Message); }

            if ( txt_password.Text == mdp)
            { new acceuil(txt_login.Text).Show();
            this.Hide();
            }
            else
                label3.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_login.Text = "";
            txt_password.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new inscription().Show();
            this.Hide();
        }

    }
}
