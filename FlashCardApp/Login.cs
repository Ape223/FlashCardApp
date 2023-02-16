using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace FlashCardApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void update_DB(string query, bool b)
        {
            var obj = new Connection();
            obj.connection.ConnectionString = obj.location;
            obj.connection.Open();
            if (b)
            {
                SqlDataAdapter var = new SqlDataAdapter(query, obj.connection);
                DataTable dt = new DataTable();
                var.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Main a = new Main();
                    a.Show();
                    this.Hide();
                    MessageBox.Show("Login Successful!");
                }
                else
                {
                    MessageBox.Show("Incorrect login. Please try again.");
                }
            }
            else
            {
                obj.cmd.Connection = obj.connection;
                obj.cmd.CommandText = query;
                obj.cmd.ExecuteNonQuery();
            }
            obj.connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Add a new entry into the database
            if (userText.Text != null && passwordText.Text != null)
            {
                string Query = $"insert into Users values ('"+userText.Text+"','"+passwordText.Text+"')";
                try
                {
                    update_DB(Query, false);
                    MessageBox.Show("Signup successful! Please keep a note of your username and password");
                }
                catch (Exception ex) { MessageBox.Show($"{ex.Message}", "Database not updated error"); }
            } else { MessageBox.Show("Fields cannot be empty!"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Perform a query for the user's login details
            if (userText.Text != null && passwordText.Text != null)
            {
                string Query = "SELECT COUNT (*) FROM Users where Username = '"+userText.Text+"' and Password = '"+passwordText.Text+"'";
                try
                {
                    update_DB(Query, true);
                }
                catch (Exception ex) { MessageBox.Show($"Login failed! Error message: {ex.Message}"); }
            }

        }
    }
}
