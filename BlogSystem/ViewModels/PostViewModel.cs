using BlogSystem.Common.Mapping;
using BlogSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSystem.ViewModels
{
    public class PostViewModel : IMapFrom<Post>
    {
        
        public string Title { get; set; }

        public string Content { get; set; }

        public string Autor { get; set; }

        public DateTime? CreatedOn { get; set; }

    }
}