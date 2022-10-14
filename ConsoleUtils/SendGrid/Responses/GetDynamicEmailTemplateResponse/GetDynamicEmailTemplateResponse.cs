namespace ConsoleUtils.SendGrid.Responses.GetDynamicEmailTemplateResponse
{
    public class GetDynamicEmailTemplateResponse
    {
        public string id { get; set; }
        public string name { get; set; }
        public string generation { get; set; }
        public string updated_at { get; set; }
        public GetDynamicEmailTemplateResponseVersion[] versions { get; set; }
    }
}