namespace WebAPI_Portfolio.Models
{
    public class test
    {
        public int Id { get; set; }
        public string? Value { get; set; }

        public test(int id, string s)
        {
            Id = id;
            Value = s;
        }
    }
}
