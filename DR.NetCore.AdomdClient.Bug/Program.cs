using Microsoft.AnalysisServices.AdomdClient;
using System;

namespace DR.NetCore.AdomdClient.Bug
{
    class Program
    {
        static void Main(string[] args)
        {
            AdomdConnection conne = new AdomdConnection();
            Console.WriteLine($"Hello World! {conne.ToString()}");
        }
    }
}
