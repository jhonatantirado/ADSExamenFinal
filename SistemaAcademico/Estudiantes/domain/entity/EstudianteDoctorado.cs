namespace Estudiantes.Domain{
    public class EstudianteDoctorado: Estudiante{
        public override decimal calculateScholarship(){
            return 100;
        }
    }
}