using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Sequences.Logic.Interfaces;
using Sequences.Models;

namespace Sequences.Controllers
{
    public class SequenceController : Controller
    {
        private readonly IEnumerable<ISequenceGenerator> generators;

        public SequenceController(IEnumerable<ISequenceGenerator> generators)
        {
            this.generators = generators;
        }
        
        // GET
        public IActionResult Generate(SequenceGenerateModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sequenceArray = generators.Select(generator => generator.Generate(model.Number).ToArray())
                                          .ToArray();

            return new OkObjectResult(new SequenceGenerateResultModel(sequenceArray));
        }
    }
}