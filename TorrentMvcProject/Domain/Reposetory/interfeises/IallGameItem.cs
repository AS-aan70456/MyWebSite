using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentMvcProject.Domain.Entity;

namespace TorrentMvcProject.Domain.Reposetory.interfeises{
    public interface IallGameItem{
        IEnumerable<GameItem> GetGameItem();
        GameItem GetGameItemById(int id);
        void SaveGameItem(GameItem newGameItem);
        void DeleteGameItem(int id);
        public GameItem GetGameItemByName(string Name);
    }
}
