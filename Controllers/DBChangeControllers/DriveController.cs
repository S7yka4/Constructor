using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Constructor.Storage.Containers;
using Constructor.Storage.Managers.Assemblies;
using Constructor.Storage.Managers.Cases;
using Constructor.Storage.Managers.Drives;
using Constructor.Storage.Managers.Pairs;
using Constructor.Storage.Models;
using Microsoft.AspNetCore.Mvc;

namespace Constructor.Controllers.DBChangeControllers
{
    [Route("api/[controller]/[action]")]
    public class DriveController : Controller
    {
        private readonly IDrivesManager Manager;
        public static Guid AssemblyId;
        private readonly IAssemblyContainerManager ContainerManager;


        public DriveController(IDrivesManager _manager, IAssemblyContainerManager _ContainerManager)
        {
            Manager = _manager;
            ContainerManager = _ContainerManager;
        }

        [HttpPost]
        public async Task<Drive> Add([FromBody]Drive drive)
        {
            try
            {
                await Manager.Add(drive);
                return drive;
                
            }
            catch
            {
                return null;
            }
        }

        [HttpDelete("{id}")]
        public async Task<string> Delete(string id)
        {
            try
            {
                await Manager.Delete(Guid.Parse(id));
                return "success";
            }
            catch
            {
                return "error";
            }
        }

        [HttpGet("{id}")]
        public Drive GetById(string id)
        {
            return Manager.GetById(Guid.Parse(id));
        }

        [HttpGet("{Id}")]
        public List<Drive> GetCompable(string Id)
        {
            AssemblyId = Guid.Parse( Id);
            ContainerManager.FillContainer(AssemblyId);
            ViewData["id"] = Id;
            return Manager.GetCompableDrives(ContainerManager.Assembly).Drives;
        }

        [HttpGet]
        public List<Drive> GetAll()
        {
            return Manager.GetAll();
        }

        public ViewResult TooMuchDrives()
        {
            return View(AssemblyId);
        }

        

        [HttpPut("{id}")]
        public async Task<Drive> Redact(string Id, [FromBody] Drive drive)
        {
            try
            {
                
                await Manager.Redact(Guid.Parse(Id), drive);
                return drive;
            }
            catch
            {
                return null;
            }
        }


        [HttpGet]
        public ViewResult RedactPage(Guid id)
        {
            return View(Manager.GetById(id));
        }
        [HttpGet]
        public ViewResult ShowMore(Guid id)
        {
            return View(Manager.GetById(id));
        }
    }
}