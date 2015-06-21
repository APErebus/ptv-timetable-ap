using System;
using Ptv.Timetable.Api;

namespace PtvTimetableConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Developer ID?");
            var devId = Console.ReadLine();
            Console.WriteLine("Security Key?");
            var securityKey = Console.ReadLine();

            var ptvService = new PtvTimetableService(devId, securityKey);

            var healthCheckTask = ptvService.PerformHealthCheckAsync();
            Console.WriteLine("Performing API health check...");

            healthCheckTask.Wait();

            Console.WriteLine("Is Valid Security Token? {0}", healthCheckTask.Result.IsSecurityTokenValid);
            Console.WriteLine("Is Client Clock In Sync? {0}", healthCheckTask.Result.IsClientClockInSync);
            Console.WriteLine("Is API Database OK? {0}", healthCheckTask.Result.IsApiDatabaseOk);
            Console.WriteLine("Is API Memory Cache OK? {0}", healthCheckTask.Result.IsApiMemoryCacheOk);
            Console.WriteLine("Is Healthy ENough To Connect? {0}", healthCheckTask.Result.IsHealthyEnoughToConnect);

            Console.Read();
        }
    }
}
