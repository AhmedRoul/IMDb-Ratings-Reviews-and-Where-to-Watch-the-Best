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
//using static IMDB_SW.Login;

namespace IMDB_SW
{
    public partial class Form1 : Form
    {
        static int userId = 4;
        string ordb = "Data Source=ORCL ; User Id=scott ; Password= tiger";
        OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select moviename  from movie";
                OracleDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();

            

            cmd.CommandType = CommandType.Text;
         
          
            cmd.CommandText = "select moviename from movie Mo,watchlist wl where Mo.movieid =wl.movie_id and wl.user_id=:iduser " ;
          cmd.Parameters.Add("iduser",userId);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                listBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();




        }

        private void addbutton_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox1.Text != ""){
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string temp_item = comboBox1.SelectedItem.ToString();
                cmd.CommandText = "select movieid from movie where moviename = :moname";
                cmd.Parameters.Add("moname", comboBox1.SelectedItem.ToString());
                OracleDataReader dr = cmd.ExecuteReader();

                dr.Read();
                int id = int.Parse(dr[0].ToString());
                dr.Close();
                conn.Close();

                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmdd = new OracleCommand();
                cmdd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmdd.CommandText = "insert into watchlist values(:iduser,:idmov)";
                cmdd.Parameters.Add("iduser", userId);
                cmdd.Parameters.Add("idmov", id);

                int r = cmdd.ExecuteNonQuery();
                if (r != -1)
                {

                    MessageBox.Show("New movie added to Watchlist!");
                    listBox1.Items.Add(comboBox1.SelectedItem.ToString());
                    comboBox1.Text = "";
                }
            }
            else 
            {
                MessageBox.Show("Make sure to select a value in the combo box");
            }



           

        }

        private void deletebutton_MouseClick(object sender, MouseEventArgs e)
        {
            


        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (listBox1.Text != "")
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string temp_item = listBox1.SelectedItem.ToString();
                cmd.CommandText = "select movieid from movie where moviename = :moname";
                cmd.Parameters.Add("moname", temp_item);
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int id = int.Parse(dr[0].ToString());
                dr.Close();
                conn.Close();
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmdd = new OracleCommand();
                cmdd.Connection = conn;
                cmd.CommandType = CommandType.Text;


                cmdd.CommandText = "delete from  watchlist where user_id =: iduser And Movie_id = :idmovies";
                cmdd.Parameters.Add("iduser", userId);
                cmdd.Parameters.Add("idmovies", id);

                int r = cmdd.ExecuteNonQuery();
                if (r != -1)
                {

                    MessageBox.Show("Delete movie  to Watchlist!");
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
                else
                    MessageBox.Show("Error deleting");
            }
            else
            {
                MessageBox.Show("Select an item in the list");
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
