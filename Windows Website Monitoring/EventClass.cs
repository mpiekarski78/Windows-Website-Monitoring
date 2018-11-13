using System;

//Formularz (MainForm) - głowny form - strona głowna
namespace Windows_Website_Monitoring
{
    public class EventClass
    {
        public string eventWebsite { get; set; }
        public string eventType { get; set; }
        public DateTime eventDateTime { get; set; }
    }
}