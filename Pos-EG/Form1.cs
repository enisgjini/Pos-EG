using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Libraria MySql
using MySql.Data;
using MySql.Data.MySqlClient;



namespace Pos_EG
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            // Making connection  
            con = new MySqlConnection("server=127.0.0.1;user id=root;password=12345678;port=3305;persistsecurityinfo=True;database=pos");
        }
        private void kyqja_Click(object sender, EventArgs e)
        {

            string user = username.Text;
            string pass = password.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM login WHERE username='" + username.Text + "' AND password='" + password.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               
                FluentDesignForm1 f2 = new FluentDesignForm1(); //this is the change, code for redirect  
                f2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();

        }







        // Mbyllja e programit
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Minimizimi i programit
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Link i jashtem i cili dergon perdoruesin tek zhvilluesi i ketij programi
        private void externallink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://enis-gjini.netlify.app/");
        }

        private void mbylle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
