using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentMvcProject.Domain.Entity;

namespace TorrentMvcProject.ViewModel{
    public class GameViewModel{

        public IEnumerable<GameItem> _allGameItems { get; set; }
    }
}
