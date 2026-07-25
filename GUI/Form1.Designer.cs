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
            tabControl1 = new TabControl();
            tabPageUser = new TabPage();
            listBoxUser = new ListBox();
            groupBoxParking = new GroupBox();
            numericUpDownNewSpot = new NumericUpDown();
            label6 = new Label();
            buttonMove = new Button();
            buttonPickUp = new Button();
            buttonPark = new Button();
            label2 = new Label();
            textBoxReg = new TextBox();
            groupBox2 = new GroupBox();
            tabPageAdmin = new TabPage();
            groupBox3 = new GroupBox();
            buttonRemove = new Button();
            buttonSearch = new Button();
            label5 = new Label();
            textBoxTools = new TextBox();
            groupBox1 = new GroupBox();
            textBoxMC = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBoxEmpty = new TextBox();
            textBoxCars = new TextBox();
            label1 = new Label();
            listBoxAdmin = new ListBox();
            listBoxPickVehicleType = new ListBox();
            tabControl1.SuspendLayout();
            tabPageUser.SuspendLayout();
            groupBoxParking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewSpot).BeginInit();
            groupBox2.SuspendLayout();
            tabPageAdmin.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageUser);
            tabControl1.Controls.Add(tabPageAdmin);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1058, 955);
            tabControl1.TabIndex = 0;
            // 
            // tabPageUser
            // 
            tabPageUser.AutoScroll = true;
            tabPageUser.Controls.Add(listBoxUser);
            tabPageUser.Controls.Add(groupBoxParking);
            tabPageUser.Location = new Point(4, 29);
            tabPageUser.Name = "tabPageUser";
            tabPageUser.Padding = new Padding(3);
            tabPageUser.Size = new Size(1050, 922);
            tabPageUser.TabIndex = 0;
            tabPageUser.Text = "User";
            tabPageUser.UseVisualStyleBackColor = true;
            // 
            // listBoxUser
            // 
            listBoxUser.Dock = DockStyle.Left;
            listBoxUser.FormattingEnabled = true;
            listBoxUser.HorizontalScrollbar = true;
            listBoxUser.Location = new Point(389, 3);
            listBoxUser.Margin = new Padding(3, 4, 3, 4);
            listBoxUser.Name = "listBoxUser";
            listBoxUser.Size = new Size(305, 916);
            listBoxUser.TabIndex = 7;
            // 
            // groupBoxParking
            // 
            groupBoxParking.Controls.Add(numericUpDownNewSpot);
            groupBoxParking.Controls.Add(label6);
            groupBoxParking.Controls.Add(buttonMove);
            groupBoxParking.Controls.Add(buttonPickUp);
            groupBoxParking.Controls.Add(buttonPark);
            groupBoxParking.Controls.Add(label2);
            groupBoxParking.Controls.Add(textBoxReg);
            groupBoxParking.Controls.Add(groupBox2);
            groupBoxParking.Dock = DockStyle.Left;
            groupBoxParking.Location = new Point(3, 3);
            groupBoxParking.Margin = new Padding(3, 4, 3, 4);
            groupBoxParking.Name = "groupBoxParking";
            groupBoxParking.Padding = new Padding(3, 4, 3, 4);
            groupBoxParking.Size = new Size(386, 916);
            groupBoxParking.TabIndex = 6;
            groupBoxParking.TabStop = false;
            groupBoxParking.Text = "Parking";
            // 
            // numericUpDownNewSpot
            // 
            numericUpDownNewSpot.Location = new Point(160, 253);
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
            label6.Location = new Point(3, 260);
            label6.Name = "label6";
            label6.Size = new Size(151, 20);
            label6.TabIndex = 9;
            label6.Text = "Move to Spot (1-100)";
            // 
            // buttonMove
            // 
            buttonMove.Location = new Point(198, 303);
            buttonMove.Margin = new Padding(3, 4, 3, 4);
            buttonMove.Name = "buttonMove";
            buttonMove.Size = new Size(86, 31);
            buttonMove.TabIndex = 7;
            buttonMove.Text = "Move";
            buttonMove.UseVisualStyleBackColor = true;
            buttonMove.Click += buttonMove_Click;
            // 
            // buttonPickUp
            // 
            buttonPickUp.Location = new Point(105, 303);
            buttonPickUp.Margin = new Padding(3, 4, 3, 4);
            buttonPickUp.Name = "buttonPickUp";
            buttonPickUp.Size = new Size(86, 31);
            buttonPickUp.TabIndex = 6;
            buttonPickUp.Text = "PickUp";
            buttonPickUp.UseVisualStyleBackColor = true;
            buttonPickUp.Click += buttonPickUp_Click;
            // 
            // buttonPark
            // 
            buttonPark.Location = new Point(13, 303);
            buttonPark.Margin = new Padding(3, 4, 3, 4);
            buttonPark.Name = "buttonPark";
            buttonPark.Size = new Size(86, 31);
            buttonPark.TabIndex = 5;
            buttonPark.Text = "Park";
            buttonPark.UseVisualStyleBackColor = true;
            buttonPark.Click += ButtonPark_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 215);
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
            groupBox2.Enter += groupBox2_Enter;
            // 
            // tabPageAdmin
            // 
            tabPageAdmin.Controls.Add(groupBox3);
            tabPageAdmin.Controls.Add(groupBox1);
            tabPageAdmin.Controls.Add(listBoxAdmin);
            tabPageAdmin.Location = new Point(4, 29);
            tabPageAdmin.Name = "tabPageAdmin";
            tabPageAdmin.Padding = new Padding(3);
            tabPageAdmin.Size = new Size(1050, 922);
            tabPageAdmin.TabIndex = 1;
            tabPageAdmin.Text = "Admin";
            tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonRemove);
            groupBox3.Controls.Add(buttonSearch);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(textBoxTools);
            groupBox3.Location = new Point(9, 7);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(342, 163);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tools";
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(203, 105);
            buttonRemove.Margin = new Padding(3, 4, 3, 4);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(114, 31);
            buttonRemove.TabIndex = 15;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(7, 105);
            buttonSearch.Margin = new Padding(3, 4, 3, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(190, 31);
            buttonSearch.TabIndex = 14;
            buttonSearch.Text = "Search For Parked Vehicle";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 68);
            label5.Name = "label5";
            label5.Size = new Size(209, 20);
            label5.TabIndex = 13;
            label5.Text = "Registration Number(ABC123)";
            // 
            // textBoxTools
            // 
            textBoxTools.CharacterCasing = CharacterCasing.Upper;
            textBoxTools.Location = new Point(221, 61);
            textBoxTools.Margin = new Padding(3, 4, 3, 4);
            textBoxTools.MaxLength = 10;
            textBoxTools.Name = "textBoxTools";
            textBoxTools.PlaceholderText = "ABC123";
            textBoxTools.Size = new Size(114, 27);
            textBoxTools.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxMC);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxEmpty);
            groupBox1.Controls.Add(textBoxCars);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(357, 7);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(230, 163);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Stats";
            // 
            // textBoxMC
            // 
            textBoxMC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxMC.Location = new Point(109, 68);
            textBoxMC.Margin = new Padding(3, 4, 3, 4);
            textBoxMC.Name = "textBoxMC";
            textBoxMC.ReadOnly = true;
            textBoxMC.Size = new Size(114, 27);
            textBoxMC.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 79);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 12;
            label4.Text = "MC parked: ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(7, 117);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 9;
            label3.Text = "Empty Spots: ";
            // 
            // textBoxEmpty
            // 
            textBoxEmpty.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxEmpty.Location = new Point(109, 107);
            textBoxEmpty.Margin = new Padding(3, 4, 3, 4);
            textBoxEmpty.Name = "textBoxEmpty";
            textBoxEmpty.ReadOnly = true;
            textBoxEmpty.Size = new Size(114, 27);
            textBoxEmpty.TabIndex = 11;
            // 
            // textBoxCars
            // 
            textBoxCars.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxCars.Location = new Point(109, 29);
            textBoxCars.Margin = new Padding(3, 4, 3, 4);
            textBoxCars.Name = "textBoxCars";
            textBoxCars.ReadOnly = true;
            textBoxCars.Size = new Size(114, 27);
            textBoxCars.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 40);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 8;
            label1.Text = "Cars parked: ";
            // 
            // listBoxAdmin
            // 
            listBoxAdmin.Dock = DockStyle.Right;
            listBoxAdmin.FormattingEnabled = true;
            listBoxAdmin.HorizontalScrollbar = true;
            listBoxAdmin.Location = new Point(590, 3);
            listBoxAdmin.Margin = new Padding(3, 4, 3, 4);
            listBoxAdmin.Name = "listBoxAdmin";
            listBoxAdmin.ScrollAlwaysVisible = true;
            listBoxAdmin.Size = new Size(457, 916);
            listBoxAdmin.TabIndex = 0;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1058, 955);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPageUser.ResumeLayout(false);
            groupBoxParking.ResumeLayout(false);
            groupBoxParking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewSpot).EndInit();
            groupBox2.ResumeLayout(false);
            tabPageAdmin.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageUser;
        private TabPage tabPageAdmin;
        private GroupBox groupBox2;
        private GroupBox groupBoxParking;
        private Label label2;
        private TextBox textBoxReg;
        private Button buttonPickUp;
        private Button buttonPark;
        private ListBox listBoxUser;
        private ListBox listBoxAdmin;
        private GroupBox groupBox1;
        private TextBox textBoxMC;
        private Label label4;
        private Label label3;
        private TextBox textBoxEmpty;
        private TextBox textBoxCars;
        private Label label1;
        private GroupBox groupBox3;
        private Button buttonSearch;
        private Label label5;
        private TextBox textBoxTools;
        private Button buttonRemove;
        private Button buttonMove;
        private Label label6;
        private NumericUpDown numericUpDownNewSpot;
        private ListBox listBoxPickVehicleType;
    }
}
