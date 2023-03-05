using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentMvcProject.Domain.Entity;

namespace TorrentMvcProject.ViewModel{
    public class CommentsViewModel{

        public IEnumerable<Comments> _allComments { get; set; }

    }
}
