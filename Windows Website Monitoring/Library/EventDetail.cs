﻿using System;
//NOTE: Used in the MainForm
namespace Windows_Website_Monitoring.Library
{
    public class EventDetail
    {
        public string WebsiteName { get; set; }
        public string Description { get; set; }
        public DateTime EventTime { get; set; }
    }
}