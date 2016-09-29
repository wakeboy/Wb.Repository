namespace DapperRepository.Example.Entities
{
    public class Product : DapperEntity<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
