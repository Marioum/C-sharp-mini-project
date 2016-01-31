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
    public partial class add_note : Form
    {
        string login = "";
        public add_note(string l)
        {
            login = l;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new note(login).Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chaine = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dhib/Desktop/Professeur.accdb";
            OleDbConnection con = new OleDbConnection(chaine);
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "update assiste set note="+Convert.ToInt32(label2.Text)+"where cin="+label1.Text+" and  id_module="+label3.Text;
            try
            {
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("Modification note added");
                dr.Close();
                con.Close();
                new note(login).Show();
                this.Hide();

            }
            catch (Exception ex) { MessageBox.Show("Erreur : " + ex.Message); con.Close(); }
        }
    }
}
