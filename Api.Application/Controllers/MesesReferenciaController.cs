using System;
using System.Net;
using Serilog;
using System.Threading.Tasks;
using Api.Domain.Dtos;
using Api.Domain.Dtos.MesReferencia;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.MesReferencia;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesesReferenciaController : ControllerBase
    {

        public IMesReferenciaService _service { get; set; }
        public static IWebHostEnvironment _environment;

        public MesesReferenciaController(IMesReferenciaService service, IWebHostEnvironment environment)
        {
            _service = service;
            _environment = environment;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // 400 Bad Request - Solicitação Inválida
            }
            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }
}
