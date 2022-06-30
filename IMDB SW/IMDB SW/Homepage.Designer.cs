using System.Windows.Forms;

namespace IMDB_SW
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Watchlist = new System.Windows.Forms.Button();
            this.SignIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameFilm1 = new System.Windows.Forms.Label();
            this.rate1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rate2 = new System.Windows.Forms.Label();
            this.NameFilm2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.rate3 = new System.Windows.Forms.Label();
            this.NameFilm3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.RELEASE_DATE1 = new System.Windows.Forms.Label();
            this.category1 = new System.Windows.Forms.Label();
            this.MOVIE_DURATION1 = new System.Windows.Forms.Label();
            this.MOVIE_DURATION2 = new System.Windows.Forms.Label();
            this.category2 = new System.Windows.Forms.Label();
            this.RELEASE_DATE2 = new System.Windows.Forms.Label();
            this.MOVIE_DURATION3 = new System.Windows.Forms.Label();
            this.category3 = new System.Windows.Forms.Label();
            this.RELEASE_DATE3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(209, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(70, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(285, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(70, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 72);
            this.label2.TabIndex = 5;
            this.label2.Text = "IMDb";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(380, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Search
            // 
            this.Search.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Search.BackColor = System.Drawing.Color.Black;
            this.Search.Location = new System.Drawing.Point(514, 48);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(61, 20);
            this.Search.TabIndex = 7;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Watchlist
            // 
            this.Watchlist.BackColor = System.Drawing.Color.Black;
            this.Watchlist.Location = new System.Drawing.Point(596, 48);
            this.Watchlist.Name = "Watchlist";
            this.Watchlist.Size = new System.Drawing.Size(64, 20);
            this.Watchlist.TabIndex = 8;
            this.Watchlist.Text = "Watchlist";
            this.Watchlist.UseVisualStyleBackColor = false;
            this.Watchlist.Click += new System.EventHandler(this.Watchlist_Click);
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.Black;
            this.SignIn.Location = new System.Drawing.Point(684, 48);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(64, 20);
            this.SignIn.TabIndex = 9;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(10, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Top Rating  (Film)";
            // 
            // NameFilm1
            // 
            this.NameFilm1.AutoSize = true;
            this.NameFilm1.BackColor = System.Drawing.Color.Black;
            this.NameFilm1.ForeColor = System.Drawing.Color.Gold;
            this.NameFilm1.Location = new System.Drawing.Point(110, 225);
            this.NameFilm1.Name = "NameFilm1";
            this.NameFilm1.Size = new System.Drawing.Size(35, 13);
            this.NameFilm1.TabIndex = 10;
            this.NameFilm1.Text = "label3";
            // 
            // rate1
            // 
            this.rate1.AutoSize = true;
            this.rate1.BackColor = System.Drawing.Color.Black;
            this.rate1.ForeColor = System.Drawing.Color.Gold;
            this.rate1.Location = new System.Drawing.Point(149, 266);
            this.rate1.Name = "rate1";
            this.rate1.Size = new System.Drawing.Size(35, 13);
            this.rate1.TabIndex = 11;
            this.rate1.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(110, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(94, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 20);
            this.button1.TabIndex = 13;
            this.button1.Text = "Watch list";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.Gold;
            this.button2.Location = new System.Drawing.Point(301, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 20);
            this.button2.TabIndex = 17;
            this.button2.Text = "Watch list";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rate2
            // 
            this.rate2.AutoSize = true;
            this.rate2.BackColor = System.Drawing.Color.Black;
            this.rate2.ForeColor = System.Drawing.Color.Gold;
            this.rate2.Location = new System.Drawing.Point(326, 266);
            this.rate2.Name = "rate2";
            this.rate2.Size = new System.Drawing.Size(35, 13);
            this.rate2.TabIndex = 15;
            this.rate2.Text = "label7";
            // 
            // NameFilm2
            // 
            this.NameFilm2.AutoSize = true;
            this.NameFilm2.BackColor = System.Drawing.Color.Black;
            this.NameFilm2.ForeColor = System.Drawing.Color.Gold;
            this.NameFilm2.Location = new System.Drawing.Point(298, 225);
            this.NameFilm2.Name = "NameFilm2";
            this.NameFilm2.Size = new System.Drawing.Size(35, 13);
            this.NameFilm2.TabIndex = 14;
            this.NameFilm2.Text = "label8";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.ForeColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(489, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 20);
            this.button3.TabIndex = 21;
            this.button3.Text = "Watch list";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rate3
            // 
            this.rate3.AutoSize = true;
            this.rate3.BackColor = System.Drawing.Color.Black;
            this.rate3.ForeColor = System.Drawing.Color.Gold;
            this.rate3.Location = new System.Drawing.Point(512, 266);
            this.rate3.Name = "rate3";
            this.rate3.Size = new System.Drawing.Size(41, 13);
            this.rate3.TabIndex = 19;
            this.rate3.Text = "label10";
            // 
            // NameFilm3
            // 
            this.NameFilm3.AutoSize = true;
            this.NameFilm3.BackColor = System.Drawing.Color.Black;
            this.NameFilm3.ForeColor = System.Drawing.Color.Gold;
            this.NameFilm3.Location = new System.Drawing.Point(486, 225);
            this.NameFilm3.Name = "NameFilm3";
            this.NameFilm3.Size = new System.Drawing.Size(41, 13);
            this.NameFilm3.TabIndex = 18;
            this.NameFilm3.Text = "label11";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.ForeColor = System.Drawing.Color.Gold;
            this.textBox2.Location = new System.Drawing.Point(94, 304);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(30, 20);
            this.textBox2.TabIndex = 22;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.ForeColor = System.Drawing.Color.Gold;
            this.label12.Location = new System.Drawing.Point(91, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "rate  ★";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.ForeColor = System.Drawing.Color.Gold;
            this.button4.Location = new System.Drawing.Point(130, 304);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 20);
            this.button4.TabIndex = 26;
            this.button4.Text = "Add your rate ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.ForeColor = System.Drawing.Color.Gold;
            this.button5.Location = new System.Drawing.Point(323, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 20);
            this.button5.TabIndex = 27;
            this.button5.Text = "Add your rate ";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.ForeColor = System.Drawing.Color.Gold;
            this.button6.Location = new System.Drawing.Point(495, 309);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 20);
            this.button6.TabIndex = 28;
            this.button6.Text = "Add your rate ";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.ForeColor = System.Drawing.Color.Gold;
            this.textBox3.Location = new System.Drawing.Point(287, 304);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(30, 20);
            this.textBox3.TabIndex = 29;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.ForeColor = System.Drawing.Color.Gold;
            this.textBox4.Location = new System.Drawing.Point(459, 309);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(30, 20);
            this.textBox4.TabIndex = 30;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // RELEASE_DATE1
            // 
            this.RELEASE_DATE1.AutoSize = true;
            this.RELEASE_DATE1.BackColor = System.Drawing.Color.Black;
            this.RELEASE_DATE1.ForeColor = System.Drawing.Color.Gold;
            this.RELEASE_DATE1.Location = new System.Drawing.Point(91, 345);
            this.RELEASE_DATE1.Name = "RELEASE_DATE1";
            this.RELEASE_DATE1.Size = new System.Drawing.Size(35, 13);
            this.RELEASE_DATE1.TabIndex = 31;
            this.RELEASE_DATE1.Text = "label3";
            // 
            // category1
            // 
            this.category1.AutoSize = true;
            this.category1.BackColor = System.Drawing.Color.Black;
            this.category1.ForeColor = System.Drawing.Color.Gold;
            this.category1.Location = new System.Drawing.Point(91, 394);
            this.category1.Name = "category1";
            this.category1.Size = new System.Drawing.Size(35, 13);
            this.category1.TabIndex = 32;
            this.category1.Text = "label4";
            // 
            // MOVIE_DURATION1
            // 
            this.MOVIE_DURATION1.AutoSize = true;
            this.MOVIE_DURATION1.BackColor = System.Drawing.Color.Black;
            this.MOVIE_DURATION1.ForeColor = System.Drawing.Color.Gold;
            this.MOVIE_DURATION1.Location = new System.Drawing.Point(183, 372);
            this.MOVIE_DURATION1.Name = "MOVIE_DURATION1";
            this.MOVIE_DURATION1.Size = new System.Drawing.Size(35, 13);
            this.MOVIE_DURATION1.TabIndex = 33;
            this.MOVIE_DURATION1.Text = "label6";
            // 
            // MOVIE_DURATION2
            // 
            this.MOVIE_DURATION2.AutoSize = true;
            this.MOVIE_DURATION2.BackColor = System.Drawing.Color.Black;
            this.MOVIE_DURATION2.ForeColor = System.Drawing.Color.Gold;
            this.MOVIE_DURATION2.Location = new System.Drawing.Point(376, 372);
            this.MOVIE_DURATION2.Name = "MOVIE_DURATION2";
            this.MOVIE_DURATION2.Size = new System.Drawing.Size(35, 13);
            this.MOVIE_DURATION2.TabIndex = 36;
            this.MOVIE_DURATION2.Text = "label6";
            // 
            // category2
            // 
            this.category2.AutoSize = true;
            this.category2.BackColor = System.Drawing.Color.Black;
            this.category2.ForeColor = System.Drawing.Color.Gold;
            this.category2.Location = new System.Drawing.Point(298, 394);
            this.category2.Name = "category2";
            this.category2.Size = new System.Drawing.Size(35, 13);
            this.category2.TabIndex = 35;
            this.category2.Text = "label4";
            // 
            // RELEASE_DATE2
            // 
            this.RELEASE_DATE2.AutoSize = true;
            this.RELEASE_DATE2.BackColor = System.Drawing.Color.Black;
            this.RELEASE_DATE2.ForeColor = System.Drawing.Color.Gold;
            this.RELEASE_DATE2.Location = new System.Drawing.Point(298, 345);
            this.RELEASE_DATE2.Name = "RELEASE_DATE2";
            this.RELEASE_DATE2.Size = new System.Drawing.Size(35, 13);
            this.RELEASE_DATE2.TabIndex = 34;
            this.RELEASE_DATE2.Text = "label3";
            // 
            // MOVIE_DURATION3
            // 
            this.MOVIE_DURATION3.AutoSize = true;
            this.MOVIE_DURATION3.BackColor = System.Drawing.Color.Black;
            this.MOVIE_DURATION3.ForeColor = System.Drawing.Color.Gold;
            this.MOVIE_DURATION3.Location = new System.Drawing.Point(578, 372);
            this.MOVIE_DURATION3.Name = "MOVIE_DURATION3";
            this.MOVIE_DURATION3.Size = new System.Drawing.Size(35, 13);
            this.MOVIE_DURATION3.TabIndex = 39;
            this.MOVIE_DURATION3.Text = "label6";
            // 
            // category3
            // 
            this.category3.AutoSize = true;
            this.category3.BackColor = System.Drawing.Color.Black;
            this.category3.ForeColor = System.Drawing.Color.Gold;
            this.category3.Location = new System.Drawing.Point(486, 394);
            this.category3.Name = "category3";
            this.category3.Size = new System.Drawing.Size(35, 13);
            this.category3.TabIndex = 38;
            this.category3.Text = "label4";
            // 
            // RELEASE_DATE3
            // 
            this.RELEASE_DATE3.AutoSize = true;
            this.RELEASE_DATE3.BackColor = System.Drawing.Color.Black;
            this.RELEASE_DATE3.ForeColor = System.Drawing.Color.Gold;
            this.RELEASE_DATE3.Location = new System.Drawing.Point(486, 345);
            this.RELEASE_DATE3.Name = "RELEASE_DATE3";
            this.RELEASE_DATE3.Size = new System.Drawing.Size(35, 13);
            this.RELEASE_DATE3.TabIndex = 37;
            this.RELEASE_DATE3.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(277, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "rate  ★";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(461, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "rate  ★";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.functionsToolStripMenuItem.Text = "Search IMDb";
            this.functionsToolStripMenuItem.Click += new System.EventHandler(this.functionsToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 480);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MOVIE_DURATION3);
            this.Controls.Add(this.category3);
            this.Controls.Add(this.RELEASE_DATE3);
            this.Controls.Add(this.MOVIE_DURATION2);
            this.Controls.Add(this.category2);
            this.Controls.Add(this.RELEASE_DATE2);
            this.Controls.Add(this.MOVIE_DURATION1);
            this.Controls.Add(this.category1);
            this.Controls.Add(this.RELEASE_DATE1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rate3);
            this.Controls.Add(this.NameFilm3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rate2);
            this.Controls.Add(this.NameFilm2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rate1);
            this.Controls.Add(this.NameFilm1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.Watchlist);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private TextBox textBox1;
        private Button Search;
        private Button Watchlist;
        private Button SignIn;
        private Label label1;
        private Label NameFilm1;
        private Label rate1;
        private Label label5;
        private Button button1;
        private Button button2;
        private Label rate2;
        private Label NameFilm2;
        private Button button3;
        private Label rate3;
        private Label NameFilm3;
        private TextBox textBox2;
        private Label label12;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label RELEASE_DATE1;
        private Label category1;
        private Label MOVIE_DURATION1;
        private Label MOVIE_DURATION2;
        private Label category2;
        private Label RELEASE_DATE2;
        private Label MOVIE_DURATION3;
        private Label category3;
        private Label RELEASE_DATE3;
        private Label label3;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem functionsToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
    }
}