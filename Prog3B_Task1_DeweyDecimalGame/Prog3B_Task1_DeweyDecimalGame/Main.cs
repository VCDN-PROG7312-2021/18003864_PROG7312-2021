using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3B_Task1_DeweyDecimalGame
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            btnReplaceBooks.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 213, 129, 118);
            btnCallNums.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 16, 150, 249);
            btnIdentify.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 82, 56, 65);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReplaceBooks rb1 = new ReplaceBooks();
            rb1.ShowDialog();
           this.Close();
        }

        private void btnCallNums_Click(object sender, EventArgs e)
        {
           
        }

        private void btnIdentify_Click(object sender, EventArgs e)
        {
            MessageBox.Show("**COMING SOON**");
        }
    }
}
