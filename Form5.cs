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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\Visual Studio 2012\Projects\inter face\inter face\Database1.mdf;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int reg = int.Parse(textBox2.Text);
                string vehicletype = comboBox1.Text;
                int seats = int.Parse(textBox3.Text);
                int weeklyRent = int.Parse(textBox4.Text);
                int dailyRent = int.Parse(textBox5.Text);
                string query = "UPDATE vehicles SET RegYear=" + reg + ",VehicleType='" + vehicletype + "',Seats=" + seats + ",WeeklyRent=" + weeklyRent + ",DailyRent=" + dailyRent + "";
                con.Open();
                SqlCommand ins = new SqlCommand(query, con);
                ins.ExecuteNonQuery();
                MessageBox.Show("Vehicle updated Successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error on Update" + ex);
            }
            finally
            {
                con.Close();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM vehicles WHERE VehicleNo='" + textBox1.Text + "'";
                con.Open();
                SqlCommand srch = new SqlCommand(query, con);
                SqlDataReader r = srch.ExecuteReader();
                while (r.Read())
                {
                    textBox2.Text = r[2].ToString();
                    comboBox1.Text = r[3].ToString();
                    textBox3.Text = r[4].ToString();
                    textBox4.Text = r[5].ToString();
                    textBox5.Text = r[6].ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error on search" + ex);
            }
            finally
            {
                con.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string query="DELETE  FROM vehicles WHERE VehicleNo='"+textBox1.Text+"'";
                con.Open();
                SqlCommand ins = new SqlCommand(query, con);
                ins.ExecuteNonQuery();
                MessageBox.Show("Vehicle Deleted Successfully");
            }
          
            catch (Exception ex)
            {

                MessageBox.Show("Error on Delete" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
