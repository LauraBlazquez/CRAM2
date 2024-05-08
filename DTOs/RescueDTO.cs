namespace CRAM2
{
    public class RescueDTO
    {
        public string? RescueId { get; set; } = "RES-";
        public string? RescueDate { get; set; } = DateTime.Now.ToString("dd/mm/yyyy hh:mm");
        public int RescuedAnimal { get; set; }
        public int AffectationDegree { get; set; }
        public string? Location { get; set; }
    }
}
