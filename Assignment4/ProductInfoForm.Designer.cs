namespace Assignment4
{
    partial class ProductInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.productInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.osTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.platformTextBox = new System.Windows.Forms.TextBox();
            this.platformLabel = new System.Windows.Forms.Label();
            this.techSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.webCamTextBox = new System.Windows.Forms.TextBox();
            this.webCamLabel = new System.Windows.Forms.Label();
            this.cpuSpeedTextBox = new System.Windows.Forms.TextBox();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.cpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.gpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.cpuNumberTextBox = new System.Windows.Forms.TextBox();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.cpuBrandTextBox = new System.Windows.Forms.TextBox();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.hddTextBox = new System.Windows.Forms.TextBox();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.lcdSizeTextBox = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.memoryTextBox = new System.Windows.Forms.TextBox();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.anotherProductButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.productInfoGroupBox.SuspendLayout();
            this.techSpecsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this._readFile);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this._saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.sToolStripMenuItem.Text = "Se&lect Another Product";
            // 
            // productIDLabel
            // 
            this.productIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDLabel.Location = new System.Drawing.Point(12, 41);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(98, 23);
            this.productIDLabel.TabIndex = 1;
            this.productIDLabel.Text = "Product ID";
            this.productIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // conditionLabel
            // 
            this.conditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionLabel.Location = new System.Drawing.Point(253, 41);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(79, 23);
            this.conditionLabel.TabIndex = 2;
            this.conditionLabel.Text = "Condition";
            this.conditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // costLabel
            // 
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(470, 41);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(42, 23);
            this.costLabel.TabIndex = 3;
            this.costLabel.Text = "Cost";
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Location = new System.Drawing.Point(117, 41);
            this.productIDTextBox.Multiline = true;
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(100, 23);
            this.productIDTextBox.TabIndex = 4;
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Location = new System.Drawing.Point(338, 41);
            this.conditionTextBox.Multiline = true;
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.ReadOnly = true;
            this.conditionTextBox.Size = new System.Drawing.Size(100, 23);
            this.conditionTextBox.TabIndex = 5;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(518, 38);
            this.costTextBox.Multiline = true;
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.Size = new System.Drawing.Size(100, 23);
            this.costTextBox.TabIndex = 6;
            // 
            // productInfoGroupBox
            // 
            this.productInfoGroupBox.Controls.Add(this.modelTextBox);
            this.productInfoGroupBox.Controls.Add(this.manufacturerTextBox);
            this.productInfoGroupBox.Controls.Add(this.osTextBox);
            this.productInfoGroupBox.Controls.Add(this.modelLabel);
            this.productInfoGroupBox.Controls.Add(this.manufacturerLabel);
            this.productInfoGroupBox.Controls.Add(this.OSLabel);
            this.productInfoGroupBox.Controls.Add(this.platformTextBox);
            this.productInfoGroupBox.Controls.Add(this.platformLabel);
            this.productInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInfoGroupBox.Location = new System.Drawing.Point(12, 82);
            this.productInfoGroupBox.Name = "productInfoGroupBox";
            this.productInfoGroupBox.Size = new System.Drawing.Size(666, 100);
            this.productInfoGroupBox.TabIndex = 7;
            this.productInfoGroupBox.TabStop = false;
            this.productInfoGroupBox.Text = "Prduct Info";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(326, 60);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(322, 22);
            this.modelTextBox.TabIndex = 7;
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Location = new System.Drawing.Point(105, 60);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.ReadOnly = true;
            this.manufacturerTextBox.Size = new System.Drawing.Size(100, 22);
            this.manufacturerTextBox.TabIndex = 6;
            // 
            // osTextBox
            // 
            this.osTextBox.Location = new System.Drawing.Point(326, 17);
            this.osTextBox.Name = "osTextBox";
            this.osTextBox.ReadOnly = true;
            this.osTextBox.Size = new System.Drawing.Size(322, 22);
            this.osTextBox.TabIndex = 5;
            // 
            // modelLabel
            // 
            this.modelLabel.Location = new System.Drawing.Point(268, 66);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(52, 16);
            this.modelLabel.TabIndex = 4;
            this.modelLabel.Text = "Model";
            this.modelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.Location = new System.Drawing.Point(6, 66);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(92, 16);
            this.manufacturerLabel.TabIndex = 3;
            this.manufacturerLabel.Text = "Manufacturer";
            this.manufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OSLabel
            // 
            this.OSLabel.Location = new System.Drawing.Point(275, 22);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(45, 16);
            this.OSLabel.TabIndex = 2;
            this.OSLabel.Text = "OS";
            this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // platformTextBox
            // 
            this.platformTextBox.Location = new System.Drawing.Point(105, 17);
            this.platformTextBox.Name = "platformTextBox";
            this.platformTextBox.ReadOnly = true;
            this.platformTextBox.Size = new System.Drawing.Size(100, 22);
            this.platformTextBox.TabIndex = 1;
            // 
            // platformLabel
            // 
            this.platformLabel.Location = new System.Drawing.Point(6, 22);
            this.platformLabel.Name = "platformLabel";
            this.platformLabel.Size = new System.Drawing.Size(92, 17);
            this.platformLabel.TabIndex = 0;
            this.platformLabel.Text = "Platform";
            this.platformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // techSpecsGroupBox
            // 
            this.techSpecsGroupBox.Controls.Add(this.webCamTextBox);
            this.techSpecsGroupBox.Controls.Add(this.webCamLabel);
            this.techSpecsGroupBox.Controls.Add(this.cpuSpeedTextBox);
            this.techSpecsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.techSpecsGroupBox.Controls.Add(this.cpuTypeTextBox);
            this.techSpecsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.techSpecsGroupBox.Controls.Add(this.gpuTypeTextBox);
            this.techSpecsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.techSpecsGroupBox.Controls.Add(this.cpuNumberTextBox);
            this.techSpecsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.techSpecsGroupBox.Controls.Add(this.cpuBrandTextBox);
            this.techSpecsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.techSpecsGroupBox.Controls.Add(this.hddTextBox);
            this.techSpecsGroupBox.Controls.Add(this.HDDLabel);
            this.techSpecsGroupBox.Controls.Add(this.lcdSizeTextBox);
            this.techSpecsGroupBox.Controls.Add(this.sizeLabel);
            this.techSpecsGroupBox.Controls.Add(this.memoryTextBox);
            this.techSpecsGroupBox.Controls.Add(this.memoryLabel);
            this.techSpecsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techSpecsGroupBox.Location = new System.Drawing.Point(12, 201);
            this.techSpecsGroupBox.Name = "techSpecsGroupBox";
            this.techSpecsGroupBox.Size = new System.Drawing.Size(666, 123);
            this.techSpecsGroupBox.TabIndex = 8;
            this.techSpecsGroupBox.TabStop = false;
            this.techSpecsGroupBox.Text = "Tech Specs";
            // 
            // webCamTextBox
            // 
            this.webCamTextBox.Location = new System.Drawing.Point(506, 82);
            this.webCamTextBox.Multiline = true;
            this.webCamTextBox.Name = "webCamTextBox";
            this.webCamTextBox.ReadOnly = true;
            this.webCamTextBox.Size = new System.Drawing.Size(143, 23);
            this.webCamTextBox.TabIndex = 23;
            // 
            // webCamLabel
            // 
            this.webCamLabel.Location = new System.Drawing.Point(435, 86);
            this.webCamLabel.Name = "webCamLabel";
            this.webCamLabel.Size = new System.Drawing.Size(69, 17);
            this.webCamLabel.TabIndex = 20;
            this.webCamLabel.Text = "WebCam";
            this.webCamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuSpeedTextBox
            // 
            this.cpuSpeedTextBox.Location = new System.Drawing.Point(326, 85);
            this.cpuSpeedTextBox.Multiline = true;
            this.cpuSpeedTextBox.Name = "cpuSpeedTextBox";
            this.cpuSpeedTextBox.ReadOnly = true;
            this.cpuSpeedTextBox.Size = new System.Drawing.Size(100, 23);
            this.cpuSpeedTextBox.TabIndex = 22;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.Location = new System.Drawing.Point(234, 86);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(87, 17);
            this.CPUSpeedLabel.TabIndex = 19;
            this.CPUSpeedLabel.Text = "CPU Speed";
            this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuTypeTextBox
            // 
            this.cpuTypeTextBox.Location = new System.Drawing.Point(105, 85);
            this.cpuTypeTextBox.Multiline = true;
            this.cpuTypeTextBox.Name = "cpuTypeTextBox";
            this.cpuTypeTextBox.ReadOnly = true;
            this.cpuTypeTextBox.Size = new System.Drawing.Size(100, 23);
            this.cpuTypeTextBox.TabIndex = 21;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.Location = new System.Drawing.Point(10, 86);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(89, 17);
            this.CPUTypeLabel.TabIndex = 18;
            this.CPUTypeLabel.Text = "CPU Type";
            this.CPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpuTypeTextBox
            // 
            this.gpuTypeTextBox.Location = new System.Drawing.Point(506, 53);
            this.gpuTypeTextBox.Multiline = true;
            this.gpuTypeTextBox.Name = "gpuTypeTextBox";
            this.gpuTypeTextBox.ReadOnly = true;
            this.gpuTypeTextBox.Size = new System.Drawing.Size(143, 23);
            this.gpuTypeTextBox.TabIndex = 17;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.Location = new System.Drawing.Point(432, 57);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(72, 17);
            this.GPUTypeLabel.TabIndex = 14;
            this.GPUTypeLabel.Text = "GPU Type";
            this.GPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuNumberTextBox
            // 
            this.cpuNumberTextBox.Location = new System.Drawing.Point(326, 56);
            this.cpuNumberTextBox.Multiline = true;
            this.cpuNumberTextBox.Name = "cpuNumberTextBox";
            this.cpuNumberTextBox.ReadOnly = true;
            this.cpuNumberTextBox.Size = new System.Drawing.Size(100, 23);
            this.cpuNumberTextBox.TabIndex = 16;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.Location = new System.Drawing.Point(231, 57);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(90, 17);
            this.CPUNumberLabel.TabIndex = 13;
            this.CPUNumberLabel.Text = "CPU Number";
            this.CPUNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuBrandTextBox
            // 
            this.cpuBrandTextBox.Location = new System.Drawing.Point(105, 54);
            this.cpuBrandTextBox.Multiline = true;
            this.cpuBrandTextBox.Name = "cpuBrandTextBox";
            this.cpuBrandTextBox.ReadOnly = true;
            this.cpuBrandTextBox.Size = new System.Drawing.Size(100, 23);
            this.cpuBrandTextBox.TabIndex = 15;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.Location = new System.Drawing.Point(10, 57);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(89, 17);
            this.CPUBrandLabel.TabIndex = 12;
            this.CPUBrandLabel.Text = "CPU Brand";
            this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hddTextBox
            // 
            this.hddTextBox.Location = new System.Drawing.Point(505, 18);
            this.hddTextBox.Multiline = true;
            this.hddTextBox.Name = "hddTextBox";
            this.hddTextBox.ReadOnly = true;
            this.hddTextBox.Size = new System.Drawing.Size(143, 23);
            this.hddTextBox.TabIndex = 11;
            // 
            // HDDLabel
            // 
            this.HDDLabel.Location = new System.Drawing.Point(458, 22);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(45, 17);
            this.HDDLabel.TabIndex = 2;
            this.HDDLabel.Text = "HDD";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lcdSizeTextBox
            // 
            this.lcdSizeTextBox.Location = new System.Drawing.Point(325, 21);
            this.lcdSizeTextBox.Multiline = true;
            this.lcdSizeTextBox.Name = "lcdSizeTextBox";
            this.lcdSizeTextBox.ReadOnly = true;
            this.lcdSizeTextBox.Size = new System.Drawing.Size(100, 23);
            this.lcdSizeTextBox.TabIndex = 10;
            // 
            // sizeLabel
            // 
            this.sizeLabel.Location = new System.Drawing.Point(244, 22);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(76, 17);
            this.sizeLabel.TabIndex = 1;
            this.sizeLabel.Text = "LCD Size";
            this.sizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // memoryTextBox
            // 
            this.memoryTextBox.Location = new System.Drawing.Point(104, 21);
            this.memoryTextBox.Multiline = true;
            this.memoryTextBox.Name = "memoryTextBox";
            this.memoryTextBox.ReadOnly = true;
            this.memoryTextBox.Size = new System.Drawing.Size(100, 23);
            this.memoryTextBox.TabIndex = 9;
            // 
            // memoryLabel
            // 
            this.memoryLabel.Location = new System.Drawing.Point(9, 22);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(89, 17);
            this.memoryLabel.TabIndex = 0;
            this.memoryLabel.Text = "Memory";
            this.memoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Click Next to Confirm Your Selection";
            // 
            // anotherProductButton
            // 
            this.anotherProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anotherProductButton.Location = new System.Drawing.Point(391, 346);
            this.anotherProductButton.Name = "anotherProductButton";
            this.anotherProductButton.Size = new System.Drawing.Size(152, 23);
            this.anotherProductButton.TabIndex = 10;
            this.anotherProductButton.Text = "Select Another Product";
            this.anotherProductButton.UseVisualStyleBackColor = true;
            this.anotherProductButton.Click += new System.EventHandler(this._anotherProductButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(559, 346);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(59, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(626, 346);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(51, 23);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this._nextButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.FileName = "Product";
            this.openFileDialog.Filter = "Text Files|*.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "Product";
            this.saveFileDialog.Filter = "Text Files|*.txt";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 381);
            this.ControlBox = false;
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.anotherProductButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.techSpecsGroupBox);
            this.Controls.Add(this.productInfoGroupBox);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.conditionTextBox);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.productIDLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Information Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.productInfoGroupBox.ResumeLayout(false);
            this.productInfoGroupBox.PerformLayout();
            this.techSpecsGroupBox.ResumeLayout(false);
            this.techSpecsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.GroupBox productInfoGroupBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.TextBox osTextBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.TextBox platformTextBox;
        private System.Windows.Forms.Label platformLabel;
        private System.Windows.Forms.GroupBox techSpecsGroupBox;
        private System.Windows.Forms.TextBox webCamTextBox;
        private System.Windows.Forms.Label webCamLabel;
        private System.Windows.Forms.TextBox cpuSpeedTextBox;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.TextBox cpuTypeTextBox;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.TextBox gpuTypeTextBox;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.TextBox cpuNumberTextBox;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.TextBox cpuBrandTextBox;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.TextBox hddTextBox;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.TextBox lcdSizeTextBox;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox memoryTextBox;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button anotherProductButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}