using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Locations.Domain.Repository;

namespace Estudiantes.API{
    public class EstudianteController : Controller{
        private readonly ILocationsRepository  _locationsRepository;
        public EstudianteController(ILocationsRepository locationsRepository)
        {
            _locationsRepository = locationsRepository;
        }
    }
    
}