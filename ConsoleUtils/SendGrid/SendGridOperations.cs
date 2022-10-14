namespace ConsoleUtils.SendGrid
{
    public class SendGridOperations
    {
        private readonly SendGridClient client;

        public SendGridOperations(string sendGridApiKey)
        {
            client = new SendGridClient(sendGridApiKey);
        }
        public async Task GetDynamicEmailTemplate(string templateId)
        {
            var response = await client.RequestAsync(
                method: SendGridClient.Method.GET,
                urlPath: $"templates/{templateId}"
            );

            if (response.IsSuccessStatusCode)
            {
                var content = JsonSerializer.Deserialize<GetDynamicEmailTemplateResponse>(response.Body.ReadAsStringAsync().Result);

                string fileName = $"{content.name}_{templateId}.html";
                Console.WriteLine($"Writing template to file {fileName}");
                File.WriteAllText(fileName, content.versions[0].html_content);
            }
        }

        public async Task<List<Template>> GetTemplates()
        {
            var queryParams = @"{ 'generations': 'dynamic' }";

            var response = await client.RequestAsync(
                method: SendGridClient.Method.GET,
                urlPath: "templates",
                queryParams: queryParams
            );

            if (response.IsSuccessStatusCode)
            {
                var content = JsonSerializer.Deserialize<GetTemplatesResponse>(response.Body.ReadAsStringAsync().Result);

                Console.WriteLine($"Retrieved {content.templates.Length - 1} templates");

                return content.templates.ToList();
            }

            return new List<Template>();
        }
    }
}