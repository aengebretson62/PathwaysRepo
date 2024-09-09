using System;

namespace InterfaceAndDI
{
    public class NoteBookLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Inside Log method of NoteBookLogger.");
            LogToNoteBook(message);
        }
        private void LogToNoteBook(string message)
        {
            Console.WriteLine("Method: LogToNoteBook, Text: {0}", message);
        }
    }
}
