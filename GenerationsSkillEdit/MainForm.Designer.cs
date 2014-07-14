namespace GenerationsSkillEdit
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skill5Select = new System.Windows.Forms.ComboBox();
            this.skill4Select = new System.Windows.Forms.ComboBox();
            this.skill3Select = new System.Windows.Forms.ComboBox();
            this.skill2Select = new System.Windows.Forms.ComboBox();
            this.skill1Select = new System.Windows.Forms.ComboBox();
            this.skillSetSelect = new System.Windows.Forms.ComboBox();
            this.characterSelect = new System.Windows.Forms.ComboBox();
            this.skillSetNameSelect1 = new System.Windows.Forms.ComboBox();
            this.skillSetNameSelect2 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 13);
            label1.TabIndex = 0;
            label1.Text = "Character:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 36);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 13);
            label2.TabIndex = 2;
            label2.Text = "Skill set:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 117);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 13);
            label3.TabIndex = 4;
            label3.Text = "Skill 1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 144);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 13);
            label4.TabIndex = 6;
            label4.Text = "Skill 2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 171);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(38, 13);
            label5.TabIndex = 8;
            label5.Text = "Skill 3:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 198);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(38, 13);
            label6.TabIndex = 10;
            label6.Text = "Skill 4:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(12, 225);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(38, 13);
            label7.TabIndex = 12;
            label7.Text = "Skill 5:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.recentFilesToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // recentFilesToolStripMenuItem
            // 
            this.recentFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem});
            this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.recentFilesToolStripMenuItem.Text = "&Recent Files";
            this.recentFilesToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.recentFilesToolStripMenuItem_DropDownItemClicked);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Enabled = false;
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.noneToolStripMenuItem.Text = "(none)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(label9);
            this.panel1.Controls.Add(this.skillSetNameSelect2);
            this.panel1.Controls.Add(this.skillSetNameSelect1);
            this.panel1.Controls.Add(label8);
            this.panel1.Controls.Add(this.skill5Select);
            this.panel1.Controls.Add(label7);
            this.panel1.Controls.Add(this.skill4Select);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(this.skill3Select);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(this.skill2Select);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.skill1Select);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.skillSetSelect);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.characterSelect);
            this.panel1.Controls.Add(label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(284, 255);
            this.panel1.TabIndex = 1;
            // 
            // skill5Select
            // 
            this.skill5Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skill5Select.FormattingEnabled = true;
            this.skill5Select.Items.AddRange(new object[] {
            "None",
            "Unused",
            "Unused",
            "Unused",
            "Unused",
            "Power Break",
            "Sure Footed",
            "Safety Net",
            "Last Chance",
            "Unused",
            "10 Second Rings",
            "Athleticism",
            "Time Brake",
            "Super Sonic",
            "Fire Shield",
            "Aqua Shield",
            "Thunder Shield",
            "Twin-Spin Attack",
            "Invincible Start",
            "Shield",
            "Power Sneakers",
            "Long Spin Dash",
            "Treasure Scanner",
            "Homing Attack",
            "Hercules Strength",
            "Breath Holder",
            "Boardmaster",
            "Ring Time",
            "Blast Off",
            "Speed Up",
            "Direct Jump",
            "Power Stomp",
            "Quick Slide",
            "Acceleration",
            "Smasher Bonus",
            "Ring Bonus",
            "Boost Gauge Up",
            "Serial Homing",
            "Auto-Gauge",
            "Gauge Rebooter",
            "Trick Mastery",
            "Endless Boost"});
            this.skill5Select.Location = new System.Drawing.Point(74, 222);
            this.skill5Select.Name = "skill5Select";
            this.skill5Select.Size = new System.Drawing.Size(121, 21);
            this.skill5Select.TabIndex = 13;
            this.skill5Select.SelectedIndexChanged += new System.EventHandler(this.skill5Select_SelectedIndexChanged);
            // 
            // skill4Select
            // 
            this.skill4Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skill4Select.FormattingEnabled = true;
            this.skill4Select.Items.AddRange(new object[] {
            "None",
            "Unused",
            "Unused",
            "Unused",
            "Unused",
            "Power Break",
            "Sure Footed",
            "Safety Net",
            "Last Chance",
            "Unused",
            "10 Second Rings",
            "Athleticism",
            "Time Brake",
            "Super Sonic",
            "Fire Shield",
            "Aqua Shield",
            "Thunder Shield",
            "Twin-Spin Attack",
            "Invincible Start",
            "Shield",
            "Power Sneakers",
            "Long Spin Dash",
            "Treasure Scanner",
            "Homing Attack",
            "Hercules Strength",
            "Breath Holder",
            "Boardmaster",
            "Ring Time",
            "Blast Off",
            "Speed Up",
            "Direct Jump",
            "Power Stomp",
            "Quick Slide",
            "Acceleration",
            "Smasher Bonus",
            "Ring Bonus",
            "Boost Gauge Up",
            "Serial Homing",
            "Auto-Gauge",
            "Gauge Rebooter",
            "Trick Mastery",
            "Endless Boost"});
            this.skill4Select.Location = new System.Drawing.Point(74, 195);
            this.skill4Select.Name = "skill4Select";
            this.skill4Select.Size = new System.Drawing.Size(121, 21);
            this.skill4Select.TabIndex = 11;
            this.skill4Select.SelectedIndexChanged += new System.EventHandler(this.skill4Select_SelectedIndexChanged);
            // 
            // skill3Select
            // 
            this.skill3Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skill3Select.FormattingEnabled = true;
            this.skill3Select.Items.AddRange(new object[] {
            "None",
            "Unused",
            "Unused",
            "Unused",
            "Unused",
            "Power Break",
            "Sure Footed",
            "Safety Net",
            "Last Chance",
            "Unused",
            "10 Second Rings",
            "Athleticism",
            "Time Brake",
            "Super Sonic",
            "Fire Shield",
            "Aqua Shield",
            "Thunder Shield",
            "Twin-Spin Attack",
            "Invincible Start",
            "Shield",
            "Power Sneakers",
            "Long Spin Dash",
            "Treasure Scanner",
            "Homing Attack",
            "Hercules Strength",
            "Breath Holder",
            "Boardmaster",
            "Ring Time",
            "Blast Off",
            "Speed Up",
            "Direct Jump",
            "Power Stomp",
            "Quick Slide",
            "Acceleration",
            "Smasher Bonus",
            "Ring Bonus",
            "Boost Gauge Up",
            "Serial Homing",
            "Auto-Gauge",
            "Gauge Rebooter",
            "Trick Mastery",
            "Endless Boost"});
            this.skill3Select.Location = new System.Drawing.Point(74, 168);
            this.skill3Select.Name = "skill3Select";
            this.skill3Select.Size = new System.Drawing.Size(121, 21);
            this.skill3Select.TabIndex = 9;
            this.skill3Select.SelectedIndexChanged += new System.EventHandler(this.skill3Select_SelectedIndexChanged);
            // 
            // skill2Select
            // 
            this.skill2Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skill2Select.FormattingEnabled = true;
            this.skill2Select.Items.AddRange(new object[] {
            "None",
            "Unused",
            "Unused",
            "Unused",
            "Unused",
            "Power Break",
            "Sure Footed",
            "Safety Net",
            "Last Chance",
            "Unused",
            "10 Second Rings",
            "Athleticism",
            "Time Brake",
            "Super Sonic",
            "Fire Shield",
            "Aqua Shield",
            "Thunder Shield",
            "Twin-Spin Attack",
            "Invincible Start",
            "Shield",
            "Power Sneakers",
            "Long Spin Dash",
            "Treasure Scanner",
            "Homing Attack",
            "Hercules Strength",
            "Breath Holder",
            "Boardmaster",
            "Ring Time",
            "Blast Off",
            "Speed Up",
            "Direct Jump",
            "Power Stomp",
            "Quick Slide",
            "Acceleration",
            "Smasher Bonus",
            "Ring Bonus",
            "Boost Gauge Up",
            "Serial Homing",
            "Auto-Gauge",
            "Gauge Rebooter",
            "Trick Mastery",
            "Endless Boost"});
            this.skill2Select.Location = new System.Drawing.Point(74, 141);
            this.skill2Select.Name = "skill2Select";
            this.skill2Select.Size = new System.Drawing.Size(121, 21);
            this.skill2Select.TabIndex = 7;
            this.skill2Select.SelectedIndexChanged += new System.EventHandler(this.skill2Select_SelectedIndexChanged);
            // 
            // skill1Select
            // 
            this.skill1Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skill1Select.FormattingEnabled = true;
            this.skill1Select.Items.AddRange(new object[] {
            "None",
            "Unused",
            "Unused",
            "Unused",
            "Unused",
            "Power Break",
            "Sure Footed",
            "Safety Net",
            "Last Chance",
            "Unused",
            "10 Second Rings",
            "Athleticism",
            "Time Brake",
            "Super Sonic",
            "Fire Shield",
            "Aqua Shield",
            "Thunder Shield",
            "Twin-Spin Attack",
            "Invincible Start",
            "Shield",
            "Power Sneakers",
            "Long Spin Dash",
            "Treasure Scanner",
            "Homing Attack",
            "Hercules Strength",
            "Breath Holder",
            "Boardmaster",
            "Ring Time",
            "Blast Off",
            "Speed Up",
            "Direct Jump",
            "Power Stomp",
            "Quick Slide",
            "Acceleration",
            "Smasher Bonus",
            "Ring Bonus",
            "Boost Gauge Up",
            "Serial Homing",
            "Auto-Gauge",
            "Gauge Rebooter",
            "Trick Mastery",
            "Endless Boost"});
            this.skill1Select.Location = new System.Drawing.Point(74, 114);
            this.skill1Select.Name = "skill1Select";
            this.skill1Select.Size = new System.Drawing.Size(121, 21);
            this.skill1Select.TabIndex = 5;
            this.skill1Select.SelectedIndexChanged += new System.EventHandler(this.skill1Select_SelectedIndexChanged);
            // 
            // skillSetSelect
            // 
            this.skillSetSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skillSetSelect.FormattingEnabled = true;
            this.skillSetSelect.Items.AddRange(new object[] {
            "Skill Set 1",
            "Skill Set 2",
            "Skill Set 3",
            "Skill Set 4",
            "Skill Set 5"});
            this.skillSetSelect.Location = new System.Drawing.Point(74, 33);
            this.skillSetSelect.Name = "skillSetSelect";
            this.skillSetSelect.Size = new System.Drawing.Size(121, 21);
            this.skillSetSelect.TabIndex = 3;
            this.skillSetSelect.SelectedIndexChanged += new System.EventHandler(this.skillSetSelect_SelectedIndexChanged);
            // 
            // characterSelect
            // 
            this.characterSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.characterSelect.FormattingEnabled = true;
            this.characterSelect.Items.AddRange(new object[] {
            "Classic Sonic",
            "Modern Sonic"});
            this.characterSelect.Location = new System.Drawing.Point(74, 6);
            this.characterSelect.Name = "characterSelect";
            this.characterSelect.Size = new System.Drawing.Size(121, 21);
            this.characterSelect.TabIndex = 1;
            this.characterSelect.SelectedIndexChanged += new System.EventHandler(this.characterSelect_SelectedIndexChanged);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(12, 63);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(47, 13);
            label8.TabIndex = 14;
            label8.Text = "Name 1:";
            // 
            // skillSetNameSelect1
            // 
            this.skillSetNameSelect1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skillSetNameSelect1.FormattingEnabled = true;
            this.skillSetNameSelect1.Location = new System.Drawing.Point(74, 60);
            this.skillSetNameSelect1.Name = "skillSetNameSelect1";
            this.skillSetNameSelect1.Size = new System.Drawing.Size(121, 21);
            this.skillSetNameSelect1.TabIndex = 15;
            this.skillSetNameSelect1.SelectedIndexChanged += new System.EventHandler(this.skillSetNameSelect1_SelectedIndexChanged);
            // 
            // skillSetNameSelect2
            // 
            this.skillSetNameSelect2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skillSetNameSelect2.FormattingEnabled = true;
            this.skillSetNameSelect2.Location = new System.Drawing.Point(74, 87);
            this.skillSetNameSelect2.Name = "skillSetNameSelect2";
            this.skillSetNameSelect2.Size = new System.Drawing.Size(121, 21);
            this.skillSetNameSelect2.TabIndex = 16;
            this.skillSetNameSelect2.SelectedIndexChanged += new System.EventHandler(this.skillSetNameSelect2_SelectedIndexChanged);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(12, 90);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(47, 13);
            label9.TabIndex = 17;
            label9.Text = "Name 2:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 279);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "GenSkillEd";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox characterSelect;
        private System.Windows.Forms.ComboBox skillSetSelect;
        private System.Windows.Forms.ComboBox skill1Select;
        private System.Windows.Forms.ComboBox skill2Select;
        private System.Windows.Forms.ComboBox skill3Select;
        private System.Windows.Forms.ComboBox skill5Select;
        private System.Windows.Forms.ComboBox skill4Select;
        private System.Windows.Forms.ComboBox skillSetNameSelect1;
        private System.Windows.Forms.ComboBox skillSetNameSelect2;
    }
}

