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
    public partial class GetActors : Form
    {
        string orcl = "Data source=orcl; user id=scott;password=tiger";
        OracleConnection conn;
        public GetActors()
        {
            InitializeComponent();
            //conn = new OracleConnection(orcl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(orcl);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GET_ACTORNAMES";
            cmd.Parameters.Add("movie_name_in", textBox1.Text);
            cmd.Parameters.Add("actor_name_out", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            listBox1.Items.Clear();
            while (dr.Read())
            {
                listBox1.Items.Add(dr[0]);
            }
            dr.Close();
        }
    }
}
