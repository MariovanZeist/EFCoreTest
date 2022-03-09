using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EFCoreTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var ctx = new TestDbContext();
            var roles = await ctx.Users.Where(u => u.Id == Guid.NewGuid()).Select(u => u.Roles.Select(r => r.Name)).FirstOrDefaultAsync();
        }
    }
}
