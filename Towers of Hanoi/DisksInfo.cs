using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Towers_of_Hanoi
{
    class DisksInfo
    {

        public List<Rectangle> Source = new List<Rectangle>();
        public List<Rectangle> Help = new List<Rectangle>();
        public List<Rectangle> Destination = new List<Rectangle>();
        public Color[] color = { Color.Black, Color.Green, Color.YellowGreen, Color.Turquoise, Color.Brown, Color.Blue, Color.Chocolate, Color.Yellow, Color.Red, Color.SkyBlue, Color.WhiteSmoke, Color.Tomato, Color.SeaGreen, Color.RosyBrown, Color.Plum, Color.Orchid, Color.MistyRose, Color.BurlyWood, Color.CornflowerBlue, Color.Cyan, Color.DarkCyan, Color.DarkGray };
        public List<INFO> AllDisks;
        public int Size;
        public int StartWidth = 180, height = 0, RateOfDecresingWidth = 0;
        public int Xsource = 100, Ysource = 300, Xhelp = 300, Yhelp = 300, Xdestination = 500, Ydestination = 300;
        public DisksInfo(int size)
        {
            Size = size;
            height = 260 / size; // Height Constant For all Disks
            RateOfDecresingWidth = StartWidth / size;
            AllDisks = new List<INFO>();
            for (int i = 0; i < size; i++)
            {
                INFO Disk = new INFO();
                Disk.ID = size - i;
                Disk.Height = height;
                Disk.Width = StartWidth - (i * RateOfDecresingWidth);
                AllDisks.Add(Disk);
            }

        }
        public void SetSource(List<int> source)
        {
            Source.Clear();
            for (int i = 0; i < source.Count; i++)
            {                 
                int width=AllDisks[(Size-source[i])].Width;
                Rectangle disk = new Rectangle();
                disk.brush = new SolidBrush(color[source[i]%21]);
                disk.Points[0]=new Point(Xsource-(width/2),Ysource-(i*height));
                disk.Points[1] = new Point(Xsource + (width / 2), Ysource - (i * height));
                disk.Points[2] = new Point(Xsource + (width / 2), Ysource - (i * height)-height);
                disk.Points[3] = new Point(Xsource - (width / 2), Ysource - (i * height)-height);
                Source.Add(disk);
            }
        }
        public void SetHelp(List<int> help)
        {
            Help.Clear();
            for (int i = 0; i < help.Count; i++)
            {
                int width = AllDisks[(Size - help[i])].Width;
                Rectangle disk = new Rectangle();
                disk.brush = new SolidBrush(color[help[i]%21]);
                disk.Points[0] = new Point(Xhelp - (width / 2), Yhelp - (i * height));
                disk.Points[1] = new Point(Xhelp + (width / 2), Yhelp - (i * height));
                disk.Points[2] = new Point(Xhelp + (width / 2), Yhelp - (i * height) - height);
                disk.Points[3] = new Point(Xhelp - (width / 2), Yhelp - (i * height) - height);
                Help.Add(disk);
            }
        }
        public void SetDestination(List<int> destination)
        {
            Destination.Clear();
            for (int i = 0; i < destination.Count; i++)
            {
                int width = AllDisks[(Size - destination[i])].Width;
                Rectangle disk = new Rectangle();
                disk.brush = new SolidBrush(color[destination[i]%21]);
                disk.Points[0] = new Point(Xdestination - (width / 2), Ydestination - (i * height));
                disk.Points[1] = new Point(Xdestination + (width / 2), Ydestination - (i * height));
                disk.Points[2] = new Point(Xdestination + (width / 2), Ydestination - (i * height) - height);
                disk.Points[3] = new Point(Xdestination - (width / 2), Ydestination - (i * height) - height);
                Destination.Add(disk);
            }
        }
    }
}
