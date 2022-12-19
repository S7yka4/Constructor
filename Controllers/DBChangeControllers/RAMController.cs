using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Constructor.Storage.Containers;
using Constructor.Storage.Managers.Assemblies;
using Constructor.Storage.Managers.RAMs;
using Constructor.Storage.Models;
using Microsoft.AspNetCore.Mvc;

namespace Constructor.Controllers.DBChangeControllers
{
    [Route("api/[controller]/[action]")]
    public class RAMController : Controller
    {
        private readonly IRAMsManager Manager;
        //public static Guid Id;
        private readonly IAssemblyContainerManager ContainerManager;

        public RAMController(IRAMsManager _Manager, IAssemblyContainerManager _ContainerManager)
        {
            Manager = _Manager;
            ContainerManager = _ContainerManager;
        }


        [HttpGet("{_Container}")]
        public List<RAM> GetCompable(string _Container)
        {
            var Id = Guid.Parse(_Container);
            ViewData["id"] = Id;
            ContainerManager.FillContainer(Id);
            return Manager.GetCompableRAMs(ContainerManager.Assembly).RAMs;
        }

        [HttpGet]
        public List<RAM> GetAll()
        {
            return Manager.GetAll();
        }

        [HttpGet("{id}")]
        public RAM GetById(string id)
        {
            return Manager.GetById(Guid.Parse(id));
        }


        [HttpPost]
        public async Task<RAM> Add([FromBody] RAM ram)
        {
            try
            {
              
                await Manager.Add(ram);
                return ram;
            }
            catch
            {
                return null ;
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

        [HttpPut("{id}")]
        public async Task<RAM> Redact(string id, [FromBody] RAM ram)
        {
            try
            {
                await Manager.Redact(Guid.Parse(id), ram);
                return ram;
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
