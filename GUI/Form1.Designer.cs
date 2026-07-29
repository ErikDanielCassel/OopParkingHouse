namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxParking = new GroupBox();
            groupBox3 = new GroupBox();
            buttonSearch = new Button();
            buttonPark = new Button();
            buttonMove = new Button();
            buttonPickUp = new Button();
            numericUpDownNewSpot = new NumericUpDown();
            label6 = new Label();
            label2 = new Label();
            textBoxReg = new TextBox();
            groupBox2 = new GroupBox();
            listBoxPickVehicleType = new ListBox();
            treeViewMap = new TreeView();
            buttonReloadPrices = new Button();
            groupBoxParking.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewSpot).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxParking
            // 
            groupBoxParking.Controls.Add(groupBox3);
            groupBoxParking.Controls.Add(numericUpDownNewSpot);
            groupBoxParking.Controls.Add(label6);
            groupBoxParking.Controls.Add(label2);
            groupBoxParking.Controls.Add(textBoxReg);
            groupBoxParking.Controls.Add(groupBox2);
            groupBoxParking.Dock = DockStyle.Left;
            groupBoxParking.Location = new Point(0, 0);
            groupBoxParking.Margin = new Padding(3, 4, 3, 4);
            groupBoxParking.Name = "groupBoxParking";
            groupBoxParking.Padding = new Padding(3, 4, 3, 4);
            groupBoxParking.Size = new Size(386, 955);
            groupBoxParking.TabIndex = 7;
            groupBoxParking.TabStop = false;
            groupBoxParking.Text = "Parking";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonReloadPrices);
            groupBox3.Controls.Add(buttonSearch);
            groupBox3.Controls.Add(buttonPark);
            groupBox3.Controls.Add(buttonMove);
            groupBox3.Controls.Add(buttonPickUp);
            groupBox3.Location = new Point(0, 288);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(298, 144);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tools";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(6, 70);
            buttonSearch.Margin = new Padding(3, 4, 3, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(270, 31);
            buttonSearch.TabIndex = 14;
            buttonSearch.Text = "Sök Efter Fordon";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonPark
            // 
            buttonPark.Location = new Point(6, 28);
            buttonPark.Margin = new Padding(3, 4, 3, 4);
            buttonPark.Name = "buttonPark";
            buttonPark.Size = new Size(86, 31);
            buttonPark.TabIndex = 5;
            buttonPark.Text = "Parkera";
            buttonPark.UseVisualStyleBackColor = true;
            buttonPark.Click += ButtonPark_Click;
            // 
            // buttonMove
            // 
            buttonMove.Location = new Point(190, 28);
            buttonMove.Margin = new Padding(3, 4, 3, 4);
            buttonMove.Name = "buttonMove";
            buttonMove.Size = new Size(86, 31);
            buttonMove.TabIndex = 7;
            buttonMove.Text = "Flytta";
            buttonMove.UseVisualStyleBackColor = true;
            buttonMove.Click += buttonMove_Click;
            // 
            // buttonPickUp
            // 
            buttonPickUp.Location = new Point(98, 28);
            buttonPickUp.Margin = new Padding(3, 4, 3, 4);
            buttonPickUp.Name = "buttonPickUp";
            buttonPickUp.Size = new Size(86, 31);
            buttonPickUp.TabIndex = 6;
            buttonPickUp.Text = "Hämta";
            buttonPickUp.UseVisualStyleBackColor = true;
            buttonPickUp.Click += buttonPickUp_Click;
            // 
            // numericUpDownNewSpot
            // 
            numericUpDownNewSpot.Location = new Point(114, 253);
            numericUpDownNewSpot.Margin = new Padding(3, 4, 3, 4);
            numericUpDownNewSpot.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownNewSpot.Name = "numericUpDownNewSpot";
            numericUpDownNewSpot.Size = new Size(137, 27);
            numericUpDownNewSpot.TabIndex = 10;
            numericUpDownNewSpot.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 261);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 9;
            label6.Text = "Flytta till plats:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 216);
            label2.Name = "label2";
            label2.Size = new Size(209, 20);
            label2.TabIndex = 4;
            label2.Text = "Registration Number(ABC123)";
            // 
            // textBoxReg
            // 
            textBoxReg.CharacterCasing = CharacterCasing.Upper;
            textBoxReg.Location = new Point(222, 208);
            textBoxReg.Margin = new Padding(3, 4, 3, 4);
            textBoxReg.MaxLength = 10;
            textBoxReg.Name = "textBoxReg";
            textBoxReg.PlaceholderText = "ABC123";
            textBoxReg.Size = new Size(114, 27);
            textBoxReg.TabIndex = 3;
            textBoxReg.KeyPress += textBoxReg_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBoxPickVehicleType);
            groupBox2.Location = new Point(7, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 169);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pick vehicle type:";
            // 
            // listBoxPickVehicleType
            // 
            listBoxPickVehicleType.Dock = DockStyle.Fill;
            listBoxPickVehicleType.FormattingEnabled = true;
            listBoxPickVehicleType.HorizontalScrollbar = true;
            listBoxPickVehicleType.Location = new Point(3, 23);
            listBoxPickVehicleType.Name = "listBoxPickVehicleType";
            listBoxPickVehicleType.Size = new Size(244, 143);
            listBoxPickVehicleType.Sorted = true;
            listBoxPickVehicleType.TabIndex = 0;
            // 
            // treeViewMap
            // 
            treeViewMap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            treeViewMap.Location = new Point(392, 12);
            treeViewMap.Name = "treeViewMap";
            treeViewMap.Size = new Size(664, 943);
            treeViewMap.TabIndex = 8;
            // 
            // buttonReloadPrices
            // 
            buttonReloadPrices.Location = new Point(14, 108);
            buttonReloadPrices.Name = "buttonReloadPrices";
            buttonReloadPrices.Size = new Size(262, 29);
            buttonReloadPrices.TabIndex = 15;
            buttonReloadPrices.Text = "Läs In Prislista Igen";
            buttonReloadPrices.UseVisualStyleBackColor = true;
            buttonReloadPrices.Click += buttonReloadPrices_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1058, 955);
            Controls.Add(treeViewMap);
            Controls.Add(groupBoxParking);
            Name = "Form1";
            Text = "Form1";
            groupBoxParking.ResumeLayout(false);
            groupBoxParking.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewSpot).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxParking;
        private GroupBox groupBox3;
        private Button buttonSearch;
        private Button buttonPark;
        private Button buttonMove;
        private Button buttonPickUp;
        private NumericUpDown numericUpDownNewSpot;
        private Label label6;
        private Label label2;
        private TextBox textBoxReg;
        private GroupBox groupBox2;
        private ListBox listBoxPickVehicleType;
        private TreeView treeViewMap;
        private Button buttonReloadPrices;
    }
}
