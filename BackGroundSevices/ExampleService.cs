namespace BackGroundSevices
{
    public class ExampleService : IHostedService
    {
        private readonly ILogger<ExampleService> _logger;

        public ExampleService(ILogger<ExampleService> logger)
        {
            _logger = logger;
        }

        public async  Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("StartSaync");
            await Task.Delay(20000);
        }

        public async  Task StopAsync(CancellationToken cancellationToken)
        {
           _logger.LogInformation("StopAsync");
        }
    }
}
