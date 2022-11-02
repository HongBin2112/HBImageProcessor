namespace projectJX_cs
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImagesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.othersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxOperation = new System.Windows.Forms.GroupBox();
            this.panelOperationBtns = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnConverted = new System.Windows.Forms.Button();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.groupBoxGamma = new System.Windows.Forms.GroupBox();
            this.trackBarGamma = new System.Windows.Forms.TrackBar();
            this.groupBoxContrast = new System.Windows.Forms.GroupBox();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.checkedListBoxOperation = new System.Windows.Forms.CheckedListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageBox_input = new Emgu.CV.UI.ImageBox();
            this.pazPictureBox_converted = new Emgu.CV.UI.PanAndZoomPictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelInfos = new System.Windows.Forms.Panel();
            this.labelOutputFolder = new System.Windows.Forms.Label();
            this.labelOutputSize = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelEnlarge = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelLeftTop = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxOperation.SuspendLayout();
            this.panelOperationBtns.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.groupBoxGamma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).BeginInit();
            this.groupBoxContrast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pazPictureBox_converted)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelInfos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.othersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1344, 27);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImagesToolStripMenuItem1,
            this.loadFromFolderToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Lavender;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadImagesToolStripMenuItem1
            // 
            this.loadImagesToolStripMenuItem1.Name = "loadImagesToolStripMenuItem1";
            this.loadImagesToolStripMenuItem1.Size = new System.Drawing.Size(187, 24);
            this.loadImagesToolStripMenuItem1.Text = "Load Images";
            this.loadImagesToolStripMenuItem1.Click += new System.EventHandler(this.loadImagesToolStripMenuItem1_Click);
            // 
            // loadFromFolderToolStripMenuItem
            // 
            this.loadFromFolderToolStripMenuItem.Name = "loadFromFolderToolStripMenuItem";
            this.loadFromFolderToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.loadFromFolderToolStripMenuItem.Text = "Load from Folder";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputFolderToolStripMenuItem});
            this.settingToolStripMenuItem.ForeColor = System.Drawing.Color.Lavender;
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // outputFolderToolStripMenuItem
            // 
            this.outputFolderToolStripMenuItem.Name = "outputFolderToolStripMenuItem";
            this.outputFolderToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.outputFolderToolStripMenuItem.Text = "Output Folder";
            this.outputFolderToolStripMenuItem.Click += new System.EventHandler(this.outputFolderToolStripMenuItem_Click);
            // 
            // othersToolStripMenuItem
            // 
            this.othersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugToolStripMenuItem});
            this.othersToolStripMenuItem.ForeColor = System.Drawing.Color.Lavender;
            this.othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            this.othersToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.othersToolStripMenuItem.Text = "Others";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // groupBoxOperation
            // 
            this.groupBoxOperation.AutoSize = true;
            this.groupBoxOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.groupBoxOperation.Controls.Add(this.panelOperationBtns);
            this.groupBoxOperation.Controls.Add(this.panelOptions);
            this.groupBoxOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxOperation.Enabled = false;
            this.groupBoxOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxOperation.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBoxOperation.Location = new System.Drawing.Point(0, 240);
            this.groupBoxOperation.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxOperation.Name = "groupBoxOperation";
            this.groupBoxOperation.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxOperation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxOperation.Size = new System.Drawing.Size(280, 423);
            this.groupBoxOperation.TabIndex = 6;
            this.groupBoxOperation.TabStop = false;
            this.groupBoxOperation.Text = "Operation";
            // 
            // panelOperationBtns
            // 
            this.panelOperationBtns.AutoScroll = true;
            this.panelOperationBtns.AutoSize = true;
            this.panelOperationBtns.Controls.Add(this.btnSave);
            this.panelOperationBtns.Controls.Add(this.btnNext);
            this.panelOperationBtns.Controls.Add(this.btnConverted);
            this.panelOperationBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOperationBtns.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelOperationBtns.Location = new System.Drawing.Point(0, 279);
            this.panelOperationBtns.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelOperationBtns.Name = "panelOperationBtns";
            this.panelOperationBtns.Size = new System.Drawing.Size(280, 144);
            this.panelOperationBtns.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Image = global::HBImageProcessor.Properties.Resources.download;
            this.btnSave.Location = new System.Drawing.Point(0, 96);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 48);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNext.Image = global::HBImageProcessor.Properties.Resources.next;
            this.btnNext.Location = new System.Drawing.Point(0, 48);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(280, 48);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnConverted
            // 
            this.btnConverted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnConverted.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConverted.FlatAppearance.BorderSize = 0;
            this.btnConverted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverted.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConverted.Image = global::HBImageProcessor.Properties.Resources.check;
            this.btnConverted.Location = new System.Drawing.Point(0, 0);
            this.btnConverted.Margin = new System.Windows.Forms.Padding(0);
            this.btnConverted.Name = "btnConverted";
            this.btnConverted.Size = new System.Drawing.Size(280, 48);
            this.btnConverted.TabIndex = 2;
            this.btnConverted.Text = "Convert";
            this.btnConverted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConverted.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConverted.UseVisualStyleBackColor = false;
            this.btnConverted.Click += new System.EventHandler(this.btnConverted_Click);
            // 
            // panelOptions
            // 
            this.panelOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelOptions.Controls.Add(this.groupBoxGamma);
            this.panelOptions.Controls.Add(this.groupBoxContrast);
            this.panelOptions.Controls.Add(this.checkedListBoxOperation);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOptions.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelOptions.Location = new System.Drawing.Point(0, 19);
            this.panelOptions.Margin = new System.Windows.Forms.Padding(0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(280, 260);
            this.panelOptions.TabIndex = 11;
            // 
            // groupBoxGamma
            // 
            this.groupBoxGamma.Controls.Add(this.trackBarGamma);
            this.groupBoxGamma.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxGamma.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxGamma.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBoxGamma.Location = new System.Drawing.Point(0, 172);
            this.groupBoxGamma.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxGamma.Name = "groupBoxGamma";
            this.groupBoxGamma.Size = new System.Drawing.Size(280, 80);
            this.groupBoxGamma.TabIndex = 6;
            this.groupBoxGamma.TabStop = false;
            this.groupBoxGamma.Text = "Gamma(x100): 100";
            // 
            // trackBarGamma
            // 
            this.trackBarGamma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarGamma.Location = new System.Drawing.Point(3, 24);
            this.trackBarGamma.Maximum = 100;
            this.trackBarGamma.Minimum = 1;
            this.trackBarGamma.Name = "trackBarGamma";
            this.trackBarGamma.Size = new System.Drawing.Size(274, 45);
            this.trackBarGamma.TabIndex = 4;
            this.trackBarGamma.TickFrequency = 10;
            this.trackBarGamma.Value = 100;
            this.trackBarGamma.Scroll += new System.EventHandler(this.trackBarGamma_Scroll);
            // 
            // groupBoxContrast
            // 
            this.groupBoxContrast.Controls.Add(this.trackBarContrast);
            this.groupBoxContrast.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxContrast.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxContrast.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBoxContrast.Location = new System.Drawing.Point(0, 92);
            this.groupBoxContrast.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxContrast.Name = "groupBoxContrast";
            this.groupBoxContrast.Size = new System.Drawing.Size(280, 80);
            this.groupBoxContrast.TabIndex = 7;
            this.groupBoxContrast.TabStop = false;
            this.groupBoxContrast.Text = "Contrast(x100): 0";
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarContrast.Location = new System.Drawing.Point(3, 24);
            this.trackBarContrast.Maximum = 200;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(274, 45);
            this.trackBarContrast.TabIndex = 5;
            this.trackBarContrast.TickFrequency = 20;
            this.trackBarContrast.Value = 100;
            this.trackBarContrast.Scroll += new System.EventHandler(this.trackBarContrast_Scroll);
            // 
            // checkedListBoxOperation
            // 
            this.checkedListBoxOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.checkedListBoxOperation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxOperation.CheckOnClick = true;
            this.checkedListBoxOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBoxOperation.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBoxOperation.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkedListBoxOperation.FormattingEnabled = true;
            this.checkedListBoxOperation.Items.AddRange(new object[] {
            "To gray",
            "Invert color",
            "Crop",
            "Flip"});
            this.checkedListBoxOperation.Location = new System.Drawing.Point(0, 0);
            this.checkedListBoxOperation.Margin = new System.Windows.Forms.Padding(0);
            this.checkedListBoxOperation.Name = "checkedListBoxOperation";
            this.checkedListBoxOperation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBoxOperation.Size = new System.Drawing.Size(280, 92);
            this.checkedListBoxOperation.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(280, 70);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.imageBox_input);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.pazPictureBox_converted);
            this.splitContainer1.Size = new System.Drawing.Size(1064, 741);
            this.splitContainer1.SplitterDistance = 563;
            this.splitContainer1.TabIndex = 7;
            // 
            // imageBox_input
            // 
            this.imageBox_input.BackColor = System.Drawing.Color.LightGray;
            this.imageBox_input.BackgroundImage = global::HBImageProcessor.Properties.Resources.image;
            this.imageBox_input.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageBox_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox_input.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox_input.InitialImage = null;
            this.imageBox_input.Location = new System.Drawing.Point(0, 0);
            this.imageBox_input.Margin = new System.Windows.Forms.Padding(0);
            this.imageBox_input.Name = "imageBox_input";
            this.imageBox_input.Size = new System.Drawing.Size(559, 737);
            this.imageBox_input.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox_input.TabIndex = 5;
            this.imageBox_input.TabStop = false;
            this.imageBox_input.DragDrop += new System.Windows.Forms.DragEventHandler(this.imageBox_input_DragDrop);
            this.imageBox_input.DragEnter += new System.Windows.Forms.DragEventHandler(this.imageBox_input_DragEnter);
            this.imageBox_input.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBox_input_Paint);
            this.imageBox_input.DoubleClick += new System.EventHandler(this.loadImagesToolStripMenuItem1_Click);
            this.imageBox_input.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBox_input_MouseDown);
            this.imageBox_input.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox_input_MouseMove);
            this.imageBox_input.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBox_input_MouseUp);
            // 
            // pazPictureBox_converted
            // 
            this.pazPictureBox_converted.BackgroundImage = global::HBImageProcessor.Properties.Resources.edit_image;
            this.pazPictureBox_converted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pazPictureBox_converted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pazPictureBox_converted.Location = new System.Drawing.Point(0, 0);
            this.pazPictureBox_converted.Name = "pazPictureBox_converted";
            this.pazPictureBox_converted.Size = new System.Drawing.Size(493, 737);
            this.pazPictureBox_converted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pazPictureBox_converted.TabIndex = 0;
            this.pazPictureBox_converted.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelLeft.Controls.Add(this.btnExit);
            this.panelLeft.Controls.Add(this.groupBoxOperation);
            this.panelLeft.Controls.Add(this.panelInfos);
            this.panelLeft.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelLeft.Location = new System.Drawing.Point(0, 70);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(280, 741);
            this.panelLeft.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Image = global::HBImageProcessor.Properties.Resources.power_off;
            this.btnExit.Location = new System.Drawing.Point(0, 681);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(280, 60);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelInfos
            // 
            this.panelInfos.AutoSize = true;
            this.panelInfos.BackColor = System.Drawing.Color.White;
            this.panelInfos.Controls.Add(this.labelOutputFolder);
            this.panelInfos.Controls.Add(this.labelOutputSize);
            this.panelInfos.Controls.Add(this.labelSize);
            this.panelInfos.Controls.Add(this.labelName);
            this.panelInfos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfos.Location = new System.Drawing.Point(0, 0);
            this.panelInfos.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelInfos.Name = "panelInfos";
            this.panelInfos.Size = new System.Drawing.Size(280, 240);
            this.panelInfos.TabIndex = 6;
            // 
            // labelOutputFolder
            // 
            this.labelOutputFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.labelOutputFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelOutputFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOutputFolder.Image = global::HBImageProcessor.Properties.Resources.add_folder;
            this.labelOutputFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelOutputFolder.Location = new System.Drawing.Point(0, 180);
            this.labelOutputFolder.Margin = new System.Windows.Forms.Padding(0);
            this.labelOutputFolder.Name = "labelOutputFolder";
            this.labelOutputFolder.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.labelOutputFolder.Size = new System.Drawing.Size(280, 60);
            this.labelOutputFolder.TabIndex = 2;
            this.labelOutputFolder.Text = "Set Output Folder";
            this.labelOutputFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOutputFolder.Click += new System.EventHandler(this.outputFolderToolStripMenuItem_Click);
            this.labelOutputFolder.MouseEnter += new System.EventHandler(this.ChangeBackgroundColor_MouseEnter);
            this.labelOutputFolder.MouseLeave += new System.EventHandler(this.ChangeBackgroundColor_MouseLeave);
            // 
            // labelOutputSize
            // 
            this.labelOutputSize.AutoEllipsis = true;
            this.labelOutputSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.labelOutputSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOutputSize.Image = global::HBImageProcessor.Properties.Resources.size;
            this.labelOutputSize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelOutputSize.Location = new System.Drawing.Point(0, 120);
            this.labelOutputSize.Name = "labelOutputSize";
            this.labelOutputSize.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.labelOutputSize.Size = new System.Drawing.Size(280, 60);
            this.labelOutputSize.TabIndex = 3;
            this.labelOutputSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOutputSize.MouseEnter += new System.EventHandler(this.ChangeBackgroundColor_MouseEnter);
            this.labelOutputSize.MouseLeave += new System.EventHandler(this.ChangeBackgroundColor_MouseLeave);
            // 
            // labelSize
            // 
            this.labelSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.labelSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSize.Image = global::HBImageProcessor.Properties.Resources.size;
            this.labelSize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSize.Location = new System.Drawing.Point(0, 60);
            this.labelSize.Margin = new System.Windows.Forms.Padding(0);
            this.labelSize.Name = "labelSize";
            this.labelSize.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.labelSize.Size = new System.Drawing.Size(280, 60);
            this.labelSize.TabIndex = 1;
            this.labelSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSize.MouseEnter += new System.EventHandler(this.ChangeBackgroundColor_MouseEnter);
            this.labelSize.MouseLeave += new System.EventHandler(this.ChangeBackgroundColor_MouseLeave);
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.labelName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelName.Image = global::HBImageProcessor.Properties.Resources.picture;
            this.labelName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Margin = new System.Windows.Forms.Padding(0);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.labelName.Size = new System.Drawing.Size(280, 60);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Load Images";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName.Click += new System.EventHandler(this.loadImagesToolStripMenuItem1_Click);
            this.labelName.MouseEnter += new System.EventHandler(this.ChangeBackgroundColor_MouseEnter);
            this.labelName.MouseLeave += new System.EventHandler(this.ChangeBackgroundColor_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelMin);
            this.panel1.Controls.Add(this.labelEnlarge);
            this.panel1.Controls.Add(this.labelClose);
            this.panel1.Controls.Add(this.labelLeftTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 70);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // labelMin
            // 
            this.labelMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMin.Image = global::HBImageProcessor.Properties.Resources.minimize_sign;
            this.labelMin.Location = new System.Drawing.Point(1217, 24);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 24);
            this.labelMin.TabIndex = 15;
            this.labelMin.Click += new System.EventHandler(this.labelMin_Click);
            // 
            // labelEnlarge
            // 
            this.labelEnlarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEnlarge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEnlarge.Image = global::HBImageProcessor.Properties.Resources.enlarge;
            this.labelEnlarge.Location = new System.Drawing.Point(1255, 19);
            this.labelEnlarge.Name = "labelEnlarge";
            this.labelEnlarge.Size = new System.Drawing.Size(32, 32);
            this.labelEnlarge.TabIndex = 14;
            this.labelEnlarge.Click += new System.EventHandler(this.labelEnlarge_Click);
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Image = global::HBImageProcessor.Properties.Resources.close;
            this.labelClose.Location = new System.Drawing.Point(1299, 23);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(24, 24);
            this.labelClose.TabIndex = 13;
            this.labelClose.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelLeftTop
            // 
            this.labelLeftTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.labelLeftTop.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelLeftTop.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLeftTop.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelLeftTop.Location = new System.Drawing.Point(0, 0);
            this.labelLeftTop.Name = "labelLeftTop";
            this.labelLeftTop.Size = new System.Drawing.Size(280, 70);
            this.labelLeftTop.TabIndex = 12;
            this.labelLeftTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1344, 811);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HB Image Processing";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxOperation.ResumeLayout(false);
            this.groupBoxOperation.PerformLayout();
            this.panelOperationBtns.ResumeLayout(false);
            this.panelOptions.ResumeLayout(false);
            this.groupBoxGamma.ResumeLayout(false);
            this.groupBoxGamma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).EndInit();
            this.groupBoxContrast.ResumeLayout(false);
            this.groupBoxContrast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pazPictureBox_converted)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelInfos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImagesToolStripMenuItem1;
        private Emgu.CV.UI.ImageBox imageBox_input;
        private System.Windows.Forms.GroupBox groupBoxOperation;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Emgu.CV.UI.PanAndZoomPictureBox pazPictureBox_converted;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.CheckedListBox checkedListBoxOperation;
        private System.Windows.Forms.Button btnConverted;
        private System.Windows.Forms.GroupBox groupBoxContrast;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.GroupBox groupBoxGamma;
        private System.Windows.Forms.TrackBar trackBarGamma;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelOutputFolder;
        private System.Windows.Forms.Label labelOutputSize;
        private System.Windows.Forms.ToolStripMenuItem othersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelOperationBtns;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Panel panelInfos;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private Label labelLeftTop;
        private Label labelMin;
        private Label labelEnlarge;
        private Label labelClose;
        private Label label1;
    }
}

