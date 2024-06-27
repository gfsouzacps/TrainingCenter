using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TrainingCenter.Entidades;

namespace TrainingCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreinoController : ControllerBase
    {
        [HttpGet("GetTreino")]
        public IActionResult GetTreino()
        {
            var treino = new Treino(1, "Treino novo", DateTime.Now);
            return Ok(treino);
        }
    }
}
