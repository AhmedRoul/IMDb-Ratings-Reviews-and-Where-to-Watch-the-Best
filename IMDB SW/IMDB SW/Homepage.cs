using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static IMDB_SW.Login;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace IMDB_SW
{
    public partial class Homepage : Form
    {
      
       
        OracleConnection conn;
        string orcl = "Data source=orcl; user id=scott;password=tiger";

        public Homepage()
        {
            InitializeComponent(); 

            comboBox2.Text = "Category";
            comboBox1.Text="ALL";
            comboBox1.Items.Add( "ALL");
            comboBox1.Items.Add("Movies");
            comboBox1.Items.Add("Actors");
            comboBox1.Items.Add("TVSHOW");

           DisplayMovies();

        }

        /// <summary>
        /// connection database get top  3 rates Movies 
        ///and set Movies into form  
        /// </summary>
        private void DisplayMovies()
        {
            conn = new OracleConnection(orcl);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select  Mo.movie_duration,  Mo.movie_rating,  Mo.moviename,  Mo.release_date, ca.category_name from MOVIE Mo, moviecategory ca  where ca.catrgory_id= mo.movie_category_id  And rownum < 4  ORDER BY MOVIE_RATING DESC";
            cmd.CommandType = CommandType.Text;
           
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            //setData  Frist movies_1 
            this.NameFilm1.Text = dr["moviename"].ToString();
            rate1.Text = dr["movie_rating"].ToString();
            DateTime dateTime = dr.GetDateTime(3);
            RELEASE_DATE1.Text = "release date " + dateTime.ToString("MM/dd/yyyy");
            MOVIE_DURATION1.Text = dr["MOVIE_DURATION"].ToString() + "M";
            category1.Text = "category : " + dr["category_name"].ToString();


            dr.Read();
            //setData  second movies_2 
            this.NameFilm2.Text = dr["moviename"].ToString();
            rate2.Text = dr["movie_rating"].ToString();
            dateTime = dr.GetDateTime(3);
            RELEASE_DATE2.Text = "release date " + dateTime.ToString("MM/dd/yyyy");
            MOVIE_DURATION2.Text = dr["MOVIE_DURATION"].ToString() + "M";
            category2.Text = "category : " + dr["category_name"].ToString();



            dr.Read();

            //setData  Third movies_3 
            this.NameFilm3.Text = dr["moviename"].ToString();
            rate3.Text = dr["movie_rating"].ToString();
            dateTime = dr.GetDateTime(3);
            RELEASE_DATE3.Text = "release date " + dateTime.ToString("MM/dd/yyyy");
            MOVIE_DURATION3.Text = dr["MOVIE_DURATION"].ToString() + "M";
            category3.Text = "category : " + dr["category_name"].ToString();


            dr.Close();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Homepage_FormClosing);
        }

        /// <summary>
        /// user should login first  to see his watchlist
        /// and go to Login page
        /// </summary>
        private void Watchlist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pls Login frist");
            this.Hide();
            (new Login()).Show();
        }

        /// <summary>
        /// go to Login page
        /// </summary>
        private void SignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Login()).Show();

        }
        /// <summary>
        /// if user select Movies or TVshow 
        /// he can add CATEGORY
        /// </summary>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select= comboBox1.SelectedItem.ToString();
            if (select=="Movies"||select== "TVSHOW")
            {
               
                comboBox2.Visible = true;
                conn = new OracleConnection(orcl);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select CATEGORY_NAME  from MOVIECATEGORY ";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox2.Items.Add(dr[0]);
                }
                dr.Close();
            }
            else
            {
                comboBox2.Visible = false ;
                comboBox2.Items.Clear();
            }
        }

        /// <summary>
        /// user should login first  and he can be add his rate 
        /// </summary>
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Pls Login frist");
            this.Hide();
            (new Login()).Show();

        }
        /// <summary>
        /// user should login first  and he can be add his rate 
        /// </summary>
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Pls Login frist");
            this.Hide();
            (new Login()).Show();

        }
        /// <summary>
        /// user should login first  and he can be add his rate 
        /// </summary>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Pls Login frist");
            this.Hide();
            (new Login()).Show();

        }
        /// <summary>
        /// user should login first  and he can be add his rate 
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pls Login frist");
            this.Hide();
            (new Login()).Show();
        }
        /// <summary>
        /// user should login first  and he can be add his rate 
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pls Login frist");
            this.Hide();
            (new Login()).Show();
        }
        /// <summary>
        /// user should login first  and he can be add his rate 
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pls Login frist");
            this.Hide();
            (new Login()).Show();
        }


        /// <summary>
        /// user should login first  and he can be add his rate 
        /// </summary>
        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            MessageBox.Show("Pls Login frist");
            this.Hide();
            (new Login()).Show();
        }
        /// <summary>
        /// user should login first  and he can be add his rate 
        /// </summary>
        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            MessageBox.Show("Pls Login frist");
            this.Hide();
            (new Login()).Show();

        }
        

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Search_Click(object sender, EventArgs e)
        {
            // this.Hide();
            //(new nameform()).show();
        }

        

        private void functionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search s = new search();
            s.Show();
        }
    }
}
