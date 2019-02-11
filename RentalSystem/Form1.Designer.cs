namespace RentalSystem
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnDeleteCust = new System.Windows.Forms.Button();
            this.btnCancelCust = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMovie = new System.Windows.Forms.DataGridView();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnCancelMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.tbgenre = new System.Windows.Forms.TextBox();
            this.tbplot = new System.Windows.Forms.TextBox();
            this.tbtitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCopies = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnUpdateCust = new System.Windows.Forms.Button();
            this.contextMenuStripCust = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuMovie = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).BeginInit();
            this.contextMenuStripCust.SuspendLayout();
            this.contextMenuMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.Location = new System.Drawing.Point(286, 427);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(75, 41);
            this.btnDeleteCust.TabIndex = 41;
            this.btnDeleteCust.Text = "Delete Customer";
            this.btnDeleteCust.UseVisualStyleBackColor = true;
            this.btnDeleteCust.Click += new System.EventHandler(this.btnDeleteCust_Click);
            // 
            // btnCancelCust
            // 
            this.btnCancelCust.Location = new System.Drawing.Point(286, 364);
            this.btnCancelCust.Name = "btnCancelCust";
            this.btnCancelCust.Size = new System.Drawing.Size(75, 41);
            this.btnCancelCust.TabIndex = 40;
            this.btnCancelCust.Text = "Cancel";
            this.btnCancelCust.UseVisualStyleBackColor = true;
            this.btnCancelCust.Click += new System.EventHandler(this.btnCancelCust_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.AllowUserToDeleteRows = false;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.ContextMenuStrip = this.contextMenuStripCust;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.ReadOnly = true;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(360, 323);
            this.dataGridViewCustomer.TabIndex = 39;
            // 
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(192, 364);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(75, 41);
            this.btnAddCust.TabIndex = 38;
            this.btnAddCust.Text = "Add Customer";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(75, 453);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(100, 20);
            this.tbphone.TabIndex = 37;
            // 
            // tbaddress
            // 
            this.tbaddress.Location = new System.Drawing.Point(75, 387);
            this.tbaddress.Multiline = true;
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(100, 50);
            this.tbaddress.TabIndex = 36;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(75, 361);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 20);
            this.tbname.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Phone No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Name";
            // 
            // dataGridViewMovie
            // 
            this.dataGridViewMovie.AllowUserToAddRows = false;
            this.dataGridViewMovie.AllowUserToDeleteRows = false;
            this.dataGridViewMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovie.ContextMenuStrip = this.contextMenuMovie;
            this.dataGridViewMovie.Location = new System.Drawing.Point(439, 12);
            this.dataGridViewMovie.Name = "dataGridViewMovie";
            this.dataGridViewMovie.ReadOnly = true;
            this.dataGridViewMovie.Size = new System.Drawing.Size(360, 323);
            this.dataGridViewMovie.TabIndex = 42;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(548, 568);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(84, 48);
            this.btnDeleteMovie.TabIndex = 57;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnCancelMovie
            // 
            this.btnCancelMovie.Location = new System.Drawing.Point(730, 568);
            this.btnCancelMovie.Name = "btnCancelMovie";
            this.btnCancelMovie.Size = new System.Drawing.Size(84, 48);
            this.btnCancelMovie.TabIndex = 56;
            this.btnCancelMovie.Text = "Cancel";
            this.btnCancelMovie.UseVisualStyleBackColor = true;
            this.btnCancelMovie.Click += new System.EventHandler(this.btnCancelMovie_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(445, 568);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(84, 48);
            this.btnAddMovie.TabIndex = 49;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // tbgenre
            // 
            this.tbgenre.Location = new System.Drawing.Point(511, 505);
            this.tbgenre.Multiline = true;
            this.tbgenre.Name = "tbgenre";
            this.tbgenre.Size = new System.Drawing.Size(166, 53);
            this.tbgenre.TabIndex = 48;
            // 
            // tbplot
            // 
            this.tbplot.Location = new System.Drawing.Point(511, 438);
            this.tbplot.Multiline = true;
            this.tbplot.Name = "tbplot";
            this.tbplot.Size = new System.Drawing.Size(166, 53);
            this.tbplot.TabIndex = 47;
            // 
            // tbtitle
            // 
            this.tbtitle.Location = new System.Drawing.Point(511, 367);
            this.tbtitle.Multiline = true;
            this.tbtitle.Name = "tbtitle";
            this.tbtitle.Size = new System.Drawing.Size(166, 53);
            this.tbtitle.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Genre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Plot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Copies";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(683, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Title";
            // 
            // cmbCopies
            // 
            this.cmbCopies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCopies.FormattingEnabled = true;
            this.cmbCopies.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbCopies.Location = new System.Drawing.Point(745, 435);
            this.cmbCopies.Name = "cmbCopies";
            this.cmbCopies.Size = new System.Drawing.Size(51, 21);
            this.cmbCopies.TabIndex = 58;
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018"});
            this.cmbYear.Location = new System.Drawing.Point(745, 364);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(51, 21);
            this.cmbYear.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 60);
            this.button1.TabIndex = 60;
            this.button1.Text = "Issue Movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 562);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 60);
            this.button2.TabIndex = 61;
            this.button2.Text = "Return Movie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(192, 487);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 55);
            this.button3.TabIndex = 62;
            this.button3.Text = "Most Valuable Customer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(306, 487);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 55);
            this.button4.TabIndex = 63;
            this.button4.Text = "Most Rented Movies";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUpdateCust
            // 
            this.btnUpdateCust.Location = new System.Drawing.Point(192, 427);
            this.btnUpdateCust.Name = "btnUpdateCust";
            this.btnUpdateCust.Size = new System.Drawing.Size(75, 41);
            this.btnUpdateCust.TabIndex = 64;
            this.btnUpdateCust.Text = "Update Customer";
            this.btnUpdateCust.UseVisualStyleBackColor = true;
            this.btnUpdateCust.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // contextMenuStripCust
            // 
            this.contextMenuStripCust.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.contextMenuStripCust.Name = "contextMenuStripCust";
            this.contextMenuStripCust.Size = new System.Drawing.Size(151, 26);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.updateToolStripMenuItem.Text = "Update/Delete";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // contextMenuMovie
            // 
            this.contextMenuMovie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateDeleteToolStripMenuItem});
            this.contextMenuMovie.Name = "contextMenuMovie";
            this.contextMenuMovie.Size = new System.Drawing.Size(151, 26);
            // 
            // updateDeleteToolStripMenuItem
            // 
            this.updateDeleteToolStripMenuItem.Name = "updateDeleteToolStripMenuItem";
            this.updateDeleteToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.updateDeleteToolStripMenuItem.Text = "Update/Delete";
            this.updateDeleteToolStripMenuItem.Click += new System.EventHandler(this.updateDeleteToolStripMenuItem_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(640, 568);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(84, 48);
            this.btnUpdateMovie.TabIndex = 67;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 642);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnUpdateCust);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbCopies);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnCancelMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.tbgenre);
            this.Controls.Add(this.tbplot);
            this.Controls.Add(this.tbtitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridViewMovie);
            this.Controls.Add(this.btnDeleteCust);
            this.Controls.Add(this.btnCancelCust);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.tbphone);
            this.Controls.Add(this.tbaddress);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Best Customers";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).EndInit();
            this.contextMenuStripCust.ResumeLayout(false);
            this.contextMenuMovie.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCust;
        private System.Windows.Forms.Button btnCancelCust;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnCancelMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.TextBox tbgenre;
        private System.Windows.Forms.TextBox tbplot;
        private System.Windows.Forms.TextBox tbtitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCopies;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnUpdateCust;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCust;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuMovie;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteToolStripMenuItem;
        private System.Windows.Forms.Button btnUpdateMovie;
    }
}

