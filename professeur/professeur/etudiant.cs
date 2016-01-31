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
    public partial class etudiant : Form
    {
        string login = "";
        public etudiant(string l)
        {
            login = l;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new nouveau_etudiant(login).Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string chaine = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dhib/Desktop/Professeur.accdb";
            OleDbConnection con = new OleDbConnection(chaine);
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from etudiant";
            try
            {
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3));
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show("Erreur : " + ex.Message); con.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new acceuil(login).Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            presence f = new presence(login);
            f.label1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f.Show();
            this.Hide();
        }
    }
}
