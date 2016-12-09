using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Threading;

namespace Towers_of_Hanoi
{
    class DynamicProgramming
    {

        public List<Rectangle> Disks = new List<Rectangle>();
        public List<int> Source;
        public List<int> Destination;
        public List<int> Help;
        public List<Steps> AllStepsOfAlgorithm = new List<Steps>();
        public int Size;
        public int Counter = 1,MaxCount=0;
        public DynamicProgramming(int size)
        {
            Size = size;
            Source = new List<int>();
            Destination = new List<int>();
            Help = new List<int>();
            for (int i = size; i >= 1; i--)
            {
                Source.Add(i);
            }
            MaxCount = 0;
            Counter = 1;
            SetMaxCounter(size,'S','H','D');
        }

        public void Tower(int n, List<int> Source, List<int> Help, List<int> Destination,Form1 form,int time,int Count)
        {
            if (n == 1)
            {
                Destination.Add(n);
                Source.Remove(n);
                // Run With Sleep Time And Counter If exist
                if (time > 0 || Count == Counter)
                {
                    form.panel1.Invalidate();
                    form.Refresh();
                    Thread.Sleep(time);
                }
                Counter++;
            }
            else
            {
                Tower(n - 1, Source, Destination, Help, form,time,Count);
              
                Destination.Add(n);
                Source.Remove(n);
                // Run With Sleep Time And Counter If exist
                if (time > 0 || Count==Counter)
                {
                    form.panel1.Invalidate();
                    form.Refresh();
                    Thread.Sleep(time);
                }
                Counter++;

                Tower(n - 1, Help, Source, Destination, form, time, Count);
            }
        }
        public void SetMaxCounter(int n, char source, char help, char destination)
        {
            if (n == 1)
            {
                MaxCount++;
            }
            else
            {

                SetMaxCounter(n - 1, source, destination, help);
               MaxCount++;
                SetMaxCounter(n - 1, help, source, destination);
            }
        }
       
    }
}
