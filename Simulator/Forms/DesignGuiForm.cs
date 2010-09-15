using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Traffic_Simulator
{
    public partial class DesignGuiForm : Form
    {
        private int gridBoxSize = 20;
        private Graphics graphicsObj = null, graphicsMiniMap = null;
        private int xGrid;
        private int yGrid;
        private Image worldMapImage, miniMapImage, unitToPlace;
        private Point newMainMapPos, newMiniMapPos;  // current image position
        private int movementSpeed, miniMapSpeed;  // current speed
        private float xScale,yScale;
        private int xMiniMapGap, yMiniMapGap;
        private float mxScale;
        private bool hasSelectedTile = false;
        private PictureBox selected;
        private Point cursorOffset;
        private Point mousePosition;

        public DesignGuiForm(Point grid, String name)
        {
            mousePosition = new Point();
            this.Name = name;
            this.xGrid = grid.X;
            this.yGrid = grid.Y;
            worldMapImage = CreateWorldImage();

            
            // start at 0,0
            newMainMapPos = Point.Empty;
            newMiniMapPos = Point.Empty;
            // speed to move grid: 20 pixles / key press
            movementSpeed = 20;
            
            System.Console.WriteLine("Created DesignGuiForm!!");
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            miniMapImage = resizeImage(CreateMiniMapImage(), this.miniMapPanel.Size);
            graphicsObj = this.worldMap.CreateGraphics();
            graphicsMiniMap = this.miniMapPanel.CreateGraphics();
            miniMapSpeed = (int)(movementSpeed * mxScale);
            //Text = "Speed: = " + movementSpeed;
            System.Console.WriteLine("Speed: = " + movementSpeed + " | Mini-map speed: " + miniMapSpeed + " (" + mxScale + ")");
            System.Console.WriteLine("MiniMap scale: " + xScale + "," + yScale + "| Panel dimensions: " + worldMap.Width + "," + worldMap.Height);
            System.Console.WriteLine("Panel1 width: " + this.mapSplitContainer.Panel1.Bounds.Right);
            System.Console.WriteLine("Panel1 Y: " + this.mapSplitContainer.Panel1.Bounds.Y);
            System.Console.WriteLine("Panel2 X: " + this.mapSplitContainer.Panel2.Bounds.X);//<--Possibly edge of main window [X]
            System.Console.WriteLine("Panel2 Y: " + this.mapSplitContainer.Panel2.Bounds.Y);
            System.Console.WriteLine("[Actual] Panel2 Y: " + this.Bounds.Top);
            System.Console.WriteLine("splitpane gap: " + this.mapSplitContainer.SplitterDistance);
            //System.Console.WriteLine("Y Bounds: " + this.worldMap.Bounds.Right);
            
            //Offset for cursor in world panel.
            cursorOffset = new Point(gridBoxSize / 2, (gridBoxSize * 2) + ((gridBoxSize * 2) / 3));
        }
        private void DesignGuiForm_Paint(object sender, PaintEventArgs e)
        {
            //Console.Write("WorldMap Painted!!\n");
            Invalidate();
            if (unitToPlace != null)
            {
                graphicsObj.DrawImage(unitToPlace, mousePosition.X/* - (this.mapSplitContainer.Panel2.Bounds.X + cursorOffset.X)*/, mousePosition.Y /*- (this.Bounds.Top + cursorOffset.Y)*/);
            }
            graphicsMiniMap.DrawImage(this.miniMapImage, xMiniMapGap, yMiniMapGap, miniMapImage.Width, miniMapImage.Height);
            Pen myPen = new Pen(Color.Black, 1);
            Rectangle newRect = new Rectangle(xMiniMapGap + newMiniMapPos.X, yMiniMapGap + newMiniMapPos.Y, (int)(worldMap.Width * mxScale), (int)(worldMap.Height * mxScale));
            //Console.WriteLine("Rect bounds: " + (xMiniMapGap + (int)((_pos.X + gridBoxSize) * mxScale)) + "," + (yMiniMapGap + (int)((_pos.Y + gridBoxSize) * mxScale)) + "," + (int)(worldMap.Width * mxScale) + "," + (int)(worldMap.Height * mxScale));
            graphicsMiniMap.DrawRectangle(myPen,newRect);
            graphicsObj.DrawImage(worldMapImage, newMainMapPos.X, newMainMapPos.Y, worldMapImage.Width, worldMapImage.Height);
            //Show();
        }
        private void worldMap_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    //Console.Write("you pressed the left arrow!\n");
                    UpdatePosition(movementSpeed, 0, -miniMapSpeed, 0);
                    break;

                case Keys.Right:
                    //Console.Write("you pressed the right arrow!\n");
                    UpdatePosition(-movementSpeed, 0, miniMapSpeed, 0);
                    break;

                case Keys.Up:
                    //Console.Write("you pressed the up arrow!\n");
                    UpdatePosition(0, movementSpeed, 0, -miniMapSpeed);
                    break;

                case Keys.Down:
                    //Console.Write("you pressed the down arrow!\n");
                    UpdatePosition(0, -movementSpeed, 0, miniMapSpeed);
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
        private void UpdatePosition(int dx, int dy,int mini_dx, int mini_dy)
        {
            //Console.Write("UpdatePosition!\n");
            Point newPos = new Point(newMainMapPos.X + dx, newMainMapPos.Y + dy);
            Point miniPos = new Point((int)(newMiniMapPos.X + mini_dx), (int)(newMiniMapPos.Y + mini_dy));
            // dont go out of window boundary
            //newPos.X = Math.Max(0, Math.Min(ClientSize.Width - worldMapImage.Width, newPos.X));
            //newPos.Y = Math.Max(0, Math.Min(ClientSize.Height - worldMapImage.Height, newPos.Y));

            if (newPos != newMainMapPos)
            {
                //Console.Write("UpdatePosition:::if reached\n");
                
                newMainMapPos = newPos;
                
                //Console.WriteLine("Picture pos: " + _pos.X + "," + _pos.Y);
                Refresh();
            }
            if (miniPos != newMiniMapPos)
            {
                newMiniMapPos = miniPos;
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
            Image canvas = new Bitmap(xGrid * gridBoxSize, yGrid * gridBoxSize);
            Console.WriteLine("World size: " + xGrid * gridBoxSize + "," + yGrid * gridBoxSize);
            
            // create an object that will do the drawing operations
            Graphics graphicsObj = Graphics.FromImage(canvas);

            // draw a few shapes on the canvas picture
            SolidBrush myBrush = new SolidBrush(Color.Green);

            graphicsObj.FillRectangle(myBrush,new Rectangle(0,0,xGrid * gridBoxSize,yGrid * gridBoxSize));
            Pen myPen = new Pen(Color.White, 1);
            for (int yPos = 0; yPos < canvas.Height; yPos = yPos + gridBoxSize)
            {
                //Horizontal line
                graphicsObj.DrawLine(myPen, 0, yPos, canvas.Width, yPos);
                //Verticle line
                //graphicsObj.DrawLine(myPen, xPos, 0, xPos, canvas.Height);
            }
            for (int xPos = 0; xPos < canvas.Width; xPos = xPos + gridBoxSize)
            {
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
            Console.WriteLine("X resize ::::: " + (float)sourceWidth + " * " + nPercent+" = "+destWidth);
            Console.WriteLine("Y resize ::::: " + (float)sourceHeight + " * " + nPercent + " = " + destHeight);
            xScale = nPercentW;
            yScale = nPercentH;
            mxScale = nPercent;
            if ((size.Width - destWidth) > 0)
            {
                xMiniMapGap = (int)((size.Width - destWidth)/2.0);
            }
            if ((size.Height - destHeight) > 0)
            {
                yMiniMapGap = (int)((size.Height - destHeight) / 2.0);
            }
            Console.WriteLine("X gap ::::: " + xMiniMapGap + " Y gap ::::: " + yMiniMapGap);
            Console.WriteLine("world display window bounds: " + this.worldMap.Width + "," + this.worldMap.Height + " | Mini view box: " + this.worldMap.Width * this.mxScale + "," + this.worldMap.Height * this.mxScale);

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
            Graphics graphicsObj = Graphics.FromImage(canvas);
            SolidBrush myBrush = new SolidBrush(Color.Green);
            graphicsObj.FillRectangle(myBrush, new Rectangle(0, 0, xGrid * gridBoxSize, yGrid * gridBoxSize));
            //discard the artist object
            graphicsObj.Dispose();
            //return the picture
            return canvas;
        }
        private void offRampClicked(object sender, EventArgs e)
        {
            if (selected != null && selected.Equals(offRampIcon))
            {
                offRampIcon.BackColor = Color.Transparent;
                selected = null;
            }
            else
            {
                if (selected != null)
                {
                    selected.BackColor = Color.Transparent;
                }
                offRampIcon.BackColor = Color.Black;
                selected = offRampIcon;
            }
            Refresh();
        }
        private void onRampClicked(object sender, EventArgs e)
        {
            if (selected != null && selected.Equals(onRampIcon))
            {
                onRampIcon.BackColor = Color.Transparent;
                selected = null;
            }
            else
            {
                if (selected != null)
                {
                    selected.BackColor = Color.Transparent;
                }
                onRampIcon.BackColor = Color.Black;
                selected = onRampIcon;
            }
            Refresh();            
        }
        private void singleRoadClicked(object sender, EventArgs e)
        {
            if (selected != null && selected.Equals(singleRoadIcon))
            {
                singleRoadIcon.BackColor = Color.Transparent;
                selected = null;
            }
            else
            {
                if (selected != null)
                {
                    selected.BackColor = Color.Transparent;
                }
                singleRoadIcon.BackColor = Color.Black;
                selected = singleRoadIcon;
            }
            Refresh();
        }
        //Two-lane-motorway icon event handler. Handles when the two-lane-motorway icon
        //is clicked/declicked.
        private void twoLaneMwayClicked(object sender, EventArgs e)
        {
            if (selected != null && selected.Equals(twoLaneMwayIcon))
            {
                twoLaneMwayIcon.BackColor = Color.Transparent;
                selected = null;
            }
            else
            {
                if (selected != null)
                {
                    selected.BackColor = Color.Transparent;
                }
                twoLaneMwayIcon.BackColor = Color.Black;
                selected = twoLaneMwayIcon;
            }
            Refresh();
        }
        private void threeLaneMwayClicked(object sender, EventArgs e)
        {
            if (selected != null && selected.Equals(threeLaneMwayIcon))
            {
                threeLaneMwayIcon.BackColor = Color.Transparent;
                unitToPlace = null;
                selected = null;
            }
            else
            {
                if (selected != null)
                {
                    selected.BackColor = Color.Transparent;
                }
                threeLaneMwayIcon.BackColor = Color.Black;
                selected = threeLaneMwayIcon;
                Assembly myAssembly = Assembly.GetExecutingAssembly();
                string[] names = myAssembly.GetManifestResourceNames();
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
                unitToPlace = new Bitmap(System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream("Traffic_Simulator.Resources.3_lane_Hway.png"));
                
            }
            Refresh();
        }

        private void worldViewEntred(object sender, EventArgs e)
        {
            if (selected != null)
            {
                this.Cursor = Cursors.Cross;
            }
            else
                this.Cursor = Cursors.Default;
        }

        private void worldViewExited(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void recalculateMousePoint(object sender, MouseEventArgs e)
        {
            mousePosition = new Point(e.X,e.Y);
        }
    }
}
