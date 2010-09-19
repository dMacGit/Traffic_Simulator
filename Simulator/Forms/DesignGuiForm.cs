using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Traffic_Simulator
{
    /// <summary> 
    /// DesignGuiForm. This is the design's form, and it
    /// handles all the gui events, such as button presses,
    /// mouse presses etc. It is delegated to handle all of
    /// the gui components by the design controller.
    /// </summary>
    
    public partial class DesignGuiForm : Form
    {
        //Design constants
        private const int gridBoxSize = 20;
        private const int worldBoarderSize = 40;
        private const int gridBoxBoarderSize = 1;

        //Unit orientation
        private const int DIRECTION_NORTH = 0;
        private const int DIRECTION_SOUTH = 1;
        private const int DIRECTION_EAST = 2;
        private const int DIRECTION_WEST = 3;

        //Graphics components used to draw.
        private Graphics graphicsObj = null, graphicsMiniMap = null;

        //Images for world grid, mini map etc.
        private Image worldMapImage, miniMapImage, gridImages;

        //Current image position
        private Point newMainMapPos, newMiniMapPos;

        //Mouse Entered grid boolean
        private bool mouseEnteredView = false;

        //The units
        private RoadUnit newUnit;

        //Current speed
        private int movementSpeed, miniMapSpeed;  

        //Specified number of grids
        private int xGrid;
        private int yGrid;

        //Mini map leftover space
        private int xMiniMapGap, yMiniMapGap;
        
        //Image size rescale factor
        private float xScale,yScale;
        private float mxScale;

        //Boolean to check if unit selected      
        private bool hasSelectedTile = false;

        //The unit selected
        private PictureBox selected;

        //Cursor offset to centre
        private Point cursorOffset;

        //Current mouse position
        private Point mousePosition;

        //Unit properties
        private int xSize;
        private int ySize;
        private int unitOrientation;
        private Point lastSnappedToGrid;
        private Point snappedToGrid;

        //The Design controller
        private Design design;

        public DesignGuiForm(Point grid, String name, Design designController)
        {
            //Assign user specified parameters to design
            this.Name = name;
            this.xGrid = grid.X;
            this.yGrid = grid.Y;
            this.design = designController;
            System.Console.WriteLine("Created Design with specified parameters [" + Name + ": " + xGrid + "," + yGrid + "]");

            //Initialize all points to zero
            mousePosition = Point.Empty;
            newMainMapPos = Point.Empty;
            newMiniMapPos = Point.Empty;
            System.Console.WriteLine("Points initialized");

            //Create the world grid image
            worldMapImage = CreateWorldImage();
            gridImages = new Bitmap(xGrid * gridBoxSize, yGrid * gridBoxSize);
            
            //Speed to move grid: 20 pixles / key press
            movementSpeed = 20;
            
            //Unit properties
            unitOrientation = DIRECTION_NORTH;
            
            InitializeComponent();
            System.Console.WriteLine("Initialized Form Components");

            graphicsMiniMap = miniMapPanel.CreateGraphics();

            //Create mini-map image based on resized world area
            miniMapImage = resizeImage(CreateMiniMapImage(), this.miniMapPanel.Size);

            if (miniMapImage == null)
            {
                System.Console.WriteLine("--->[Error creating mini image!!]<---");
            }

            //Manually set controls for form
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            
            //Setting mini-map revised movement speed
            miniMapSpeed = (int)(movementSpeed * mxScale);
        }
        private void worldMap_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    UpdatePosition(movementSpeed, 0, -miniMapSpeed, 0);
                    break;
                case Keys.Right:
                    UpdatePosition(-movementSpeed, 0, miniMapSpeed, 0);
                    break;
                case Keys.Up:
                    UpdatePosition(0, movementSpeed, 0, -miniMapSpeed);
                    break;
                case Keys.Down:
                    UpdatePosition(0, -movementSpeed, 0, miniMapSpeed);
                    break;
                default:
                    return;
            }
        }


        private void UpdatePosition(int dx, int dy,int mini_dx, int mini_dy)
        {
            Point newPos = new Point(newMainMapPos.X + dx, newMainMapPos.Y + dy);
            Point miniPos = new Point((int)(newMiniMapPos.X + mini_dx), (int)(newMiniMapPos.Y + mini_dy));

            if (newPos != newMainMapPos)
            {                
                newMainMapPos = newPos;
                Refresh();
            }
            if (miniPos != newMiniMapPos)
            {
                newMiniMapPos = miniPos;
                Refresh();
            }
            else
            {
                Refresh();
            }
        }
        
        /**
         * 
         * Create World. Creates an image with a certain colour,
         * with the dimensions the user specified. This is the worldMap.
         * 
         */
 
        private Image CreateWorldImage()
        {
            Image canvas = new Bitmap(xGrid * gridBoxSize + (2 * worldBoarderSize), yGrid * gridBoxSize + (2 * worldBoarderSize));
            Console.WriteLine("World size: " + (xGrid * gridBoxSize + (2 * worldBoarderSize)) + "," + (yGrid * gridBoxSize + (2 * worldBoarderSize)));
            
            Graphics graphicsObj = Graphics.FromImage(canvas);

            SolidBrush RedBrush = new SolidBrush(Color.Red);
            graphicsObj.FillRectangle(RedBrush, new Rectangle(0, 0, xGrid * gridBoxSize + (2 * worldBoarderSize), yGrid * gridBoxSize + (2 * worldBoarderSize)));
            SolidBrush myBrush = new SolidBrush(Color.Green);
            graphicsObj.FillRectangle(myBrush, new Rectangle(worldBoarderSize, worldBoarderSize, xGrid * gridBoxSize, yGrid * gridBoxSize));
            Pen myPen = new Pen(Color.White, 1);
            for (int yPos = 0; yPos < yGrid; yPos++)
            {
                //Horizontal line
                graphicsObj.DrawLine(myPen, worldBoarderSize, (yPos * gridBoxSize) + worldBoarderSize, xGrid * gridBoxSize + worldBoarderSize, (yPos * gridBoxSize) + worldBoarderSize);
                graphicsObj.DrawLine(myPen, worldBoarderSize, ((yPos * gridBoxSize) + (gridBoxSize - 1)) + worldBoarderSize, xGrid * gridBoxSize + worldBoarderSize, ((yPos * gridBoxSize) + (gridBoxSize - 1)) + worldBoarderSize);
            }
            for (int xPos = 0; xPos < xGrid; xPos++)
            {
                //Vertical line
                graphicsObj.DrawLine(myPen, (xPos * gridBoxSize) + worldBoarderSize, worldBoarderSize, (xPos * gridBoxSize) + worldBoarderSize, yGrid * gridBoxSize + worldBoarderSize);
                graphicsObj.DrawLine(myPen, ((xPos * gridBoxSize) + (gridBoxSize - 1)) + worldBoarderSize, worldBoarderSize, ((xPos * gridBoxSize) + (gridBoxSize - 1)) + worldBoarderSize, yGrid * gridBoxSize + worldBoarderSize);
            }
            graphicsObj.Dispose();
            return canvas;
        }
        private Bitmap resizeImage(Image imgToResize, Size size)
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
            //Graphics g = Graphics.FromImage((Image)b);

            //g.Dispose();                                          
            return b;
        }
        private Image CreateMiniMapImage()
        {
            Bitmap bitmap = new Bitmap(xGrid * gridBoxSize, yGrid * gridBoxSize);
            Console.WriteLine("MiniMap size: " + xGrid * gridBoxSize + "," + yGrid * gridBoxSize);
            Graphics graphicsObj = Graphics.FromImage(bitmap);
            SolidBrush myBrush = new SolidBrush(Color.Green);
            //Rectangle fillRect = new Rectangle(0, 0, xGrid * gridBoxSize, yGrid * gridBoxSize);
            graphicsObj.FillRectangle(myBrush, new Rectangle(0, 0, xGrid * gridBoxSize, yGrid * gridBoxSize));
            //graphicsObj.Dispose();
            return (Image)bitmap;
        }
        private void offRampClicked(object sender, EventArgs e)
        {
            if (selected != null && selected.Equals(offRampIcon))
            {
                offRampIcon.BackColor = Color.Transparent;
                selected = null;
                newUnit = null;
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
                newUnit = null;
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
                newUnit = null;
            }
            else
            {
                if (selected != null)
                {
                    selected.BackColor = Color.Transparent;
                }
                singleRoadIcon.BackColor = Color.Black;
                selected = singleRoadIcon;
                Assembly myAssembly = Assembly.GetExecutingAssembly();
                newUnit = new RoadUnit();
                newUnit.unitImage = new Bitmap(System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream("Traffic_Simulator.Resources.Single_Road.png"));
                newUnit.NumOfLanes = 1;
                newUnit.Width = 1 * gridBoxSize;
                newUnit.Height = 1 * gridBoxSize;

                if (this.unitOrientation == DIRECTION_NORTH)
                {
                    xSize = newUnit.Width;
                    ySize = newUnit.Height;
                }
                this.cursorOffset = new Point(xSize / 2, ySize / 2);
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
                newUnit = null;
            }
            else
            {
                if (selected != null)
                {
                    selected.BackColor = Color.Transparent;
                }
                twoLaneMwayIcon.BackColor = Color.Black;
                selected = twoLaneMwayIcon;
                Assembly myAssembly = Assembly.GetExecutingAssembly();
                newUnit = new RoadUnit();
                newUnit.unitImage = new Bitmap(System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream("Traffic_Simulator.Resources.2_Lane_Hway.png"));
                newUnit.NumOfLanes = 2;
                newUnit.Width = 2 * gridBoxSize;
                newUnit.Height = 1 * gridBoxSize;

                if (this.unitOrientation == DIRECTION_NORTH)
                {
                    xSize = newUnit.Width;
                    ySize = newUnit.Height;
                }
                this.cursorOffset = new Point(xSize / 2, ySize / 2);
            }
            Refresh();
        }
        private void threeLaneMwayClicked(object sender, EventArgs e)
        {
            if (selected != null && selected.Equals(threeLaneMwayIcon))
            {
                threeLaneMwayIcon.BackColor = Color.Transparent;
                selected = null;
                newUnit = null;
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
                newUnit = new RoadUnit();
                newUnit.unitImage = new Bitmap(System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream("Traffic_Simulator.Resources.3_lane_Hway.png"));
                newUnit.NumOfLanes = 3;
                newUnit.Width = 3 * gridBoxSize;
                newUnit.Height = 1 * gridBoxSize;
                
                if (this.unitOrientation == DIRECTION_NORTH)
                {
                    xSize = newUnit.Width;
                    ySize = newUnit.Height;
                }
                this.cursorOffset = new Point(xSize / 2, ySize / 2);
            }
            Refresh();
        }

        private void worldViewEntred(object sender, EventArgs e)
        {
            if (selected != null)
            {
                this.Cursor = Cursors.Cross;
                mouseEnteredView = true;
            }
            else
                this.Cursor = Cursors.Default;
        }

        private void worldViewExited(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            mouseEnteredView = false;
        }

        private void recalculateMousePoint(object sender, MouseEventArgs e)
        {
            if ((int)e.X != mousePosition.X || (int)e.Y != mousePosition.Y)
            {
                mousePosition.X = e.X;
                mousePosition.Y = e.Y;
            }
            if (newUnit != null)
            {
                snappedToGrid = snapToGrid(snapWithinWorldBounds());
                if (snappedToGrid.X != lastSnappedToGrid.X || snappedToGrid.Y != lastSnappedToGrid.Y)
                {
                    lastSnappedToGrid = snappedToGrid;
                    newUnit.unitPosition = snappedToGrid;
                    Refresh();
                }
            }
        }
        private void miniOnPaint(object sender, PaintEventArgs e)
        {
            Graphics graphicsMiniMap = e.Graphics;
            Rectangle rect = new Rectangle(xMiniMapGap, yMiniMapGap, miniMapImage.Width, miniMapImage.Height);
            SolidBrush newGreen = new SolidBrush(Color.Green);
            graphicsMiniMap.FillRectangle(newGreen, rect);
            Pen myPen = new Pen(Color.Black, 1);
            Rectangle newRect = new Rectangle(xMiniMapGap + newMiniMapPos.X, yMiniMapGap + newMiniMapPos.Y, (int)(worldMap.Width * mxScale), (int)(worldMap.Height * mxScale));
            graphicsMiniMap.DrawRectangle(myPen, newRect);
            graphicsMiniMap.Dispose();  
        }

        /**
         * The snapWithinWorldBounds Method keeps unit within grid. This method snaps the
         * unit image centred behind the mouse cursor within the world
         * bounds (within the green and white grid). If the cursor moves
         * outside this bounds (into the red area and beyond) the unit image
         * is repositioned within the grid.
         */

        private Point snapWithinWorldBounds()
        {
            int actualXposLeft = (mousePosition.X - cursorOffset.X);
            int actualXposRight = (mousePosition.X + cursorOffset.X);

            int actualYposUp = (mousePosition.Y - cursorOffset.Y);
            int actualYposDown = (mousePosition.Y + cursorOffset.Y);

            int actualXpos = (mousePosition.X - cursorOffset.X);
            int actualYpos = (mousePosition.Y - cursorOffset.Y);

            if (actualXposLeft < worldBoarderSize + newMainMapPos.X || actualXposRight > (worldMapImage.Width - worldBoarderSize) + newMainMapPos.X)
            {
                if (actualXposLeft < worldBoarderSize + newMainMapPos.X)
                {
                    actualXpos = worldBoarderSize + newMainMapPos.X;
                }
                if (actualXposRight > (worldBoarderSize + newMainMapPos.X + (xGrid * gridBoxSize)))
                {
                    actualXpos = ((worldMapImage.Width - worldBoarderSize) + newMainMapPos.X) - xSize;
                }
            }
            if (actualYposUp > worldBoarderSize + newMainMapPos.Y || actualYposDown < (worldMapImage.Height - worldBoarderSize) + newMainMapPos.Y)
            {
                if (actualYposUp < worldBoarderSize + newMainMapPos.Y)
                {
                    actualYpos = worldBoarderSize + newMainMapPos.Y;
                }
                if (actualYposDown > (worldBoarderSize + newMainMapPos.Y + (yGrid * gridBoxSize)))
                {
                    actualYpos = ((worldMapImage.Height - worldBoarderSize) + newMainMapPos.Y) - ySize;
                }
            }
            return new Point(actualXpos, actualYpos);
        }
        private Point snapToGrid(Point snappedWithinPoint)
        {
            int xGrid_No_Offset = snappedWithinPoint.X / gridBoxSize;
            int yGrid_No_Offset = snappedWithinPoint.Y / gridBoxSize;
            int xGridNum = xGrid_No_Offset - (worldBoarderSize / gridBoxSize) - (newMainMapPos.X / gridBoxSize);
            int yGridNum = yGrid_No_Offset - (worldBoarderSize / gridBoxSize) - (newMainMapPos.Y / gridBoxSize);
            newUnit.gridValue = new Point(xGridNum, yGridNum);
            int xPos = gridBoxSize * xGrid_No_Offset;
            int yPos = gridBoxSize * yGrid_No_Offset;
            return new Point(xPos, yPos);
        }
        private void mainWindowPaint(object sender, PaintEventArgs e)
        {
            Graphics graphicsObj = this.worldMap.CreateGraphics();
            graphicsObj.DrawImage(worldMapImage, newMainMapPos.X, newMainMapPos.Y, worldMapImage.Width, worldMapImage.Height);
            if (newUnit != null && mouseEnteredView)
            {
                graphicsObj.DrawImage(newUnit.unitImage, newUnit.unitPosition.X, newUnit.unitPosition.Y);
            }
            graphicsObj.Dispose();  
        }

        private void addUnitToGrid(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (newUnit != null)
                    {
                        if (design.addRoadUnit(newUnit))
                        {
                            Graphics imageGraphics = Graphics.FromImage(worldMapImage);
                            design.modifiedUnitArray[newUnit.gridValue.Y, newUnit.gridValue.X].Draw(imageGraphics, -newMainMapPos.X, -newMainMapPos.Y);
                        }
                        else
                            System.Console.WriteLine("Couldn't add to grid @: " + newUnit.gridValue.Y + "," + newUnit.gridValue.X);
                    }
                    break;
                case MouseButtons.Right:
                    break;
                case MouseButtons.Middle:
                    break;
                default:
                    break;
            } 
        }
    }
}
