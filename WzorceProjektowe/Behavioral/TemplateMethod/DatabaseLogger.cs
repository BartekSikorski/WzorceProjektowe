﻿using System;

namespace WzorceProjektowe.Behavioral.TemplateMethod
{
    public class DatabaseLogger : Logger<DatabaseService>
    {
        protected override void OnCloseService()
        {
            base.OnCloseService();
            Console.WriteLine("Disconnected from Database.");
        }

        protected override void SaveLog(DatabaseService service, string messageToLog)
        {
            service.Insert(messageToLog);
        }

        protected override DatabaseService ConnectToService()
        {
            Console.WriteLine("Connecting to Database.");
            return new DatabaseService();
        }
    }
}