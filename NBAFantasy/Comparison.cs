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
