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

    public class UpazilaController : AppController
    {
        private IUpazilaService _service;
        
        private readonly IWebHostEnvironment _hostEnvironment;
        public UpazilaController(IUpazilaService iService, IUnitOfWork iUnitOfWork, IWebHostEnvironment hostEnvironment) : base(iUnitOfWork)
        {
            _service = iService;
           
           

        }
      
        [HttpGet]
        public ActionResult<IEnumerable<Upazila>> GetUpazila()
        {
            var data = _service.GetAll()
                .Select(x => new Upazila()
                {
                    Id = x.Id,
                    Name = x.Name,
                  
                }).ToList();

            return data;
        }

      

        

       

      

       

    }


}
