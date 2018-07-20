using System.Collections.Generic;
namespace Estudiantes.Domain.Repository{
    public interface IEstudiantesRepository
    {
        void save (Estudiante estudiante);
        void deactivate(long id);
        void activate(long id);
        Estudiante findByStudentCode (string studentCode);
        List<Estudiante> findByStudentType (string studentType);
    }
}