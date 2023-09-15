using CreateDb.Models;
using CreateDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CreateDb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();


            builder.Services.AddDbContext<SchoolContext>(options =>
            {
                // Server=(localdb)\\name
                options.UseSqlServer("Server=(localdb)\\Local;Database=SchoolDB;Trusted_Connection=True;TrustServerCertificate=True;");
            });
                

            var app = builder.Build();

            
        }
    }
}