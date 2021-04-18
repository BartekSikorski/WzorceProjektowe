using System;

namespace WzorceProjektowe.Behavioral.TemplateMethod
{
    internal class FileLogger : Logger<FileService>
    {
        protected override FileService ConnectToService()
        {
            Console.WriteLine("Opening File.");
            return new FileService();
        }

        protected override void SaveLog(FileService service, string messageToLog)
        {
            service.Write(messageToLog);
        }
    }
}