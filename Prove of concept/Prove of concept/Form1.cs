using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prove_of_concept
{
    
    public partial class LogCoplaint : Form
    {
        int counter;

        public LogCoplaint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            filehandeler fl = new filehandeler();
            List<string> datatoshow = fl.readdata();
            string problemrefreacode =null;
            string regoin = null;
            string problemtype = null ;
            string valuetosearch= textBox1.Text;

            string regionresult = "";
            string ComplaintSerivice = "";
            string problemtypes = ""; 

            foreach (var item in datatoshow)
            {
                if (valuetosearch == item)
                {
                    
                    regoin = item[0].ToString();
                    problemrefreacode = item[1].ToString();
                    problemtype = item[2].ToString();



                    if (regoin == "1")
                    {
                        regionresult = "The complaint was logged in Regoin 1";

                    }

                    if (regoin == "2")
                    {

                        regionresult = "The complaint was logged in Regoin 2a";
                    }
                    if (regoin == "3")
                    {

                        regionresult = "The complaint was logged in Regoin 2b";
                            
                    }
                    if (regoin == "4")
                    {

                        regionresult = "The complaint was logged in Regoin 3";
                    }
                    if (regoin == "5")
                    {
                        regionresult = "The complaint was logged in Regoin 4";

                    }
                    if (regoin == "6")
                    {

                        regionresult = "The complaint was logged in Regoin 5";
                    }
                    if (regoin == "7")
                    {
                        regionresult = "The complaint was logged in Regoin 6";

                    }
                    if (regoin == "8")
                    {

                        regionresult = "The complaint was logged in Regoin 7";
                    }

                    if (problemrefreacode == "1")
                    {
                        ComplaintSerivice = "Complaint was water related ";
                    }
                    if (problemrefreacode == "2")
                    {
                        ComplaintSerivice = "Complaint was Electical related ";

                    }
                    if (problemrefreacode == "3")
                    {

                        ComplaintSerivice = "Complaint was Sanitation related ";
                    }
                    if (problemtype == "1")
                    {
                        problemtypes = "Level of priority is High";

                    }
                    if (problemtype == "2")
                    {
                        problemtypes = "Level of priority is Medium";


                    }


                }

            
            }
            listBox1.Items.Clear();
            listBox1.Items.Add(regionresult );
            listBox1.Items.Add(ComplaintSerivice);
            listBox1.Items.Add(problemtypes);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Regoin = comboBox1.SelectedItem.ToString();
            string Problemarea = comboBox2.SelectedItem.ToString();
            string Problemtype = comboBox4.SelectedItem.ToString();
            int problemrefreacode = 0;
            int regoin = 0;
            int problemtype = 0;
            string refrencenumber =null;


            if (Regoin == "1")
            {
                regoin = 1;
              
            }
      
            if (Regoin == "2a")
            {
                regoin = 2;
            
            }
            if (Regoin == "2b")
            {
                regoin = 3;
               
            }
            if (Regoin == "3")
            {
                regoin = 4;
             
            }
            if (Regoin == "4")
            {
                regoin = 5;
              
            }
            if (Regoin == "5")
            {
                regoin = 6;
           
            }
            if (Regoin == "6")
            {
                regoin = 7;
             
            }
            if (Regoin == "7")
            {
                regoin = 8;
             
            }

            if (Problemarea == "Water")
            {
                problemrefreacode = 1;
           
            }
            if (Problemarea == "Electricty")
            {
                problemrefreacode = 2;
         
            }
            if (Problemarea == "Sanitation")
            {
                problemrefreacode = 3;
              
            }
            if (Problemtype == "Water leak ")
            {
                problemtype = 1;
              
            }
            if (Problemtype == "Electrity meter down")
            {
                problemtype = 2;

             
            }
            if (problemrefreacode == 2 && problemtype == 1)
            {
                MessageBox.Show("Please seclet the crorecct Problem type");
                refrencenumber = null;
                return;
            }
            if (problemrefreacode == 1 && problemtype == 2)
            {
                MessageBox.Show("Please seclet the crorecct Problem type");
                refrencenumber = null;
                return;
            }
            if (problemrefreacode == 3 && problemtype == 1)
            {
                MessageBox.Show("Please seclet the crorecct Problem type");
                refrencenumber = null;
                return;
            }
            if (problemrefreacode == 3 && problemtype ==2)
            {
                MessageBox.Show("Please seclet the crorecct Problem type");
                refrencenumber = null;
                return;
            }
            Random random = new Random();
            counter++;

            int randomnumber = random.Next(1,1000);
             refrencenumber = regoin.ToString() + problemrefreacode.ToString() + problemtype.ToString() + counter.ToString() + randomnumber.ToString() ;
            textBox2.Text = refrencenumber;
            filehandeler fl = new filehandeler();
            fl.insertdata(refrencenumber);


        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
       

    }


