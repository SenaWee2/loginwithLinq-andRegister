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

namespace loginwithLinq
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
         
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=myLogindb2;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[login]
           ([firstname]
           ,[LastName]
           ,[Address]
           ,[Gender]
           ,[Email]
           ,[Phone]
           ,[username]
           ,[password])
           VALUES
           ('" + txtFName.Text + "', '" + txtLname.Text + "', '" + txtade.Text + "', '" + txtGender.SelectedItem.ToString() + "','" + txtemail.Text + "','" + textBox6.Text + "', '" + textBox1.Text + "', '" + textBox2.Text + "')", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("REGISTER sUCCESSFULLY");

                this.Hide();
                Main mm = new Main();
                mm.Show();

           
           
           
               



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ff = new Form1();
            ff.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
