using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Constructor.Storage.Managers.Pairs;
using Constructor.Storage.Models;
using Microsoft.AspNetCore.Mvc;

namespace Constructor.Controllers.PairControllers
{
    [Route("api/[controller]/[action]")]
    public class PairController : Controller
    {
        private readonly IDAPManager DAPManager;
        private readonly IRAPManager RAPManager;
        private readonly IFAPManager FAPManager;

        public PairController(IDAPManager _DAPManager, IRAPManager _RAPManager, IFAPManager _FAPManager)
        {
            DAPManager = _DAPManager;
            RAPManager= _RAPManager;
            FAPManager= _FAPManager;
        }

        async public Task<IActionResult> DeleteAllPairsWithThisAssembly(Guid AssemblyId)
        {
            await DAPManager.DeleteAllPairsWithAssemblyId(AssemblyId);
            await FAPManager.DeleteAllPairsWithAssemblyId(AssemblyId);
            await RAPManager.DeleteAllPairsWithAssemblyId(AssemblyId);
            return RedirectToAction("Output", "Assembly");
        }

        [HttpPost]
        async public Task<string> AddDriveInAssembly([FromBody] IdPair pair)
        {
           return  await DAPManager.MakeNewPair(Guid.Parse(pair.AssemblyId), Guid.Parse(pair.DeviceId));
        }

        [HttpPost]
        async public Task<string> AddFANInAssembly([FromBody] IdPair pair)
        {
            return await FAPManager.MakeNewPair(Guid.Parse(pair.AssemblyId), Guid.Parse(pair.DeviceId));

        }

        [HttpGet]
        async public Task<string> DeleteDriveInPair([FromBody] IdPair pair)
        {

            return await DAPManager.DeletePair(Guid.Parse(pair.AssemblyId), Guid.Parse(pair.DeviceId));

        }

        [HttpGet]
        async public Task<string> DeleteFANInPair([FromBody] IdPair pair)
        {

            return await FAPManager.DeletePair(Guid.Parse(pair.AssemblyId), Guid.Parse(pair.DeviceId));
 
        }


        [HttpPost]
        async public Task<string> AddRAMInAssembly([FromBody] IdPair pair)
        {
            return await RAPManager.MakeNewPair(Guid.Parse(pair.AssemblyId), Guid.Parse(pair.DeviceId));

        }

        [HttpPost]
        async public Task<string> DeleteRAMPair([FromBody] IdPair pair)
        {
            return await RAPManager.DeletePair(Guid.Parse(pair.AssemblyId), Guid.Parse(pair.DeviceId));

        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
