﻿using AmarDaktar.Repositories.Abastractions.IUnitWork;
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

    public class DistrictController : AppController
    {
        private IDistrictService _service;
        
       
        public DistrictController(IDistrictService iService, IUnitOfWork iUnitOfWork, IWebHostEnvironment hostEnvironment) : base(iUnitOfWork)
        {
            _service = iService;
           
           

        }
        
        [HttpGet]
        public ActionResult<IEnumerable<District>> GetDistrict()
        {
            var data = _service.GetAll()
                .Select(x => new District()
                {
                    Id = x.Id,
                    Name = x.Name,
                  
                }).ToList();

            return data;
        }

      
       

       

       

        

       

    }


}
