using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentMvcProject.Domain.Reposetory.interfeises;
using TorrentMvcProject.Domain.Reposetory.RepModel;
using TorrentMvcProject.Service;
using TorrentMvcProject.ViewModel;

namespace TorrentMvcProject.Controllers{
    public class CommentsController : Controller{

        public IallComments allComments { get; set; }

        public CommentsController(IallComments allComments) {
            this.allComments = allComments;
        }


        [Route("Comments/Comments")]
        [Route("Comments/Comments/{ID}")]
        public ActionResult Comments(int ID) {

            CommentsViewModel model = new CommentsViewModel(){
                _allComments = PageMeneger.PegeSelect( allComments.GetComments() ,12, ID)
            };

            ViewBag.ID = ID;
            ViewBag.Max = (model._allComments.ToList().Count == 11);
            ViewBag.next = "/Comments/Comments/" + (ID + 1);
            ViewBag.back = "/Comments/Comments/" + (ID - 1);

            return View(model);
        }
    }
}
