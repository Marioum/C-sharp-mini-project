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
    public partial class note : Form
    {
        string login;
        string id_id="";
        public note(string l)
        {
            


            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string chaine = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dhib/Desktop/Professeur.accdb";
            OleDbConnection con = new OleDbConnection(chaine);
            OleDbCommand cmd = con.CreateCommand();
            OleDbCommand cmd1 = con.CreateCommand();
            cmd.CommandText = "select cin from assiste where id_module=" + label1.Text + " group by cin";
          
            try
            {
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
        
                while (dr.Read())
                {
                    //dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(0));
                    cmd1.CommandText="select nom,prenom from etudiant where cin="+dr.GetValue(0);
                    
                    try { OleDbDataReader dr1 = cmd1.ExecuteReader(); dr1.Read(); dataGridView1.Rows.Add(dr.GetValue(0), dr1.GetValue(0), dr1.GetValue(1),0); }
                    catch (Exception ex) { }
                    
                }
                dr.Close();
                con.Close();

            }
            catch (Exception ex) { MessageBox.Show("Erreur : " + ex.Message); con.Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new modules(login).Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add_note f = new add_note(login);
            f.label1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f.label3.Text = label1.Text;
            f.Show();
            this.Hide();
        }
    }
}
