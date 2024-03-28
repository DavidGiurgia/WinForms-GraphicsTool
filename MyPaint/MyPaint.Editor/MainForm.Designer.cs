namespace MyPaint.Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBoxPaint = new System.Windows.Forms.PictureBox();
            this.groupBoxShapes = new System.Windows.Forms.GroupBox();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.tbShapesKeys = new System.Windows.Forms.TextBox();
            this.panelOriginPicker = new System.Windows.Forms.Panel();
            this.panelEndingPicker = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDrawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaint)).BeginInit();
            this.groupBoxShapes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPaint
            // 
            this.pictureBoxPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPaint.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoxPaint.Location = new System.Drawing.Point(12, 41);
            this.pictureBoxPaint.Name = "pictureBoxPaint";
            this.pictureBoxPaint.Size = new System.Drawing.Size(1039, 600);
            this.pictureBoxPaint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPaint.TabIndex = 0;
            this.pictureBoxPaint.TabStop = false;
            this.pictureBoxPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPaint_Paint);
            this.pictureBoxPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseDown);
            this.pictureBoxPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseMove);
            this.pictureBoxPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseUp);
            // 
            // groupBoxShapes
            // 
            this.groupBoxShapes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxShapes.Controls.Add(this.rbSquare);
            this.groupBoxShapes.Controls.Add(this.rbRectangle);
            this.groupBoxShapes.Controls.Add(this.rbCircle);
            this.groupBoxShapes.Controls.Add(this.rbLine);
            this.groupBoxShapes.Location = new System.Drawing.Point(1059, 41);
            this.groupBoxShapes.Name = "groupBoxShapes";
            this.groupBoxShapes.Size = new System.Drawing.Size(290, 100);
            this.groupBoxShapes.TabIndex = 8;
            this.groupBoxShapes.TabStop = false;
            this.groupBoxShapes.Text = "Shapes";
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbSquare.Location = new System.Drawing.Point(149, 60);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(83, 24);
            this.rbSquare.TabIndex = 3;
            this.rbSquare.Text = "Square";
            this.rbSquare.UseVisualStyleBackColor = true;
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbRectangle.Location = new System.Drawing.Point(149, 30);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(105, 24);
            this.rbRectangle.TabIndex = 2;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbCircle.Location = new System.Drawing.Point(19, 60);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(74, 24);
            this.rbCircle.TabIndex = 1;
            this.rbCircle.Text = "Circle";
            this.rbCircle.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Checked = true;
            this.rbLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbLine.Location = new System.Drawing.Point(19, 30);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(62, 24);
            this.rbLine.TabIndex = 0;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // tbConsole
            // 
            this.tbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConsole.Location = new System.Drawing.Point(1059, 147);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.ReadOnly = true;
            this.tbConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConsole.Size = new System.Drawing.Size(290, 256);
            this.tbConsole.TabIndex = 11;
            // 
            // tbShapesKeys
            // 
            this.tbShapesKeys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShapesKeys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbShapesKeys.Location = new System.Drawing.Point(1059, 409);
            this.tbShapesKeys.Multiline = true;
            this.tbShapesKeys.Name = "tbShapesKeys";
            this.tbShapesKeys.ReadOnly = true;
            this.tbShapesKeys.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbShapesKeys.Size = new System.Drawing.Size(290, 232);
            this.tbShapesKeys.TabIndex = 12;
            // 
            // panelOriginPicker
            // 
            this.panelOriginPicker.BackColor = System.Drawing.Color.White;
            this.panelOriginPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOriginPicker.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.panelOriginPicker.Location = new System.Drawing.Point(88, 181);
            this.panelOriginPicker.Name = "panelOriginPicker";
            this.panelOriginPicker.Size = new System.Drawing.Size(10, 10);
            this.panelOriginPicker.TabIndex = 13;
            this.panelOriginPicker.Visible = false;
            this.panelOriginPicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelOriginPicker_MouseDown);
            this.panelOriginPicker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelOriginPicker_MouseMove);
            this.panelOriginPicker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelOriginPicker_MouseUp);
            // 
            // panelEndingPicker
            // 
            this.panelEndingPicker.BackColor = System.Drawing.Color.White;
            this.panelEndingPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEndingPicker.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.panelEndingPicker.Location = new System.Drawing.Point(152, 172);
            this.panelEndingPicker.Name = "panelEndingPicker";
            this.panelEndingPicker.Size = new System.Drawing.Size(10, 10);
            this.panelEndingPicker.TabIndex = 14;
            this.panelEndingPicker.Visible = false;
            this.panelEndingPicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelEndingPicker_MouseDown);
            this.panelEndingPicker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelEndingPicker_MouseMove);
            this.panelEndingPicker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelEndingPicker_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1363, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDrawingToolStripMenuItem,
            this.openImageToolStripMenuItem});
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(221, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitmapToolStripMenuItem,
            this.drawingToolStripMenuItem});
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem1,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem1
            // 
            this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            this.undoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.undoToolStripMenuItem1.Text = "&Undo";
            this.undoToolStripMenuItem1.Click += new System.EventHandler(this.undoToolStripMenuItem1_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(221, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.clearConsoleToolStripMenuItem});
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem1.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(221, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // openDrawingToolStripMenuItem
            // 
            this.openDrawingToolStripMenuItem.Name = "openDrawingToolStripMenuItem";
            this.openDrawingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openDrawingToolStripMenuItem.Text = "Open Drawing";
            this.openDrawingToolStripMenuItem.Click += new System.EventHandler(this.openDrawingToolStripMenuItem_Click);
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // bitmapToolStripMenuItem
            // 
            this.bitmapToolStripMenuItem.Name = "bitmapToolStripMenuItem";
            this.bitmapToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bitmapToolStripMenuItem.Text = "Bitmap";
            this.bitmapToolStripMenuItem.Click += new System.EventHandler(this.bitmapToolStripMenuItem_Click);
            // 
            // drawingToolStripMenuItem
            // 
            this.drawingToolStripMenuItem.Name = "drawingToolStripMenuItem";
            this.drawingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.drawingToolStripMenuItem.Text = "Drawing";
            this.drawingToolStripMenuItem.Click += new System.EventHandler(this.drawingToolStripMenuItem_Click);
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // clearConsoleToolStripMenuItem
            // 
            this.clearConsoleToolStripMenuItem.Name = "clearConsoleToolStripMenuItem";
            this.clearConsoleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clearConsoleToolStripMenuItem.Text = "Clear Console";
            this.clearConsoleToolStripMenuItem.Click += new System.EventHandler(this.clearConsoleToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 653);
            this.Controls.Add(this.panelEndingPicker);
            this.Controls.Add(this.tbShapesKeys);
            this.Controls.Add(this.tbConsole);
            this.Controls.Add(this.panelOriginPicker);
            this.Controls.Add(this.groupBoxShapes);
            this.Controls.Add(this.pictureBoxPaint);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Paint";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaint)).EndInit();
            this.groupBoxShapes.ResumeLayout(false);
            this.groupBoxShapes.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPaint;
        private System.Windows.Forms.GroupBox groupBoxShapes;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.TextBox tbConsole;
        private System.Windows.Forms.TextBox tbShapesKeys;
        private System.Windows.Forms.Panel panelEndingPicker;
        private System.Windows.Forms.Panel panelOriginPicker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDrawingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearConsoleToolStripMenuItem;
    }
}

