namespace Estudiantes.Domain{
    public class EstudiantePregrado: Estudiante{
        public override decimal calculateScholarship(){
            return 10;
        }
    }
}