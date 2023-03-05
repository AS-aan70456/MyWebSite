using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentMvcProject.Domain.Entity;

namespace TorrentMvcProject.Service{
    public static class PageMeneger{

        public static IEnumerable<GameItem> PegeSelect(IEnumerable<GameItem> gameItems, int pageNumber, int page) {
            return gameItems.Skip(pageNumber * page).Take(pageNumber);
        }
        public static IEnumerable<Comments> PegeSelect(IEnumerable<Comments> gameItems, int pageNumber, int page){
            return gameItems.Skip(pageNumber * page).Take(pageNumber);
        }
    }
}
