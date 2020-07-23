using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookCatalog.Common.Controllers;
using BookCatalog.Identity.Services;
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

            return null; // RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
