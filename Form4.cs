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


namespace inter_face
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\Visual Studio 2012\Projects\inter face\inter face\Database1.mdf;Integrated Security=True");

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 showform5 = new Form5();
            showform5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String VehicleNo = textBox1.Text;
                int RegYear = int.Parse(textBox2.Text);
                String VehicleType = comboBox1.Text;
                int Seats = int.Parse(textBox3.Text);
                int WeeklyRent = int.Parse(textBox4.Text);
                int DailyRent = int.Parse(textBox5.Text);
                String query = "INSERT INTO Vehicles VALUES('"+VehicleNo+"',"+RegYear+",'"+VehicleType+"',"+Seats+","+WeeklyRent+","+DailyRent+")";
                con.Open();
                SqlCommand ins = new SqlCommand(query, con);
                ins.ExecuteNonQuery();
                MessageBox.Show("Vehicle Save Successfully");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error on insert" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 showform3 = new Form3();
            showform3.Show();
            this.Hide();
        }
    }
}
