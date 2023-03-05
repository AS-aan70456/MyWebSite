using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentMvcProject.Domain.Entity;

namespace TorrentMvcProject.Domain.Reposetory.interfeises{
    public interface IallComments{
        IEnumerable<Comments> GetComments();
        Comments GetCommentsById(int id);
        void SaveComments(Comments newGameItem);
        void DeleteComments(int id);
        public Comments GetCommentsName(string Name);

    }
}
