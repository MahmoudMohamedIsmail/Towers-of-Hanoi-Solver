using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Towers_of_Hanoi
{
    public partial class Form1 : Form
    {
        DynamicProgramming solve;
        DisksInfo disk;
        bool Created = false;
        int Counter = 0,NumberofDisks=0,Time=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
              disk.SetSource(solve.Source);
              disk.SetDestination(solve.Destination);
              disk.SetHelp(solve.Help);
              var g = e.Graphics;

            //Source Line And string "Source"
              Point[] points = new Point[4];
              points[0] = new Point(98, 300);
              points[1] = new Point(102, 300);
              points[2] = new Point(102, 30);
              points[3] = new Point(98, 30);
              Brush brush = new SolidBrush(Color.Black);
              g.FillPolygon(brush, points);
              Font drawFontBold = new Font("Arial", 15, FontStyle.Bold);
              g.DrawString("Source", drawFontBold, brush, 70,310); 
            //Disks 
            for (int i = 0; i < disk.Source.Count; i++)
              {
                  
                  g.FillPolygon(disk.Source[i].brush, disk.Source[i].Points);

              }
        
            //Help Line And string "Help"
            points[0] = new Point(298, 300);
            points[1] = new Point(302, 300);
            points[2] = new Point(302, 30);
            points[3] = new Point(298, 30);
            g.FillPolygon(brush, points);
            g.DrawString("Help", drawFontBold, brush, 280, 310);
            //Disks 
              for (int i = 0; i < disk.Help.Count; i++)
              {
              
                  g.FillPolygon(disk.Help[i].brush, disk.Help[i].Points);

              }

              //Destination Line And string "Destination"
              points[0] = new Point(498, 300);
              points[1] = new Point(502, 300);
              points[2] = new Point(502, 30);
              points[3] = new Point(498, 30);
              g.FillPolygon(brush, points);
              g.DrawString("Destination", drawFontBold, brush, 450, 310);
              //Disks 
              for (int i = 0; i < disk.Destination.Count; i++)
              {
                  g.FillPolygon(disk.Destination[i].brush, disk.Destination[i].Points);

              }
        }

        private void CreteTower_Click(object sender, EventArgs e)
        {
            if (NumberOfDisks.Text == "")
                MessageBox.Show("Enter Number Of Disks");
            else
            {
                NumberofDisks = int.Parse(NumberOfDisks.Text);
                solve = new DynamicProgramming(NumberofDisks);
                disk = new DisksInfo(NumberofDisks);
                this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
                panel1.Invalidate();
                Created = true;
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (Counter <=0)
            {
                MessageBox.Show("No Steps Untill Now");
                Counter = 0;
            }
            else if (Counter == 1)
            {
                Counter--;
                solve = new DynamicProgramming(NumberofDisks);
                panel1.Invalidate();

            }
            else
            {
                Counter--;
                solve = new DynamicProgramming(NumberofDisks);
                solve.Tower(NumberofDisks, solve.Source, solve.Help, solve.Destination, this, Time, Counter);
            }
            
        }

        private void Next_Click(object sender, EventArgs e)
        {
          
            if (Counter>=solve.MaxCount)
            {
                Counter = solve.MaxCount;
                MessageBox.Show("This Is Final Step");
            }
            else {
                Counter++;
                solve = new DynamicProgramming(NumberofDisks);
                solve.Tower(NumberofDisks, solve.Source, solve.Help, solve.Destination, this, Time, Counter);
            }

        }

        private void Solveb_Click(object sender, EventArgs e)
        {
            if (Created)
            {

                
                //This three Line to Solve From Step 0;
                solve = new DynamicProgramming(NumberofDisks);
                disk = new DisksInfo(NumberofDisks);
                panel1.Invalidate();

                if (TimeText.Text != "")
                {
                    // Start Solving with time
                    Time = int.Parse(TimeText.Text);
                    solve.Tower(NumberofDisks, solve.Source, solve.Help, solve.Destination, this, Time, -1);
                    Counter = solve.MaxCount;
                }
                else {
                    MessageBox.Show("Please Enter Time");
                }
            }
            else {
                MessageBox.Show("Please Create The Tower");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}