using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineVotingSystem.Areas.Identity.Data;
using OnlineVotingSystem.Data;
using OnlineVotingSystem.ViewModel;

namespace OnlineVotingSystem.Controllers
{
    public class Admin : Controller
    {
        private UserManager<OnlineVotingSystemUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private OnlineVotingSystemContext _context;

        public Admin(UserManager<OnlineVotingSystemUser> userManager, 
            RoleManager<IdentityRole> roleManager, 
            OnlineVotingSystemContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }
        [HttpGet]

        public async Task<IActionResult> ViewVoters()
        {

            var voters = await (from user in _context.Users
                                         join userRole in _context.UserRoles
                                         on user.Id equals userRole.UserId
                                         join role in _context.Roles
                                         on userRole.RoleId equals role.Id
                                         where role.Name != "Admin"
                                         select user)
                                        .ToListAsync();
            ConvertApplicationUser ViewModelUsers = new ConvertApplicationUser(voters);
            return View(ViewModelUsers.ApplicationUsers);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(string id)
        {
            var user = _context.Users.Where(x=>x.Id.Equals(id)).FirstOrDefault();
            ConvertApplicationUser viewModelUser = ConvertApplicationUser.EditConvertModel(user);
            return View(viewModelUser);
        }
    }
}
