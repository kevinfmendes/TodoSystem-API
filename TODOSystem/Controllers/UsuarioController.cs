using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TODOSystem.Models;

namespace TODOSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UsuarioModel>> FindAdll() {
            
            return Ok(); //200

        } 
    }
}
