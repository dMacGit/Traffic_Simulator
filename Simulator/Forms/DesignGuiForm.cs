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
        /// <summary> 
        /// GridBoxSize integer. Specifies the grid/square dimension.
        /// </summary>
        private const int gridBoxSize = 20;
        /// <summary> 
        /// WorldBoarderSize integer. Specifies the world grid Boarder Size (Red boarder)
        /// </summary>
        private const int worldBoarderSize = 40;

        /// <summary> 
        /// DIRECTION_NORTH integer. Constant variable used to specify unit's direction is North facing
        /// </summary>
        private const int DIRECTION_NORTH = 0;
        /// <summary> 
        /// DIRECTION_SOUTH integer. Constant variable used to specify unit's direction is South facing
        /// </summary>
        private const int DIRECTION_SOUTH = 1;
        /// <summary> 
        /// DIRECTION_EAST integer. Constant variable used to specify unit's direction is East facing
        /// </summary>
        private const int DIRECTION_EAST = 2;
        /// <summary> 
        /// DIRECTION_WEST integer. Constant variable used to specify unit's direction is West facing
        /// </summary>
        private const int DIRECTION_WEST = 3;
        /// <summary> 
        /// GraphicsMiniMap Graphics. Graphics object used to draw onto the minimap panel.
        /// </summary>
        private Graphics graphicsMiniMap = null;
        /// <summary> 
        /// WorldMapImage Image. Image used for the world grid area.
        /// </summary>
        private Image worldMapImage;
        /// <summary> 
        /// MiniMapImage Image. Image used for the mini-map area.
        /// </summary>
        private Image miniMapImage;
        /// <summary> 
        /// NewMainMapPos Point. Point used to hold the updated movment of the world grid image.
        /// </summary>
        private Point newMainMapPos;
        /// <summary> 
        /// NewMiniMapPos Point. Point used to hold the updated movment of the mini-map view box.
        /// </summary>
        private Point newMiniMapPos;
        /// <summary> 
        /// MouseEnteredView bool. Boolean used to signify the mouse has entered the world grid panel.
        /// </summary>
        private bool mouseEnteredView = false;
        /// <summary> 
        /// NewUnit RoadUnit. RoadUnit object used when adding to the grid.
        /// </summary>
        private RoadUnit newUnit;
        /// <summary> 
        /// MovementSpeed Integer. Integer value specifying the speed of movment for the world grid area.
        /// </summary>
        private int movementSpeed;
        /// <summary> 
        /// MiniMapSpeed Integer. Integer value specifying the speed of movment for the mini-map view box.
        /// </summary>
        private int miniMapSpeed;
        /// <summary> 
        /// XGrid Integer. Integer value specifying number of horizontal boxes in the world grid.
        /// </summary>
        private int xGrid;
        /// <summary> 
        /// YGrid Integer. Integer value specifying number of vertical boxes in the world grid.
        /// </summary>
        private int yGrid;
        /// <summary> 
        /// XMiniMapGap Integer. Integer value specifying left-over horizontal
        /// space within the mini-map after re-scaling image.
        /// </summary>
        private int xMiniMapGap;
        /// <summary> 
        /// YMiniMapGap Integer. Integer value specifying left-over vertical
        /// space within the mini-map after re-scaling image.
        /// </summary>
        private int yMiniMapGap;
        /// <summary> 
        /// XScale Float. Float value for holding the horizontal scale factor for
        /// re-scaling the image.
        /// </summary>
        private float xScale;
        /// <summary> 
        /// YScale Float. Float value for holding the vertical scale factor for
        /// re-scaling the image.
        /// </summary>
        private float yScale;
        /// <summary> 
        /// MxScale Float. Float value for holding the max scale factor of x&y
        /// scale factors for re-scaling the image.
        /// </summary>
        private float mxScale;
        /// <summary> 
        /// Selected PictureBox. PictureBox object holding the currently selected
        /// icon's picture box info.
        /// </summary>
        private PictureBox selected;
        /// <summary> 
        /// CursorOffset Point. Point value for the adjusted unit's position.
        /// </summary>
        private Point cursorOffset;
        /// <summary> 
        /// MousePosition Point. Point value for the current mouse position.
        /// </summary>
        private Point mousePosition;
        /// <summary> 
        /// XSize Integer. Integer value for units horizontal pixel size.
        /// </summary>
        private int xSize;
        /// <summary> 
        /// YSize Integer. Integer value for units vertical pixel size.
        /// </summary>
        private int ySize;
        /// <summary> 
        /// UnitOrientation Integer. Integer value holding the units direction.
        /// </summary>
        private int unitOrientation;
        /// <summary> 
        /// LastSnappedToGrid Point. Point value for the previous grid position of the unit.
        /// </summary>
        private Point lastSnappedToGrid;
        /// <summary> 
        /// SnappedToGrid Point. Point value for the current grid position of the unit.
        /// </summary>
        private Point snappedToGrid;
        /// <summary> 
        /// Design Design. Design object holding a reference to the design controller.
        /// </summary>
        private Design design;

        /// <summary> 
        /// DesignGuiForm Constructor method. Used to Initilize parameters needed to handle the gui events.
        /// Sets design form name, grid size. Assigns the design controller class. Initializes points, and
        /// direction orientation, as well as creating the images needed in the world grid and the mini-map.
        /// </summary>
        /// <param name="grid">Point</param>
        /// <param name="name">String</param>
        /// <param name="designController">Design</param>
        
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

        /// <summary> 
        /// WorldMap_KeyDown Event Handler method. Handles key press events.
        /// Checks for what arrow key was pressed and then updates the world-grid
        /// and mini-map view box positions.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">KeyEventArgs</param>
        
        private void worldMap_KeyDown(object sender, KeyEventArgs e)
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

        /// <summary> 
        /// UpdatePosition method. Is called by the worldMap_KeyDown event
        /// handler. Updates the world-grid and mini-map view box positions
        /// by either adding or subtracting a value (Speed variable), depending
        /// key was pressed.
        /// </summary>
        /// <param name="dx">Integer</param>
        /// <param name="dy">Integer</param>
        /// <param name="mini_dx">Integer</param>
        /// <param name="mini_dy">Integer</param>

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

        /// <summary> 
        /// CreateWorldImage method. Is called in the constructer to create
        /// the image for the world-grid.
        /// </summary>
        
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

        /// <summary> 
        /// ResizeImage method. Is called in the constructer to re-size the
        /// world-grid's image size to fit in the mini-map panel.
        /// </summary>
        /// <param name="imgToResize">Image</param>
        /// <param name="size">Size</param>
        
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

        /// <summary> 
        /// CreateMiniMapImage method. Is called in the constructer to 
        /// create the mini-map image based on the world-grid size, before
        /// being resized to fit in the mini-map panel.
        /// </summary>
        
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

        /// <summary> 
        /// OffRampClicked Event Handler method. Handler for when the
        /// off-ramp icon is clicked.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        
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

        /// <summary> 
        /// OnRampClicked Event Handler method. Handler for when the
        /// on-ramp icon is clicked.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        
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

        /// <summary> 
        /// SingleRoadClicked Event Handler method. Handler for when the
        /// single road icon is clicked.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        
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

        /// <summary> 
        /// TwoLaneMwayClicked Event Handler method. Handler for when the
        /// two lane Mway icon is clicked.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        
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

        /// <summary> 
        /// ThreeLaneMwayClicked Event Handler method. Handler for when the
        /// three lane Mway icon is clicked.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        
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

        /// <summary> 
        /// WorldViewEntred Event Handler method. Handler for when the
        /// world grid panel in entered by the mouse.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        
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

        /// <summary> 
        /// WorldViewExited Event Handler method. Handler for when the
        /// world grid panel in exited by the mouse.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
       
        private void worldViewExited(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            mouseEnteredView = false;
        }

        /// <summary> 
        /// RecalculateMousePoint Event Handler method. Handler for when the
        /// mouse is moved within the world grid panel.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">MouseEventArgs</param>
        
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

        /// <summary> 
        /// MiniOnPaint Paint Event Handler method. Handles re-painting
        /// the mini-map panel.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">PaintEventArgs</param>
        
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

        /// <summary>
        /// SnapWithinWorldBounds Method. keeps unit within grid. This method snaps the
        /// unit image centred behind the mouse cursor within the world
        /// bounds (within the green and white grid). If the cursor moves
        /// outside this bounds (into the red area and beyond) the unit image
        /// is repositioned within the grid.
        /// </summary>

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

        /// <summary>
        /// SnapToGrid Method. Snaps the provided point to
        /// within an actual grid-box. It then updates the
        /// units parameters.
        /// </summary>
        /// <param name="snappedWithinPoint">Point</param>
        
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

        /// <summary> 
        /// MainWindowPaint Paint Event Handler method. Handles re-painting
        /// the world-grid panel.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">PaintEventArgs</param>
        
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

        /// <summary> 
        /// AddUnitToGrid Event Handler method. Handler for when
        /// user clickes mouse buttons within the world-grid panel.
        /// Checks for left click then calls the parent design
        /// controller addRoadUnit method.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">MouseEventArgs</param>
        
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
