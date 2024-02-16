using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Repository;
using MasjidLibraryAPI.Models;
using MasjidLibraryAPI.Repository.IRepostiory;
using Microsoft.EntityFrameworkCore;

namespace MasjidLibraryAPI.Repository
{
   
    public class ParentRepository : Repository<Parent>, IParent
    {
        private readonly ApplicationDbContext _db;
        public ParentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public Task SaveParentWithChildren()
        {
            var newParent = new Parent
            {
                // Set other parent properties...
                Children = new List<Child>
            {
                new Child { Name = "ChildName1" },
                new Child { Name = "ChildName2" }
                // Add more child entities as needed
            }
            };

            _db.Parents.Add(newParent);
            _db.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
