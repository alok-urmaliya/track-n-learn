namespace back_end.Models
{
    public class javascript_tute
    {
        public Guid topic_id {  get; set; }
        public int sort_key { get; set; }
        public string topic_name { get; set;}
        public string body { get; set;}
        public string? topic_code { get; set; }
    }
}
