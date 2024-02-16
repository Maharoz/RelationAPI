using System.ComponentModel.DataAnnotations;

namespace MasjidLibraryAPI.Models.Dto
{
    public class SubCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }
}
