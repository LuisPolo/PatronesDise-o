using System.Threading;
using System;

namespace SingletonPattern
{

static class BackgroundTaskDemo
{
    //volatile
    private static bool stopping = false;

    /*static void Main(string[] args)
    {
        new Thread(EfectuarTrabajo).Start();
        Thread.Sleep(5000);
        stopping = true;


        Console.WriteLine("Main exit");
        Console.ReadLine();
    }*/

    static void EfectuarTrabajo()
    {
        int i = 0;
        int j = 2;

        while (!stopping)
        {
            i++;
            j = 100 + (int)Math.Sin((double)i * 10d);
        }
        Console.WriteLine("EfectuarTrabajo exit " + i);
    }
}

}
