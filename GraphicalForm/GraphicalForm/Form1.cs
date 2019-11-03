using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalForm
{
    public partial class Form1 : Form
    {
        ArrayList shapes = new ArrayList();
        Command command = new Command();

        string previousCommand;

        public Form1()
        {
            InitializeComponent();
        }

        
       

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //First Tab - Single Line
        private void SingleLineInputTab_TextChanged(object sender, EventArgs e)
        {
            if (e.Keycode == Keys.Enter)
            {
                TextBox SingleLineInputTextbox
            }
        }
    }
}
