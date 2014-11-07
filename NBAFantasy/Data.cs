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
    public static class Data
    {
        public static int currentPlayerIndex { get; set; }
        public static void AddNewPlayer()
        {
            using (MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString()))
            {
                cnn.Open();
                using (var cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO fantasystats (playername, fantasyteamid) VALUES ('New Player', 0)";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdatePlayer(int id, string playername, double fg, double ft, double tptm, double pts, double reb, double ast, double st, double blk, double to, string position)
        {
            using (MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString()))
            {
                cnn.Open();
                using (var cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE fantasystats SET playername=@playername, fg=@fg, ft=@ft, 3ptm=@3ptm, pts=@pts, reb=@reb, ast=@ast, st=@st, blk=@blk, tos=@to, position=@position WHERE id=@id";
                    cmd.Parameters.AddWithValue("playername", playername);
                    cmd.Parameters.AddWithValue("fg", fg);
                    cmd.Parameters.AddWithValue("ft", ft);
                    cmd.Parameters.AddWithValue("3ptm", tptm);
                    cmd.Parameters.AddWithValue("pts", pts);
                    cmd.Parameters.AddWithValue("reb", reb);
                    cmd.Parameters.AddWithValue("ast", ast);
                    cmd.Parameters.AddWithValue("st", st);
                    cmd.Parameters.AddWithValue("blk", blk);
                    cmd.Parameters.AddWithValue("to", to);
                    cmd.Parameters.AddWithValue("position", position);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeletePlayer(int id)
        {
            using (MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString()))
            {
                cnn.Open();
                using (var cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM fantasystats WHERE id=@id";
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void RemovePlayer(int id)
        {
            using (MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString()))
            {
                cnn.Open();
                using (var cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE fantasystats SET fantasyteamid=0 WHERE id=@id";
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void AddPlayer(int teamid, int playerid)
        {
            using (MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString()))
            {
                cnn.Open();
                using (var cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE fantasystats SET fantasyteamid=@fantasyteamid WHERE id=@id";
                    cmd.Parameters.AddWithValue("fantasyteamid", teamid);
                    cmd.Parameters.AddWithValue("id", playerid);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

    public static class Comparisons
    {
        public static DataTable GetTeamStats(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString()))
            {
                cnn.Open();
                using (var cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM fantasystats JOIN fantasyteam ON fantasystats.fantasyteamid= fantasyteam.id WHERE fantasystats.id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable GetAvgTotals(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString()))
            {
                cnn.Open();
                using (var cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "SELECT fantasyteam.teamname, ROUND(AVG(fg), 3) as fg, ROUND(AVG(ft), 3) as ft, ROUND(AVG(3ptm), 3) as 3ptm, ROUND(AVG(pts), 3) as pts, ROUND(AVG(reb), 3) as reb, ROUND(AVG(ast), 3) as ast, ROUND(AVG(st), 3) as st, ROUND(AVG(blk), 3) as blk, ROUND(AVG(tos), 3) as tos FROM fantasystats JOIN fantasyteam ON fantasystats.fantasyteamid= fantasyteam.id WHERE fantasyteam.id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
