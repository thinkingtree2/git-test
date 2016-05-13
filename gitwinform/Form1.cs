using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gitwinform
{
    public partial class Form1 : Form
    {
        private string name;

        public Form1()
        {
            InitializeComponent();
        }


        public void print()
        {
            MessageBox.Show("first~");
        }

        public void GetName()
        {
            MessageBox.Show("soo");
        }


        public void GetName2()
        {
            MessageBox.Show("soo");
        }

        public void SetName(string name)
        {
            this.name = name;
        }

    }
}
