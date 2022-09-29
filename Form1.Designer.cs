namespace MineSweeper
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
            this.button1 = new System.Windows.Forms.Button();
            this.easy = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.expert = new System.Windows.Forms.RadioButton();
            this.custom = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.playANewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.expertMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Play);
            // 
            // easy
            // 
            this.easy.AutoSize = true;
            this.easy.Location = new System.Drawing.Point(26, 45);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(48, 17);
            this.easy.TabIndex = 1;
            this.easy.TabStop = true;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = true;
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.Checked = true;
            this.medium.Location = new System.Drawing.Point(80, 45);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(62, 17);
            this.medium.TabIndex = 2;
            this.medium.TabStop = true;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = true;
            // 
            // expert
            // 
            this.expert.AutoSize = true;
            this.expert.Location = new System.Drawing.Point(148, 45);
            this.expert.Name = "expert";
            this.expert.Size = new System.Drawing.Size(55, 17);
            this.expert.TabIndex = 3;
            this.expert.TabStop = true;
            this.expert.Text = "Expert";
            this.expert.UseVisualStyleBackColor = true;
            // 
            // custom
            // 
            this.custom.AutoSize = true;
            this.custom.Location = new System.Drawing.Point(209, 45);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(60, 17);
            this.custom.TabIndex = 4;
            this.custom.TabStop = true;
            this.custom.Text = "Custom";
            this.custom.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Close All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Close);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(86, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "# of Games";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(191, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Player Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playANewGameToolStripMenuItem,
            this.closeAllGamesToolStripMenuItem,
            this.exitMenu});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // playANewGameToolStripMenuItem
            // 
            this.playANewGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyMenu,
            this.mediumMenu,
            this.expertMenu});
            this.playANewGameToolStripMenuItem.Name = "playANewGameToolStripMenuItem";
            this.playANewGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playANewGameToolStripMenuItem.Text = "Play a new game";
            // 
            // easyMenu
            // 
            this.easyMenu.Name = "easyMenu";
            this.easyMenu.Size = new System.Drawing.Size(180, 22);
            this.easyMenu.Text = "Easy";
            this.easyMenu.Click += new System.EventHandler(this.Play);
            // 
            // mediumMenu
            // 
            this.mediumMenu.Name = "mediumMenu";
            this.mediumMenu.Size = new System.Drawing.Size(180, 22);
            this.mediumMenu.Text = "Medium";
            this.mediumMenu.Click += new System.EventHandler(this.Play);
            // 
            // expertMenu
            // 
            this.expertMenu.Name = "expertMenu";
            this.expertMenu.Size = new System.Drawing.Size(180, 22);
            this.expertMenu.Text = "Expert";
            this.expertMenu.Click += new System.EventHandler(this.Play);
            // 
            // closeAllGamesToolStripMenuItem
            // 
            this.closeAllGamesToolStripMenuItem.Name = "closeAllGamesToolStripMenuItem";
            this.closeAllGamesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeAllGamesToolStripMenuItem.Text = "Close all games";
            this.closeAllGamesToolStripMenuItem.Click += new System.EventHandler(this.Close);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(180, 22);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 179);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.custom);
            this.Controls.Add(this.expert);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MineSweeper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton easy;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton expert;
        private System.Windows.Forms.RadioButton custom;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem playANewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyMenu;
        private System.Windows.Forms.ToolStripMenuItem mediumMenu;
        private System.Windows.Forms.ToolStripMenuItem expertMenu;
        private System.Windows.Forms.ToolStripMenuItem closeAllGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
    }
}

