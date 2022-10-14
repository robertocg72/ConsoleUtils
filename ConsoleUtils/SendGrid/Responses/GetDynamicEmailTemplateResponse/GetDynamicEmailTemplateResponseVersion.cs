namespace ConsoleUtils.SendGrid.Responses.GetDynamicEmailTemplateResponse
{
    public class GetDynamicEmailTemplateResponseVersion
    {
        public string id { get; set; }
        public int user_id { get; set; }
        public string template_id { get; set; }
        public int active { get; set; }
        public string name { get; set; }
        public string html_content { get; set; }
        public string plain_content { get; set; }
        public bool generate_plain_content { get; set; }
        public string subject { get; set; }
        public string updated_at { get; set; }
        public string editor { get; set; }
        public string test_data { get; set; }
        public string thumbnail_url { get; set; }
    }
}
