﻿using GeometriaRestAPIWeb.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GeometriaRestAPIWeb.Controllers;
[Route("api/[controller]")]
[ApiController]
public class Geometria1Controller : ControllerBase
{
    static List<FiguraDTO> lista = new List<FiguraDTO> { new FiguraDTO { Id = 1, Tipo = 1, Area = 3 }, new FiguraDTO { Id = 2, Tipo = 2, Area = 3.3 } };
    // GET: api/<Geometria1Controller>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<Geometria1Controller>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<Geometria1Controller>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<Geometria1Controller>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<Geometria1Controller>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
