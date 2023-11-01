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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\Visual Studio 2012\Projects\inter face\inter face\Database1.mdf;Integrated Security=True");


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet2.vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter1.Fill(this.database1DataSet2.vehicles);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalDays = int.Parse(textBox1.Text);
            int weeks = totalDays / 7;
            int days = totalDays % 7;
            textBox3.Text = weeks.ToString();
            textBox4.Text = days.ToString();
            int Amount = int.Parse(textBox2.Text);
            try
            {
             string query= "SELECT * FROM vehicles WHERE vehicleno ='"+comboBox1.Text+"'";
              con.Open();
              SqlCommand srch = new SqlCommand(query, con);
              SqlDataReader r = srch.ExecuteReader();
              while (r.Read())
              {
                  textBox5.Text = r[5].ToString();
                  textBox6.Text = r[6].ToString();
                  int weeklycoust = int.Parse(textBox5.Text) * weeks;
                  int dailycoust = int.Parse(textBox6.Text) * days;
                  int total = Amount + weeklycoust + dailycoust;
                  textBox7.Text = total.ToString();

              }

                }
            catch (Exception ex)
            {

                MessageBox.Show("error on searching" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox15.Clear();
            textBox14.Clear();
            textBox13.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox15.Text;
                string tel  = textBox14.Text;
                string nic = textBox13.Text;
                string date = dateTimePicker3.Text;
                string vehicleno = comboBox1.Text;
                int amount = int.Parse(textBox2.Text);
                //databased query 
                string query1 = "INSERT INTO Rentdetails VALUES('" + name + "','" + tel + "','" + nic + "','" + date + "','" + vehicleno + "'," +amount + ")";
                //open connection
                con.Open();
                SqlCommand ins = new SqlCommand(query1, con);
                ins.ExecuteNonQuery();
                MessageBox.Show("Pay Complete");
                textBox15.Clear();
                textBox14.Clear();
                textBox13.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 showform3 = new Form3();
            showform3.Show();
            this.Hide();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vehiclesTableAdapter.FillBy(this.database1DataSet1.vehicles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }
    }
}
