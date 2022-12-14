namespace ConsoleUtils.SendGrid.Responses.GetTemplatesResponse
{
    public class GetTemplatesResponseVersion
    {
        public string id { get; set; }
        public string template_id { get; set; }
        public int active { get; set; }
        public string name { get; set; }
        public bool generate_plain_content { get; set; }
        public string subject { get; set; }
        public string updated_at { get; set; }
        public string editor { get; set; }
        public string thumbnail_url { get; set; }
    }
}
