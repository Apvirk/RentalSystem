using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RentalSystem
{
    public partial class Form1 : Form
    {
        SqlConnection c;
        SqlCommand cmd;
        SqlDataAdapter adpater;
        string _connString;

        string CustomerID, MovieID;

        public Form1()
        {
            InitializeComponent();
            _connString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            c = new SqlConnection(_connString);
            CustomerDataBind();
            MovieDataBind();
            btnCancelCust.Visible = false;
            btnDeleteCust.Visible = false;
            btnUpdateCust.Visible = false;
            btnCancelMovie.Visible = false;
            btnDeleteMovie.Visible = false;
            btnUpdateMovie.Visible = false;
            cmbCopies.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
            dataGridViewCustomer.MultiSelect = false;
            dataGridViewCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMovie.MultiSelect = false;
            dataGridViewMovie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CustomerDataBind()
        {
            string q = "SELECT * FROM [tblCustomer]";
            cmd = new SqlCommand(q, c);
            DataTable data = new DataTable();
            adpater = new SqlDataAdapter(cmd);
            adpater.Fill(data);
            dataGridViewCustomer.DataSource = data;
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {

            string q = "INSERT INTO [tblCustomer] VALUES (@Name, @Address, @Phone)";
            cmd = new SqlCommand(q, c);
            cmd.Parameters.AddWithValue("@Name", tbname.Text);
            cmd.Parameters.AddWithValue("@Address", tbaddress.Text);
            cmd.Parameters.AddWithValue("@Phone", tbphone.Text);
            c.Open();
            cmd.ExecuteNonQuery();
            c.Close();
            CustomerDataBind();
            MessageBox.Show("Customer Added");

        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string q = "UPDATE [tblCustomer] SET [Name] = @Name, [Address] = @Address, [Phone] = @Phone WHERE [CustomerID] = @CustomerID";
            cmd = new SqlCommand(q, c);
            cmd.Parameters.AddWithValue("@Name", tbname.Text);
            cmd.Parameters.AddWithValue("@Address", tbaddress.Text);
            cmd.Parameters.AddWithValue("@Phone", tbphone.Text);
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            c.Open();
            cmd.ExecuteNonQuery();
            c.Close();
            CustomerID = "";
            btnCancelCust_Click(this, null);
            CustomerDataBind();
            MessageBox.Show("Customer Updated");
        }

        private void btnCancelCust_Click(object sender, EventArgs e)
        {
            CustomerID = "";
            tbname.Text = "";
            tbaddress.Text = "";
            tbphone.Text = "";

            btnAddCust.Visible = true;
            btnCancelCust.Visible = false;
            btnDeleteCust.Visible = false;
            btnUpdateCust.Visible = false;
        }

        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Deletion", "Are you sure to Delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string q = "DELETE FROM [tblCustomer] WHERE [CustomerID] = @CustomerID";
                cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                c.Open();
                cmd.ExecuteNonQuery();
                c.Close();
                btnCancelCust_Click(this, null);
                CustomerDataBind();
                MessageBox.Show("Customer Deleted");
            }
        }

        void MovieDataBind()
        {
            string q = "SELECT * FROM [tblMovie]";
            cmd = new SqlCommand(q, c);
            DataTable data = new DataTable();
            adpater = new SqlDataAdapter(cmd);
            adpater.Fill(data);
            dataGridViewMovie.DataSource = data;
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            int Rent;
            if ((DateTime.Now.Year - Convert.ToInt32(cmbYear.SelectedItem.ToString())) > 5)
            {
                Rent = 2;
            }
            else
            {
                Rent = 5;
            }
            
            string q = "INSERT INTO [tblMovie] VALUES ( @Title, @Year, @Cost, @Copies, @Plot, @Genre)";
            cmd = new SqlCommand(q, c);
            cmd.Parameters.AddWithValue("@Title", tbtitle.Text);
            cmd.Parameters.AddWithValue("@Year", cmbYear.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Cost", Rent);
            cmd.Parameters.AddWithValue("@Copies", cmbCopies.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Plot", tbplot.Text);
            cmd.Parameters.AddWithValue("@Genre", tbgenre.Text);
            c.Open();
            cmd.ExecuteNonQuery();
            c.Close();
            MovieDataBind();
            MessageBox.Show("Movie Added");
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            int Rent;
            if ((DateTime.Now.Year - Convert.ToInt32(cmbYear.SelectedItem.ToString())) > 5)
            {
                Rent = 2;
            }
            else
            {
                Rent = 5;
            }

            string q = "UPDATE [tblMovie] SET [Title] = @Title, [Year] = @Year, [Cost] = @Cost, [Copies] = @Copies, [Plot] =  @Plot, [Genre] = @Genre WHERE [MovieId] = @MovieId";
            cmd = new SqlCommand(q, c);
            cmd.Parameters.AddWithValue("@Title", tbtitle.Text);
            cmd.Parameters.AddWithValue("@Year", cmbYear.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Cost", Rent);
            cmd.Parameters.AddWithValue("@Copies", cmbCopies.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Plot", tbplot.Text);
            cmd.Parameters.AddWithValue("@Genre", tbgenre.Text);
            cmd.Parameters.AddWithValue("@MovieId", MovieID);
            c.Open();
            cmd.ExecuteNonQuery();
            c.Close();

            MovieID = "";

            btnCancelMovie_Click(this, null);
            MovieDataBind();
            MessageBox.Show("Movie Updated");
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm", "Delete?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string q = "DELETE FROM [tblMovie] WHERE [MovieId] = @MovieID";
                cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("@MovieId", MovieID);
                c.Open();
                cmd.ExecuteNonQuery();
                c.Close();
                btnCancelMovie_Click(this, null);
                MovieDataBind();
                MessageBox.Show("Movie Deleted");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomer.SelectedRows.Count > 0 || dataGridViewMovie.SelectedRows.Count > 0)
            {
                string CustomerID = dataGridViewCustomer.SelectedRows[0].Cells[0].Value.ToString();
                string MovieId = dataGridViewMovie.SelectedRows[0].Cells[0].Value.ToString();

                int CopiesToRent = 0;

                string q = "SELECT (SELECT copies FROM tblMovie WHERE MovieId = @MovieId) - (SELECT ISNULL(COUNT(MovieIDFK), 0) FROM tblRentedMovies WHERE MovieIDFK = @MovieId AND DateOfReturn IS NULL)";
                cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("@MovieId", MovieId);
                DataTable table = new DataTable();
                adpater = new SqlDataAdapter(cmd);
                adpater.Fill(table);
                CopiesToRent = Convert.ToInt32(table.Rows[0][0]);

                if (CopiesToRent > 0)
                {
                    string Date = DateTime.Now.ToString("MM/dd/yyyy") + " " + DateTime.Now.ToShortTimeString();

                    q = "INSERT INTO [tblRentedMovies] (MovieIDFK, CustIDFK, DateOfRental) VALUES (@MovieIDFK, @CustIDFK, @DateOfRental)";

                    cmd = new SqlCommand(q, c);
                    cmd.Parameters.AddWithValue("@MovieIDFK", MovieId);
                    cmd.Parameters.AddWithValue("@CustIDFK", CustomerID);
                    cmd.Parameters.AddWithValue("@DateOfRental", Date);
                    c.Open();
                    cmd.ExecuteNonQuery();
                    c.Close();

                    MessageBox.Show("Movie Rented");
                }
                else
                {
                    MessageBox.Show("No copy available to rent");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string q = "SELECT * FROM [tblRentedMovies] WHERE [MovieIDFK] = @MovieIDFK AND [CustIDFK] = @CustIDFK AND [DateOfReturn] IS NULL";
            cmd = new SqlCommand(q, c);
            cmd.Parameters.AddWithValue("@MovieIDFK", dataGridViewMovie.SelectedRows[0].Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("@CustIDFK", dataGridViewCustomer.SelectedRows[0].Cells[0].Value.ToString());
            DataTable data = new DataTable();
            adpater = new SqlDataAdapter(cmd);
            adpater.Fill(data);
            if (data.Rows.Count == 1)
            {
                if (MessageBox.Show("Confirm", "Return?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string Date = DateTime.Now.ToString("MM/dd/yyyy") + " " + DateTime.Now.ToShortTimeString();
                    string Query = "UPDATE [tblRentedMovies] SET [DateOfReturn] = @DateOfReturn WHERE [MovieIDFK] = @MovieIDFK AND [CustIDFK] = @CustIDFK AND [DateOfReturn] IS NULL";
                    cmd = new SqlCommand(Query, c);
                    cmd.Parameters.AddWithValue("@DateOfReturn", Date);
                    cmd.Parameters.AddWithValue("@MovieIDFK", dataGridViewMovie.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@CustIDFK", dataGridViewCustomer.SelectedRows[0].Cells[0].Value.ToString());
                    c.Open();
                    cmd.ExecuteNonQuery();
                    c.Close();
                    MessageBox.Show("Movie Returned");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string q = "SELECT *, ISNULL((SELECT COUNT(RMID) FROM tblRentedMovies WHERE CustIDFK = tblCustomer.CustomerID), 0) AS RentedMovies FROM tblCustomer ORDER BY RentedMovies DESC";
            cmd = new SqlCommand(q, c);
            DataTable table = new DataTable();
            adpater = new SqlDataAdapter(cmd);
            adpater.Fill(table);
            new GridViewReport(table).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string Query = "SELECT *, ISNULL((SELECT COUNT (RMID) FROM tblRentedMovies WHERE MovieIDFK = tblMovie.MovieID), 0) AS TimesRented FROM tblMovie ORDER BY TimesRented DESC";
            cmd = new SqlCommand(Query, c);
            DataTable table = new DataTable();
            adpater = new SqlDataAdapter(cmd);
            adpater.Fill(table);
            new GridViewReport(table).ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerID = dataGridViewCustomer.SelectedRows[0].Cells[0].Value.ToString();
            string Query = "SELECT * FROM [tblCustomer] WHERE [CustomerID] = @CustomerID";
            cmd = new SqlCommand(Query, c);
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            DataTable table = new DataTable();
            adpater = new SqlDataAdapter(cmd);
            adpater.Fill(table);

            if (table.Rows.Count == 1)
            {
                tbname.Text = table.Rows[0]["Name"].ToString();
                tbaddress.Text = table.Rows[0]["Address"].ToString();
                tbphone.Text = table.Rows[0]["Phone"].ToString();

                btnAddCust.Visible = false;
                btnCancelCust.Visible = true;
                btnDeleteCust.Visible = true;
                btnUpdateCust.Visible = true;
            }
        }

        private void updateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieID = dataGridViewMovie.SelectedRows[0].Cells[0].Value.ToString();

            string Query = "SELECT * FROM [tblMovie] WHERE [MovieId] = @MovieId";
            cmd = new SqlCommand(Query, c);
            cmd.Parameters.AddWithValue("@MovieId", MovieID);
            DataTable table = new DataTable();
            adpater = new SqlDataAdapter(cmd);
            adpater.Fill(table);

            if (table.Rows.Count > 0)
            {
                tbtitle.Text = table.Rows[0]["title"].ToString();
                cmbYear.SelectedValue = table.Rows[0]["year"].ToString();
                cmbCopies.SelectedValue = table.Rows[0]["copies"].ToString();
                tbplot.Text = table.Rows[0]["plot"].ToString();
                tbgenre.Text = table.Rows[0]["genre"].ToString();

                btnAddMovie.Visible = false;
                btnCancelMovie.Visible = true;
                btnDeleteMovie.Visible = true;
                btnUpdateMovie.Visible = true;
            }
        }

        private void btnCancelMovie_Click(object sender, EventArgs e)
        {
            MovieID = "";
            tbtitle.Text = "";
            cmbYear.SelectedIndex = 0;
            cmbCopies.SelectedIndex = 0;
            tbplot.Text = "";
            tbgenre.Text = "";

            btnAddMovie.Visible = true ;
            btnCancelMovie.Visible = false;
            btnDeleteMovie.Visible = false;
            btnUpdateMovie.Visible = false;
        }
    }
}
