using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentMvcProject.Domain.Entity;

namespace TorrentMvcProject.ViewModel{
    public class HomeViewModel{
        public IEnumerable<Comments> allComment { get; set; }
        public GameItem Game { get; set; }
        public Comments newComment { get; set; }
    }
}
