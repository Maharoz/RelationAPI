using AutoMapper;
using MagicVilla_VillaAPI.Models;
using MasjidLibraryAPI.Models.Dto;
using MasjidLibraryAPI.Models;
using MasjidLibraryAPI.Repository.IRepostiory;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MasjidLibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentController : ControllerBase
    {

        protected APIResponse _response;
        private readonly IParent _dbParent;
        private readonly IMapper _mapper;
        private readonly IHostEnvironment _hostEnvironment;
        public ParentController(IParent dbParent, IMapper mapper, IHostEnvironment hostEnvironment)
        {
            _dbParent = dbParent;
            _mapper = mapper;
            _hostEnvironment = hostEnvironment;
            _response = new();
        }


        [HttpPost]
        public async Task SaveParents()
        {
            try
            {
                await _dbParent.SaveParentWithChildren();

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
      
        }
    }
}
