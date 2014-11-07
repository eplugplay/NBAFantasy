namespace NBAFantasy
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ddlTeam1 = new System.Windows.Forms.ComboBox();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.gpbxMain = new System.Windows.Forms.GroupBox();
            this.lblVersus = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.ddlTeam2 = new System.Windows.Forms.ComboBox();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gpbxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(376, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPlayersToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editPlayersToolStripMenuItem
            // 
            this.editPlayersToolStripMenuItem.Name = "editPlayersToolStripMenuItem";
            this.editPlayersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editPlayersToolStripMenuItem.Text = "Edit Players";
            this.editPlayersToolStripMenuItem.Click += new System.EventHandler(this.editPlayersToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ddlTeam1
            // 
            this.ddlTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlTeam1.FormattingEnabled = true;
            this.ddlTeam1.Location = new System.Drawing.Point(91, 29);
            this.ddlTeam1.Name = "ddlTeam1";
            this.ddlTeam1.Size = new System.Drawing.Size(227, 21);
            this.ddlTeam1.TabIndex = 1;
            // 
            // lblTeam1
            // 
            this.lblTeam1.AutoSize = true;
            this.lblTeam1.Location = new System.Drawing.Point(26, 32);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(53, 13);
            this.lblTeam1.TabIndex = 2;
            this.lblTeam1.Text = "Team 1:";
            // 
            // gpbxMain
            // 
            this.gpbxMain.Controls.Add(this.lblVersus);
            this.gpbxMain.Controls.Add(this.btnCompare);
            this.gpbxMain.Controls.Add(this.ddlTeam2);
            this.gpbxMain.Controls.Add(this.lblTeam2);
            this.gpbxMain.Controls.Add(this.ddlTeam1);
            this.gpbxMain.Controls.Add(this.lblTeam1);
            this.gpbxMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxMain.Location = new System.Drawing.Point(12, 27);
            this.gpbxMain.Name = "gpbxMain";
            this.gpbxMain.Size = new System.Drawing.Size(352, 137);
            this.gpbxMain.TabIndex = 3;
            this.gpbxMain.TabStop = false;
            this.gpbxMain.Text = "Compare Teams";
            // 
            // lblVersus
            // 
            this.lblVersus.AutoSize = true;
            this.lblVersus.Location = new System.Drawing.Point(175, 60);
            this.lblVersus.Name = "lblVersus";
            this.lblVersus.Size = new System.Drawing.Size(20, 13);
            this.lblVersus.TabIndex = 6;
            this.lblVersus.Text = "vs";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(271, 108);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 5;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // ddlTeam2
            // 
            this.ddlTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlTeam2.FormattingEnabled = true;
            this.ddlTeam2.Location = new System.Drawing.Point(91, 81);
            this.ddlTeam2.Name = "ddlTeam2";
            this.ddlTeam2.Size = new System.Drawing.Size(227, 21);
            this.ddlTeam2.TabIndex = 3;
            // 
            // lblTeam2
            // 
            this.lblTeam2.AutoSize = true;
            this.lblTeam2.Location = new System.Drawing.Point(26, 84);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(53, 13);
            this.lblTeam2.TabIndex = 4;
            this.lblTeam2.Text = "Team 2:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 176);
            this.Controls.Add(this.gpbxMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbxMain.ResumeLayout(false);
            this.gpbxMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox ddlTeam1;
        private System.Windows.Forms.Label lblTeam1;
        private System.Windows.Forms.GroupBox gpbxMain;
        private System.Windows.Forms.ComboBox ddlTeam2;
        private System.Windows.Forms.Label lblTeam2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblVersus;
    }
}

