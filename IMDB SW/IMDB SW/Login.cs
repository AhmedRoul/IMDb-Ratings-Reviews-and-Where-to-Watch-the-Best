using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
//using static IMDB_SW.HomePageWithLogin;
namespace IMDB_SW
{
    public partial class Login : Form
    {
        
        public static int userId = 0;
        string ordb = "Data Source=ORCL ; User Id=scott ; Password= tiger";
        OracleConnection conn;
    
        public Login()
        {
            InitializeComponent();
          
        }
       

        private void Login_Load(object sender, EventArgs e)
        {
            // this.FormClosing += new FormClosingEventHandler(Login_FormClosing);

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            if (passtxtbox.Text != string.Empty || usernametxtbox.Text != string.Empty)
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select userid  from Users where username= :username and userpassword=:password ";
                cmd.Parameters.Add("username", usernametxtbox.Text);
                cmd.Parameters.Add("password", passtxtbox.Text);
                
                
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    if (usernametxtbox.Text.ToLower() == "admin" && passtxtbox.Text.ToLower() == "admin")
                    {
                        //go admin page 
                        this.Hide();
                        (new Admin()).Show();
                    }
                    else
                    {
                        userId=  Convert.ToInt32( dr[0]);

                        this.Hide();
                        (new HomePageWithLogin()).Show();
                    }
                   
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernametxtbox.Text = "";
                    passtxtbox.Text = "";

                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passtxtbox_TextChanged(object sender, EventArgs e)
        {
            //char lastChar = passtxtbox.Text[passtxtbox.Text.Length - 1];
            //passtxtbox.Text.Remove(passtxtbox.Text.Length - 1);
            //if (lastChar == '\n')
            //{
            //    button1.PerformClick();
            //}
        }

        private void passtxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void usernametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernametxtbox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        
    }
}
