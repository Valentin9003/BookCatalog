using System.Threading.Tasks;
using AutoMapper;
using BookCatalog.Admin.Services.Identity;
using BookCatalog.Common.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookCatalog.Admin.Controllers.Identity
{
    public class IdentityController : ApiController
    {
        private readonly IIdentityService identityService;
        private readonly IMapper mapper;

        public IdentityController(
            IIdentityService identityService,
            IMapper mapper)
        {
            this.identityService = identityService;
            this.mapper = mapper;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string model)
        {
            return null;
        }
           

        public IActionResult Logout()
        {

            return null;
        }
    }
}
