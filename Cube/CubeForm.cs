using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cube
{
    public partial class CubeForm : Form
    {
        public CubeForm()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(DrawCube);
        }

        private void sizeScroll_Scroll(object sender, ScrollEventArgs e)
        {
            sizeLabel.Text = sizeScroll.Value.ToString();
            this.Invalidate();
        }

        private void redScroll_Scroll(object sender, ScrollEventArgs e)
        {
            redLabel.Text = redScroll.Value.ToString();
            this.Invalidate();
        }

        private void greenScroll_Scroll(object sender, ScrollEventArgs e)
        {
            greenLabel.Text = greenScroll.Value.ToString();
            this.Invalidate();
        }

        private void blueScroll_Scroll(object sender, ScrollEventArgs e)
        {
            blueLabel.Text = blueScroll.Value.ToString();
            this.Invalidate();
        }

        public void DrawCube(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);

            int red = redScroll.Value;
            int green = greenScroll.Value;
            int blue = blueScroll.Value;

            Brush brush = new SolidBrush(Color.FromArgb(red, green, blue));

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            int squareSize = 30 + 10*sizeScroll.Value;

            int topLeftX = centerX - squareSize / 2;
            int topLeftY = centerY - squareSize / 2;



            Point[] frontFace = {
            new Point(topLeftX, topLeftY),
            new Point(topLeftX + squareSize, topLeftY),
            new Point(topLeftX + squareSize, topLeftY + squareSize),
            new Point(topLeftX, topLeftY + squareSize)
            };

            Point[] topFace = {
                new Point(topLeftX, topLeftY), 
                new Point(topLeftX + squareSize, topLeftY), 
                new Point(topLeftX + squareSize + squareSize / 2, topLeftY - squareSize / 2), 
                new Point(topLeftX + squareSize / 2, topLeftY - squareSize / 2) 
            };

            Point[] sideFace = {
                new Point(topLeftX + squareSize, topLeftY),  
                new Point(topLeftX + squareSize + squareSize / 2, topLeftY - squareSize / 2), 
                new Point(topLeftX + squareSize + squareSize / 2, topLeftY + squareSize / 2), 
                new Point(topLeftX + squareSize, topLeftY + squareSize) 
            };

            Brush topBrush = new SolidBrush(Color.FromArgb((int)(red / 1.5), (int)(green / 1.5), (int)(blue / 1.5)));
            Brush sideBrush = new SolidBrush(Color.FromArgb((int)(red / 2), (int)(green / 2), (int)(blue / 2)));


            

            g.FillPolygon(brush, frontFace);
            
            g.FillPolygon(topBrush, topFace);
            
            g.FillPolygon(sideBrush, sideFace);


            g.DrawPolygon(pen, frontFace);
            g.DrawPolygon(pen, topFace);
            g.DrawPolygon(pen, sideFace);

        }

        private void CubeForm_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }

}
