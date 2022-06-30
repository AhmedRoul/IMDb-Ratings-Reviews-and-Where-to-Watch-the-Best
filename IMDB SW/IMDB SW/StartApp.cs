using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static IMDB_SW.Homepage;
namespace IMDB_SW
{
    public partial class StartApp : Form
    {
        public StartApp()
        {
            InitializeComponent();
        }

        private void StartApp_Load(object sender, EventArgs e)
        {
            

            // Task.Factory.StartNew(() =>
            // {
             // HOMEPAGEISOPEN = true;
             //  Thread.Sleep(2000);
             this.Hide();
              (new Homepage()).Show();

              

            // });
        }
    }
}
