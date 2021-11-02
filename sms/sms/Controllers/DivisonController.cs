using AmarDaktar.Repositories.Abastractions.IUnitWork;
using AmarDaktarApp.Controllers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS.BLL.IEntityService;
using SMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DivisonController : AppController
    {
        private IDivisonService _service;
        
        public DivisonController(IDivisonService iService, IUnitOfWork iUnitOfWork, IWebHostEnvironment hostEnvironment) : base(iUnitOfWork)
        {
            _service = iService;
           
          

        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Divison>> GetDivison()
        {
            var data = _service.GetAll()
                .Select(x => new Divison()
                {
                    Id = x.Id,
                    Name = x.Name,
                  
                }).ToList();

            return data;
        }

    
    }


}
