namespace AjudaAiAPI.Entity
{
    public class NgoEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Social { get; set; }
        public string Headperson { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int CityId { get; set; }
        public int CausesId { get; set; }
    }
}
