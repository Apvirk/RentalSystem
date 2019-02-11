using System;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RentalSystemTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Conn()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\RentalSystem\rentaldb.mdf;Integrated Security=True");
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            Assert.IsTrue(true);
            con.Close();
        }

        [TestMethod]
        public void Insert()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\RentalSystem\rentaldb.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO [tblCustomer] VALUES (@Name, @Address, @Phone)", con);
            cmd.Parameters.AddWithValue("@Name", "A");
            cmd.Parameters.AddWithValue("@Address", "B");
            cmd.Parameters.AddWithValue("@Phone", "C");
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            Assert.IsTrue(result > 0);
        }
    }
}
