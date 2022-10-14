namespace ConsoleUtils
{
    public class Main
    {
        private readonly ApplicationSettings applicationSettings;

        public Main(IOptions<ApplicationSettings> appSettings)
        {
            applicationSettings = appSettings?.Value ?? throw new ArgumentNullException(nameof(appSettings));
        }

        public async Task Run(string[] args)
        {
            var sendGridOperations = new SendGridOperations(applicationSettings.SendGridApiKey);
            var templates = await sendGridOperations.GetTemplates();

            foreach (var template in templates)
            {
                await sendGridOperations.GetDynamicEmailTemplate(template.id);
            }
        }
    }
}
