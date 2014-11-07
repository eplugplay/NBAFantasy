using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NBAFantasy
{
    public partial class Comparison : Form
    {
        int team1id { get; set; }
        int team2id { get; set; }
        public Comparison(int _team1id, int _team2id)
        {
            team1id = _team1id;
            team2id = _team2id;
            InitializeComponent();
        }

        private void Comparison_Load(object sender, EventArgs e)
        {
            LoadAvg(team1id, team2id);
        }

        public void CompareTeam1Results(int team1id, int team2id)
        {
            DataTable dtTeam1 = Comparisons.GetAvgTotals(team1id);
            DataTable dtTeam2 = Comparisons.GetAvgTotals(team2id);

           for (int a = 0; a < dtTeam1.Rows.Count; a++)
           {
               for (int b = 0; b < dtTeam2.Rows.Count; b++)
               {

               }
           }
        }

        public void LoadAvg(int team1id, int team2id)
        {
            DataTable dtTeam1 = Comparisons.GetAvgTotals(team1id);
            for (int i = 0; i < dtTeam1.Rows.Count; i++)
            {
                txtTeamName.Text = dtTeam1.Rows[i]["teamname"].ToString();
                txtFg.Text = dtTeam1.Rows[i]["fg"].ToString();
                txtFt.Text = dtTeam1.Rows[i]["ft"].ToString();
                txt3Ptm.Text = dtTeam1.Rows[i]["3ptm"].ToString();
                txtPts.Text = dtTeam1.Rows[i]["pts"].ToString();
                txtReb.Text = dtTeam1.Rows[i]["reb"].ToString();
                txtAst.Text = dtTeam1.Rows[i]["ast"].ToString();
                txtSt.Text = dtTeam1.Rows[i]["st"].ToString();
                txtBlk.Text = dtTeam1.Rows[i]["blk"].ToString();
                txtTo.Text = dtTeam1.Rows[i]["tos"].ToString();
            }
            DataTable dtTeam2 = Comparisons.GetAvgTotals(team2id);
            for (int i = 0; i < dtTeam2.Rows.Count; i++)
            {
                txtTeamName2.Text = dtTeam2.Rows[i]["teamname"].ToString();
                txtFg2.Text = dtTeam2.Rows[i]["fg"].ToString();
                txtFt2.Text = dtTeam2.Rows[i]["ft"].ToString();
                txt3Ptm2.Text = dtTeam2.Rows[i]["3ptm"].ToString();
                txtPts2.Text = dtTeam2.Rows[i]["pts"].ToString();
                txtReb2.Text = dtTeam2.Rows[i]["reb"].ToString();
                txtAst2.Text = dtTeam2.Rows[i]["ast"].ToString();
                txtSt2.Text = dtTeam2.Rows[i]["st"].ToString();
                txtBlk2.Text = dtTeam2.Rows[i]["blk"].ToString();
                txtTo2.Text = dtTeam2.Rows[i]["tos"].ToString();
            }

            int team1Ctr = 0;
            int team2Ctr = 0;
            // compare fg
            if (Convert.ToDouble(txtFg.Text) > Convert.ToDouble(txtFg2.Text))
            {
                lblFg.ForeColor = Color.Blue;
                lblFg2.ForeColor = Color.Red;
                team1Ctr++;
            }
            else if (Convert.ToDouble(txtFg.Text) < Convert.ToDouble(txtFg2.Text))
            {
                lblFg.ForeColor = Color.Red;
                lblFg2.ForeColor = Color.Blue;
                team2Ctr++;
            }
            else if (Convert.ToDouble(txtFg.Text) == Convert.ToDouble(txtFg2.Text))
            {
                lblFg.ForeColor = Color.Green;
                lblFg2.ForeColor = Color.Green;
            }

            // compare ft
            if (Convert.ToDouble(txtFt.Text) > Convert.ToDouble(txtFt2.Text))
            {
                lblFt.ForeColor = Color.Blue;
                lblFt2.ForeColor = Color.Red;
                team1Ctr++;
            }
            else if (Convert.ToDouble(txtFt.Text) < Convert.ToDouble(txtFt2.Text))
            {
                lblFt.ForeColor = Color.Red;
                lblFt2.ForeColor = Color.Blue;
                team2Ctr++;
            }
            else if (Convert.ToDouble(txtFt.Text) == Convert.ToDouble(txtFt2.Text))
            {
                lblFt.ForeColor = Color.Green;
                lblFt2.ForeColor = Color.Green;
            }

            // compare 3ptm
            if (Convert.ToDouble(txt3Ptm.Text) > Convert.ToDouble(txt3Ptm2.Text))
            {
                lbl3Ptm.ForeColor = Color.Blue;
                lbl3Ptm2.ForeColor = Color.Red;
                team1Ctr++;
            }
            else if (Convert.ToDouble(txt3Ptm.Text) < Convert.ToDouble(txt3Ptm2.Text))
            {
                lbl3Ptm.ForeColor = Color.Red;
                lbl3Ptm2.ForeColor = Color.Blue;
                team2Ctr++;
            }
            else if (Convert.ToDouble(txt3Ptm.Text) == Convert.ToDouble(txt3Ptm2.Text))
            {
                lbl3Ptm.ForeColor = Color.Green;
                lbl3Ptm2.ForeColor = Color.Green;
            }

            // compare Pts
            if (Convert.ToDouble(txtPts.Text) > Convert.ToDouble(txtPts2.Text))
            {
                lblPts.ForeColor = Color.Blue;
                lblPts2.ForeColor = Color.Red;
                team1Ctr++;
            }
            else if (Convert.ToDouble(txtPts.Text) < Convert.ToDouble(txtPts2.Text))
            {
                lblPts.ForeColor = Color.Red;
                lblPts2.ForeColor = Color.Blue;
                team2Ctr++;
            }
            else if (Convert.ToDouble(txtPts.Text) == Convert.ToDouble(txtPts2.Text))
            {
                lblPts.ForeColor = Color.Green;
                lblPts2.ForeColor = Color.Green;
            }

            // compare Reb
            if (Convert.ToDouble(txtReb.Text) > Convert.ToDouble(txtReb2.Text))
            {
                lblReb.ForeColor = Color.Blue;
                lblReb2.ForeColor = Color.Red;
                team1Ctr++;
            }
            else if (Convert.ToDouble(txtReb.Text) < Convert.ToDouble(txtReb2.Text))
            {
                lblReb.ForeColor = Color.Red;
                lblReb2.ForeColor = Color.Blue;
                team2Ctr++;
            }
            else if (Convert.ToDouble(txtReb.Text) == Convert.ToDouble(txtReb2.Text))
            {
                lblReb.ForeColor = Color.Green;
                lblReb2.ForeColor = Color.Green;
            }

            // compare Ast
            if (Convert.ToDouble(txtAst.Text) > Convert.ToDouble(txtAst2.Text))
            {
                lblAst.ForeColor = Color.Blue;
                lblAst2.ForeColor = Color.Red;
                team1Ctr++;
            }
            else if (Convert.ToDouble(txtAst.Text) < Convert.ToDouble(txtAst2.Text))
            {
                lblAst.ForeColor = Color.Red;
                lblAst2.ForeColor = Color.Blue;
                team2Ctr++;
            }
            else if (Convert.ToDouble(txtAst.Text) == Convert.ToDouble(txtAst2.Text))
            {
                lblAst.ForeColor = Color.Green;
                lblAst2.ForeColor = Color.Green;
            }

            // compare St
            if (Convert.ToDouble(txtSt.Text) > Convert.ToDouble(txtSt2.Text))
            {
                lblSt.ForeColor = Color.Blue;
                lblSt2.ForeColor = Color.Red;
                team1Ctr++;
            }
            else if (Convert.ToDouble(txtSt.Text) < Convert.ToDouble(txtSt2.Text))
            {
                lblSt.ForeColor = Color.Red;
                lblSt2.ForeColor = Color.Blue;
                team2Ctr++;
            }
            else if (Convert.ToDouble(txtSt.Text) == Convert.ToDouble(txtSt2.Text))
            {
                lblSt.ForeColor = Color.Green;
                lblSt2.ForeColor = Color.Green;
            }

            // compare Blk
            if (Convert.ToDouble(txtBlk.Text) > Convert.ToDouble(txtBlk2.Text))
            {
                lblBlk.ForeColor = Color.Blue;
                lblBlk2.ForeColor = Color.Red;
                team1Ctr++;
            }
            else if (Convert.ToDouble(txtBlk.Text) < Convert.ToDouble(txtBlk2.Text))
            {
                lblBlk.ForeColor = Color.Red;
                lblBlk2.ForeColor = Color.Blue;
                team2Ctr++;
            }
            else if (Convert.ToDouble(txtBlk.Text) == Convert.ToDouble(txtBlk2.Text))
            {
                lblBlk.ForeColor = Color.Green;
                lblBlk2.ForeColor = Color.Green;
            }

            // compare To
            if (Convert.ToDouble(txtTo.Text) < Convert.ToDouble(txtTo2.Text))
            {
                lblTo.ForeColor = Color.Blue;
                lblTo2.ForeColor = Color.Red;
                team1Ctr++;
            }
            else if (Convert.ToDouble(txtTo.Text) > Convert.ToDouble(txtTo2.Text))
            {
                lblTo.ForeColor = Color.Red;
                lblTo2.ForeColor = Color.Blue;
                team2Ctr++;
            }
            else if (Convert.ToDouble(txtTo.Text) == Convert.ToDouble(txtTo2.Text))
            {
                lblTo.ForeColor = Color.Green;
                lblTo2.ForeColor = Color.Green;
            }
            txtTeam1.Text = team1Ctr.ToString();
            txtTeam2.Text = team2Ctr.ToString();
        }

        public void CompareTeam2Results(int team1id, int team2id)
        {
            DataTable dtTeam1 = Comparisons.GetTeamStats(team1id);
            DataTable dtTeam2 = Comparisons.GetTeamStats(team2id);
            for (int i = 0; i < dtTeam1.Rows.Count; i++)
            {

            }
        }
    }
}
