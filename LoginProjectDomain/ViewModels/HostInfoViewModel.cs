namespace LoginProjectDomain.ViewModels
{
    public class HostInfoViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Decimal? Price { get; set; }
        public long? BandWidth { get; set; }
        public int? OnlineSpace { get; set; }
        public bool? Support { get; set; }
    }
}
