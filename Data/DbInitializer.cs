using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebProgrammingMovie.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgrammingMovie.Data
{
    public class DbInitializer : IDbInitializer
    {

        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(ApplicationDbContext db, 
            UserManager<IdentityUser> userManager, 
            RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }


        public async void Initialize()
        {
            try
            {
                if(_db.Database.GetPendingMigrations().Count()>0)
                {
                    _db.Database.Migrate();
                }
            }
            catch(Exception ex)
            {

            }

            if (_db.Roles.Any(r => r.Name == "Admin")) return;

            _roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole("Uye")).GetAwaiter().GetResult();

            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                Name = "Muhammet",
                Surname="Çağatay",
                EmailConfirmed = true,
                PhoneNumber = "1112223333"
            }, "admin123").GetAwaiter().GetResult();


            _userManager.AddToRoleAsync(_db.Users.FirstOrDefaultAsync(u => u.Email == "admin@gmail.com").GetAwaiter().GetResult(), "Admin").GetAwaiter().GetResult();

        }
    }
}
