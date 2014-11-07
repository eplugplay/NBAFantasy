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
    public partial class EditPlayers : Form
    {
        private bool lstAllSelected { get; set; }
        public EditPlayers()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditPlayers_Load(object sender, EventArgs e)
        {
            LoadTeams();
            LoadPlayers();
            LoadAllAvailablePlayers();
        }

        public void LoadAllAvailablePlayers()
        {
            lstAllPlayers.DisplayMember = "playername";
            lstAllPlayers.ValueMember = "id";
            lstAllPlayers.DataSource = Uti.GetAllAvailablePlayers();
        }

        public void LoadTeams()
        {
            ddlTeams.DisplayMember = "teamname";
            ddlTeams.ValueMember = "id";
            ddlTeams.DataSource = Uti.GetTeams();
        }

        public void LoadPlayers()
        {
            lstPlayers.DisplayMember = "playername";
            lstPlayers.ValueMember = "id";
            lstPlayers.DataSource = Uti.GetFantasyStats(Convert.ToInt32(ddlTeams.SelectedValue));
        }

        public void LoadStats()
        {
            DataTable dt = Uti.GetFantasyStats(Convert.ToInt32(ddlTeams.SelectedValue));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToInt32(lstPlayers.SelectedValue) == Convert.ToInt32(dt.Rows[i]["id"]))
                {
                    txtPlayerName.Text = dt.Rows[i]["playername"].ToString();
                    txtFg.Text = dt.Rows[i]["fg"].ToString();
                    txtFt.Text = dt.Rows[i]["ft"].ToString();
                    txt3Ptm.Text = dt.Rows[i]["3ptm"].ToString();
                    txtPts.Text = dt.Rows[i]["pts"].ToString();
                    txtReb.Text = dt.Rows[i]["reb"].ToString();
                    txtAst.Text = dt.Rows[i]["ast"].ToString();
                    txtSt.Text = dt.Rows[i]["st"].ToString();
                    txtBlk.Text = dt.Rows[i]["blk"].ToString();
                    txtTo.Text = dt.Rows[i]["tos"].ToString();
                    txtPosition.Text = dt.Rows[i]["position"].ToString();

                }
            }
        }

        public void LoadAllPlayersStats()
        {
            DataTable dt = Uti.GetIndividualStats(Convert.ToInt32(lstAllPlayers.SelectedValue));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtPlayerName.Text = dt.Rows[i]["playername"].ToString();
                txtFg.Text = dt.Rows[i]["fg"].ToString();
                txtFt.Text = dt.Rows[i]["ft"].ToString();
                txt3Ptm.Text = dt.Rows[i]["3ptm"].ToString();
                txtPts.Text = dt.Rows[i]["pts"].ToString();
                txtReb.Text = dt.Rows[i]["reb"].ToString();
                txtAst.Text = dt.Rows[i]["ast"].ToString();
                txtSt.Text = dt.Rows[i]["st"].ToString();
                txtBlk.Text = dt.Rows[i]["blk"].ToString();
                txtTo.Text = dt.Rows[i]["tos"].ToString();
                txtPosition.Text = dt.Rows[i]["position"].ToString();
            }
        }

        public void ClearAllFields()
        {
            txtPlayerName.Clear();
            txtFg.Clear();
            txtFt.Clear();
            txt3Ptm.Clear();
            txtPts.Clear();
            txtReb.Clear();
            txtAst.Clear();
            txtSt.Clear();
            txtBlk.Clear();
            txtTo.Clear();
            txtPosition.Clear();
        }

        private void lstPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAllSelected == true)
            {
                lstAllPlayers.SelectedIndex = -1;
            }
            if (lstPlayers.SelectedItems.Count > 1)
            {
                gpbxStats.Enabled = false;
            }
            else
            {
                gpbxStats.Enabled = true;
            }
            lstAllSelected = false;
            LoadStats();
        }

        private void lstAllPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAllSelected == false)
            {
                lstPlayers.SelectedIndex = -1;
            }
            if (lstAllPlayers.SelectedItems.Count > 1)
            {
                gpbxStats.Enabled = false;
            }
            else
            {
                gpbxStats.Enabled = true;
            }
            lstAllSelected = true;
            LoadAllPlayersStats();
        }

        private void ddlTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAllFields();
            LoadPlayers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Data.AddNewPlayer();
            LoadAllAvailablePlayers();
            lstAllPlayers.SelectedIndex = -1;
            lstAllPlayers.SelectedIndex = lstAllPlayers.Items.Count - 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Control txt in gpbxStats.Controls)
            {
                if (txt is TextBox)
                {
                    if (txt.Text == "")
                    {
                        MessageBox.Show("Empty text boxes.");
                        return;
                    }
                }
            }
            if (lstAllSelected == true)
            {
                Data.currentPlayerIndex = Convert.ToInt32(lstAllPlayers.SelectedIndex);
                Data.UpdatePlayer(Convert.ToInt32(lstAllPlayers.SelectedValue), txtPlayerName.Text, Convert.ToDouble(txtFg.Text), Convert.ToDouble(txtFt.Text), Convert.ToDouble(txt3Ptm.Text),
                    Convert.ToDouble(txtPts.Text), Convert.ToDouble(txtReb.Text), Convert.ToDouble(txtAst.Text), Convert.ToDouble(txtSt.Text), Convert.ToDouble(txtBlk.Text), Convert.ToDouble(txtTo.Text), txtPosition.Text);
                LoadAllAvailablePlayers();
                lstAllPlayers.SelectedIndex = -1;
                lstAllPlayers.SelectedIndex = Data.currentPlayerIndex;
            }
            else
            {
                Data.currentPlayerIndex = Convert.ToInt32(lstPlayers.SelectedIndex);
                Data.UpdatePlayer(Convert.ToInt32(lstPlayers.SelectedValue), txtPlayerName.Text, Convert.ToDouble(txtFg.Text), Convert.ToDouble(txtFt.Text), Convert.ToDouble(txt3Ptm.Text),
                    Convert.ToDouble(txtPts.Text), Convert.ToDouble(txtReb.Text), Convert.ToDouble(txtAst.Text), Convert.ToDouble(txtSt.Text), Convert.ToDouble(txtBlk.Text), Convert.ToDouble(txtTo.Text), txtPosition.Text);
                LoadPlayers();
                lstPlayers.SelectedIndex = -1;
                lstPlayers.SelectedIndex = Data.currentPlayerIndex;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex == -1)
            {
                return;
            }

            foreach (DataRowView drv in lstPlayers.SelectedItems)
            {
                Data.RemovePlayer(Convert.ToInt32(drv["id"]));
            }

            LoadPlayers();
            LoadAllAvailablePlayers();
            if (lstPlayers.Items.Count != 0)
            {
                lstPlayers.SelectedIndex = 0;
            }
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (lstAllPlayers.SelectedIndex == -1)
            {
                return;
            }

            foreach (DataRowView drv in lstAllPlayers.SelectedItems)
            {
                Data.AddPlayer(Convert.ToInt32(ddlTeams.SelectedValue), Convert.ToInt32(drv["id"]));
            }
            
            LoadPlayers();
            LoadAllAvailablePlayers();
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            if (lstAllPlayers.SelectedIndex == -1)
            {
                return;
            }
            foreach (DataRowView drv in lstAllPlayers.SelectedItems)
            {
                Data.DeletePlayer(Convert.ToInt32(drv["id"]));
            }
            
            LoadPlayers();
            LoadAllAvailablePlayers();
        }
    }
}
