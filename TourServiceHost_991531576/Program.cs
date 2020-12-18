using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TourServiceHost_991531576
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(FinalTourService_991531576.TourService_991531576)))
            {
                host.Open();
                Console.WriteLine("Prog30000 final exam by Mun Vladislav 991531576");
                Console.WriteLine("Host started at:" + DateTime.Now);
                Console.ReadKey();
            }
        }
    }
}
