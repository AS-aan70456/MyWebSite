﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorrentMvcProject.Service{
    public class Config{
        public static string ConnectionString { get; set; }
        public static string CompanyName { get; set; }
        public static string CompanyPhone { get; set; }
        public static string CompanyHelpPhone { get; set; }
        public static string CompanyEmail { get; set; }
    }
}