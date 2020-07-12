using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookBlog.Identity.Models
{
    public class UserOutputModel
    {
        public UserOutputModel(string token)
        {
            this.Token = token;
        }

        public string Token { get; }
    }
}
