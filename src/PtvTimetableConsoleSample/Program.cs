using System;
using Nito.AsyncEx;
using Ptv.Timetable.Api;

namespace PtvTimetableConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncContext.Run(() => MainAsync(args));
        }

        static async void MainAsync(string[] args)
        {
            Console.WriteLine("Developer ID?");
            var devId = Console.ReadLine();
            Console.WriteLine("Security Key?");
            var securityKey = Console.ReadLine();

            IPtvTimetableService ptvService = new PtvTimetableService(devId, securityKey);
            
            Console.WriteLine("Performing API health check...");
            var healthCheckResponse = await ptvService.PerformHealthCheckAsync();

            Console.WriteLine("Is Valid Security Token? {0}", healthCheckResponse.IsSecurityTokenValid);
            Console.WriteLine("Is Client Clock In Sync? {0}", healthCheckResponse.IsClientClockInSync);
            Console.WriteLine("Is API Database OK? {0}", healthCheckResponse.IsApiDatabaseOk);
            Console.WriteLine("Is API Memory Cache OK? {0}", healthCheckResponse.IsApiMemoryCacheOk);
            Console.WriteLine("Is Healthy ENough To Connect? {0}", healthCheckResponse.IsHealthyEnoughToConnect);

            Console.WriteLine("Checking Lines By Modes...");
            var linesByMode = await ptvService.ListLinesByModeAsync(TransportType.Train);
            foreach (var line in linesByMode.Lines)
                Console.WriteLine("Line: {0}", line.Name);  

            Console.Read();
        }
    }
}
