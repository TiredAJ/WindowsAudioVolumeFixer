namespace WindowsAudioVolumeFixer
{
    public class Worker : BackgroundService
    {
        private readonly AudioSVC ASVC;
        private readonly ILogger<Worker> _logger;

        public Worker(AudioSVC _AudioSVC, ILogger<Worker> logger)
        {
            ASVC = _AudioSVC;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    if (_logger.IsEnabled(LogLevel.Information))
                    {_logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);}

                    ASVC.DoStuff();

                    await Task.Delay(1000, stoppingToken);
                }
            }
            catch (OperationCanceledException)
            {

            }
            catch (Exception EXC)
            {
                _logger.LogError(EXC, "{Message}", EXC.Message);

                //terminates and reports to OS that service has terminated

                Environment.Exit(1);
            }
        }
    }
}
