using System;
using Microsoft.AspNet.SignalR.Client;

namespace Bbl.SignalR.SharedWhiteboard.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new HubConnection("http://localhost:59391");
            var hubProxy = connection.CreateHubProxy("DrawingBoard");

            hubProxy.On("clear", ClearConsole);

            hubProxy.On("drawPoint", (int x, int y) => DrawPoint(x, y));

            connection.Start();
            Console.WriteLine("Ready");
            Console.ReadKey();
        }

        private static void DrawPoint(int x, int y)
        {
            var translatedx = Console.WindowWidth*x/300;
            var translatedy = Console.WindowHeight*y/300;

            Console.SetCursorPosition(translatedx, translatedy);
            Console.BackgroundColor = ConsoleColor.White;

            Console.Write(" ");
        }

        private static void ClearConsole()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }
    }
}
