using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorrentMvcProject.Domain.Entity{
    public class Catagory{

        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }

        public IEnumerable<GameItem> gemeItems;
    }
}
