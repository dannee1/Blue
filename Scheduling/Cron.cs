using Quartz;

namespace Scheduling
{
    public class AnualReportJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            //data of report here.
            return Task.FromResult(true);
        }
    }
}