using System;
using LiteDB;
using System.Drawing;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Calendar_NEW
{
    public class Global_Access : Form
    {
        public static void MonolithConsole(string Input)
        {
            if(StringHolder.Count > 2000)
            {
                StringHolder.Clear();
            }

            StringHolder.Add(Input);
                dialog_console.textBox_Dialog_Console.Clear();

            for (int x = 0; x < StringHolder.Count; x++)
            {
                dialog_console.textBox_Dialog_Console.AppendText(StringHolder[x] + Environment.NewLine);
            }
        }

        public static List<string> StringHolder = new List<string> { };
        public static string vicente = "Lou Vicente";
        public static string mocilan = "Tim Mocilan";
        public static string keller = "Kevin Keller";
        public static string fleischacker = "Rob Fleischacker";
        public static string friedman = "Jeff Friedman";
        public static string bautista = "Christine Bautista";
        public static string lanier = "Copeland Lanier";
        public static string martano = "Anthony Martano";

        public static List<string> PersonnelList = new List<string> { };

        /// First Run Switch
        public static int First_Run_Switch = 0;

        /// Status Elements Initiation
        public static StatusStrip statusStrip1;
        public static ToolStripStatusLabel toolStripStatusLabel1;
        public static ToolStripProgressBar toolStripProgressBar1;
        public static FileSystemWatcher fileSystemWatcher_WebUpload;
        public static FileSystemWatcher fileSystemWatcher_Config;
        public static FileSystemWatcher fileSystemWatcher_RemoteDB;
        public static BackgroundWorker backgroundWorker_Listener;

        /// Main panel program entry point
        public static Display_Panel display_Panel1;

        /// Form implementations
        public static Dialog_Console dialog_console = new Dialog_Console();
        public static Dialog_FirstRun_Database dialog_database = new Dialog_FirstRun_Database();
        public static Dialog_FirstRun_Settings dialog_settings = new Dialog_FirstRun_Settings();
        public static Dialog_FirstRun_FTPSettings dialog_ftpsettings = new Dialog_FirstRun_FTPSettings();
        public static Dialog_FirstRun_DuplicateEntries dialog_duplicate = new Dialog_FirstRun_DuplicateEntries();
        public static Dialog_SettingsInternal dialog_internalsettings = new Dialog_SettingsInternal();
        public static Config_Load config_load = new Config_Load();
        public static Dialog_Exit dialog_exit = new Dialog_Exit();

        /// Software Registration Information
        public static string SoftwareRegistration;
        public static string ComputerUserName;

        /// Store Image Avatar
        public static Image ImageAvatar;

        /// Color setting transportation variable
        public static Color ColorTransfer;

        /// Error Color
        public static Color ErrorColor = Color.LightPink;

        /// Day View Background Colors 
        public static Color orange = Color.FromArgb(255, 209, 167);
        public static Color monolith = Color.FromArgb(192, 169, 255);
        public static Color blue = Color.FromArgb(168, 186, 255);
        public static Color pink = Color.FromArgb(255, 164, 205);
        public static Color aqua = Color.FromArgb(176, 240, 246);
        public static Color lavendar = Color.FromArgb(225, 178, 249);
        public static Color yellow = Color.FromArgb(232, 255, 167);
        public static Color green = Color.FromArgb(184, 237, 190);
        public static Color grey = Color.FromArgb(208, 208, 208);
        public static Color peach = Color.FromArgb(254, 179, 155);
        public static Color defaultColor = Color.DarkGray;

        // Theme Colors
        public static Color theme_orange = Color.FromArgb(233, 128, 32);
        public static Color theme_monolith = Color.FromArgb(97, 52, 221);
        public static Color theme_blue = Color.FromArgb(39, 74, 211);
        public static Color theme_pink = Color.FromArgb(203, 27, 106);
        public static Color theme_aqua = Color.FromArgb(9, 200, 218);
        public static Color theme_lavendar = Color.FromArgb(142, 30, 199);
        public static Color theme_yellow = Color.FromArgb(217, 196, 19);
        public static Color theme_green = Color.FromArgb(14, 187, 94);
        public static Color theme_grey = Color.FromArgb(120, 120, 120);
        public static Color theme_peach = Color.FromArgb(227, 84, 38);
        public static Color theme_defaultColor = Color.DarkGray;

        // Database Variables
        public static string DATABASE_INTERNAL;
        public static string DATABASE_EXTERNAL;
        public static string DATABASE_NAME;
        public static string DATABASE_PATH;
        public static string FIRST_NAME;
        public static string LAST_NAME;
        public static string EMAIL;
        public static string PHONE;
        public static string THEME;
        public static string JOB_TITLE;
        public static string AVATAR_LOCAL;
        public static string AVATAR_DB;
        public static string CONFIG_DB;
        public static bool ADMINISTRATOR;
        public static bool FIRSTRUN_SWITCH;
        public static string COMPUTER_USERNAME;
        public static int TIMELINE_EVENT_NUMBER;

        public static void CLEAR_DATABASE_VARIABLES()
        {
            DATABASE_INTERNAL = "";
            DATABASE_EXTERNAL = "";
            DATABASE_NAME = "";
            FIRST_NAME = "";
            LAST_NAME = "";
            EMAIL = "";
            PHONE = "";
            THEME = "";
            JOB_TITLE = "";
            AVATAR_LOCAL = "";
            AVATAR_DB = "";
            TIMELINE_EVENT_NUMBER = 0;
        }

        public class Calendar
        {
            [BsonId]
            public int Id { get; set; }
            public int Timeline_Event_Num { get; set; }
            public string Title { get; set; }           
            public string Notes { get; set; }
            public DateTime Date_Start { get; set; }
            public DateTime Date_End { get; set; }
            public DateTime Time_Start { get; set; }
            public DateTime Time_End { get; set; }
            public bool Alarm_Set { get; set; }
            public bool Repeat_Set { get; set; }
            public override string ToString()
            { return string.Format("Id: {0}, Timeline_Event_Num {1}, Title: {2}, Notes: {3}, Start Date: {4}, End Date: {5}, Begin Time: {6}, End Time: {7}, Alarm_Set: {8}, Repeat_Set: {9}", Id, Title, Notes, Date_Start, Date_End, Time_Start, Time_End, Alarm_Set, Repeat_Set); }
        }
    }
}
