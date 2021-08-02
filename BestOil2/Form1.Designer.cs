
namespace BestOil2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.titlePanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.minBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.closeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.totalSumPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.fastFoodGrpBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.colaCB = new Guna.UI2.WinForms.Guna2CheckBox();
            this.friesCB = new Guna.UI2.WinForms.Guna2CheckBox();
            this.hamburgerCB = new Guna.UI2.WinForms.Guna2CheckBox();
            this.hotdogCB = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cafeSumPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.gasStationGrpBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.statSumPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.radioPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.priceRadio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.literRadio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.gasPrice = new System.Windows.Forms.Label();
            this.gasLabel = new System.Windows.Forms.Label();
            this.moneyAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.literAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.gasPriceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.gasComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.hotdogPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.hotdogQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.hamburgerPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.hamburgerQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.friesPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.friesQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.colaPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.colaQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.cafePriceLbl = new System.Windows.Forms.Label();
            this.cafeQuantityLbl = new System.Windows.Forms.Label();
            this.cafeAznLbl = new System.Windows.Forms.Label();
            this.gasAznLbl = new System.Windows.Forms.Label();
            this.totalSum = new System.Windows.Forms.Label();
            this.gasSum = new System.Windows.Forms.Label();
            this.cafeSum = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            this.totalSumPanel.SuspendLayout();
            this.fastFoodGrpBox.SuspendLayout();
            this.cafeSumPanel.SuspendLayout();
            this.gasStationGrpBox.SuspendLayout();
            this.statSumPanel.SuspendLayout();
            this.radioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.minBox);
            this.titlePanel.Controls.Add(this.closeBox);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.titlePanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.ShadowDecoration.Parent = this.titlePanel;
            this.titlePanel.Size = new System.Drawing.Size(607, 30);
            this.titlePanel.TabIndex = 0;
            // 
            // minBox
            // 
            this.minBox.Animated = true;
            this.minBox.BackColor = System.Drawing.Color.Transparent;
            this.minBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.minBox.FillColor = System.Drawing.Color.Transparent;
            this.minBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minBox.HoverState.Parent = this.minBox;
            this.minBox.IconColor = System.Drawing.Color.White;
            this.minBox.Location = new System.Drawing.Point(517, 0);
            this.minBox.Name = "minBox";
            this.minBox.ShadowDecoration.Parent = this.minBox;
            this.minBox.Size = new System.Drawing.Size(45, 30);
            this.minBox.TabIndex = 1;
            // 
            // closeBox
            // 
            this.closeBox.Animated = true;
            this.closeBox.BackColor = System.Drawing.Color.Transparent;
            this.closeBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBox.FillColor = System.Drawing.Color.Transparent;
            this.closeBox.HoverState.FillColor = System.Drawing.Color.Red;
            this.closeBox.HoverState.Parent = this.closeBox;
            this.closeBox.IconColor = System.Drawing.Color.White;
            this.closeBox.Location = new System.Drawing.Point(562, 0);
            this.closeBox.Name = "closeBox";
            this.closeBox.ShadowDecoration.Parent = this.closeBox;
            this.closeBox.Size = new System.Drawing.Size(45, 30);
            this.closeBox.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.titlePanel;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // totalSumPanel
            // 
            this.totalSumPanel.BorderRadius = 10;
            this.totalSumPanel.Controls.Add(this.totalSum);
            this.totalSumPanel.FillColor = System.Drawing.Color.White;
            this.totalSumPanel.Location = new System.Drawing.Point(8, 446);
            this.totalSumPanel.Name = "totalSumPanel";
            this.totalSumPanel.ShadowDecoration.Parent = this.totalSumPanel;
            this.totalSumPanel.Size = new System.Drawing.Size(589, 137);
            this.totalSumPanel.TabIndex = 0;
            // 
            // fastFoodGrpBox
            // 
            this.fastFoodGrpBox.BorderColor = System.Drawing.Color.Transparent;
            this.fastFoodGrpBox.BorderRadius = 10;
            this.fastFoodGrpBox.BorderThickness = 0;
            this.fastFoodGrpBox.Controls.Add(this.cafeQuantityLbl);
            this.fastFoodGrpBox.Controls.Add(this.cafePriceLbl);
            this.fastFoodGrpBox.Controls.Add(this.colaQuantity);
            this.fastFoodGrpBox.Controls.Add(this.friesQuantity);
            this.fastFoodGrpBox.Controls.Add(this.hamburgerQuantity);
            this.fastFoodGrpBox.Controls.Add(this.hotdogQuantity);
            this.fastFoodGrpBox.Controls.Add(this.colaCB);
            this.fastFoodGrpBox.Controls.Add(this.friesCB);
            this.fastFoodGrpBox.Controls.Add(this.hamburgerCB);
            this.fastFoodGrpBox.Controls.Add(this.colaPrice);
            this.fastFoodGrpBox.Controls.Add(this.friesPrice);
            this.fastFoodGrpBox.Controls.Add(this.hotdogCB);
            this.fastFoodGrpBox.Controls.Add(this.hamburgerPrice);
            this.fastFoodGrpBox.Controls.Add(this.cafeSumPanel);
            this.fastFoodGrpBox.Controls.Add(this.hotdogPrice);
            this.fastFoodGrpBox.CustomBorderColor = System.Drawing.Color.Transparent;
            this.fastFoodGrpBox.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.fastFoodGrpBox.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastFoodGrpBox.ForeColor = System.Drawing.Color.Black;
            this.fastFoodGrpBox.Location = new System.Drawing.Point(307, 40);
            this.fastFoodGrpBox.Name = "fastFoodGrpBox";
            this.fastFoodGrpBox.ShadowDecoration.Parent = this.fastFoodGrpBox;
            this.fastFoodGrpBox.Size = new System.Drawing.Size(290, 400);
            this.fastFoodGrpBox.TabIndex = 1;
            this.fastFoodGrpBox.Text = "Fast Food";
            this.fastFoodGrpBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // colaCB
            // 
            this.colaCB.Animated = true;
            this.colaCB.AutoSize = true;
            this.colaCB.BackColor = System.Drawing.Color.Transparent;
            this.colaCB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.colaCB.CheckedState.BorderRadius = 2;
            this.colaCB.CheckedState.BorderThickness = 0;
            this.colaCB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.colaCB.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaCB.ForeColor = System.Drawing.Color.Black;
            this.colaCB.Location = new System.Drawing.Point(16, 212);
            this.colaCB.Name = "colaCB";
            this.colaCB.Size = new System.Drawing.Size(93, 22);
            this.colaCB.TabIndex = 5;
            this.colaCB.Text = "Coca-Cola";
            this.colaCB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.colaCB.UncheckedState.BorderRadius = 2;
            this.colaCB.UncheckedState.BorderThickness = 0;
            this.colaCB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.colaCB.UseVisualStyleBackColor = false;
            this.colaCB.CheckedChanged += new System.EventHandler(this.colaCB_CheckedChanged);
            // 
            // friesCB
            // 
            this.friesCB.Animated = true;
            this.friesCB.AutoSize = true;
            this.friesCB.BackColor = System.Drawing.Color.Transparent;
            this.friesCB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.friesCB.CheckedState.BorderRadius = 2;
            this.friesCB.CheckedState.BorderThickness = 0;
            this.friesCB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.friesCB.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesCB.ForeColor = System.Drawing.Color.Black;
            this.friesCB.Location = new System.Drawing.Point(16, 158);
            this.friesCB.Name = "friesCB";
            this.friesCB.Size = new System.Drawing.Size(104, 22);
            this.friesCB.TabIndex = 5;
            this.friesCB.Text = "Potato Fries";
            this.friesCB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.friesCB.UncheckedState.BorderRadius = 2;
            this.friesCB.UncheckedState.BorderThickness = 0;
            this.friesCB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.friesCB.UseVisualStyleBackColor = false;
            this.friesCB.CheckedChanged += new System.EventHandler(this.friesCB_CheckedChanged);
            // 
            // hamburgerCB
            // 
            this.hamburgerCB.Animated = true;
            this.hamburgerCB.AutoSize = true;
            this.hamburgerCB.BackColor = System.Drawing.Color.Transparent;
            this.hamburgerCB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.hamburgerCB.CheckedState.BorderRadius = 2;
            this.hamburgerCB.CheckedState.BorderThickness = 0;
            this.hamburgerCB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.hamburgerCB.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hamburgerCB.ForeColor = System.Drawing.Color.Black;
            this.hamburgerCB.Location = new System.Drawing.Point(16, 102);
            this.hamburgerCB.Name = "hamburgerCB";
            this.hamburgerCB.Size = new System.Drawing.Size(105, 22);
            this.hamburgerCB.TabIndex = 5;
            this.hamburgerCB.Text = "Hamburger";
            this.hamburgerCB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.hamburgerCB.UncheckedState.BorderRadius = 2;
            this.hamburgerCB.UncheckedState.BorderThickness = 0;
            this.hamburgerCB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.hamburgerCB.UseVisualStyleBackColor = false;
            this.hamburgerCB.CheckedChanged += new System.EventHandler(this.hamburgerCB_CheckedChanged);
            // 
            // hotdogCB
            // 
            this.hotdogCB.Animated = true;
            this.hotdogCB.AutoSize = true;
            this.hotdogCB.BackColor = System.Drawing.Color.Transparent;
            this.hotdogCB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.hotdogCB.CheckedState.BorderRadius = 2;
            this.hotdogCB.CheckedState.BorderThickness = 0;
            this.hotdogCB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.hotdogCB.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotdogCB.ForeColor = System.Drawing.Color.Black;
            this.hotdogCB.Location = new System.Drawing.Point(16, 48);
            this.hotdogCB.Name = "hotdogCB";
            this.hotdogCB.Size = new System.Drawing.Size(82, 22);
            this.hotdogCB.TabIndex = 5;
            this.hotdogCB.Text = "Hot Dog";
            this.hotdogCB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.hotdogCB.UncheckedState.BorderRadius = 2;
            this.hotdogCB.UncheckedState.BorderThickness = 0;
            this.hotdogCB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.hotdogCB.UseVisualStyleBackColor = false;
            this.hotdogCB.CheckedChanged += new System.EventHandler(this.hotdogCB_CheckedChanged);
            // 
            // cafeSumPanel
            // 
            this.cafeSumPanel.BackColor = System.Drawing.Color.Transparent;
            this.cafeSumPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.cafeSumPanel.BorderRadius = 10;
            this.cafeSumPanel.BorderThickness = 2;
            this.cafeSumPanel.Controls.Add(this.cafeSum);
            this.cafeSumPanel.Controls.Add(this.cafeAznLbl);
            this.cafeSumPanel.Location = new System.Drawing.Point(11, 264);
            this.cafeSumPanel.Name = "cafeSumPanel";
            this.cafeSumPanel.ShadowDecoration.Parent = this.cafeSumPanel;
            this.cafeSumPanel.Size = new System.Drawing.Size(268, 110);
            this.cafeSumPanel.TabIndex = 4;
            // 
            // gasStationGrpBox
            // 
            this.gasStationGrpBox.BorderColor = System.Drawing.Color.Transparent;
            this.gasStationGrpBox.BorderRadius = 10;
            this.gasStationGrpBox.BorderThickness = 0;
            this.gasStationGrpBox.Controls.Add(this.moneyAmount);
            this.gasStationGrpBox.Controls.Add(this.literAmount);
            this.gasStationGrpBox.Controls.Add(this.statSumPanel);
            this.gasStationGrpBox.Controls.Add(this.radioPanel);
            this.gasStationGrpBox.Controls.Add(this.gasPrice);
            this.gasStationGrpBox.Controls.Add(this.gasLabel);
            this.gasStationGrpBox.Controls.Add(this.gasPriceTextBox);
            this.gasStationGrpBox.Controls.Add(this.gasComboBox);
            this.gasStationGrpBox.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gasStationGrpBox.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gasStationGrpBox.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasStationGrpBox.ForeColor = System.Drawing.Color.Black;
            this.gasStationGrpBox.Location = new System.Drawing.Point(8, 40);
            this.gasStationGrpBox.Margin = new System.Windows.Forms.Padding(1);
            this.gasStationGrpBox.Name = "gasStationGrpBox";
            this.gasStationGrpBox.ShadowDecoration.Parent = this.gasStationGrpBox;
            this.gasStationGrpBox.Size = new System.Drawing.Size(290, 400);
            this.gasStationGrpBox.TabIndex = 2;
            this.gasStationGrpBox.Text = "Gas Station";
            this.gasStationGrpBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // statSumPanel
            // 
            this.statSumPanel.BackColor = System.Drawing.Color.Transparent;
            this.statSumPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.statSumPanel.BorderRadius = 10;
            this.statSumPanel.BorderThickness = 2;
            this.statSumPanel.Controls.Add(this.gasSum);
            this.statSumPanel.Controls.Add(this.gasAznLbl);
            this.statSumPanel.Location = new System.Drawing.Point(11, 264);
            this.statSumPanel.Name = "statSumPanel";
            this.statSumPanel.ShadowDecoration.Parent = this.statSumPanel;
            this.statSumPanel.Size = new System.Drawing.Size(268, 110);
            this.statSumPanel.TabIndex = 4;
            // 
            // radioPanel
            // 
            this.radioPanel.BackColor = System.Drawing.Color.Transparent;
            this.radioPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.radioPanel.BorderRadius = 10;
            this.radioPanel.BorderThickness = 2;
            this.radioPanel.Controls.Add(this.priceRadio);
            this.radioPanel.Controls.Add(this.literRadio);
            this.radioPanel.Location = new System.Drawing.Point(11, 163);
            this.radioPanel.Name = "radioPanel";
            this.radioPanel.ShadowDecoration.Parent = this.radioPanel;
            this.radioPanel.Size = new System.Drawing.Size(137, 66);
            this.radioPanel.TabIndex = 3;
            // 
            // priceRadio
            // 
            this.priceRadio.Animated = true;
            this.priceRadio.AutoSize = true;
            this.priceRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.priceRadio.CheckedState.BorderThickness = 0;
            this.priceRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.priceRadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.priceRadio.CheckedState.InnerOffset = -4;
            this.priceRadio.FlatAppearance.BorderSize = 0;
            this.priceRadio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.priceRadio.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceRadio.Location = new System.Drawing.Point(15, 36);
            this.priceRadio.Name = "priceRadio";
            this.priceRadio.Size = new System.Drawing.Size(104, 27);
            this.priceRadio.TabIndex = 0;
            this.priceRadio.TabStop = true;
            this.priceRadio.Text = "For price";
            this.priceRadio.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.priceRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.priceRadio.UncheckedState.BorderThickness = 2;
            this.priceRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.priceRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.priceRadio.UseVisualStyleBackColor = true;
            this.priceRadio.CheckedChanged += new System.EventHandler(this.priceRadio_CheckedChanged);
            // 
            // literRadio
            // 
            this.literRadio.Animated = true;
            this.literRadio.AutoSize = true;
            this.literRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.literRadio.CheckedState.BorderThickness = 0;
            this.literRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.literRadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.literRadio.CheckedState.InnerOffset = -4;
            this.literRadio.FlatAppearance.BorderSize = 0;
            this.literRadio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.literRadio.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.literRadio.Location = new System.Drawing.Point(15, 3);
            this.literRadio.Name = "literRadio";
            this.literRadio.Size = new System.Drawing.Size(96, 27);
            this.literRadio.TabIndex = 0;
            this.literRadio.TabStop = true;
            this.literRadio.Text = "Per liter";
            this.literRadio.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.literRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.literRadio.UncheckedState.BorderThickness = 2;
            this.literRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.literRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.literRadio.UseVisualStyleBackColor = true;
            this.literRadio.CheckedChanged += new System.EventHandler(this.literRadio_CheckedChanged);
            // 
            // gasPrice
            // 
            this.gasPrice.AutoSize = true;
            this.gasPrice.BackColor = System.Drawing.Color.Transparent;
            this.gasPrice.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasPrice.ForeColor = System.Drawing.Color.Black;
            this.gasPrice.Location = new System.Drawing.Point(11, 101);
            this.gasPrice.Name = "gasPrice";
            this.gasPrice.Size = new System.Drawing.Size(50, 22);
            this.gasPrice.TabIndex = 2;
            this.gasPrice.Text = "Price";
            this.gasPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gasLabel
            // 
            this.gasLabel.AutoSize = true;
            this.gasLabel.BackColor = System.Drawing.Color.Transparent;
            this.gasLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasLabel.ForeColor = System.Drawing.Color.Black;
            this.gasLabel.Location = new System.Drawing.Point(11, 48);
            this.gasLabel.Name = "gasLabel";
            this.gasLabel.Size = new System.Drawing.Size(78, 22);
            this.gasLabel.TabIndex = 2;
            this.gasLabel.Text = "Gasoline";
            this.gasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // moneyAmount
            // 
            this.moneyAmount.BackColor = System.Drawing.Color.Transparent;
            this.moneyAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.moneyAmount.BorderRadius = 5;
            this.moneyAmount.BorderThickness = 2;
            this.moneyAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.moneyAmount.DefaultText = "";
            this.moneyAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.moneyAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.moneyAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.moneyAmount.DisabledState.Parent = this.moneyAmount;
            this.moneyAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.moneyAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.moneyAmount.FocusedState.Parent = this.moneyAmount;
            this.moneyAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(188)))));
            this.moneyAmount.HoverState.Parent = this.moneyAmount;
            this.moneyAmount.Location = new System.Drawing.Point(154, 203);
            this.moneyAmount.MaxLength = 3;
            this.moneyAmount.Name = "moneyAmount";
            this.moneyAmount.PasswordChar = '\0';
            this.moneyAmount.PlaceholderText = "";
            this.moneyAmount.SelectedText = "";
            this.moneyAmount.ShadowDecoration.Parent = this.moneyAmount;
            this.moneyAmount.Size = new System.Drawing.Size(125, 26);
            this.moneyAmount.TabIndex = 1;
            this.moneyAmount.TextChanged += new System.EventHandler(this.moneyAmount_TextChanged);
            // 
            // literAmount
            // 
            this.literAmount.BackColor = System.Drawing.Color.Transparent;
            this.literAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.literAmount.BorderRadius = 5;
            this.literAmount.BorderThickness = 2;
            this.literAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.literAmount.DefaultText = "";
            this.literAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.literAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.literAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.literAmount.DisabledState.Parent = this.literAmount;
            this.literAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.literAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.literAmount.FocusedState.Parent = this.literAmount;
            this.literAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(188)))));
            this.literAmount.HoverState.Parent = this.literAmount;
            this.literAmount.Location = new System.Drawing.Point(154, 163);
            this.literAmount.MaxLength = 3;
            this.literAmount.Name = "literAmount";
            this.literAmount.PasswordChar = '\0';
            this.literAmount.PlaceholderText = "";
            this.literAmount.SelectedText = "";
            this.literAmount.ShadowDecoration.Parent = this.literAmount;
            this.literAmount.Size = new System.Drawing.Size(125, 26);
            this.literAmount.TabIndex = 1;
            this.literAmount.TextChanged += new System.EventHandler(this.literAmount_TextChanged);
            // 
            // gasPriceTextBox
            // 
            this.gasPriceTextBox.BackColor = System.Drawing.Color.Transparent;
            this.gasPriceTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.gasPriceTextBox.BorderRadius = 5;
            this.gasPriceTextBox.BorderThickness = 2;
            this.gasPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gasPriceTextBox.DefaultText = "";
            this.gasPriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.gasPriceTextBox.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.gasPriceTextBox.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.gasPriceTextBox.DisabledState.Parent = this.gasPriceTextBox;
            this.gasPriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.gasPriceTextBox.Enabled = false;
            this.gasPriceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.gasPriceTextBox.FocusedState.Parent = this.gasPriceTextBox;
            this.gasPriceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(188)))));
            this.gasPriceTextBox.HoverState.Parent = this.gasPriceTextBox;
            this.gasPriceTextBox.Location = new System.Drawing.Point(108, 97);
            this.gasPriceTextBox.Name = "gasPriceTextBox";
            this.gasPriceTextBox.PasswordChar = '\0';
            this.gasPriceTextBox.PlaceholderText = "";
            this.gasPriceTextBox.SelectedText = "";
            this.gasPriceTextBox.ShadowDecoration.Parent = this.gasPriceTextBox;
            this.gasPriceTextBox.Size = new System.Drawing.Size(171, 26);
            this.gasPriceTextBox.TabIndex = 1;
            // 
            // gasComboBox
            // 
            this.gasComboBox.Animated = true;
            this.gasComboBox.BackColor = System.Drawing.Color.Transparent;
            this.gasComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.gasComboBox.BorderRadius = 5;
            this.gasComboBox.BorderThickness = 2;
            this.gasComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gasComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.gasComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.gasComboBox.FocusedState.Parent = this.gasComboBox;
            this.gasComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gasComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gasComboBox.FormattingEnabled = true;
            this.gasComboBox.HoverState.Parent = this.gasComboBox;
            this.gasComboBox.ItemHeight = 20;
            this.gasComboBox.ItemsAppearance.Parent = this.gasComboBox;
            this.gasComboBox.Location = new System.Drawing.Point(108, 45);
            this.gasComboBox.Name = "gasComboBox";
            this.gasComboBox.ShadowDecoration.Parent = this.gasComboBox;
            this.gasComboBox.Size = new System.Drawing.Size(171, 26);
            this.gasComboBox.TabIndex = 0;
            this.gasComboBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.gasComboBox.SelectedIndexChanged += new System.EventHandler(this.gasComboBox_SelectedIndexChanged);
            // 
            // hotdogPrice
            // 
            this.hotdogPrice.BackColor = System.Drawing.Color.Transparent;
            this.hotdogPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.hotdogPrice.BorderRadius = 5;
            this.hotdogPrice.BorderThickness = 2;
            this.hotdogPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hotdogPrice.DefaultText = "";
            this.hotdogPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hotdogPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hotdogPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hotdogPrice.DisabledState.Parent = this.hotdogPrice;
            this.hotdogPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hotdogPrice.Enabled = false;
            this.hotdogPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.hotdogPrice.FocusedState.Parent = this.hotdogPrice;
            this.hotdogPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(188)))));
            this.hotdogPrice.HoverState.Parent = this.hotdogPrice;
            this.hotdogPrice.Location = new System.Drawing.Point(147, 46);
            this.hotdogPrice.Name = "hotdogPrice";
            this.hotdogPrice.PasswordChar = '\0';
            this.hotdogPrice.PlaceholderText = "";
            this.hotdogPrice.SelectedText = "";
            this.hotdogPrice.ShadowDecoration.Parent = this.hotdogPrice;
            this.hotdogPrice.Size = new System.Drawing.Size(62, 26);
            this.hotdogPrice.TabIndex = 1;
            // 
            // hotdogQuantity
            // 
            this.hotdogQuantity.BackColor = System.Drawing.Color.Transparent;
            this.hotdogQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.hotdogQuantity.BorderRadius = 5;
            this.hotdogQuantity.BorderThickness = 2;
            this.hotdogQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hotdogQuantity.DefaultText = "";
            this.hotdogQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hotdogQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hotdogQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hotdogQuantity.DisabledState.Parent = this.hotdogQuantity;
            this.hotdogQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hotdogQuantity.Enabled = false;
            this.hotdogQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.hotdogQuantity.FocusedState.Parent = this.hotdogQuantity;
            this.hotdogQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(188)))));
            this.hotdogQuantity.HoverState.Parent = this.hotdogQuantity;
            this.hotdogQuantity.Location = new System.Drawing.Point(218, 46);
            this.hotdogQuantity.MaxLength = 3;
            this.hotdogQuantity.Name = "hotdogQuantity";
            this.hotdogQuantity.PasswordChar = '\0';
            this.hotdogQuantity.PlaceholderText = "";
            this.hotdogQuantity.SelectedText = "";
            this.hotdogQuantity.ShadowDecoration.Parent = this.hotdogQuantity;
            this.hotdogQuantity.Size = new System.Drawing.Size(62, 26);
            this.hotdogQuantity.TabIndex = 6;
            this.hotdogQuantity.TextChanged += new System.EventHandler(this.hotdogQuantity_TextChanged);
            this.hotdogQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hotdogQuantity_KeyPress);
            // 
            // hamburgerPrice
            // 
            this.hamburgerPrice.BackColor = System.Drawing.Color.Transparent;
            this.hamburgerPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.hamburgerPrice.BorderRadius = 5;
            this.hamburgerPrice.BorderThickness = 2;
            this.hamburgerPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hamburgerPrice.DefaultText = "";
            this.hamburgerPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hamburgerPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hamburgerPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hamburgerPrice.DisabledState.Parent = this.hamburgerPrice;
            this.hamburgerPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hamburgerPrice.Enabled = false;
            this.hamburgerPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.hamburgerPrice.FocusedState.Parent = this.hamburgerPrice;
            this.hamburgerPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(188)))));
            this.hamburgerPrice.HoverState.Parent = this.hamburgerPrice;
            this.hamburgerPrice.Location = new System.Drawing.Point(147, 98);
            this.hamburgerPrice.Name = "hamburgerPrice";
            this.hamburgerPrice.PasswordChar = '\0';
            this.hamburgerPrice.PlaceholderText = "";
            this.hamburgerPrice.SelectedText = "";
            this.hamburgerPrice.ShadowDecoration.Parent = this.hamburgerPrice;
            this.hamburgerPrice.Size = new System.Drawing.Size(62, 26);
            this.hamburgerPrice.TabIndex = 1;
            // 
            // hamburgerQuantity
            // 
            this.hamburgerQuantity.BackColor = System.Drawing.Color.Transparent;
            this.hamburgerQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.hamburgerQuantity.BorderRadius = 5;
            this.hamburgerQuantity.BorderThickness = 2;
            this.hamburgerQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hamburgerQuantity.DefaultText = "";
            this.hamburgerQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hamburgerQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hamburgerQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hamburgerQuantity.DisabledState.Parent = this.hamburgerQuantity;
            this.hamburgerQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hamburgerQuantity.Enabled = false;
            this.hamburgerQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.hamburgerQuantity.FocusedState.Parent = this.hamburgerQuantity;
            this.hamburgerQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(188)))));
            this.hamburgerQuantity.HoverState.Parent = this.hamburgerQuantity;
            this.hamburgerQuantity.Location = new System.Drawing.Point(218, 97);
            this.hamburgerQuantity.MaxLength = 3;
            this.hamburgerQuantity.Name = "hamburgerQuantity";
            this.hamburgerQuantity.PasswordChar = '\0';
            this.hamburgerQuantity.PlaceholderText = "";
            this.hamburgerQuantity.SelectedText = "";
            this.hamburgerQuantity.ShadowDecoration.Parent = this.hamburgerQuantity;
            this.hamburgerQuantity.Size = new System.Drawing.Size(62, 26);
            this.hamburgerQuantity.TabIndex = 6;
            this.hamburgerQuantity.TextChanged += new System.EventHandler(this.hamburgerQuantity_TextChanged);
            this.hamburgerQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hamburgerQuantity_KeyPress);
            // 
            // friesPrice
            // 
            this.friesPrice.BackColor = System.Drawing.Color.Transparent;
            this.friesPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.friesPrice.BorderRadius = 5;
            this.friesPrice.BorderThickness = 2;
            this.friesPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.friesPrice.DefaultText = "";
            this.friesPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.friesPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.friesPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.friesPrice.DisabledState.Parent = this.friesPrice;
            this.friesPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.friesPrice.Enabled = false;
            this.friesPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.friesPrice.FocusedState.Parent = this.friesPrice;
            this.friesPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(188)))));
            this.friesPrice.HoverState.Parent = this.friesPrice;
            this.friesPrice.Location = new System.Drawing.Point(147, 154);
            this.friesPrice.Name = "friesPrice";
            this.friesPrice.PasswordChar = '\0';
            this.friesPrice.PlaceholderText = "";
            this.friesPrice.SelectedText = "";
            this.friesPrice.ShadowDecoration.Parent = this.friesPrice;
            this.friesPrice.Size = new System.Drawing.Size(62, 26);
            this.friesPrice.TabIndex = 1;
            // 
            // friesQuantity
            // 
            this.friesQuantity.BackColor = System.Drawing.Color.Transparent;
            this.friesQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.friesQuantity.BorderRadius = 5;
            this.friesQuantity.BorderThickness = 2;
            this.friesQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.friesQuantity.DefaultText = "";
            this.friesQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.friesQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.friesQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.friesQuantity.DisabledState.Parent = this.friesQuantity;
            this.friesQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.friesQuantity.Enabled = false;
            this.friesQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.friesQuantity.FocusedState.Parent = this.friesQuantity;
            this.friesQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(188)))));
            this.friesQuantity.HoverState.Parent = this.friesQuantity;
            this.friesQuantity.Location = new System.Drawing.Point(218, 154);
            this.friesQuantity.MaxLength = 3;
            this.friesQuantity.Name = "friesQuantity";
            this.friesQuantity.PasswordChar = '\0';
            this.friesQuantity.PlaceholderText = "";
            this.friesQuantity.SelectedText = "";
            this.friesQuantity.ShadowDecoration.Parent = this.friesQuantity;
            this.friesQuantity.Size = new System.Drawing.Size(62, 26);
            this.friesQuantity.TabIndex = 6;
            this.friesQuantity.TextChanged += new System.EventHandler(this.friesQuantity_TextChanged);
            this.friesQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.friesQuantity_KeyPress);
            // 
            // colaPrice
            // 
            this.colaPrice.BackColor = System.Drawing.Color.Transparent;
            this.colaPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.colaPrice.BorderRadius = 5;
            this.colaPrice.BorderThickness = 2;
            this.colaPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.colaPrice.DefaultText = "";
            this.colaPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.colaPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.colaPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.colaPrice.DisabledState.Parent = this.colaPrice;
            this.colaPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.colaPrice.Enabled = false;
            this.colaPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.colaPrice.FocusedState.Parent = this.colaPrice;
            this.colaPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(188)))));
            this.colaPrice.HoverState.Parent = this.colaPrice;
            this.colaPrice.Location = new System.Drawing.Point(147, 203);
            this.colaPrice.Name = "colaPrice";
            this.colaPrice.PasswordChar = '\0';
            this.colaPrice.PlaceholderText = "";
            this.colaPrice.SelectedText = "";
            this.colaPrice.ShadowDecoration.Parent = this.colaPrice;
            this.colaPrice.Size = new System.Drawing.Size(62, 26);
            this.colaPrice.TabIndex = 1;
            // 
            // colaQuantity
            // 
            this.colaQuantity.BackColor = System.Drawing.Color.Transparent;
            this.colaQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.colaQuantity.BorderRadius = 5;
            this.colaQuantity.BorderThickness = 2;
            this.colaQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.colaQuantity.DefaultText = "";
            this.colaQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.colaQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.colaQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.colaQuantity.DisabledState.Parent = this.colaQuantity;
            this.colaQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.colaQuantity.Enabled = false;
            this.colaQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.colaQuantity.FocusedState.Parent = this.colaQuantity;
            this.colaQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(177)))), ((int)(((byte)(188)))));
            this.colaQuantity.HoverState.Parent = this.colaQuantity;
            this.colaQuantity.Location = new System.Drawing.Point(218, 203);
            this.colaQuantity.MaxLength = 3;
            this.colaQuantity.Name = "colaQuantity";
            this.colaQuantity.PasswordChar = '\0';
            this.colaQuantity.PlaceholderText = "";
            this.colaQuantity.SelectedText = "";
            this.colaQuantity.ShadowDecoration.Parent = this.colaQuantity;
            this.colaQuantity.Size = new System.Drawing.Size(62, 26);
            this.colaQuantity.TabIndex = 6;
            this.colaQuantity.TextChanged += new System.EventHandler(this.colaQuantity_TextChanged);
            this.colaQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.colaQuantity_KeyPress);
            // 
            // cafePriceLbl
            // 
            this.cafePriceLbl.BackColor = System.Drawing.Color.Transparent;
            this.cafePriceLbl.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cafePriceLbl.ForeColor = System.Drawing.Color.Black;
            this.cafePriceLbl.Location = new System.Drawing.Point(147, 25);
            this.cafePriceLbl.Name = "cafePriceLbl";
            this.cafePriceLbl.Size = new System.Drawing.Size(62, 18);
            this.cafePriceLbl.TabIndex = 7;
            this.cafePriceLbl.Text = "Price";
            this.cafePriceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cafeQuantityLbl
            // 
            this.cafeQuantityLbl.BackColor = System.Drawing.Color.Transparent;
            this.cafeQuantityLbl.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cafeQuantityLbl.ForeColor = System.Drawing.Color.Black;
            this.cafeQuantityLbl.Location = new System.Drawing.Point(216, 25);
            this.cafeQuantityLbl.Name = "cafeQuantityLbl";
            this.cafeQuantityLbl.Size = new System.Drawing.Size(67, 22);
            this.cafeQuantityLbl.TabIndex = 7;
            this.cafeQuantityLbl.Text = "Quantity";
            // 
            // cafeAznLbl
            // 
            this.cafeAznLbl.AutoSize = true;
            this.cafeAznLbl.Font = new System.Drawing.Font("Montserrat", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cafeAznLbl.Location = new System.Drawing.Point(205, 42);
            this.cafeAznLbl.Name = "cafeAznLbl";
            this.cafeAznLbl.Size = new System.Drawing.Size(60, 29);
            this.cafeAznLbl.TabIndex = 0;
            this.cafeAznLbl.Text = "AZN";
            // 
            // gasAznLbl
            // 
            this.gasAznLbl.AutoSize = true;
            this.gasAznLbl.Font = new System.Drawing.Font("Montserrat", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasAznLbl.Location = new System.Drawing.Point(205, 42);
            this.gasAznLbl.Name = "gasAznLbl";
            this.gasAznLbl.Size = new System.Drawing.Size(60, 29);
            this.gasAznLbl.TabIndex = 0;
            this.gasAznLbl.Text = "AZN";
            // 
            // totalSum
            // 
            this.totalSum.BackColor = System.Drawing.Color.Transparent;
            this.totalSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalSum.Font = new System.Drawing.Font("Montserrat", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.totalSum.Location = new System.Drawing.Point(0, 0);
            this.totalSum.Name = "totalSum";
            this.totalSum.Size = new System.Drawing.Size(589, 137);
            this.totalSum.TabIndex = 0;
            this.totalSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalSum.TextChanged += new System.EventHandler(this.totalSum_TextChanged);
            // 
            // gasSum
            // 
            this.gasSum.AutoSize = true;
            this.gasSum.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasSum.Location = new System.Drawing.Point(10, 42);
            this.gasSum.Name = "gasSum";
            this.gasSum.Size = new System.Drawing.Size(0, 29);
            this.gasSum.TabIndex = 0;
            // 
            // cafeSum
            // 
            this.cafeSum.AutoSize = true;
            this.cafeSum.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cafeSum.Location = new System.Drawing.Point(10, 42);
            this.cafeSum.Name = "cafeSum";
            this.cafeSum.Size = new System.Drawing.Size(0, 29);
            this.cafeSum.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(136)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(607, 591);
            this.Controls.Add(this.gasStationGrpBox);
            this.Controls.Add(this.fastFoodGrpBox);
            this.Controls.Add(this.totalSumPanel);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.titlePanel.ResumeLayout(false);
            this.totalSumPanel.ResumeLayout(false);
            this.fastFoodGrpBox.ResumeLayout(false);
            this.fastFoodGrpBox.PerformLayout();
            this.cafeSumPanel.ResumeLayout(false);
            this.cafeSumPanel.PerformLayout();
            this.gasStationGrpBox.ResumeLayout(false);
            this.gasStationGrpBox.PerformLayout();
            this.statSumPanel.ResumeLayout(false);
            this.statSumPanel.PerformLayout();
            this.radioPanel.ResumeLayout(false);
            this.radioPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel titlePanel;
        private Guna.UI2.WinForms.Guna2ControlBox minBox;
        private Guna.UI2.WinForms.Guna2ControlBox closeBox;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GroupBox gasStationGrpBox;
        private Guna.UI2.WinForms.Guna2GroupBox fastFoodGrpBox;
        private Guna.UI2.WinForms.Guna2Panel totalSumPanel;
        private Guna.UI2.WinForms.Guna2ComboBox gasComboBox;
        private Guna.UI2.WinForms.Guna2TextBox gasPriceTextBox;
        private Guna.UI2.WinForms.Guna2Panel radioPanel;
        private System.Windows.Forms.Label gasLabel;
        private Guna.UI2.WinForms.Guna2TextBox moneyAmount;
        private Guna.UI2.WinForms.Guna2TextBox literAmount;
        private Guna.UI2.WinForms.Guna2RadioButton literRadio;
        private Guna.UI2.WinForms.Guna2RadioButton priceRadio;
        private System.Windows.Forms.Label gasPrice;
        private Guna.UI2.WinForms.Guna2Panel statSumPanel;
        private Guna.UI2.WinForms.Guna2Panel cafeSumPanel;
        private Guna.UI2.WinForms.Guna2CheckBox colaCB;
        private Guna.UI2.WinForms.Guna2CheckBox friesCB;
        private Guna.UI2.WinForms.Guna2CheckBox hamburgerCB;
        private Guna.UI2.WinForms.Guna2CheckBox hotdogCB;
        private System.Windows.Forms.Label cafeQuantityLbl;
        private System.Windows.Forms.Label cafePriceLbl;
        private Guna.UI2.WinForms.Guna2TextBox colaQuantity;
        private Guna.UI2.WinForms.Guna2TextBox friesQuantity;
        private Guna.UI2.WinForms.Guna2TextBox hamburgerQuantity;
        private Guna.UI2.WinForms.Guna2TextBox hotdogQuantity;
        private Guna.UI2.WinForms.Guna2TextBox colaPrice;
        private Guna.UI2.WinForms.Guna2TextBox friesPrice;
        private Guna.UI2.WinForms.Guna2TextBox hamburgerPrice;
        private Guna.UI2.WinForms.Guna2TextBox hotdogPrice;
        private System.Windows.Forms.Label gasAznLbl;
        private System.Windows.Forms.Label cafeAznLbl;
        private System.Windows.Forms.Label gasSum;
        private System.Windows.Forms.Label cafeSum;
        private System.Windows.Forms.Label totalSum;
    }
}

