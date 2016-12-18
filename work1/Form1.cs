using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work1
{
    
    public partial class Form1 : Form
    {
        private static Random rnd = new Random(DateTime.Now.Millisecond);
        private static int size = 10000;


        public Worker[] workers { get; set; }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addListview();
        }

        public void addListview()
        {
            //Random rnd = new Random();
            ListView L1 = new ListView();
            workers = new Worker[size];
            for (int i = 0; i< size; i++)
            {
                int id1 = rnd.Next(100000000,400000000);
         
                string email = RandomString(rnd.Next(5, 10)) + "@" + RandomString(rnd.Next(5, 10)) +".COM";
                int numbers = rnd.Next(100000000, 600000000);
                string phonestring = "0" + numbers.ToString();
                workers[i]=new Worker(id1.ToString(), RandomString(rnd.Next(5, 10)), RandomString(rnd.Next(5, 10)), email, phonestring, RandomString(rnd.Next(15, 22)), rnd.Next(3000, 15000));
                string[] row = { workers[i].id, workers[i].name, workers[i].lastName, workers[i].email, workers[i].phone, workers[i].address, workers[i].salary.ToString() };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
            
            
            

        }

        private string RandomString(int size)
        {
            //Random random = new Random();
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rnd.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }
        public void bubblesort()
        {
            
            
            Worker tempw;


            

            for (int write = 0; write < workers.Length; write++)
            {
                for (int sort = 0; sort < workers.Length - 1; sort++)
                {
                    if (workers[sort].salary > workers[sort + 1].salary)
                    {
                        tempw = workers[sort + 1];
                        workers[sort + 1] = workers[sort];
                        workers[sort] = tempw;
                    }
                }
            }



        }
        public void sortTable()
        {
            for (int i = 0; i < size; i++)
            {
         
                string[] row = { workers[i].id, workers[i].name, workers[i].lastName, workers[i].email, workers[i].phone, workers[i].address, workers[i].salary.ToString() };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }



        }



        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            bubblesort();
            sortTable();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
