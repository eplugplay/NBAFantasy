﻿namespace NBAFantasy
{
    partial class EditPlayers
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
            this.gpbxMain = new System.Windows.Forms.GroupBox();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.lblAllPlayers = new System.Windows.Forms.Label();
            this.lstAllPlayers = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddNewPlayer = new System.Windows.Forms.Button();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.ddlTeams = new System.Windows.Forms.ComboBox();
            this.gpbxStats = new System.Windows.Forms.GroupBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBlk = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtSt = new System.Windows.Forms.TextBox();
            this.txtAst = new System.Windows.Forms.TextBox();
            this.txtReb = new System.Windows.Forms.TextBox();
            this.txtPts = new System.Windows.Forms.TextBox();
            this.txt3Ptm = new System.Windows.Forms.TextBox();
            this.txtFt = new System.Windows.Forms.TextBox();
            this.txtFg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbxMain.SuspendLayout();
            this.gpbxStats.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbxMain
            // 
            this.gpbxMain.Controls.Add(this.btnDeletePlayer);
            this.gpbxMain.Controls.Add(this.btnAddPlayer);
            this.gpbxMain.Controls.Add(this.lblAllPlayers);
            this.gpbxMain.Controls.Add(this.lstAllPlayers);
            this.gpbxMain.Controls.Add(this.btnRemove);
            this.gpbxMain.Controls.Add(this.btnAddNewPlayer);
            this.gpbxMain.Controls.Add(this.lstPlayers);
            this.gpbxMain.Controls.Add(this.ddlTeams);
            this.gpbxMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxMain.Location = new System.Drawing.Point(6, 142);
            this.gpbxMain.Name = "gpbxMain";
            this.gpbxMain.Size = new System.Drawing.Size(468, 240);
            this.gpbxMain.TabIndex = 4;
            this.gpbxMain.TabStop = false;
            this.gpbxMain.Text = "Edit Teams";
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Location = new System.Drawing.Point(375, 29);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(21, 20);
            this.btnDeletePlayer.TabIndex = 25;
            this.btnDeletePlayer.TabStop = false;
            this.btnDeletePlayer.Text = "-";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(226, 175);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(21, 23);
            this.btnAddPlayer.TabIndex = 24;
            this.btnAddPlayer.TabStop = false;
            this.btnAddPlayer.Text = "<";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // lblAllPlayers
            // 
            this.lblAllPlayers.AutoSize = true;
            this.lblAllPlayers.Location = new System.Drawing.Point(260, 33);
            this.lblAllPlayers.Name = "lblAllPlayers";
            this.lblAllPlayers.Size = new System.Drawing.Size(70, 13);
            this.lblAllPlayers.TabIndex = 23;
            this.lblAllPlayers.Text = "All Players:";
            // 
            // lstAllPlayers
            // 
            this.lstAllPlayers.FormattingEnabled = true;
            this.lstAllPlayers.Location = new System.Drawing.Point(253, 49);
            this.lstAllPlayers.Name = "lstAllPlayers";
            this.lstAllPlayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstAllPlayers.Size = new System.Drawing.Size(165, 186);
            this.lstAllPlayers.TabIndex = 22;
            this.lstAllPlayers.TabStop = false;
            this.lstAllPlayers.SelectedIndexChanged += new System.EventHandler(this.lstAllPlayers_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(226, 82);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(21, 23);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = ">";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddNewPlayer
            // 
            this.btnAddNewPlayer.Location = new System.Drawing.Point(397, 29);
            this.btnAddNewPlayer.Name = "btnAddNewPlayer";
            this.btnAddNewPlayer.Size = new System.Drawing.Size(21, 20);
            this.btnAddNewPlayer.TabIndex = 20;
            this.btnAddNewPlayer.TabStop = false;
            this.btnAddNewPlayer.Text = "+";
            this.btnAddNewPlayer.UseVisualStyleBackColor = true;
            this.btnAddNewPlayer.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstPlayers
            // 
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.Location = new System.Drawing.Point(55, 49);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPlayers.Size = new System.Drawing.Size(165, 186);
            this.lstPlayers.TabIndex = 9;
            this.lstPlayers.TabStop = false;
            this.lstPlayers.SelectedIndexChanged += new System.EventHandler(this.lstPlayers_SelectedIndexChanged);
            // 
            // ddlTeams
            // 
            this.ddlTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTeams.FormattingEnabled = true;
            this.ddlTeams.Location = new System.Drawing.Point(55, 22);
            this.ddlTeams.Name = "ddlTeams";
            this.ddlTeams.Size = new System.Drawing.Size(165, 21);
            this.ddlTeams.TabIndex = 1;
            this.ddlTeams.TabStop = false;
            this.ddlTeams.SelectedIndexChanged += new System.EventHandler(this.ddlTeams_SelectedIndexChanged);
            // 
            // gpbxStats
            // 
            this.gpbxStats.Controls.Add(this.txtPosition);
            this.gpbxStats.Controls.Add(this.txtPlayerName);
            this.gpbxStats.Controls.Add(this.label10);
            this.gpbxStats.Controls.Add(this.txtTo);
            this.gpbxStats.Controls.Add(this.btnSave);
            this.gpbxStats.Controls.Add(this.txtBlk);
            this.gpbxStats.Controls.Add(this.lblPlayerName);
            this.gpbxStats.Controls.Add(this.txtSt);
            this.gpbxStats.Controls.Add(this.txtAst);
            this.gpbxStats.Controls.Add(this.txtReb);
            this.gpbxStats.Controls.Add(this.txtPts);
            this.gpbxStats.Controls.Add(this.txt3Ptm);
            this.gpbxStats.Controls.Add(this.txtFt);
            this.gpbxStats.Controls.Add(this.txtFg);
            this.gpbxStats.Controls.Add(this.label4);
            this.gpbxStats.Controls.Add(this.label1);
            this.gpbxStats.Controls.Add(this.label5);
            this.gpbxStats.Controls.Add(this.label2);
            this.gpbxStats.Controls.Add(this.label6);
            this.gpbxStats.Controls.Add(this.label3);
            this.gpbxStats.Controls.Add(this.label7);
            this.gpbxStats.Controls.Add(this.label9);
            this.gpbxStats.Controls.Add(this.label8);
            this.gpbxStats.Location = new System.Drawing.Point(6, 27);
            this.gpbxStats.Name = "gpbxStats";
            this.gpbxStats.Size = new System.Drawing.Size(468, 117);
            this.gpbxStats.TabIndex = 19;
            this.gpbxStats.TabStop = false;
            this.gpbxStats.Text = "Stats";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(360, 19);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(63, 20);
            this.txtPosition.TabIndex = 2;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(155, 19);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(132, 20);
            this.txtPlayerName.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(307, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Position:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(404, 60);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(40, 20);
            this.txtTo.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(369, 86);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBlk
            // 
            this.txtBlk.Location = new System.Drawing.Point(362, 60);
            this.txtBlk.Name = "txtBlk";
            this.txtBlk.Size = new System.Drawing.Size(38, 20);
            this.txtBlk.TabIndex = 10;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(67, 22);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(70, 13);
            this.lblPlayerName.TabIndex = 28;
            this.lblPlayerName.Text = "Player Name:";
            // 
            // txtSt
            // 
            this.txtSt.Location = new System.Drawing.Point(318, 60);
            this.txtSt.Name = "txtSt";
            this.txtSt.Size = new System.Drawing.Size(41, 20);
            this.txtSt.TabIndex = 9;
            // 
            // txtAst
            // 
            this.txtAst.Location = new System.Drawing.Point(272, 60);
            this.txtAst.Name = "txtAst";
            this.txtAst.Size = new System.Drawing.Size(42, 20);
            this.txtAst.TabIndex = 8;
            // 
            // txtReb
            // 
            this.txtReb.Location = new System.Drawing.Point(221, 60);
            this.txtReb.Name = "txtReb";
            this.txtReb.Size = new System.Drawing.Size(45, 20);
            this.txtReb.TabIndex = 7;
            // 
            // txtPts
            // 
            this.txtPts.Location = new System.Drawing.Point(168, 60);
            this.txtPts.Name = "txtPts";
            this.txtPts.Size = new System.Drawing.Size(47, 20);
            this.txtPts.TabIndex = 6;
            // 
            // txt3Ptm
            // 
            this.txt3Ptm.Location = new System.Drawing.Point(113, 60);
            this.txt3Ptm.Name = "txt3Ptm";
            this.txt3Ptm.Size = new System.Drawing.Size(49, 20);
            this.txt3Ptm.TabIndex = 5;
            // 
            // txtFt
            // 
            this.txtFt.Location = new System.Drawing.Point(61, 60);
            this.txtFt.Name = "txtFt";
            this.txtFt.Size = new System.Drawing.Size(46, 20);
            this.txtFt.TabIndex = 4;
            // 
            // txtFg
            // 
            this.txtFg.Location = new System.Drawing.Point(12, 60);
            this.txtFg.Name = "txtFg";
            this.txtFg.Size = new System.Drawing.Size(43, 20);
            this.txtFg.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "TO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "FG%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "BLK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "FT%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "ST";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "3PTM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "AST";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "PTS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "REB";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(479, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // EditPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 385);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gpbxMain);
            this.Controls.Add(this.gpbxStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "EditPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Players";
            this.Load += new System.EventHandler(this.EditPlayers_Load);
            this.gpbxMain.ResumeLayout(false);
            this.gpbxMain.PerformLayout();
            this.gpbxStats.ResumeLayout(false);
            this.gpbxStats.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxMain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox ddlTeams;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gpbxStats;
        private System.Windows.Forms.TextBox txtFg;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtBlk;
        private System.Windows.Forms.TextBox txtSt;
        private System.Windows.Forms.TextBox txtAst;
        private System.Windows.Forms.TextBox txtReb;
        private System.Windows.Forms.TextBox txtPts;
        private System.Windows.Forms.TextBox txt3Ptm;
        private System.Windows.Forms.TextBox txtFt;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddNewPlayer;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstAllPlayers;
        private System.Windows.Forms.Label lblAllPlayers;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnDeletePlayer;
    }
}