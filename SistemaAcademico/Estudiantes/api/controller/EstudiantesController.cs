using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Estudiantes.Application;
using Estudiantes.Application.Dto;
using System.Collections.Generic;

namespace Estudiantes.API{
    public class EstudianteController : Controller{

        IEstudianteApplicationService _estudianteApplicationService;
        public EstudianteController(IEstudianteApplicationService estudianteApplicationService)
        {
            _estudianteApplicationService = estudianteApplicationService;
        }


        [Route("/api/Fibonacci/Lineal/{n}")]
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public List<EstudianteDTO> getByStudentByType(string studentType)
        {
            if (string.IsNullOrWhiteSpace(studentType)){
                return null;
            } 

            try
            {
                return _estudianteApplicationService.getByStudentType(studentType);
            }
            catch (ArgumentException ex){
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
    
}