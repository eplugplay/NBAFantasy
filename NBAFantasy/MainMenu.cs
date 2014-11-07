using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Data.Common;
using System.Collections;

namespace NBAFantasy
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadTeams()
        {
            ddlTeam1.DisplayMember = "teamname";
            ddlTeam1.ValueMember = "id";
            ddlTeam1.DataSource = Uti.GetTeams();

            ddlTeam2.DisplayMember = "teamname";
            ddlTeam2.ValueMember = "id";
            ddlTeam2.DataSource = Uti.GetTeams();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            LoadTeams();
        }

        private static Comparison _Comparison;
        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (_Comparison == null || _Comparison.IsDisposed)
            {
                _Comparison = new Comparison(Convert.ToInt32(ddlTeam1.SelectedValue), Convert.ToInt32(ddlTeam2.SelectedValue));
                _Comparison.Show();
            }
            else
            {
                if (_Comparison.WindowState == FormWindowState.Minimized)
                {
                    _Comparison.WindowState = FormWindowState.Normal;
                }
                else
                {
                    _Comparison.BringToFront();
                }
            }
        }

        private static EditPlayers _EditPlayers;
        private void editPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_EditPlayers == null || _EditPlayers.IsDisposed)
            {
                _EditPlayers = new EditPlayers();
                _EditPlayers.Show();
            }
            else
            {
                if (_EditPlayers.WindowState == FormWindowState.Minimized)
                {
                    _EditPlayers.WindowState = FormWindowState.Normal;
                }
                else
                {
                    _EditPlayers.BringToFront();
                }
            }
        }
    }
}
