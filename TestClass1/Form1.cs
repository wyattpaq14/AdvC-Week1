using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClass1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bnt1_Click(object sender, EventArgs e)
        {
            //todo
            Person person1 = new Person(txtFirstName.Text, txtLastName.Text);
            lblFinalOutput.Text = person1.retreivePersonData();
        }
    }
}
