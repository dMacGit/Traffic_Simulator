using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Traffic_Simulator
{
    public partial class DesignGuiForm : Form
    {
        private int gridBoxSize = 20;
        private Graphics graphicsObj = null, graphicsMiniMap = null;
        private int xGrid;
        private int yGrid;
        private Image worldMapImage, miniMapImage;
        private Point _pos, _mini;  // current image position
        private int _speed;  // current speed
        private float xScale,yScale;
        private int xMiniMapGap, yMiniMapGap;
        private float mxScale;

        public DesignGuiForm(Point grid)
        {
            this.xGrid = grid.X;
            this.yGrid = grid.Y;
            worldMapImage = CreateWorldImage();

            
            // start at 0,0
            _pos = Point.Empty;
            // speed to move grid: 20 pixles / key press
            _speed = 20;
            Text = "Speed: = " + _speed;
            
            System.Console.WriteLine("Created DesignGuiForm!!");
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            miniMapImage = resizeImage(CreateMiniMapImage(), this.miniMapPanel.Size);
            graphicsObj = this.worldMap.CreateGraphics();
            graphicsMiniMap = this.miniMapPanel.CreateGraphics();

            System.Console.WriteLine("MiniMap scale: " + xScale + "," + yScale + "| Panel dimensions: " + worldMap.Width + "," + worldMap.Height);
        }
        private void DesignGuiForm_Paint(object sender, PaintEventArgs e)
        {
            //Console.Write("WorldMap Painted!!\n");
            Invalidate();
            graphicsMiniMap.DrawImage(this.miniMapImage, xMiniMapGap, yMiniMapGap, miniMapImage.Width, miniMapImage.Height);
            Pen myPen = new Pen(Color.Black, 1);
            Rectangle newRect = new Rectangle(xMiniMapGap + _mini.X, yMiniMapGap + _mini.Y, (int)(worldMap.Width * mxScale), (int)(worldMap.Height * mxScale));
            //Console.WriteLine("Rect bounds: " + (xMiniMapGap + (int)((_pos.X + gridBoxSize) * mxScale)) + "," + (yMiniMapGap + (int)((_pos.Y + gridBoxSize) * mxScale)) + "," + (int)(worldMap.Width * mxScale) + "," + (int)(worldMap.Height * mxScale));
            graphicsMiniMap.DrawRectangle(myPen,newRect);
            graphicsObj.DrawImage(worldMapImage, _pos.X, _pos.Y, worldMapImage.Width, worldMapImage.Height);
            Show();
        }
        private void worldMap_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    //Console.Write("you pressed the left arrow!\n");
                    UpdatePosition(_speed, 0);
                    break;

                case Keys.Right:
                    //Console.Write("you pressed the right arrow!\n");
                    UpdatePosition(-_speed, 0);
                    break;

                case Keys.Up:
                    //Console.Write("you pressed the up arrow!\n");
                    UpdatePosition(0, _speed);
                    break;

                case Keys.Down:
                    //Console.Write("you pressed the down arrow!\n");
                    UpdatePosition(0, -_speed);
                    break;

                /*case Keys.Add:
                    _speed++;
                    _speed = Math.Min(10, _speed);
                    Text = "Speed: = " + _speed;
                    break;

                case Keys.Subtract:
                    _speed--;
                    _speed = Math.Max(1, _speed);
                    Text = "Speed: = " + _speed;
                    break;*/
                default:
                    return;
            }
        }
        // the move helper function
        private void UpdatePosition(int dx, int dy)
        {
            //Console.Write("UpdatePosition!\n");
            Point newPos = new Point(_pos.X + dx, _pos.Y + dy);
            Point miniPos = new Point( (int)((_pos.X + dx)*mxScale), (int)((_pos.Y + dy)*mxScale));
            // dont go out of window boundary
            //newPos.X = Math.Max(0, Math.Min(ClientSize.Width - worldMapImage.Width, newPos.X));
            //newPos.Y = Math.Max(0, Math.Min(ClientSize.Height - worldMapImage.Height, newPos.Y));

            if (newPos != _pos)
            {
                //Console.Write("UpdatePosition:::if reached\n");
                
                _pos = newPos;
                _mini = miniPos;
                //Console.WriteLine("Picture pos: " + _pos.X + "," + _pos.Y);
                Refresh();
            }
            else
            {
                //Console.WriteLine("Picture pos: " + _pos.X + "," + _pos.Y);
                Refresh();
            }
            
        }
        
        /*
         * 
         * Create World. Creates an image with a certain colour,
         * with the dimensions the user specified. This is the worldMap.
         * 
         */
 
        private Image CreateWorldImage()
        {
            // Create a new Bitmap object, 50 x 50 pixels in size
            Image canvas = new Bitmap(xGrid * gridBoxSize, yGrid * gridBoxSize);
            Console.WriteLine("World size: " + xGrid * gridBoxSize + "," + yGrid * gridBoxSize);
            
            // create an object that will do the drawing operations
            Graphics graphicsObj = Graphics.FromImage(canvas);

            // draw a few shapes on the canvas picture
            SolidBrush myBrush = new SolidBrush(Color.Green);

            graphicsObj.FillRectangle(myBrush,new Rectangle(0,0,xGrid * gridBoxSize,yGrid * gridBoxSize));
            Pen myPen = new Pen(Color.White, 1);
            for (int xPos = 0; xPos < canvas.Width; xPos = xPos + gridBoxSize)
            {
                graphicsObj.DrawLine(myPen, 0, xPos, canvas.Width, xPos);
                graphicsObj.DrawLine(myPen, xPos, 0, xPos, canvas.Height);
            }

            // now the drawing is done, we can discard the artist object
            graphicsObj.Dispose();

            // return the picture
            return canvas;
        }
        private Image resizeImage(Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);
            Console.WriteLine("x scale ::::: " + (float)size.Width +" / " + (float)sourceWidth);
            Console.WriteLine("y scale ::::: " + (float)size.Height + " / " + (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);
            xScale = nPercentW;
            yScale = nPercentH;
            mxScale = nPercent;
            if ((size.Width - destWidth) > 0)
            {
                xMiniMapGap = (size.Width - destWidth)/2;
            }
            if ((size.Height - destHeight) > 0)
            {
                yMiniMapGap = (size.Height - destHeight)/2;
            }
            
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
           
            //g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }
        private Image CreateMiniMapImage()
        {
            // Create a new Bitmap object
            Image canvas = new Bitmap(xGrid * gridBoxSize, yGrid * gridBoxSize);
            Console.WriteLine("MiniMap size: " + xGrid * gridBoxSize + "," + yGrid * gridBoxSize);
            // create an object that will do the drawing operations
            Graphics graphicsObj = Graphics.FromImage(canvas);
            // draw a few shapes on the canvas picture
            SolidBrush myBrush = new SolidBrush(Color.Green);
            graphicsObj.FillRectangle(myBrush, new Rectangle(0, 0, xGrid * gridBoxSize, yGrid * gridBoxSize));
            // now the drawing is done, we can discard the artist object
            graphicsObj.Dispose();
            // return the picture
            return canvas;
        }
    }
}
