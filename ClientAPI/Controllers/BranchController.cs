using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Service;
using Microsoft.AspNetCore.Mvc;
using Client.Model.Models;

namespace ClientAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchService branchService;

        public BranchController(IBranchService _branchService)
        {
            branchService = _branchService;
        }

        [HttpGet]
        public IEnumerable<Branch> Get()
        {
            var Branches = branchService.GetBranches();
            return Branches;
        }

        [HttpGet("{id}")]
        public Branch GetBranch(int id)
        {
            var Branch = branchService.GetBranch(id);
            return Branch;
        }

        [HttpPost]
        public IActionResult AddBranch(Branch Branch)
        {
            branchService.CreateBranch(Branch);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateBranch(Branch Branch)
        {
            branchService.UpdateBranch(Branch);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteBranch(int id)
        {
            branchService.DeleteBranch(id);
            return Ok();
        }
    }
}