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
    public partial class HomePageWithLogin : Form
    {
        public int[] IDMovies;
        float[] rate ;

        
        OracleConnection conn;
        string orcl = "Data source=orcl; user id=scott;password=tiger";

        public HomePageWithLogin()
        {
            InitializeComponent(); 

            comboBox2.Text = "Category";
            comboBox1.Text = "ALL";
            comboBox1.Items.Add("ALL");
            comboBox1.Items.Add("Movies");
            comboBox1.Items.Add("Actors");
            comboBox1.Items.Add("TVSHOW");

            IDMovies = new int[3];
            rate = new float[3];
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

            cmd.CommandText = "select  Mo.movie_duration,  Mo.movie_rating,  Mo.moviename,  Mo.release_date, ca.category_name, Mo.movieid from MOVIE Mo, moviecategory ca  where ca.catrgory_id= mo.movie_category_id  And rownum < 4  ORDER BY MOVIE_RATING DESC";
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
            IDMovies[0] = Convert.ToInt32(dr["movieid"].ToString());
           
            dr.Read();
            //setData  second movies_2 
            this.NameFilm2.Text = dr["moviename"].ToString();
            rate2.Text = dr["movie_rating"].ToString();
            dateTime = dr.GetDateTime(3);
            RELEASE_DATE2.Text = "release date " + dateTime.ToString("MM/dd/yyyy");
            MOVIE_DURATION2.Text = dr["MOVIE_DURATION"].ToString() + "M";
            category2.Text = "category : " + dr["category_name"].ToString();
            IDMovies[1] = Convert.ToInt32(dr["movieid"].ToString());


            dr.Read();
            //setData  Third movies_3 
            this.NameFilm3.Text = dr["moviename"].ToString();
            rate3.Text = dr["movie_rating"].ToString();
            dateTime = dr.GetDateTime(3);
            RELEASE_DATE3.Text = "release date " + dateTime.ToString("MM/dd/yyyy");
            MOVIE_DURATION3.Text = dr["MOVIE_DURATION"].ToString() + "M";
            category3.Text = "category : " + dr["category_name"].ToString();
            IDMovies[2] = Convert.ToInt32(dr["movieid"].ToString());
            dr.Close();


            AddRate();

        }

        /// <summary>
        /// Check if the user has given rate before or not
        /// If he has rate, it will be shown to him
        /// 
        /// </summary>
        private void  AddRate()
        {
           
            for(int i=0; i<IDMovies.Length; i++)    
            {
                rate[i]=getRateUser(IDMovies[i]);
            }

            if (rate[0] != -1)
            {
                rate_Film_user1.Text = rate[0].ToString();
                button_user_rate1.Text = "Change Rate";
            }
            else
                rate_Film_user1.Clear() ;


            if (rate[1] != -1)
            {
                rate_Film_user2.Text = rate[1].ToString();
                button_user_rate2.Text = "Change Rate";
            }
            else
                rate_Film_user2.Clear();

            if (rate[2] != -1)
            {
                rate_Film_user3.Text = rate[2].ToString();
                button_user_rate3.Text = "Change Rate";
            }
            else
                rate_Film_user3.Clear();


        }

        /// <summary>
        /// connection with database and 
        /// check and get rate if  the user has rate  for this movie or not
        /// </summary>
        /// <param name="idmovies">id movie if user has rate or not  </param>
        private float getRateUser(int idmovies)
        {
            conn = new OracleConnection(orcl);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select  rating  from user_rating where movie_id =:idmovies And user_id=:iduser ";
            cmd.Parameters.Add("idmovies", idmovies);
            cmd.Parameters.Add("iduser", Login.userId);
            OracleDataReader dr =cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString() != "")
                    return (float)Convert.ToDouble(dr[0]);
                else
                    return-1;
            }
            else
                return -1;


        }

        /// <summary>
        /// user can make logout from his profile 
        /// </summary>
        private void SignIn_Click(object sender, EventArgs e)
        {
            Login.userId = 0;
            this.Hide();
            (new Homepage()).Show();


        }

        private void HomePageWithLogin_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Home_FormClosing);
        }
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
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
        /// <summary>
        /// user can change his rate 
        /// or add new rate in database
        /// </summary>
        private void button_user_rate1_Click(object sender, EventArgs e)
        {
            float rateText = float.Parse( rate_Film_user1.Text.ToString());

            if (rateText>=0&&rateText<=10)
            {
                
                if (!string.IsNullOrEmpty(rate_Film_user1.Text))
                    rate1.Text = updateRate(IDMovies[0], rateText).ToString();
                else
                   rate1.Text=insertRate(IDMovies[0], rateText).ToString();
                   
                
                

                button_user_rate1.Text = "Change Rate";

            }
            else
                MessageBox.Show("Add valid rate ");
        }
        /// <summary>
        /// If the user has already given his rate 
        /// rate will be updated 
        /// </summary>
        private float updateRate(int idmovies ,float rate)
        {
            
            conn = new OracleConnection(orcl);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE_RATE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("idmovies",idmovies.ToString());
            cmd.Parameters.Add("iduser",Login.userId.ToString());
            cmd.Parameters.Add("rate",rate.ToString());
            cmd.Parameters.Add("Avg_rate_out", OracleDbType.Decimal, ParameterDirection.Output);

            cmd.ExecuteNonQuery();

            return (float)Decimal.Parse(cmd.Parameters["Avg_rate_out"].Value.ToString());
        }

        /// <summary>
        /// He has never given his rate
        /// rate will be inserted 
        /// </summary>
        private float insertRate(int idmovies, float rate)
        {
            conn = new OracleConnection(orcl);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert_RATE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("idmovies", idmovies.ToString());
            cmd.Parameters.Add("iduser", Login.userId.ToString());
            cmd.Parameters.Add("rate", rate.ToString());
            cmd.Parameters.Add("Avg_rate_out", OracleDbType.BinaryFloat, ParameterDirection.Output);

            cmd.ExecuteNonQuery();

            return (float)Convert.ToDouble(cmd.Parameters["Avg_rate_out"].Value);
        }

        private void rate_Film_user1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// user can change his rate 
        /// or add new rate in database
        /// </summary>
        private void button_user_rate2_Click(object sender, EventArgs e)
        {
            float rateText = float.Parse(rate_Film_user2.Text.ToString());

            if (rateText >= 0 && rateText <= 10)
            {

                if (!string.IsNullOrEmpty(rate_Film_user2.Text))
                    rate2.Text = updateRate(IDMovies[1], rateText).ToString();
                else
                    rate2.Text = insertRate(IDMovies[1], rateText).ToString();




                button_user_rate2.Text = "Change Rate";

            }
            else
                MessageBox.Show("Add valid rate ");
        }
        /// <summary>
        /// user can change his rate 
        /// or add new rate in database
        /// </summary>
        private void button_user_rate3_Click(object sender, EventArgs e)
        {
            float rateText = float.Parse(rate_Film_user3.Text.ToString());

            if (rateText >= 0 && rateText <= 10)
            {

                if (!string.IsNullOrEmpty(rate_Film_user3.Text))
                    rate3.Text = updateRate(IDMovies[2], rateText).ToString();
                else
                    rate3.Text = insertRate(IDMovies[2], rateText).ToString();




                button_user_rate3.Text = "Change Rate";

            }
            else
                MessageBox.Show("Add valid rate ");
        }


        /// <summary>
        /// user can change his rate 
        /// or add new rate in database
        /// </summary>
        private void Watchlist_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        /// <summary>
        /// user can change his rate 
        /// or add new rate in database
        /// </summary>
        private void Search_Click(object sender, EventArgs e)
        {
            // this.Hide();
            //(new nameform()).show();
        }

       

        

        private void Watchlist_MouseDown(object sender, MouseEventArgs e)
        {
            this.Watchlist.BackColor = System.Drawing.Color.Gold;
        }

        private void Watchlist_MouseUp(object sender, MouseEventArgs e)
        {
            this.Watchlist.BackColor = System.Drawing.Color.Black;
        }
    }
}
