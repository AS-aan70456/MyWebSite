using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorrentMvcProject.Domain.Entity{
    public class GameItem {

        public int id { get; set; }
        public string name { get; set; }
        public string version { get; set; }
        public string desc { get; set; }

        public int like { get; set; }
        public int dizlike { get; set; }

        public string mainImg { get; set; }
        public string img1 { get; set; }
        public string img2 { get; set; }
        public string img3 { get; set; }
        public string img4 { get; set; }

        public string puthToTorrent { get; set; }

        public int ReleaseDate { get; set; }
        public string developer { get; set; }
        public string languages { get; set; }
        public string Windows { get; set; }

        public string CPU { get; set; }
        public string RAM { get; set; }

        public string videoCard { get; set; }
        public int weight { get; set; }

        public string teg { get; set; }
    }
}
