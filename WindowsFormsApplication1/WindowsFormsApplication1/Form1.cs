using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[,] MultiNames = new string[2,3]{
                {"Ruiz","A.","Manzano"},
                {"Dane","G.","Garcia"},
            };


            string[] fullname = new string[2];
            fullname[0] = MultiNames[0, 0] + MultiNames[0, 1] + MultiNames[0, 2];
            fullname[1] = MultiNames[1, 0] + MultiNames[1, 1] + MultiNames[1, 2];


            int fullnameCounter = 0;
            foreach (string n in fullname)
            {
                MessageBox.Show("the Result is:" + fullname[fullnameCounter]);
                fullnameCounter++;
            }

        }
    }
}
