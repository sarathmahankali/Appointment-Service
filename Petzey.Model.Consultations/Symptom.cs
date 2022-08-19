using System.ComponentModel.DataAnnotations.Schema;

namespace Petzey.Model.Consultations
{
    public class Symptom
    {
        public int Id { get; set; }
        public string Name { get; set; }
 
        public int AppointmentId { get; set; }
    }
}