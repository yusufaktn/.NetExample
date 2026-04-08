using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.Mvc;
using YazOkuluVarmi_API.Shared;
using YazOkuluVarmi_API.Tables;

namespace YazOkuluVarmi_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UniversiteController : Controller
    {
        DbConn dbcon;
        public UniversiteController()
        {
            dbcon = new DbConn();
        }

        [HttpGet(Name = "GetUniversite")]
        public IActionResult Get()
        {
            try
            {
                var universite = dbcon.conn.GetAll<UNIVERSITE>();
                return Ok(universite);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("{bkod}", Name = "GetUniversiteByBkod")]
        public IActionResult Get(string bkod)
        {
            try
            {
                var universite = dbcon.conn.Query<UNIVERSITE>($@"SELECT U.AD,U.BKOD,D.AD FROM UNIVERSITE U LEFT JOIN DERS D ON U.BKOD=D.BKOD WHERE U.BKOD ='{bkod}'");
                return Ok(universite);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


    }
}
