using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Constructor.Storage.Containers;
using Constructor.Storage.Managers.Assemblies;
using Constructor.Storage.Managers.FANs;
using Constructor.Storage.Models;
using Microsoft.AspNetCore.Mvc;

namespace Constructor.Controllers.DBChangeControllers
{
    [Route("api/[controller]/[action]")]
    public class FANController : Controller
    {
        private readonly IFANsManager Manager;
        public static Guid AssemblyId;
        private readonly IAssemblyContainerManager ContainerManager;

        public FANController(IFANsManager _manager, IAssemblyContainerManager _ContainerManager)
        {
            Manager = _manager;
            ContainerManager = _ContainerManager;
        }

        [HttpPost]
        public async Task<FAN> Add([FromBody] FAN fan)
        {

            try
            {   
            await Manager.Add(fan);
            return fan;
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
        public List<FAN> GetCompable(string id)
        {
            AssemblyId = Guid.Parse(id);
            ContainerManager.FillContainer(AssemblyId);
            ViewData["id"] = id;
            return Manager.GetCompableFANs(ContainerManager.Assembly).FANs;
        }

        public ViewResult TooMuchFANs()
        {
            return View(AssemblyId);
        }

        [HttpGet]
        public List<FAN> GetAll()
        {
            return Manager.GetAll();
        }

        [HttpGet("{id}")]
        public FAN GetById(string id)
        {
            return Manager.GetById(Guid.Parse(id));
        }

        [HttpPut("{id}")]
        public async Task<FAN> Redact(string id, [FromBody] FAN fan)
        {
            try
            {
                await Manager.Redact(Guid.Parse(id), fan);
                return fan;
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
