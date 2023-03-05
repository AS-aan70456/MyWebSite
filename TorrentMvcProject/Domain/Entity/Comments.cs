using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorrentMvcProject.Domain.Entity{
    public class Comments{

        public int id { get; set; }
        public string Name { get; set; }
        public string Gmail { get; set; }

        public string DataPost { get; set; }
        public string Text { get; set; }


        public int GameId { get; set; }
        public string GameName { get; set; }
    }
}
