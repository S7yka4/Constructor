using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Constructor.Storage.Containers;
using Constructor.Storage.Managers.Assemblies;
//using Constructor.Storage.Managers.Assemblies;
using Constructor.Storage.Managers.Cases;
using Constructor.Storage.Managers.Devices;
using Constructor.Storage.Models;
using Microsoft.AspNetCore.Mvc;

namespace Constructor.Controllers.DBChangeControllers
{
    [Route("api/[controller]/[action]")]
    public class CaseController : Controller
    {
        private readonly ICasesManager Manager;
        public static Guid AssemblyId;
        private readonly IAssembliesManager AssembliesManager;
        private readonly IAssemblyContainerManager ContainerManager;

        public CaseController(ICasesManager _Manager, IAssembliesManager _AssembliesManager, IAssemblyContainerManager _ContainerManager)
        {
            Manager = _Manager;
            AssembliesManager = _AssembliesManager;
            ContainerManager = _ContainerManager;
        }

        [HttpPost]
        public async Task<Case> Add([FromBody] Case _case)
        {
            try
            {

                await Manager.Add(_case);
                return _case;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        [HttpDelete("{id}")]
        public async Task<string> Delete(Guid id)
        {
            try
            {
                await Manager.Delete(id);
                return "Success";
            }
            catch
            {
                return "Error";
            }
        }

        [HttpPut("{id}")]
        public async Task<Case> Redact(Guid id, [FromBody] Case Case)
        {
            try
            {
                await Manager.Redact(id, Case);
                return Case;
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

        [HttpGet("{id}")]
        public Case GetById(Guid id)
        {
            return Manager.GetById(id);
        }

        [HttpGet]
        public List<Case> GetAll()
        {
            return Manager.GetAll();
        }


        [HttpGet("{_Container}")]
        public List<Case> GetCompable(string _Container)
        {
            AssemblyId = Guid.Parse(_Container);
            ViewData["id"] = AssemblyId;
            ContainerManager.FillContainer(AssemblyId);
            return Manager.GetCompableCases(ContainerManager.Assembly);
        }

        [HttpPost]
        async public Task<Assembly> SetToAssembly([FromBody]IdPair pair)
        {
            var Assembly = AssembliesManager.Find(Guid.Parse(pair.AssemblyId));
            Assembly.Case = Guid.Parse(pair.DeviceId);
            await AssembliesManager.Redact(Assembly);
            return Assembly;
        }

         /////////////////////////


       /* [HttpPost]
        public ViewResult Output2(Guid _tmp)
        {
            Id = _tmp;
            ViewData["id"] = Id;
            return View(Manager.GetAll());
        }*/

    }
}
