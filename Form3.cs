using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inter_face
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 showform7 = new Form7();
            showform7.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 showform4 = new Form4();
            showform4.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 showform8 = new Form8();
            showform8.Show();
            this.Hide();


        }
    }
}
