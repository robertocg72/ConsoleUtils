namespace ConsoleUtils.SendGrid.Responses.GetTemplatesResponse
{
    public class Template
    {
        public string id { get; set; }
        public string name { get; set; }
        public string generation { get; set; }
        public string updated_at { get; set; }
        public GetTemplatesResponseVersion[] versions { get; set; }
    }
}
