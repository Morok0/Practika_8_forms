using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_8_zad_1_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String line = " ";
            line = Convert.ToString(textBox1.Text);
            
            int length = int.Parse(textBox2.Text);
            textBox3.Text=($"{string.Join(" ", Regex.Matches(line, @"\w+").Cast<Match>().Where(t => t.Length == length))}");
        }
    }
}
