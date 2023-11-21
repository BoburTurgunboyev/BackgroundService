namespace BackGroundSevices
{
    public class SimpleBackGround : BackgroundService
    {
        protected async  override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //while(!stoppingToken.IsCancellationRequested)
            //{
                Console.WriteLine("Irakl");
                //await Task.Delay(1000);
            //}
        }
    }
}
