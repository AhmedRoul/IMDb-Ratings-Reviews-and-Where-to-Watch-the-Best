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

namespace IMDB_SW
{
    public partial class search : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        OracleConnection conn;
        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger;";
       
        public search()
        {
            InitializeComponent();
            


        }

        private void search_Load(object sender, EventArgs e)
        {
            
        }

        

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            // Disconnected
            string cmdstr = "";
            if(rdo_actors.Checked)
            {
                cmdstr = "select * from actorsinfo where actor_NAME like '%" + searchbox.Text + "%'";
            }
            else if (rdo_tvshow.Checked)
            {
                cmdstr = "select * from tvshow where showname like '%" + searchbox.Text + "%'";
            }
            else if (rdo_movie.Checked)
            {
                cmdstr = "select * from movie  where moviename like '%" + searchbox.Text + "%'";
            }
            adapter = new OracleDataAdapter(cmdstr, ordb);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];









            // Connected search
            /* {
                listBox1.Items.Clear();
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select moviename from movie  where moviename like '%" + searchbox.Text + "%'";
                cmd.Parameters.Add("moviename", searchbox.Text);
                cmd.CommandType = CommandType.Text;


                OracleDataReader dr = cmd.ExecuteReader();

                dr.Read();
                while (dr.Read())
                {
                    listBox1.Items.Add(dr[0]);


                }
            } */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }
    }
}
