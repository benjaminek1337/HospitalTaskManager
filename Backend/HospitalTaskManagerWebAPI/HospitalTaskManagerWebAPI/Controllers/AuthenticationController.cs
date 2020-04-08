using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalTaskManagerWebAPI.Data;
using HospitalTaskManagerWebAPI.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HospitalTaskManagerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public AuthenticationController(UserManager<AppUser> userManager, 
            SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost]
        [Route("Register")]
        //POST : api/Authentication/Register
        public async Task<Object> PostRegisterUser(AppUserViewModel model)
        {
            var user = new AppUser()
            {
                UserName = model.UserName,
                Email = model.Email
            };
            try
            {
                var result = await userManager.CreateAsync(user, model.Password);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}