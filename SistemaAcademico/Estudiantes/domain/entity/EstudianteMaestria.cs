namespace Estudiantes.Domain{
    public class EstudianteMaestria: Estudiante{
        public override decimal calculateScholarship(){
            return 50;
        }
    }
}