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
using System.Collections;

namespace professeur
{
    public partial class nouveau_etudiant : Form
    {
        string login = "";
        int id;
        string nom = "";
        public Hashtable hash = new Hashtable();

        public nouveau_etudiant(string l)
        {

            login = l;
            InitializeComponent();
            string chaine = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dhib/Desktop/Professeur.accdb";
            OleDbConnection con = new OleDbConnection(chaine);
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "select module_ID,nom_module from module1 where login_enseignant='"+login+"'";
            try
            {
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    id = (int)dr.GetValue(0);
                    nom = (string)dr.GetValue(1);
                    hash.Add(nom, id);
                    checkedListBox1.Items.Add(nom);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show("Erreur : " + ex.Message); con.Close(); }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string chaine = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dhib/Desktop/Professeur.accdb";
            OleDbConnection con = new OleDbConnection(chaine);
            OleDbCommand cmd = con.CreateCommand();
            OleDbCommand cmd1 = con.CreateCommand();

            cmd.CommandText = "Insert into etudiant values (" + Convert.ToInt32(txt_cin.Text) + ",'" + txt_nom.Text + "','" + txt_prenom.Text + "','" + comboBox1.Text + "')";
            

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajout Module Réussi");
                con.Close();

                new acceuil(login).Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex.Message);
                con.Close();
            }



            //ckecked lisT 
             foreach(object itemChecked in checkedListBox1.CheckedItems) {
                 cmd1.CommandText = "Insert into assiste(cin,id_module,date_present) values(" + Convert.ToInt32(txt_cin.Text) + "," + hash[(string)itemChecked] + ",'" + DateTime.Now.ToString("dd-MM-yyyy") + "')";
                 try
                 {
                     con.Open();
                     cmd1.ExecuteNonQuery();
                     con.Close();


                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Erreur" + ex.Message);
                     con.Close();
                 }
             }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            new etudiant(login).Show();
            this.Hide();
        }
    }
}
