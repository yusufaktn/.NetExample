using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.Mvc;
using YazOkuluVarmi_API.Shared;
using YazOkuluVarmi_API.Tables;

namespace YazOkuluVarmi_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DersController : Controller
    {
        DbConn dbcon;
        public DersController()
        {
            dbcon = new DbConn();
        }


        [HttpGet(Name = "GetDers")]
        public IActionResult Get()
        {
            try
            {
                var ders = dbcon.conn.GetAll<DERS>();
                return Ok(ders);
            }
            catch(System.Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }



    }
}
