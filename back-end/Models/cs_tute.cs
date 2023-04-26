namespace back_end.Models
{
    public class cs_tute
    {
        public Guid topic_id { get; set; }
        public string topic_name { get; set; }
        public string body { get; set; }
        public string? topic_code { get; set; }
    }
}