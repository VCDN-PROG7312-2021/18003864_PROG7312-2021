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
    public partial class ReplaceBooks : Form
    {
        int index = 0;
        private int counter = 60;
       public List<string> deciList = new List<string>();
        public List<string> sortList1 = new List<string>();
        public List<string> sortList2 = new List<string>();


        public ReplaceBooks()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReplaceBooks_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            sortlist();
        }
  

        public void generator() 
        {
            //generate random string:
            int length = 3;
            string numgenerated=null;

            // creating a StringBuilder object()
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();
            string deweyDec;
            char letter;

            for (int j = 0; j <length; j++)
            {
                numgenerated = string.Format("{0:000.###}", new Random().NextDouble() * 1000);

            }

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }

            deweyDec = numgenerated + " " + str_build.ToString();
            deciList.Add(deweyDec);//adds to list
           

        }
        public void sortlist() //get from userinput
        {
            int i = 0;
            if (LstboxDecimal.Items.Count <= 0)
            {
                for (i = 0; i < sortList1.Count; i++)
                {
                    sortList1.Add(LstboxDecimal.Items.ToString());
                }
            }
            sortList1.Sort();//sorted in ascending order and stored in seperate list
            sortList1 = sortList1.OrderBy(p => p.Substring(0)).ToList();// sorted alphabetically in list

            if (LstboxRearange.Items.Count <= 0)
            {
                for (i = 0; i < sortList2.Count; i++)
                {
                    sortList2.Add(LstboxRearange.Items.ToString());//retrieving users answer 
                }
            }

            //Validation//
       
            bool isEqual = Enumerable.SequenceEqual(sortList1, sortList2);
            if (isEqual)
            {
                MessageBox.Show("WELL DONE! YOUR SORTING IS CORRECT.😊\nPROCEED TO THE NEXT LEVEL.");
            }
            else
            {
                MessageBox.Show("SORTING IS INCORRECT 😞 \nTRY AGAIN.");
            }
        }
      

        public void outputNums() 
        {
            for (int i = 0; i < deciList.Count; i++)
            {

                LstboxDecimal.Items.Add(deciList[i].ToString());
            }
        }
     
            private void button3_Click_1(object sender, EventArgs e)
        {
            LstboxDecimal.Items.Clear();
            generator();              
             outputNums();


            ///////////////////////timer: needs fixing
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            lblCount.Text = counter.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
                timer1.Stop();
            lblCount.Text = counter.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //reset button:

            LstboxDecimal.Items.Clear();
            LstboxRearange.Items.Clear();
            timer1.Stop();
            lblCount.Text = "";
            outputNums();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //ListBox check1 = sender as ListBox;
            //index = check1.IndexFromPoint(e.X, e.Y);
            //if (index >= 0 & e.Button == MouseButtons.Left)
            //    check1.DoDragDrop(check1.Items[index].ToString(), DragDropEffects.Move);
            //if (LstboxDecimal.Items.Count == 0)
            //    return;

            int index = LstboxDecimal.IndexFromPoint(e.X, e.Y);
            string s = LstboxDecimal.Items[index].ToString();
            DragDropEffects dde1 = DoDragDrop(s,
                DragDropEffects.All);

            if (dde1 == DragDropEffects.All)
            {
                LstboxDecimal.Items.RemoveAt(LstboxDecimal.IndexFromPoint(e.X, e.Y));
            }

        }

        private void LstboxDecimal_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
         
        }

        private void LstboxRearange_DragDrop(object sender, DragEventArgs e)
        {
           // int index1 = 0;
            //ListBox check2 = sender as ListBox;
            //check2.Items.Add(e.Data.GetData(typeof(System.String)).ToString());
            //LstboxDecimal.Items.RemoveAt(index);

            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(
                    DataFormats.StringFormat);

                LstboxRearange.Items.Add(str);

            }

            Point point = LstboxRearange.PointToClient(new Point(e.X, e.Y));
            int index = this.LstboxRearange.IndexFromPoint(point);
            if (index < 0) index = this.LstboxRearange.Items.Count - 1;
            object data = e.Data.GetData(typeof(String));
            this.LstboxRearange.Items.Remove(data);
            this.LstboxRearange.Items.Insert(index, data);



        }

        private void LstboxRearange_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void LstboxDecimal_DragDrop(object sender, DragEventArgs e)
        {
            

        }

        private void LstboxRearange_DragOver(object sender, DragEventArgs e)
        {
        
             e.Effect = DragDropEffects.All;
            e.Effect = DragDropEffects.Move;
        }

        private void LstboxRearange_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void LstboxRearange_DragLeave(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Main m1 = new Main();
            m1.ShowDialog();
            this.Close();
        }
    }
}
