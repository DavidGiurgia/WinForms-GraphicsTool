using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPaint.Bussiness;
using System.Windows.Forms;
using System.IO;

namespace MyPaint.Editor
{
    public partial class MainForm : Form
    {
        Shape currentShape;
        GraphicTool graphicTool;
        Point2D mouseDown;
        Point2D mouseUp;
        Point2D mouseMove;
        bool isDrawing;
        bool isDragging;
        int squareLength;
        string consoleText;
        public MainForm()
        {
            InitializeComponent();
            graphicTool = new GraphicTool();
            mouseDown = new Point2D();
            mouseUp = new Point2D();
            mouseMove = new Point2D();
            isDrawing = false;
            isDragging = false;
            consoleText = string.Empty;
            this.KeyPreview = true;
        }

        private void pictureBoxPaint_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDown = new Point2D(e.Location);
            if (!isDrawing)
            {
                isDrawing = true;

                panelOriginPicker.Visible = false;
                panelEndingPicker.Visible = false;

                panelOriginPicker.Location = new Point(mouseDown.X + pictureBoxPaint.Left, mouseDown.Y + pictureBoxPaint.Top);
                
                currentShape = CreateNewShape();
            }
        }
        private void pictureBoxPaint_MouseMove(object sender, MouseEventArgs e)
        {
            this.mouseMove = new Point2D(e.Location);
            if (isDrawing && currentShape != null)
            {
                currentShape.Initialize(mouseDown, mouseMove);
                pictureBoxPaint.Invalidate();
            }
        }
        private void pictureBoxPaint_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseUp = new Point2D(e.Location);
            if (isDrawing && currentShape != null)
            {
                isDrawing = false;

                currentShape.Initialize(mouseDown, mouseUp);

                panelEndingPicker.Location = new Point(mouseUp.X + pictureBoxPaint.Left, mouseUp.Y + pictureBoxPaint.Top);

                panelOriginPicker.Visible = true;
                if (!(currentShape is Square))
                {
                    panelEndingPicker.Visible = true;
                }

                graphicTool.Add(currentShape);
                pictureBoxPaint.Invalidate();
            }
        }
        private void pictureBoxPaint_Paint(object sender, PaintEventArgs e)
        {
            graphicTool.DrawAll(e.Graphics);
            tbShapesKeys.Text = graphicTool.ToString();

            if ((isDrawing || isDragging) && currentShape != null)
            {
                currentShape.Draw(e.Graphics);
            }
        }
        private Shape CreateNewShape()
        {
            if (rbCircle.Checked) return new Circle();

            if (rbLine.Checked) return new Line();

            if (rbRectangle.Checked) return new Bussiness.Rectangle();

            if (rbSquare.Checked)
            {
                this.squareLength = 100;
                return new Square();
            }

            return null;
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            tbConsole.Text += Environment.NewLine + "Window resized";
        }
        
        private void panelOriginPicker_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isDragging && panelOriginPicker.Visible)
            {
                isDragging = true;
            }
        }

        private void panelOriginPicker_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point mouseLocation = pictureBoxPaint.PointToClient(MousePosition); 
                int newX = mouseLocation.X - panelOriginPicker.Width / 2;
                int newY =  mouseLocation.Y - panelOriginPicker.Height / 2;

                newX = Math.Max(0, Math.Min(newX, pictureBoxPaint.Width - panelOriginPicker.Width));
                newY = Math.Max(0, Math.Min(newY, pictureBoxPaint.Height - panelOriginPicker.Height));

                panelOriginPicker.Location = new Point(pictureBoxPaint.Left + newX, pictureBoxPaint.Top + newY);
                if (currentShape is Square)
                {
                    Square square = currentShape as Square;
                    square.length = squareLength;
                    square.Initialize(new Point2D(mouseLocation), new Point2D(panelEndingPicker.Location.X - pictureBoxPaint.Left, panelEndingPicker.Location.Y - pictureBoxPaint.Top));
                }
                else
                {
                    currentShape.Initialize(new Point2D(newX, newY), new Point2D(panelEndingPicker.Location.X - pictureBoxPaint.Left, panelEndingPicker.Location.Y - pictureBoxPaint.Top));
                }
                pictureBoxPaint.Invalidate();
            }
        }

        private void panelOriginPicker_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging && currentShape != null)
            {
                isDragging = false;

                Point mouseLocation = pictureBoxPaint.PointToClient(MousePosition); 
                if(currentShape is Square)
                {
                    Square square = currentShape as Square;
                    square.length = squareLength;
                    square.Initialize(new Point2D(mouseLocation), new Point2D(panelEndingPicker.Location.X - pictureBoxPaint.Left, panelEndingPicker.Location.Y - pictureBoxPaint.Top));
                    this.graphicTool.SetLastShape(square);
                }
                else
                {
                    currentShape.Initialize(new Point2D(mouseLocation), new Point2D(panelEndingPicker.Location.X - pictureBoxPaint.Left, panelEndingPicker.Location.Y - pictureBoxPaint.Top));
                    this.graphicTool.SetLastShape(currentShape);
                }
                pictureBoxPaint.Invalidate();
            }
        }

        private void panelEndingPicker_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isDragging && panelEndingPicker.Visible)
            {
                isDragging = true;
            }
        }

        private void panelEndingPicker_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point mouseLocation = pictureBoxPaint.PointToClient(MousePosition);
                int newX = mouseLocation.X - panelOriginPicker.Width / 2;
                int newY = mouseLocation.Y - panelOriginPicker.Height / 2;

                newX = Math.Max(0, Math.Min(newX, pictureBoxPaint.Width - panelEndingPicker.Width));
                newY = Math.Max(0, Math.Min(newY, pictureBoxPaint.Height - panelEndingPicker.Height));

                panelEndingPicker.Location = new Point(pictureBoxPaint.Left + newX, pictureBoxPaint.Top + newY);

                currentShape.Initialize(new Point2D(panelOriginPicker.Location.X - pictureBoxPaint.Left, panelOriginPicker.Location.Y - pictureBoxPaint.Top), new Point2D(newX, newY));
                pictureBoxPaint.Invalidate();
            }
        }

        private void panelEndingPicker_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging && currentShape != null)
            {
                isDragging = false;

                Point mouseLocation = pictureBoxPaint.PointToClient(MousePosition);

                currentShape.Initialize(new Point2D(panelOriginPicker.Location.X - pictureBoxPaint.Left, panelOriginPicker.Location.Y - pictureBoxPaint.Top), new Point2D(mouseLocation.X, mouseLocation.Y));
                this.graphicTool.SetLastShape(currentShape);
                pictureBoxPaint.Invalidate();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (currentShape != null && currentShape is Square)
            {
                int unit = 10;
                if (e.Control && e.KeyCode == Keys.Oemplus)
                {
                    this.squareLength += unit;
                    panelOriginPicker.Location = new Point(panelOriginPicker.Location.X + unit/2, panelOriginPicker.Location.Y + unit/2);
                }
                else if (e.Control && e.KeyCode == Keys.OemMinus && squareLength > unit)
                {
                    this.squareLength -= unit;
                    panelOriginPicker.Location = new Point(panelOriginPicker.Location.X - unit/2, panelOriginPicker.Location.Y - unit/2);
                }
                else
                {
                    return;
                }
                Square square = currentShape as Square;
                square.length = this.squareLength;

                graphicTool.SetLastShape(square);
                pictureBoxPaint.Invalidate();
            }
        }
       
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.graphicTool.RemoveAll();
            this.pictureBoxPaint.Image = null;
            
            panelOriginPicker.Visible = false;
            panelEndingPicker.Visible = false;
            tbConsole.Text += Environment.NewLine + "New File";

            pictureBoxPaint.Invalidate();
        }

        private void openDrawingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Shape> shapes = FileManager.OpenDrawingFromJson();
            if (shapes != null)
            {
                foreach (var shape in shapes)
                {
                    this.graphicTool.Add(shape);
                }
                pictureBoxPaint.Invalidate();
            }
        }

        private void bitmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileManager.SaveDrawingAsBitmap(pictureBoxPaint))
            {
                tbConsole.Text += Environment.NewLine + "Successfully saved as BMP!";
            }
            else
            {
                tbConsole.Text += Environment.NewLine + "Failed to save as BMP!";
            }
        }

        private void drawingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileManager.SaveInJsonFormat(graphicTool.Shapes))
            {
                tbConsole.Text += Environment.NewLine + "Successfully saved as JSON!";
            }
            else
            {
                tbConsole.Text += Environment.NewLine + "Failed to save as JSON!";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (graphicTool.Shapes.Any())
            {
                graphicTool.Shapes.Remove(graphicTool.Shapes.Last());
                panelOriginPicker.Visible = false;
                panelEndingPicker.Visible = false;
                if (graphicTool.Shapes.Any())
                {
                    currentShape = graphicTool.Shapes.Last() as Shape;
                }
                pictureBoxPaint.Invalidate();
            }
        }

        private void clearConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consoleText = string.Empty;
            tbConsole.Text = consoleText;
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = FileManager.OpenImageFromFile();
            pictureBoxPaint.Image = img;
        }
    }
}
