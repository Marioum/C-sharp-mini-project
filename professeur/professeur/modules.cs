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
    public partial class modules : Form
    {
        string login="";
        public modules(string l)
        {
            login = l;
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new nouveau_module(login).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string chaine = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dhib/Desktop/Professeur.accdb";
            OleDbConnection con = new OleDbConnection(chaine);
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from module1";
            try
            {
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4),dr.GetValue(0));
                }
                dr.Close();
                con.Close();
                
            }
            catch (Exception ex) { MessageBox.Show("Erreur : " + ex.Message); con.Close(); }



          //  dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }


        /*private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            new note(id).Show();
            this.Hide();
        }
        */
        private void button3_Click(object sender, EventArgs e)
        {
            new acceuil(login).Show();
            this.Hide();
        }
       /* private void Edit_Click(object sender, EventArgs e)
        {
            note f = new note(login);
            MessageBox.Show(this.dataGridView1.CurrentRow.Cells[4].Value.ToString());

            f.zouba = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[4].Value.ToString());
            f.Show();
            this.Hide();

        }*/

        private void Edit_Click_1(object sender, EventArgs e)
        {
            note f = new note(login);
            f.label1.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f.Show();
            this.Hide();
        }
    }
}
