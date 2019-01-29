using System;
using System.Collections.Generic;
using System.Text;
using AspNetCoreTodo.Models;
using AspNetCoreTodo.Services;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace AspNetCoreTodo.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser,IdentityRole,string>
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

         
        public DbSet<TodoItem> Items { get; set; }
    }
}
