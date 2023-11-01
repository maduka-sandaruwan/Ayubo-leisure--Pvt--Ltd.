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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\Visual Studio 2012\Projects\inter face\inter face\Database1.mdf;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string tel = textBox2.Text;
                string nic = textBox3.Text;
                string date = dateTimePicker1.Text;
                string vehicleno = textBox4.Text;
                int count = 0;
                int amount = int.Parse(textBox5.Text);
                string query = "INSERT INTO HireDetails VALUES('"+name+"','"+tel+"','"+nic+"','"+date+"','"+vehicleno+"',"+count+","+amount+")";
                con.Open();
                SqlCommand ins = new SqlCommand(query, con);
                ins.ExecuteNonQuery();
                MessageBox.Show("Payment Complete");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();



            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form3 showform3 = new Form3();
            showform3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
              try
            {
                string name = textBox10.Text;
                string tel = textBox9.Text;
                string nic = textBox8.Text;
                string date = dateTimePicker2.Text;
                string vehicleno = textBox7.Text;
                int count = 0;
                int amount = int.Parse(textBox6.Text);
                string query = "INSERT INTO HireDetails VALUES('"+name+"','"+tel+"','"+nic+"','"+date+"','"+vehicleno+"',"+count+","+amount+")";
                con.Open();
                SqlCommand ins = new SqlCommand(query, con);
                ins.ExecuteNonQuery();
                MessageBox.Show("Payment Complete");
                textBox10.Clear();
                textBox9.Clear();
                textBox8.Clear();
                textBox7.Clear();
                textBox6.Clear();



            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
            finally
            {
                con.Close();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string name = textBox15.Text;
            string tel = textBox14.Text;
            string nic = textBox13.Text;
            string date = dateTimePicker3.Text;
            string vehicleno = textBox12.Text;
            int count = int.Parse(textBox11.Text);
            int amount = int.Parse(textBox18.Text);
            try
            {
                string query = "INSERT INTO HireDetails VALUES('" + name + "','" + tel + "','" + nic + "','" + date + "','" + vehicleno + "'," + count + "," + amount + ")";
                con.Open();
                SqlCommand ins = new SqlCommand(query, con);
                ins.ExecuteNonQuery();
                MessageBox.Show("Payment Complete");
            }
            catch (Exception ex)
            {

                MessageBox.Show("error" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int count = int.Parse(textBox11.Text);
            int amount = int.Parse(textBox16.Text);
            int AdditionalKilometers = count - 100;
            int fine;
            if (AdditionalKilometers > 0)
            {
                fine = AdditionalKilometers * 200;
            }
           
            else

            {
                fine = 0;

            }
            int total = amount + fine;
            textBox17.Text = fine.ToString();
            textBox18.Text = total.ToString();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int count = int.Parse(textBox22.Text);
            int amount = int.Parse(textBox21.Text);
            int AdditionalKilometers = count - 200;
            int fine;
            if (AdditionalKilometers > 0)
            {
                fine = AdditionalKilometers * 200;
            }

            else
            {
                fine = 0;

            }
            int total = amount + fine;
            textBox20.Text = fine.ToString();
            textBox19.Text = total.ToString();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string name = textBox26.Text;
            string tel = textBox25.Text;
            string nic = textBox24.Text;
            string date = dateTimePicker4.Text;
            string vehicleno = textBox23.Text;
            int count = int.Parse(textBox22.Text);
            int amount = int.Parse(textBox21.Text);
            try
            {
                string query = "INSERT INTO HireDetails VALUES('" + name + "','" + tel + "','" + nic + "','" + date + "','" + vehicleno + "'," + count + "," + amount + ")";
                con.Open();
                SqlCommand ins = new SqlCommand(query, con);
                ins.ExecuteNonQuery();
                MessageBox.Show("Payment Complete");
            }
            catch (Exception ex)
            {

                MessageBox.Show("error" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox26.Clear();
            textBox25.Clear();
            textBox24.Clear();
            textBox23.Clear();
            textBox22.Clear();
            textBox21.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox15.Clear();
            textBox14.Clear();
            textBox13.Clear();
            textBox12.Clear();
            textBox11.Clear();
            
        }
    }
}
