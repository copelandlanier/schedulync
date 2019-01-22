using System;
using System.IO;
using System.Linq;
using LiteDB;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace Calendar_NEW
{
    public class DATABASE_OPERATIONS : Global_Access
    {
        // Main BSON Document
        Calendar AddEmployee = new Calendar
        {
            Id = 0,
            Notes = "Notes",
            Alarm_Set = false,
            Repeat_Set = false,
            Title = "Blank Title",
            Timeline_Event_Num = 0,
            Date_Start = DateTime.Today,
            Date_End = DateTime.Today,
            Time_Start = DateTime.Now,
            Time_End = DateTime.Now
        };

        //EventWaitHandle eventWait = new EventWaitHandle(true, EventResetMode.AutoReset, "EVENT_WAIT");
        private string EXTERNAL_DATABASE;

        public void DATABASE_OPERATONS()
        {
            //
        }

        // Update Local Database. Upload Configuration file and Avatar image to remote database.
        public void CREATE_DATABASE_LOCAL()
        {
            string INTERNAL_DATABASE = AppDomain.CurrentDomain.BaseDirectory + "database_internal.db";
            EXTERNAL_DATABASE = DATABASE_EXTERNAL + DATABASE_NAME + ".db";
            AVATAR_DB = @"images/" + FIRST_NAME + "_" + LAST_NAME +  "/" + FIRST_NAME + "_" + LAST_NAME + ".avt";
            CONFIG_DB = @"configurations/" + FIRST_NAME + "_" + LAST_NAME + "/" + FIRST_NAME + "_" + LAST_NAME + ".cfg";
          
            // First run settings only. Check for 'Checked' Button
          if (dialog_database.radio_NewDB.Checked == true)
                {
                    using (var db = new LiteDatabase(INTERNAL_DATABASE))
                    {
                        var EmployeeCollection = db.GetCollection<Calendar>(FIRST_NAME + "_" + LAST_NAME);

                        if (AVATAR_LOCAL != null)
                        {
                            db.FileStorage.Upload(AVATAR_DB, AVATAR_LOCAL);
                        }

                        if (CONFIG_DB != null)
                        {
                            db.FileStorage.Upload(CONFIG_DB, AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/configuration");
                        }

                        EmployeeCollection.Insert(AddEmployee);
                        EmployeeCollection.EnsureIndex(x => x.Id, true);
                    }

                // Copy local database to remote location. Overwrite operation. Will wait for reconnection if network is disconnected.
                File.Copy(INTERNAL_DATABASE, DATABASE_EXTERNAL + DATABASE_NAME + ".db", true);
                    dialog_database.radio_NewDB.Checked = false;
                }
          
            if (dialog_database.radio_ExistingDB.Checked == true)
            {
                MonolithConsole("Create Database // External Database" + EXTERNAL_DATABASE);
                using (var db = new LiteDatabase(EXTERNAL_DATABASE))
                {
                    var EmployeeCollection = db.GetCollection<Calendar>(FIRST_NAME + "_" + LAST_NAME);

                    if (AVATAR_LOCAL != null)
                    {
                        db.FileStorage.Upload(AVATAR_DB, AVATAR_LOCAL);
                    }

                    if (CONFIG_DB != null)
                    {
                        db.FileStorage.Upload(CONFIG_DB, AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/configuration");
                    }

                    EmployeeCollection.Insert(AddEmployee);
                    EmployeeCollection.EnsureIndex(x => x.Id, true);
                }

                // Copy remote database to local location. Overwrite operation. Will wait for reconnection if network is disconnected.
                File.Copy(EXTERNAL_DATABASE, INTERNAL_DATABASE, true);
                    dialog_database.radio_ExistingDB.Checked = false;
            }
        }

        // Query by name
        public void NAME_QUERY()
        {

        }

        // Query by date
        public void DATE_QUERY()
        {

        }

        // Add record
        public void ADD_RECORD()
        {

        }

        // Insert record
        public void INSERT_RECORD()
        {

        }

        // Delete record
        public void DELETE_RECORD()
        {

        }

        // Retrieve image file from local database.
        public void RETRIEVE_IMAGE_FILE(string NAME_RETRIEVE)
        {
            string INTERNAL_DATABASE = AppDomain.CurrentDomain.BaseDirectory + "database_internal.db";
            AVATAR_DB = @"images/" + NAME_RETRIEVE + "/" + NAME_RETRIEVE + ".avt";

            using (var db = new LiteDatabase(INTERNAL_DATABASE))
            {
                if(db.FileStorage.Exists(AVATAR_DB))
                {
                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/" + "avatar") == false)
                    {
                        LiteFileInfo file = db.FileStorage.FindById(AVATAR_DB);
                        file.SaveAs(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/" + "avatar");
                    }
                }
            }
        }

        // Copy the configuration file for default user to the Calendar_Configuration folder.
        public void RETRIEVE_CONFIG_FILE(string NAME_RETRIEVE)
        {
            string INTERNAL_DATABASE = AppDomain.CurrentDomain.BaseDirectory + "database_internal.db";
            CONFIG_DB = @"configurations/" + NAME_RETRIEVE + "/" + NAME_RETRIEVE + ".cfg";

            using (var db = new LiteDatabase(INTERNAL_DATABASE))
            {
                if (db.FileStorage.Exists(CONFIG_DB))
                {
                    LiteFileInfo file = db.FileStorage.FindById(CONFIG_DB);
                    file.SaveAs(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/" + "configuration");
                }
            }
        }

        // Copy the configuration files for remote linked users to the local Calendar_Configuration folder.
        public void RETRIEVE_REMOTE_USERS()
        {
            string[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/configuration");

            DATABASE_NAME = null;
            DATABASE_EXTERNAL = null;

            DATABASE_NAME = lines[17];
            DATABASE_EXTERNAL = lines[18];

            EXTERNAL_DATABASE = DATABASE_EXTERNAL + DATABASE_NAME + ".db";

            FileInfo FileFromDirectory = new FileInfo(EXTERNAL_DATABASE);

                using (var db = new LiteDatabase(EXTERNAL_DATABASE))
                {
                    var EmployeeCollection = db.GetCollectionNames();

                    while (db.Engine.Locker.ThreadState != LockState.Unlocked)
                    {
                        Console.WriteLine("Wainting for file to be unlocked");
                    }

                for (int x = 3; x < EmployeeCollection.Count(); x++)

                {

                    MonolithConsole("Count Add List");
                    PersonnelList.Add(EmployeeCollection.ElementAtOrDefault(x));
                    string FULL_NAME = EmployeeCollection.ElementAtOrDefault(x);
                    LiteFileInfo file = db.FileStorage.FindById("configurations/" + FULL_NAME + "/" + FULL_NAME + ".cfg");

                    if (file != null)
                    {

                        if (lines[8] + "_" + lines[9] != FULL_NAME)
                            {
                                    file.SaveAs(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/" + FULL_NAME + ".cfg", true);
                            }
                        }
                    }
            }
        }

        // Copy the avatar files for remote linked users to the local Calendar_Configuration folder.
        public void RETRIEVE_REMOTE_IMAGES(string NAME_RETRIEVE)
        {
            string[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/configuration");

            DATABASE_NAME = null;
            DATABASE_EXTERNAL = null;

            DATABASE_NAME = lines[17];
            DATABASE_EXTERNAL = lines[18];

            EXTERNAL_DATABASE = DATABASE_EXTERNAL + DATABASE_NAME + ".db";

            AVATAR_DB = @"images/" + NAME_RETRIEVE + "/" + NAME_RETRIEVE + ".avt";

            FileInfo FileFromDirectory = new FileInfo(EXTERNAL_DATABASE);

                MonolithConsole("File is unlocked in RETRIEVE REMOTE USERS " + IsFileLocked(FileFromDirectory, EXTERNAL_DATABASE));

            using (var db = new LiteDatabase(EXTERNAL_DATABASE))
            {
                
                var EmployeeCollection = db.GetCollectionNames();

                while (db.Engine.Locker.ThreadState != LockState.Unlocked)
                {
                    Console.WriteLine("Wainting for file to be unlocked");
                }

                //

                    for (int x = 3; x < EmployeeCollection.Count(); x++)
                    {
                        string FULL_NAME = EmployeeCollection.ElementAtOrDefault(x);
                        LiteFileInfo file = db.FileStorage.FindById("images/" + FULL_NAME + "/" + FULL_NAME + ".avt");

                        if (file != null)
                        {
                            if (lines[8] + "_" + lines[9] != FULL_NAME)
                            {
                                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/" + FULL_NAME + ".avt") == false)
                                {
                                    file.SaveAs(AppDomain.CurrentDomain.BaseDirectory + "Calendar_Configuration/" + FULL_NAME + ".avt", true);
                                }
                            }
                        }
                    }
            }
        }

        public bool IsFileLocked(FileInfo file, string Path)
        {
            FileStream stream = null;
            try
            {
                if (File.Exists(Path) == true)
                {
                    using (FileStream inputStream = file.Open(System.IO.FileMode.Open, FileAccess.Read, FileShare.None))
                    {
                        if (inputStream.Length > 0)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
            catch (IOException)
            {
                return true;
            }

            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }

        public bool IsFileLockedDatabase(FileInfo file, string Path)
        {
            FileStream stream = null;
            try
            {
                if (File.Exists(Path) == true)
                {
                    using (FileStream inputStream = file.Open(System.IO.FileMode.Open, FileAccess.Read, FileShare.None))
                    {
                        if (inputStream.Length > 0)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
            catch (IOException)
            {
                return true;
            }

            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }

        public void ADD_EVENT()
        {
        }

        public void DELETE_EVENT()
        {

        }

        public void UPDATE_EVENT(int TimeIn, int TimeOut, string TimeOfDay)
        {
            //Point PIn = new Point(TimeIn, TimeOut * 2);
            //Point POut = new Point(TimeOut, TimeOut *2);
            display_Panel1.day_Control_1.Day_Expanding_Panel_01.Location = new Point(0, TimeOut);
            display_Panel1.day_Control_1.Day_Expanding_Panel_01.Height = TimeIn;
        }        
    }
}
