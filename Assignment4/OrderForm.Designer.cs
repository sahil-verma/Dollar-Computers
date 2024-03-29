﻿namespace Assignment4
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentsGroupBox = new System.Windows.Forms.GroupBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.platformTextBox = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.platformLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.featureGroupBox = new System.Windows.Forms.GroupBox();
            this.componentsListBox = new System.Windows.Forms.ListBox();
            this.osLabel = new System.Windows.Forms.Label();
            this.webCamLabel = new System.Windows.Forms.Label();
            this.gpuTypeLabel = new System.Windows.Forms.Label();
            this.hddLabel = new System.Windows.Forms.Label();
            this.cpuSpeedLabel = new System.Windows.Forms.Label();
            this.cpuNumberLabel = new System.Windows.Forms.Label();
            this.cpuTypeLabel = new System.Windows.Forms.Label();
            this.cpuBrandLabel = new System.Windows.Forms.Label();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.yourPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.componentsGroupBox.SuspendLayout();
            this.featureGroupBox.SuspendLayout();
            this.yourPriceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this._printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this._backButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this._aboutToolStripMenuItem_Click);
            // 
            // componentsGroupBox
            // 
            this.componentsGroupBox.Controls.Add(this.modelTextBox);
            this.componentsGroupBox.Controls.Add(this.manufacturerTextBox);
            this.componentsGroupBox.Controls.Add(this.platformTextBox);
            this.componentsGroupBox.Controls.Add(this.conditionTextBox);
            this.componentsGroupBox.Controls.Add(this.modelLabel);
            this.componentsGroupBox.Controls.Add(this.manufacturerLabel);
            this.componentsGroupBox.Controls.Add(this.platformLabel);
            this.componentsGroupBox.Controls.Add(this.conditionLabel);
            this.componentsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentsGroupBox.Location = new System.Drawing.Point(13, 38);
            this.componentsGroupBox.Name = "componentsGroupBox";
            this.componentsGroupBox.Size = new System.Drawing.Size(413, 100);
            this.componentsGroupBox.TabIndex = 1;
            this.componentsGroupBox.TabStop = false;
            this.componentsGroupBox.Text = "System Components";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTextBox.Location = new System.Drawing.Point(297, 74);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(100, 22);
            this.modelTextBox.TabIndex = 7;
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerTextBox.Location = new System.Drawing.Point(102, 74);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.ReadOnly = true;
            this.manufacturerTextBox.Size = new System.Drawing.Size(100, 22);
            this.manufacturerTextBox.TabIndex = 6;
            // 
            // platformTextBox
            // 
            this.platformTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformTextBox.Location = new System.Drawing.Point(297, 28);
            this.platformTextBox.Name = "platformTextBox";
            this.platformTextBox.ReadOnly = true;
            this.platformTextBox.Size = new System.Drawing.Size(100, 22);
            this.platformTextBox.TabIndex = 5;
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionTextBox.Location = new System.Drawing.Point(103, 31);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.ReadOnly = true;
            this.conditionTextBox.Size = new System.Drawing.Size(100, 22);
            this.conditionTextBox.TabIndex = 4;
            // 
            // modelLabel
            // 
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(223, 77);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(68, 16);
            this.modelLabel.TabIndex = 3;
            this.modelLabel.Text = "Model";
            this.modelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerLabel.Location = new System.Drawing.Point(6, 77);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(90, 16);
            this.manufacturerLabel.TabIndex = 2;
            this.manufacturerLabel.Text = "Manufactur";
            this.manufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // platformLabel
            // 
            this.platformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformLabel.Location = new System.Drawing.Point(223, 31);
            this.platformLabel.Name = "platformLabel";
            this.platformLabel.Size = new System.Drawing.Size(68, 16);
            this.platformLabel.TabIndex = 1;
            this.platformLabel.Text = "Platform";
            this.platformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // conditionLabel
            // 
            this.conditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionLabel.Location = new System.Drawing.Point(9, 31);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(87, 13);
            this.conditionLabel.TabIndex = 0;
            this.conditionLabel.Text = "Condition";
            this.conditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // featureGroupBox
            // 
            this.featureGroupBox.Controls.Add(this.componentsListBox);
            this.featureGroupBox.Controls.Add(this.osLabel);
            this.featureGroupBox.Controls.Add(this.webCamLabel);
            this.featureGroupBox.Controls.Add(this.gpuTypeLabel);
            this.featureGroupBox.Controls.Add(this.hddLabel);
            this.featureGroupBox.Controls.Add(this.cpuSpeedLabel);
            this.featureGroupBox.Controls.Add(this.cpuNumberLabel);
            this.featureGroupBox.Controls.Add(this.cpuTypeLabel);
            this.featureGroupBox.Controls.Add(this.cpuBrandLabel);
            this.featureGroupBox.Controls.Add(this.memoryLabel);
            this.featureGroupBox.Controls.Add(this.sizeLabel);
            this.featureGroupBox.Location = new System.Drawing.Point(13, 134);
            this.featureGroupBox.Name = "featureGroupBox";
            this.featureGroupBox.Size = new System.Drawing.Size(413, 310);
            this.featureGroupBox.TabIndex = 2;
            this.featureGroupBox.TabStop = false;
            // 
            // componentsListBox
            // 
            this.componentsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentsListBox.FormattingEnabled = true;
            this.componentsListBox.ItemHeight = 15;
            this.componentsListBox.Location = new System.Drawing.Point(114, 25);
            this.componentsListBox.Name = "componentsListBox";
            this.componentsListBox.Size = new System.Drawing.Size(283, 259);
            this.componentsListBox.TabIndex = 10;
            // 
            // osLabel
            // 
            this.osLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osLabel.Location = new System.Drawing.Point(12, 271);
            this.osLabel.Name = "osLabel";
            this.osLabel.Size = new System.Drawing.Size(95, 18);
            this.osLabel.TabIndex = 9;
            this.osLabel.Text = "OS";
            this.osLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // webCamLabel
            // 
            this.webCamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webCamLabel.Location = new System.Drawing.Point(12, 248);
            this.webCamLabel.Name = "webCamLabel";
            this.webCamLabel.Size = new System.Drawing.Size(95, 13);
            this.webCamLabel.TabIndex = 8;
            this.webCamLabel.Text = "WebCam";
            this.webCamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpuTypeLabel
            // 
            this.gpuTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuTypeLabel.Location = new System.Drawing.Point(12, 220);
            this.gpuTypeLabel.Name = "gpuTypeLabel";
            this.gpuTypeLabel.Size = new System.Drawing.Size(95, 18);
            this.gpuTypeLabel.TabIndex = 7;
            this.gpuTypeLabel.Text = "GPU Type";
            this.gpuTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hddLabel
            // 
            this.hddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hddLabel.Location = new System.Drawing.Point(12, 192);
            this.hddLabel.Name = "hddLabel";
            this.hddLabel.Size = new System.Drawing.Size(95, 18);
            this.hddLabel.TabIndex = 6;
            this.hddLabel.Text = "HDD";
            this.hddLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuSpeedLabel
            // 
            this.cpuSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuSpeedLabel.Location = new System.Drawing.Point(12, 165);
            this.cpuSpeedLabel.Name = "cpuSpeedLabel";
            this.cpuSpeedLabel.Size = new System.Drawing.Size(95, 18);
            this.cpuSpeedLabel.TabIndex = 5;
            this.cpuSpeedLabel.Text = "CPU Speed";
            this.cpuSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuNumberLabel
            // 
            this.cpuNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuNumberLabel.Location = new System.Drawing.Point(-1, 135);
            this.cpuNumberLabel.Name = "cpuNumberLabel";
            this.cpuNumberLabel.Size = new System.Drawing.Size(108, 18);
            this.cpuNumberLabel.TabIndex = 4;
            this.cpuNumberLabel.Text = "CPU Number";
            this.cpuNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuTypeLabel
            // 
            this.cpuTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuTypeLabel.Location = new System.Drawing.Point(12, 107);
            this.cpuTypeLabel.Name = "cpuTypeLabel";
            this.cpuTypeLabel.Size = new System.Drawing.Size(95, 18);
            this.cpuTypeLabel.TabIndex = 3;
            this.cpuTypeLabel.Text = "CPU Type";
            this.cpuTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpuBrandLabel
            // 
            this.cpuBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuBrandLabel.Location = new System.Drawing.Point(12, 79);
            this.cpuBrandLabel.Name = "cpuBrandLabel";
            this.cpuBrandLabel.Size = new System.Drawing.Size(95, 18);
            this.cpuBrandLabel.TabIndex = 2;
            this.cpuBrandLabel.Text = "CPU Brand";
            this.cpuBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // memoryLabel
            // 
            this.memoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryLabel.Location = new System.Drawing.Point(12, 52);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(95, 18);
            this.memoryLabel.TabIndex = 1;
            this.memoryLabel.Text = "Memory";
            this.memoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sizeLabel
            // 
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel.Location = new System.Drawing.Point(12, 25);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(95, 14);
            this.sizeLabel.TabIndex = 0;
            this.sizeLabel.Text = "LCD Size";
            this.sizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // yourPriceGroupBox
            // 
            this.yourPriceGroupBox.Controls.Add(this.label4);
            this.yourPriceGroupBox.Controls.Add(this.totalTextBox);
            this.yourPriceGroupBox.Controls.Add(this.taxTextBox);
            this.yourPriceGroupBox.Controls.Add(this.priceTextBox);
            this.yourPriceGroupBox.Controls.Add(this.totalLabel);
            this.yourPriceGroupBox.Controls.Add(this.salesTaxLabel);
            this.yourPriceGroupBox.Controls.Add(this.priceLabel);
            this.yourPriceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourPriceGroupBox.Location = new System.Drawing.Point(450, 241);
            this.yourPriceGroupBox.Name = "yourPriceGroupBox";
            this.yourPriceGroupBox.Size = new System.Drawing.Size(294, 131);
            this.yourPriceGroupBox.TabIndex = 3;
            this.yourPriceGroupBox.TabStop = false;
            this.yourPriceGroupBox.Text = "Your Price";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 2);
            this.label4.TabIndex = 6;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(179, 93);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalTextBox.TabIndex = 5;
            // 
            // taxTextBox
            // 
            this.taxTextBox.Location = new System.Drawing.Point(179, 46);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.ReadOnly = true;
            this.taxTextBox.Size = new System.Drawing.Size(100, 22);
            this.taxTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(179, 17);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceTextBox.TabIndex = 3;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(7, 93);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(132, 22);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTaxLabel.Location = new System.Drawing.Point(7, 49);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(132, 27);
            this.salesTaxLabel.TabIndex = 1;
            this.salesTaxLabel.Text = "Sales Tax (13%)";
            this.salesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(7, 22);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(132, 24);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Price";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(508, 415);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(55, 29);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this._backButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(586, 415);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(69, 29);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButton.Location = new System.Drawing.Point(675, 415);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(69, 29);
            this.finishButton.TabIndex = 6;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this._finishButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment4.Properties.Resources.hack_any_computer;
            this.pictureBox1.Location = new System.Drawing.Point(433, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 157);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 456);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.yourPriceGroupBox);
            this.Controls.Add(this.featureGroupBox);
            this.Controls.Add(this.componentsGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complete Your Order";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.componentsGroupBox.ResumeLayout(false);
            this.componentsGroupBox.PerformLayout();
            this.featureGroupBox.ResumeLayout(false);
            this.yourPriceGroupBox.ResumeLayout(false);
            this.yourPriceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.GroupBox componentsGroupBox;
        private System.Windows.Forms.GroupBox featureGroupBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.Label platformLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.TextBox platformTextBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.Label osLabel;
        private System.Windows.Forms.Label webCamLabel;
        private System.Windows.Forms.Label gpuTypeLabel;
        private System.Windows.Forms.Label hddLabel;
        private System.Windows.Forms.Label cpuSpeedLabel;
        private System.Windows.Forms.Label cpuNumberLabel;
        private System.Windows.Forms.Label cpuTypeLabel;
        private System.Windows.Forms.Label cpuBrandLabel;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.ListBox componentsListBox;
        private System.Windows.Forms.GroupBox yourPriceGroupBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}