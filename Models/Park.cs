namespace ParksApi.Models
{
    public class Park
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public double Area { get; set; } // in square kilometers
        public DateTime EstablishedDate { get; set; }
        public string[]? Activities { get; set; } // e.g., hiking, camping, bird watching
    }
}