
namespace IMDB_SW
{
    partial class search
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
            this.searchbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdo_movie = new System.Windows.Forms.RadioButton();
            this.rdo_tvshow = new System.Windows.Forms.RadioButton();
            this.rdo_actors = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(162, 49);
            this.searchbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(203, 20);
            this.searchbox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DimGray;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(-2, 117);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(604, 225);
            this.listBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "IMDb";
            // 
            // rdo_movie
            // 
            this.rdo_movie.AutoSize = true;
            this.rdo_movie.ForeColor = System.Drawing.Color.White;
            this.rdo_movie.Location = new System.Drawing.Point(162, 28);
            this.rdo_movie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo_movie.Name = "rdo_movie";
            this.rdo_movie.Size = new System.Drawing.Size(58, 17);
            this.rdo_movie.TabIndex = 7;
            this.rdo_movie.TabStop = true;
            this.rdo_movie.Text = "Movies";
            this.rdo_movie.UseVisualStyleBackColor = true;
            // 
            // rdo_tvshow
            // 
            this.rdo_tvshow.AutoSize = true;
            this.rdo_tvshow.ForeColor = System.Drawing.Color.White;
            this.rdo_tvshow.Location = new System.Drawing.Point(228, 28);
            this.rdo_tvshow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo_tvshow.Name = "rdo_tvshow";
            this.rdo_tvshow.Size = new System.Drawing.Size(66, 17);
            this.rdo_tvshow.TabIndex = 8;
            this.rdo_tvshow.TabStop = true;
            this.rdo_tvshow.Text = "TV Show";
            this.rdo_tvshow.UseVisualStyleBackColor = true;
            // 
            // rdo_actors
            // 
            this.rdo_actors.AutoSize = true;
            this.rdo_actors.ForeColor = System.Drawing.Color.White;
            this.rdo_actors.Location = new System.Drawing.Point(302, 28);
            this.rdo_actors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo_actors.Name = "rdo_actors";
            this.rdo_actors.Size = new System.Drawing.Size(56, 17);
            this.rdo_actors.TabIndex = 9;
            this.rdo_actors.TabStop = true;
            this.rdo_actors.Text = "Actors";
            this.rdo_actors.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(604, 248);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 11;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(601, 344);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdo_actors);
            this.Controls.Add(this.rdo_tvshow);
            this.Controls.Add(this.rdo_movie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchbox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "search";
            this.Text = "search";
            this.Load += new System.EventHandler(this.search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdo_movie;
        private System.Windows.Forms.RadioButton rdo_tvshow;
        private System.Windows.Forms.RadioButton rdo_actors;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}