using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace sarki_liste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string baglanti ="Server=localhost;Database=muzik;Uid=root;Pwd=";



        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(baglanti))
            {
                string sql = "Select * from sarkilar";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con); 
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt=new DataTable();
                da.Fill(dt);
                dgvListe.DataSource = dt;
                
            }




        }
    }
}
