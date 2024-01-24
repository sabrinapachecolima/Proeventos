﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
       
       public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
                EventoId = 1,
                Tema = "Angular 11 e .Net5",
                Local = "Belo Horizonte",
                Lote = "1 Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
           },
             new Evento(){
                EventoId = 2,
                Tema = "Angular e suas novidades",
                Local = "São Paulo",
                Lote = "2 Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto1.png"
           },
          };
        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return
             _evento;
             

        }
          [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
             

        }
       
        
        [HttpPost]
        public String Post()
        {
            return "Exemplo de post";
        }
        
        [HttpPut ("{id}")]
        public String Put( int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete ("{id}")]
        public String DHttpDelete( int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
        

    }
}
