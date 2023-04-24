namespace PICsim.View
{
    partial class GUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            gui_gbMemory = new GroupBox();
            menuStrip1 = new MenuStrip();
            öffnenToolStripMenuItem = new ToolStripMenuItem();
            öffnenToolStripMenuItem1 = new ToolStripMenuItem();
            beendenToolStripMenuItem = new ToolStripMenuItem();
            checkedListBox1 = new CheckedListBox();
            gui_lWReg = new Label();
            gui_gbIO = new GroupBox();
            gui_lRB0 = new Label();
            gui_lRA0 = new Label();
            gui_lRB1 = new Label();
            gui_lRA1 = new Label();
            gui_lRA2 = new Label();
            gui_lRB2 = new Label();
            gui_lRB3 = new Label();
            gui_lRA3 = new Label();
            gui_lRA4 = new Label();
            gui_lRB4 = new Label();
            gui_lRB5 = new Label();
            gui_lRB6 = new Label();
            gui_lRB7 = new Label();
            label3 = new Label();
            label2 = new Label();
            gui_bRA4 = new Button();
            gui_bRA3 = new Button();
            gui_bRA2 = new Button();
            gui_bRA1 = new Button();
            gui_bRA0 = new Button();
            gui_bRB7 = new Button();
            gui_bRB6 = new Button();
            gui_bRB5 = new Button();
            gui_bRB4 = new Button();
            gui_bRB3 = new Button();
            gui_bRB2 = new Button();
            gui_bRB1 = new Button();
            gui_bRB0 = new Button();
            gui_gbStatus = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label51 = new Label();
            label49 = new Label();
            label47 = new Label();
            label46 = new Label();
            label43 = new Label();
            gui_lStatus7 = new Label();
            gui_lStatus6 = new Label();
            gui_lStatus5 = new Label();
            gui_lStatus1 = new Label();
            gui_lStatus2 = new Label();
            gui_lStatus0 = new Label();
            gui_lStatus3 = new Label();
            gui_lStatus4 = new Label();
            label6 = new Label();
            gui_lPC = new Label();
            label5 = new Label();
            label1 = new Label();
            gui_gbStack = new GroupBox();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            label37 = new Label();
            label38 = new Label();
            label39 = new Label();
            label40 = new Label();
            gui_lStack0 = new Label();
            gui_lStack1 = new Label();
            gui_lStack2 = new Label();
            gui_lStack6 = new Label();
            gui_lStack5 = new Label();
            gui_lStack7 = new Label();
            gui_lStack4 = new Label();
            gui_lStack3 = new Label();
            gui_gbInfo = new GroupBox();
            gui_lTime = new Label();
            gui_lFreq = new Label();
            gui_bStart = new Button();
            gui_bPause = new Button();
            gui_bStep = new Button();
            gui_bReset = new Button();
            menuStrip1.SuspendLayout();
            gui_gbIO.SuspendLayout();
            gui_gbStatus.SuspendLayout();
            gui_gbStack.SuspendLayout();
            gui_gbInfo.SuspendLayout();
            SuspendLayout();
            // 
            // gui_gbMemory
            // 
            gui_gbMemory.Enabled = false;
            gui_gbMemory.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            gui_gbMemory.Location = new Point(16, 49);
            gui_gbMemory.Margin = new Padding(4, 5, 4, 5);
            gui_gbMemory.Name = "gui_gbMemory";
            gui_gbMemory.Padding = new Padding(4, 5, 4, 5);
            gui_gbMemory.Size = new Size(425, 460);
            gui_gbMemory.TabIndex = 1;
            gui_gbMemory.TabStop = false;
            gui_gbMemory.Text = "Memory";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { öffnenToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1179, 30);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // öffnenToolStripMenuItem
            // 
            öffnenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { öffnenToolStripMenuItem1, beendenToolStripMenuItem });
            öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            öffnenToolStripMenuItem.Size = new Size(59, 24);
            öffnenToolStripMenuItem.Text = "Datei";
            // 
            // öffnenToolStripMenuItem1
            // 
            öffnenToolStripMenuItem1.Name = "öffnenToolStripMenuItem1";
            öffnenToolStripMenuItem1.Size = new Size(150, 26);
            öffnenToolStripMenuItem1.Text = "Öffnen";
            öffnenToolStripMenuItem1.Click += openToolStripMenuItem1_Click;
            // 
            // beendenToolStripMenuItem
            // 
            beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            beendenToolStripMenuItem.Size = new Size(150, 26);
            beendenToolStripMenuItem.Text = "Beenden";
            beendenToolStripMenuItem.Click += beendenToolStripMenuItem_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBox1.Location = new Point(16, 532);
            checkedListBox1.Margin = new Padding(4, 5, 4, 5);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(1135, 292);
            checkedListBox1.TabIndex = 3;
            checkedListBox1.ItemCheck += checkedListBox1_SelectedIndexChanged;
            // 
            // gui_lWReg
            // 
            gui_lWReg.AutoSize = true;
            gui_lWReg.BackColor = SystemColors.Control;
            gui_lWReg.Location = new Point(109, 77);
            gui_lWReg.Margin = new Padding(4, 0, 4, 0);
            gui_lWReg.Name = "gui_lWReg";
            gui_lWReg.Size = new Size(17, 20);
            gui_lWReg.TabIndex = 6;
            gui_lWReg.Text = "0";
            // 
            // gui_gbIO
            // 
            gui_gbIO.Controls.Add(gui_lRB0);
            gui_gbIO.Controls.Add(gui_lRA0);
            gui_gbIO.Controls.Add(gui_lRB1);
            gui_gbIO.Controls.Add(gui_lRA1);
            gui_gbIO.Controls.Add(gui_lRA2);
            gui_gbIO.Controls.Add(gui_lRB2);
            gui_gbIO.Controls.Add(gui_lRB3);
            gui_gbIO.Controls.Add(gui_lRA3);
            gui_gbIO.Controls.Add(gui_lRA4);
            gui_gbIO.Controls.Add(gui_lRB4);
            gui_gbIO.Controls.Add(gui_lRB5);
            gui_gbIO.Controls.Add(gui_lRB6);
            gui_gbIO.Controls.Add(gui_lRB7);
            gui_gbIO.Controls.Add(label3);
            gui_gbIO.Controls.Add(label2);
            gui_gbIO.Controls.Add(gui_bRA4);
            gui_gbIO.Controls.Add(gui_bRA3);
            gui_gbIO.Controls.Add(gui_bRA2);
            gui_gbIO.Controls.Add(gui_bRA1);
            gui_gbIO.Controls.Add(gui_bRA0);
            gui_gbIO.Controls.Add(gui_bRB7);
            gui_gbIO.Controls.Add(gui_bRB6);
            gui_gbIO.Controls.Add(gui_bRB5);
            gui_gbIO.Controls.Add(gui_bRB4);
            gui_gbIO.Controls.Add(gui_bRB3);
            gui_gbIO.Controls.Add(gui_bRB2);
            gui_gbIO.Controls.Add(gui_bRB1);
            gui_gbIO.Controls.Add(gui_bRB0);
            gui_gbIO.Enabled = false;
            gui_gbIO.Location = new Point(591, 49);
            gui_gbIO.Margin = new Padding(4, 5, 4, 5);
            gui_gbIO.Name = "gui_gbIO";
            gui_gbIO.Padding = new Padding(4, 5, 4, 5);
            gui_gbIO.Size = new Size(165, 460);
            gui_gbIO.TabIndex = 10;
            gui_gbIO.TabStop = false;
            gui_gbIO.Text = "IO";
            // 
            // gui_lRB0
            // 
            gui_lRB0.AutoSize = true;
            gui_lRB0.BackColor = SystemColors.Control;
            gui_lRB0.Location = new Point(84, 400);
            gui_lRB0.Margin = new Padding(4, 0, 4, 0);
            gui_lRB0.Name = "gui_lRB0";
            gui_lRB0.Size = new Size(13, 20);
            gui_lRB0.TabIndex = 27;
            gui_lRB0.Text = "I";
            // 
            // gui_lRA0
            // 
            gui_lRA0.AutoSize = true;
            gui_lRA0.BackColor = SystemColors.Control;
            gui_lRA0.Location = new Point(8, 400);
            gui_lRA0.Margin = new Padding(4, 0, 4, 0);
            gui_lRA0.Name = "gui_lRA0";
            gui_lRA0.Size = new Size(13, 20);
            gui_lRA0.TabIndex = 26;
            gui_lRA0.Text = "I";
            // 
            // gui_lRB1
            // 
            gui_lRB1.AutoSize = true;
            gui_lRB1.BackColor = SystemColors.Control;
            gui_lRB1.Location = new Point(84, 354);
            gui_lRB1.Margin = new Padding(4, 0, 4, 0);
            gui_lRB1.Name = "gui_lRB1";
            gui_lRB1.Size = new Size(13, 20);
            gui_lRB1.TabIndex = 25;
            gui_lRB1.Text = "I";
            // 
            // gui_lRA1
            // 
            gui_lRA1.AutoSize = true;
            gui_lRA1.BackColor = SystemColors.Control;
            gui_lRA1.Location = new Point(8, 354);
            gui_lRA1.Margin = new Padding(4, 0, 4, 0);
            gui_lRA1.Name = "gui_lRA1";
            gui_lRA1.Size = new Size(13, 20);
            gui_lRA1.TabIndex = 24;
            gui_lRA1.Text = "I";
            // 
            // gui_lRA2
            // 
            gui_lRA2.AutoSize = true;
            gui_lRA2.BackColor = SystemColors.Control;
            gui_lRA2.Location = new Point(8, 308);
            gui_lRA2.Margin = new Padding(4, 0, 4, 0);
            gui_lRA2.Name = "gui_lRA2";
            gui_lRA2.Size = new Size(13, 20);
            gui_lRA2.TabIndex = 23;
            gui_lRA2.Text = "I";
            // 
            // gui_lRB2
            // 
            gui_lRB2.AutoSize = true;
            gui_lRB2.BackColor = SystemColors.Control;
            gui_lRB2.Location = new Point(84, 308);
            gui_lRB2.Margin = new Padding(4, 0, 4, 0);
            gui_lRB2.Name = "gui_lRB2";
            gui_lRB2.Size = new Size(13, 20);
            gui_lRB2.TabIndex = 22;
            gui_lRB2.Text = "I";
            // 
            // gui_lRB3
            // 
            gui_lRB3.AutoSize = true;
            gui_lRB3.BackColor = SystemColors.Control;
            gui_lRB3.Location = new Point(84, 262);
            gui_lRB3.Margin = new Padding(4, 0, 4, 0);
            gui_lRB3.Name = "gui_lRB3";
            gui_lRB3.Size = new Size(13, 20);
            gui_lRB3.TabIndex = 21;
            gui_lRB3.Text = "I";
            // 
            // gui_lRA3
            // 
            gui_lRA3.AutoSize = true;
            gui_lRA3.BackColor = SystemColors.Control;
            gui_lRA3.Location = new Point(8, 262);
            gui_lRA3.Margin = new Padding(4, 0, 4, 0);
            gui_lRA3.Name = "gui_lRA3";
            gui_lRA3.Size = new Size(13, 20);
            gui_lRA3.TabIndex = 20;
            gui_lRA3.Text = "I";
            // 
            // gui_lRA4
            // 
            gui_lRA4.AutoSize = true;
            gui_lRA4.BackColor = SystemColors.Control;
            gui_lRA4.Location = new Point(8, 215);
            gui_lRA4.Margin = new Padding(4, 0, 4, 0);
            gui_lRA4.Name = "gui_lRA4";
            gui_lRA4.Size = new Size(13, 20);
            gui_lRA4.TabIndex = 19;
            gui_lRA4.Text = "I";
            // 
            // gui_lRB4
            // 
            gui_lRB4.AutoSize = true;
            gui_lRB4.BackColor = SystemColors.Control;
            gui_lRB4.Location = new Point(84, 215);
            gui_lRB4.Margin = new Padding(4, 0, 4, 0);
            gui_lRB4.Name = "gui_lRB4";
            gui_lRB4.Size = new Size(13, 20);
            gui_lRB4.TabIndex = 18;
            gui_lRB4.Text = "I";
            // 
            // gui_lRB5
            // 
            gui_lRB5.AutoSize = true;
            gui_lRB5.BackColor = SystemColors.Control;
            gui_lRB5.Location = new Point(84, 169);
            gui_lRB5.Margin = new Padding(4, 0, 4, 0);
            gui_lRB5.Name = "gui_lRB5";
            gui_lRB5.Size = new Size(13, 20);
            gui_lRB5.TabIndex = 17;
            gui_lRB5.Text = "I";
            // 
            // gui_lRB6
            // 
            gui_lRB6.AutoSize = true;
            gui_lRB6.BackColor = SystemColors.Control;
            gui_lRB6.Location = new Point(84, 123);
            gui_lRB6.Margin = new Padding(4, 0, 4, 0);
            gui_lRB6.Name = "gui_lRB6";
            gui_lRB6.Size = new Size(13, 20);
            gui_lRB6.TabIndex = 16;
            gui_lRB6.Text = "I";
            // 
            // gui_lRB7
            // 
            gui_lRB7.AutoSize = true;
            gui_lRB7.BackColor = SystemColors.Control;
            gui_lRB7.Location = new Point(84, 77);
            gui_lRB7.Margin = new Padding(4, 0, 4, 0);
            gui_lRB7.Name = "gui_lRB7";
            gui_lRB7.Size = new Size(13, 20);
            gui_lRB7.TabIndex = 15;
            gui_lRB7.Text = "I";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 28);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 14;
            label3.Text = "RB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 13;
            label2.Text = "RA";
            // 
            // gui_bRA4
            // 
            gui_bRA4.Location = new Point(29, 208);
            gui_bRA4.Margin = new Padding(4, 5, 4, 5);
            gui_bRA4.Name = "gui_bRA4";
            gui_bRA4.Size = new Size(40, 35);
            gui_bRA4.TabIndex = 12;
            gui_bRA4.Text = "0";
            gui_bRA4.UseVisualStyleBackColor = true;
            gui_bRA4.Click += gui_bRA_Click;
            // 
            // gui_bRA3
            // 
            gui_bRA3.Location = new Point(29, 254);
            gui_bRA3.Margin = new Padding(4, 5, 4, 5);
            gui_bRA3.Name = "gui_bRA3";
            gui_bRA3.Size = new Size(40, 35);
            gui_bRA3.TabIndex = 11;
            gui_bRA3.Text = "0";
            gui_bRA3.UseVisualStyleBackColor = true;
            gui_bRA3.Click += gui_bRA_Click;
            // 
            // gui_bRA2
            // 
            gui_bRA2.Location = new Point(29, 300);
            gui_bRA2.Margin = new Padding(4, 5, 4, 5);
            gui_bRA2.Name = "gui_bRA2";
            gui_bRA2.Size = new Size(40, 35);
            gui_bRA2.TabIndex = 10;
            gui_bRA2.Text = "0";
            gui_bRA2.UseVisualStyleBackColor = true;
            gui_bRA2.Click += gui_bRA_Click;
            // 
            // gui_bRA1
            // 
            gui_bRA1.Location = new Point(29, 346);
            gui_bRA1.Margin = new Padding(4, 5, 4, 5);
            gui_bRA1.Name = "gui_bRA1";
            gui_bRA1.Size = new Size(40, 35);
            gui_bRA1.TabIndex = 9;
            gui_bRA1.Text = "0";
            gui_bRA1.UseVisualStyleBackColor = true;
            gui_bRA1.Click += gui_bRA_Click;
            // 
            // gui_bRA0
            // 
            gui_bRA0.Location = new Point(29, 392);
            gui_bRA0.Margin = new Padding(4, 5, 4, 5);
            gui_bRA0.Name = "gui_bRA0";
            gui_bRA0.Size = new Size(40, 35);
            gui_bRA0.TabIndex = 8;
            gui_bRA0.Text = "0";
            gui_bRA0.UseVisualStyleBackColor = true;
            gui_bRA0.Click += gui_bRA_Click;
            // 
            // gui_bRB7
            // 
            gui_bRB7.Location = new Point(105, 69);
            gui_bRB7.Margin = new Padding(4, 5, 4, 5);
            gui_bRB7.Name = "gui_bRB7";
            gui_bRB7.Size = new Size(40, 35);
            gui_bRB7.TabIndex = 7;
            gui_bRB7.Text = "0";
            gui_bRB7.UseVisualStyleBackColor = true;
            gui_bRB7.Click += gui_bRB_Click;
            // 
            // gui_bRB6
            // 
            gui_bRB6.Location = new Point(105, 115);
            gui_bRB6.Margin = new Padding(4, 5, 4, 5);
            gui_bRB6.Name = "gui_bRB6";
            gui_bRB6.Size = new Size(40, 35);
            gui_bRB6.TabIndex = 6;
            gui_bRB6.Text = "0";
            gui_bRB6.UseVisualStyleBackColor = true;
            gui_bRB6.Click += gui_bRB_Click;
            // 
            // gui_bRB5
            // 
            gui_bRB5.Location = new Point(105, 162);
            gui_bRB5.Margin = new Padding(4, 5, 4, 5);
            gui_bRB5.Name = "gui_bRB5";
            gui_bRB5.Size = new Size(40, 35);
            gui_bRB5.TabIndex = 5;
            gui_bRB5.Text = "0";
            gui_bRB5.UseVisualStyleBackColor = true;
            gui_bRB5.Click += gui_bRB_Click;
            // 
            // gui_bRB4
            // 
            gui_bRB4.Location = new Point(105, 208);
            gui_bRB4.Margin = new Padding(4, 5, 4, 5);
            gui_bRB4.Name = "gui_bRB4";
            gui_bRB4.Size = new Size(40, 35);
            gui_bRB4.TabIndex = 4;
            gui_bRB4.Text = "0";
            gui_bRB4.UseVisualStyleBackColor = true;
            gui_bRB4.Click += gui_bRB_Click;
            // 
            // gui_bRB3
            // 
            gui_bRB3.Location = new Point(105, 254);
            gui_bRB3.Margin = new Padding(4, 5, 4, 5);
            gui_bRB3.Name = "gui_bRB3";
            gui_bRB3.Size = new Size(40, 35);
            gui_bRB3.TabIndex = 3;
            gui_bRB3.Text = "0";
            gui_bRB3.UseVisualStyleBackColor = true;
            gui_bRB3.Click += gui_bRB_Click;
            // 
            // gui_bRB2
            // 
            gui_bRB2.Location = new Point(105, 300);
            gui_bRB2.Margin = new Padding(4, 5, 4, 5);
            gui_bRB2.Name = "gui_bRB2";
            gui_bRB2.Size = new Size(40, 35);
            gui_bRB2.TabIndex = 2;
            gui_bRB2.Text = "0";
            gui_bRB2.UseVisualStyleBackColor = true;
            gui_bRB2.Click += gui_bRB_Click;
            // 
            // gui_bRB1
            // 
            gui_bRB1.Location = new Point(105, 346);
            gui_bRB1.Margin = new Padding(4, 5, 4, 5);
            gui_bRB1.Name = "gui_bRB1";
            gui_bRB1.Size = new Size(40, 35);
            gui_bRB1.TabIndex = 1;
            gui_bRB1.Text = "0";
            gui_bRB1.UseVisualStyleBackColor = true;
            gui_bRB1.Click += gui_bRB_Click;
            // 
            // gui_bRB0
            // 
            gui_bRB0.Location = new Point(105, 392);
            gui_bRB0.Margin = new Padding(4, 5, 4, 5);
            gui_bRB0.Name = "gui_bRB0";
            gui_bRB0.Size = new Size(40, 35);
            gui_bRB0.TabIndex = 0;
            gui_bRB0.Text = "0";
            gui_bRB0.UseVisualStyleBackColor = true;
            gui_bRB0.Click += gui_bRB_Click;
            // 
            // gui_gbStatus
            // 
            gui_gbStatus.Controls.Add(label8);
            gui_gbStatus.Controls.Add(label7);
            gui_gbStatus.Controls.Add(label4);
            gui_gbStatus.Controls.Add(label51);
            gui_gbStatus.Controls.Add(label49);
            gui_gbStatus.Controls.Add(label47);
            gui_gbStatus.Controls.Add(label46);
            gui_gbStatus.Controls.Add(label43);
            gui_gbStatus.Controls.Add(gui_lStatus7);
            gui_gbStatus.Controls.Add(gui_lStatus6);
            gui_gbStatus.Controls.Add(gui_lStatus5);
            gui_gbStatus.Controls.Add(gui_lStatus1);
            gui_gbStatus.Controls.Add(gui_lStatus2);
            gui_gbStatus.Controls.Add(gui_lStatus0);
            gui_gbStatus.Controls.Add(gui_lStatus3);
            gui_gbStatus.Controls.Add(gui_lStatus4);
            gui_gbStatus.Controls.Add(label6);
            gui_gbStatus.Controls.Add(gui_lPC);
            gui_gbStatus.Controls.Add(label5);
            gui_gbStatus.Controls.Add(label1);
            gui_gbStatus.Controls.Add(gui_lWReg);
            gui_gbStatus.Enabled = false;
            gui_gbStatus.Location = new Point(764, 49);
            gui_gbStatus.Margin = new Padding(4, 5, 4, 5);
            gui_gbStatus.Name = "gui_gbStatus";
            gui_gbStatus.Padding = new Padding(4, 5, 4, 5);
            gui_gbStatus.Size = new Size(187, 460);
            gui_gbStatus.TabIndex = 12;
            gui_gbStatus.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 77);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(30, 20);
            label8.TabIndex = 50;
            label8.Text = "IRP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 123);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 49;
            label7.Text = "RP1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 169);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 48;
            label4.Text = "RP0";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Location = new Point(13, 215);
            label51.Margin = new Padding(4, 0, 4, 0);
            label51.Name = "label51";
            label51.Size = new Size(33, 20);
            label51.TabIndex = 47;
            label51.Text = "/TO";
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Location = new Point(13, 262);
            label49.Margin = new Padding(4, 0, 4, 0);
            label49.Name = "label49";
            label49.Size = new Size(34, 20);
            label49.TabIndex = 45;
            label49.Text = "/PD";
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Location = new Point(31, 308);
            label47.Margin = new Padding(4, 0, 4, 0);
            label47.Name = "label47";
            label47.Size = new Size(18, 20);
            label47.TabIndex = 43;
            label47.Text = "Z";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(20, 354);
            label46.Margin = new Padding(4, 0, 4, 0);
            label46.Name = "label46";
            label46.Size = new Size(29, 20);
            label46.TabIndex = 42;
            label46.Text = "DC";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(31, 400);
            label43.Margin = new Padding(4, 0, 4, 0);
            label43.Name = "label43";
            label43.Size = new Size(18, 20);
            label43.TabIndex = 39;
            label43.Text = "C";
            // 
            // gui_lStatus7
            // 
            gui_lStatus7.AutoSize = true;
            gui_lStatus7.Location = new Point(57, 77);
            gui_lStatus7.Margin = new Padding(4, 0, 4, 0);
            gui_lStatus7.Name = "gui_lStatus7";
            gui_lStatus7.Size = new Size(17, 20);
            gui_lStatus7.TabIndex = 27;
            gui_lStatus7.Text = "0";
            // 
            // gui_lStatus6
            // 
            gui_lStatus6.AutoSize = true;
            gui_lStatus6.Location = new Point(57, 123);
            gui_lStatus6.Margin = new Padding(4, 0, 4, 0);
            gui_lStatus6.Name = "gui_lStatus6";
            gui_lStatus6.Size = new Size(17, 20);
            gui_lStatus6.TabIndex = 26;
            gui_lStatus6.Text = "0";
            // 
            // gui_lStatus5
            // 
            gui_lStatus5.AutoSize = true;
            gui_lStatus5.Location = new Point(57, 169);
            gui_lStatus5.Margin = new Padding(4, 0, 4, 0);
            gui_lStatus5.Name = "gui_lStatus5";
            gui_lStatus5.Size = new Size(17, 20);
            gui_lStatus5.TabIndex = 25;
            gui_lStatus5.Text = "0";
            // 
            // gui_lStatus1
            // 
            gui_lStatus1.AutoSize = true;
            gui_lStatus1.BackColor = SystemColors.Control;
            gui_lStatus1.Location = new Point(57, 354);
            gui_lStatus1.Margin = new Padding(4, 0, 4, 0);
            gui_lStatus1.Name = "gui_lStatus1";
            gui_lStatus1.Size = new Size(17, 20);
            gui_lStatus1.TabIndex = 24;
            gui_lStatus1.Text = "0";
            // 
            // gui_lStatus2
            // 
            gui_lStatus2.AutoSize = true;
            gui_lStatus2.BackColor = SystemColors.Control;
            gui_lStatus2.Location = new Point(57, 308);
            gui_lStatus2.Margin = new Padding(4, 0, 4, 0);
            gui_lStatus2.Name = "gui_lStatus2";
            gui_lStatus2.Size = new Size(17, 20);
            gui_lStatus2.TabIndex = 23;
            gui_lStatus2.Text = "0";
            // 
            // gui_lStatus0
            // 
            gui_lStatus0.AutoSize = true;
            gui_lStatus0.BackColor = SystemColors.Control;
            gui_lStatus0.Location = new Point(57, 400);
            gui_lStatus0.Margin = new Padding(4, 0, 4, 0);
            gui_lStatus0.Name = "gui_lStatus0";
            gui_lStatus0.Size = new Size(17, 20);
            gui_lStatus0.TabIndex = 22;
            gui_lStatus0.Text = "0";
            // 
            // gui_lStatus3
            // 
            gui_lStatus3.AutoSize = true;
            gui_lStatus3.Location = new Point(57, 262);
            gui_lStatus3.Margin = new Padding(4, 0, 4, 0);
            gui_lStatus3.Name = "gui_lStatus3";
            gui_lStatus3.Size = new Size(17, 20);
            gui_lStatus3.TabIndex = 21;
            gui_lStatus3.Text = "0";
            // 
            // gui_lStatus4
            // 
            gui_lStatus4.AutoSize = true;
            gui_lStatus4.Location = new Point(57, 215);
            gui_lStatus4.Margin = new Padding(4, 0, 4, 0);
            gui_lStatus4.Name = "gui_lStatus4";
            gui_lStatus4.Size = new Size(17, 20);
            gui_lStatus4.TabIndex = 20;
            gui_lStatus4.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 28);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 17;
            label6.Text = "Status";
            // 
            // gui_lPC
            // 
            gui_lPC.AutoSize = true;
            gui_lPC.BackColor = SystemColors.Control;
            gui_lPC.Location = new Point(141, 77);
            gui_lPC.Margin = new Padding(4, 0, 4, 0);
            gui_lPC.Name = "gui_lPC";
            gui_lPC.Size = new Size(17, 20);
            gui_lPC.TabIndex = 15;
            gui_lPC.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(141, 28);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(26, 20);
            label5.TabIndex = 14;
            label5.Text = "PC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(23, 20);
            label1.TabIndex = 12;
            label1.Text = "W";
            // 
            // gui_gbStack
            // 
            gui_gbStack.Controls.Add(label33);
            gui_gbStack.Controls.Add(label34);
            gui_gbStack.Controls.Add(label35);
            gui_gbStack.Controls.Add(label36);
            gui_gbStack.Controls.Add(label37);
            gui_gbStack.Controls.Add(label38);
            gui_gbStack.Controls.Add(label39);
            gui_gbStack.Controls.Add(label40);
            gui_gbStack.Controls.Add(gui_lStack0);
            gui_gbStack.Controls.Add(gui_lStack1);
            gui_gbStack.Controls.Add(gui_lStack2);
            gui_gbStack.Controls.Add(gui_lStack6);
            gui_gbStack.Controls.Add(gui_lStack5);
            gui_gbStack.Controls.Add(gui_lStack7);
            gui_gbStack.Controls.Add(gui_lStack4);
            gui_gbStack.Controls.Add(gui_lStack3);
            gui_gbStack.Enabled = false;
            gui_gbStack.Location = new Point(453, 49);
            gui_gbStack.Margin = new Padding(4, 5, 4, 5);
            gui_gbStack.Name = "gui_gbStack";
            gui_gbStack.Padding = new Padding(4, 5, 4, 5);
            gui_gbStack.Size = new Size(129, 460);
            gui_gbStack.TabIndex = 13;
            gui_gbStack.TabStop = false;
            gui_gbStack.Text = "Stack";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(29, 77);
            label33.Margin = new Padding(4, 0, 4, 0);
            label33.Name = "label33";
            label33.Size = new Size(17, 20);
            label33.TabIndex = 43;
            label33.Text = "0";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(29, 123);
            label34.Margin = new Padding(4, 0, 4, 0);
            label34.Name = "label34";
            label34.Size = new Size(17, 20);
            label34.TabIndex = 42;
            label34.Text = "1";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(29, 169);
            label35.Margin = new Padding(4, 0, 4, 0);
            label35.Name = "label35";
            label35.Size = new Size(17, 20);
            label35.TabIndex = 41;
            label35.Text = "2";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(29, 354);
            label36.Margin = new Padding(4, 0, 4, 0);
            label36.Name = "label36";
            label36.Size = new Size(17, 20);
            label36.TabIndex = 40;
            label36.Text = "6";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(29, 308);
            label37.Margin = new Padding(4, 0, 4, 0);
            label37.Name = "label37";
            label37.Size = new Size(17, 20);
            label37.TabIndex = 39;
            label37.Text = "5";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(29, 400);
            label38.Margin = new Padding(4, 0, 4, 0);
            label38.Name = "label38";
            label38.Size = new Size(17, 20);
            label38.TabIndex = 38;
            label38.Text = "7";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(29, 262);
            label39.Margin = new Padding(4, 0, 4, 0);
            label39.Name = "label39";
            label39.Size = new Size(17, 20);
            label39.TabIndex = 37;
            label39.Text = "4";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(29, 215);
            label40.Margin = new Padding(4, 0, 4, 0);
            label40.Name = "label40";
            label40.Size = new Size(17, 20);
            label40.TabIndex = 36;
            label40.Text = "3";
            // 
            // gui_lStack0
            // 
            gui_lStack0.AutoSize = true;
            gui_lStack0.Location = new Point(77, 77);
            gui_lStack0.Margin = new Padding(4, 0, 4, 0);
            gui_lStack0.Name = "gui_lStack0";
            gui_lStack0.Size = new Size(17, 20);
            gui_lStack0.TabIndex = 35;
            gui_lStack0.Text = "0";
            // 
            // gui_lStack1
            // 
            gui_lStack1.AutoSize = true;
            gui_lStack1.Location = new Point(77, 123);
            gui_lStack1.Margin = new Padding(4, 0, 4, 0);
            gui_lStack1.Name = "gui_lStack1";
            gui_lStack1.Size = new Size(17, 20);
            gui_lStack1.TabIndex = 34;
            gui_lStack1.Text = "0";
            // 
            // gui_lStack2
            // 
            gui_lStack2.AutoSize = true;
            gui_lStack2.Location = new Point(77, 169);
            gui_lStack2.Margin = new Padding(4, 0, 4, 0);
            gui_lStack2.Name = "gui_lStack2";
            gui_lStack2.Size = new Size(17, 20);
            gui_lStack2.TabIndex = 33;
            gui_lStack2.Text = "0";
            // 
            // gui_lStack6
            // 
            gui_lStack6.AutoSize = true;
            gui_lStack6.Location = new Point(77, 354);
            gui_lStack6.Margin = new Padding(4, 0, 4, 0);
            gui_lStack6.Name = "gui_lStack6";
            gui_lStack6.Size = new Size(17, 20);
            gui_lStack6.TabIndex = 32;
            gui_lStack6.Text = "0";
            // 
            // gui_lStack5
            // 
            gui_lStack5.AutoSize = true;
            gui_lStack5.Location = new Point(77, 308);
            gui_lStack5.Margin = new Padding(4, 0, 4, 0);
            gui_lStack5.Name = "gui_lStack5";
            gui_lStack5.Size = new Size(17, 20);
            gui_lStack5.TabIndex = 31;
            gui_lStack5.Text = "0";
            // 
            // gui_lStack7
            // 
            gui_lStack7.AutoSize = true;
            gui_lStack7.Location = new Point(77, 400);
            gui_lStack7.Margin = new Padding(4, 0, 4, 0);
            gui_lStack7.Name = "gui_lStack7";
            gui_lStack7.Size = new Size(17, 20);
            gui_lStack7.TabIndex = 30;
            gui_lStack7.Text = "0";
            // 
            // gui_lStack4
            // 
            gui_lStack4.AutoSize = true;
            gui_lStack4.Location = new Point(77, 262);
            gui_lStack4.Margin = new Padding(4, 0, 4, 0);
            gui_lStack4.Name = "gui_lStack4";
            gui_lStack4.Size = new Size(17, 20);
            gui_lStack4.TabIndex = 29;
            gui_lStack4.Text = "0";
            // 
            // gui_lStack3
            // 
            gui_lStack3.AutoSize = true;
            gui_lStack3.Location = new Point(77, 215);
            gui_lStack3.Margin = new Padding(4, 0, 4, 0);
            gui_lStack3.Name = "gui_lStack3";
            gui_lStack3.Size = new Size(17, 20);
            gui_lStack3.TabIndex = 28;
            gui_lStack3.Text = "0";
            // 
            // gui_gbInfo
            // 
            gui_gbInfo.Controls.Add(gui_lTime);
            gui_gbInfo.Controls.Add(gui_lFreq);
            gui_gbInfo.Enabled = false;
            gui_gbInfo.Location = new Point(959, 49);
            gui_gbInfo.Margin = new Padding(4, 5, 4, 5);
            gui_gbInfo.Name = "gui_gbInfo";
            gui_gbInfo.Padding = new Padding(4, 5, 4, 5);
            gui_gbInfo.Size = new Size(193, 126);
            gui_gbInfo.TabIndex = 14;
            gui_gbInfo.TabStop = false;
            gui_gbInfo.Text = "Info";
            // 
            // gui_lTime
            // 
            gui_lTime.AutoSize = true;
            gui_lTime.Location = new Point(21, 83);
            gui_lTime.Margin = new Padding(4, 0, 4, 0);
            gui_lTime.Name = "gui_lTime";
            gui_lTime.Size = new Size(61, 20);
            gui_lTime.TabIndex = 3;
            gui_lTime.Text = "Laufzeit";
            // 
            // gui_lFreq
            // 
            gui_lFreq.AutoSize = true;
            gui_lFreq.Location = new Point(21, 40);
            gui_lFreq.Margin = new Padding(4, 0, 4, 0);
            gui_lFreq.Name = "gui_lFreq";
            gui_lFreq.Size = new Size(119, 20);
            gui_lFreq.TabIndex = 0;
            gui_lFreq.Text = "Frequenz: 4 MHz";
            // 
            // gui_bStart
            // 
            gui_bStart.Enabled = false;
            gui_bStart.Location = new Point(959, 205);
            gui_bStart.Margin = new Padding(4, 5, 4, 5);
            gui_bStart.Name = "gui_bStart";
            gui_bStart.Size = new Size(193, 69);
            gui_bStart.TabIndex = 8;
            gui_bStart.Text = "Start";
            gui_bStart.UseVisualStyleBackColor = true;
            gui_bStart.Click += gui_bStart_Click;
            // 
            // gui_bPause
            // 
            gui_bPause.Enabled = false;
            gui_bPause.Location = new Point(959, 283);
            gui_bPause.Margin = new Padding(4, 5, 4, 5);
            gui_bPause.Name = "gui_bPause";
            gui_bPause.Size = new Size(193, 69);
            gui_bPause.TabIndex = 7;
            gui_bPause.Text = "Pause";
            gui_bPause.UseVisualStyleBackColor = true;
            gui_bPause.Click += gui_bPause_Click;
            // 
            // gui_bStep
            // 
            gui_bStep.Enabled = false;
            gui_bStep.Location = new Point(959, 362);
            gui_bStep.Margin = new Padding(4, 5, 4, 5);
            gui_bStep.Name = "gui_bStep";
            gui_bStep.Size = new Size(193, 69);
            gui_bStep.TabIndex = 4;
            gui_bStep.Text = "Einzelschritt";
            gui_bStep.UseVisualStyleBackColor = true;
            gui_bStep.Click += gui_bStep_Click;
            // 
            // gui_bReset
            // 
            gui_bReset.Enabled = false;
            gui_bReset.Location = new Point(959, 440);
            gui_bReset.Margin = new Padding(4, 5, 4, 5);
            gui_bReset.Name = "gui_bReset";
            gui_bReset.Size = new Size(193, 69);
            gui_bReset.TabIndex = 16;
            gui_bReset.Text = "Reset";
            gui_bReset.UseVisualStyleBackColor = true;
            gui_bReset.Click += gui_bReset_Click;
            // 
            // GUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1179, 865);
            Controls.Add(gui_bReset);
            Controls.Add(gui_gbInfo);
            Controls.Add(gui_gbStack);
            Controls.Add(gui_gbStatus);
            Controls.Add(gui_gbIO);
            Controls.Add(gui_bStart);
            Controls.Add(gui_bPause);
            Controls.Add(gui_bStep);
            Controls.Add(checkedListBox1);
            Controls.Add(gui_gbMemory);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "GUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PICsim";
            Load += GUI_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gui_gbIO.ResumeLayout(false);
            gui_gbIO.PerformLayout();
            gui_gbStatus.ResumeLayout(false);
            gui_gbStatus.PerformLayout();
            gui_gbStack.ResumeLayout(false);
            gui_gbStack.PerformLayout();
            gui_gbInfo.ResumeLayout(false);
            gui_gbInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox gui_gbMemory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button gui_bStep;
        private System.Windows.Forms.Label gui_lWReg;
        private System.Windows.Forms.Button gui_bPause;
        private System.Windows.Forms.Button gui_bStart;
        private System.Windows.Forms.GroupBox gui_gbIO;
        private System.Windows.Forms.Button gui_bRB5;
        private System.Windows.Forms.Button gui_bRB4;
        private System.Windows.Forms.Button gui_bRB3;
        private System.Windows.Forms.Button gui_bRB2;
        private System.Windows.Forms.Button gui_bRB1;
        private System.Windows.Forms.Button gui_bRB0;
        private System.Windows.Forms.Button gui_bRB6;
        private System.Windows.Forms.Button gui_bRA4;
        private System.Windows.Forms.Button gui_bRA3;
        private System.Windows.Forms.Button gui_bRA2;
        private System.Windows.Forms.Button gui_bRA1;
        private System.Windows.Forms.Button gui_bRA0;
        private System.Windows.Forms.Button gui_bRB7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gui_lRB0;
        private System.Windows.Forms.Label gui_lRA0;
        private System.Windows.Forms.Label gui_lRB1;
        private System.Windows.Forms.Label gui_lRA1;
        private System.Windows.Forms.Label gui_lRA2;
        private System.Windows.Forms.Label gui_lRB2;
        private System.Windows.Forms.Label gui_lRB3;
        private System.Windows.Forms.Label gui_lRA3;
        private System.Windows.Forms.Label gui_lRA4;
        private System.Windows.Forms.Label gui_lRB4;
        private System.Windows.Forms.Label gui_lRB5;
        private System.Windows.Forms.Label gui_lRB6;
        private System.Windows.Forms.Label gui_lRB7;
        private System.Windows.Forms.GroupBox gui_gbStatus;
        private System.Windows.Forms.Label gui_lPC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label gui_lStatus7;
        private System.Windows.Forms.Label gui_lStatus6;
        private System.Windows.Forms.Label gui_lStatus5;
        private System.Windows.Forms.Label gui_lStatus1;
        private System.Windows.Forms.Label gui_lStatus2;
        private System.Windows.Forms.Label gui_lStatus0;
        private System.Windows.Forms.Label gui_lStatus3;
        private System.Windows.Forms.Label gui_lStatus4;
        private System.Windows.Forms.GroupBox gui_gbStack;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label gui_lStack0;
        private System.Windows.Forms.Label gui_lStack1;
        private System.Windows.Forms.Label gui_lStack2;
        private System.Windows.Forms.Label gui_lStack6;
        private System.Windows.Forms.Label gui_lStack5;
        private System.Windows.Forms.Label gui_lStack7;
        private System.Windows.Forms.Label gui_lStack4;
        private System.Windows.Forms.Label gui_lStack3;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.GroupBox gui_gbInfo;
        private System.Windows.Forms.Label gui_lTime;
        private System.Windows.Forms.Label gui_lFreq;
        private System.Windows.Forms.Button gui_bReset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}