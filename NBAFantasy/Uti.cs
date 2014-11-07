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
    public static class Uti
    {
        public static DataTable GetStats()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString()))
            {
                cnn.Open();
                using (var cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM fantasystats";
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable GetAllAvailablePlayers()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString()))
            {
                cnn.Open();
                using (var cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM fantasystats WHERE fantasyteamid = 0";
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable GetTeams()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString()))
            {
                cnn.Open();
                using (var cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM fantasyteam";
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable GetFantasyStats(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString()))
            {
                cnn.Open();
                using (var cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM fantasystats WHERE fantasyteamid = @fantasyteamid order by id";
                    cmd.Parameters.AddWithValue("Fantasyteamid", id);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable GetIndividualStats(int id)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection cnn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString()))
            {
                cnn.Open();
                using (var cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM fantasystats WHERE id=@id";
                    cmd.Parameters.AddWithValue("id", id);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
