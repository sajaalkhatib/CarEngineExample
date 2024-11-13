using System;

namespace CarEngineExample
{
   
    public interface IEngine
    {
        void Start();
        void Stop();
    }

    public class Engine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Engine starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Engine stopping...");
        }
    }


    public class Car
    {
        private readonly IEngine _engine;

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public void Start()
        {
            _engine.Start();
            Console.WriteLine("Car is now running.");
        }

        public void Stop()
        {
            _engine.Stop();
            Console.WriteLine("Car has stopped.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
         
            IEngine engine = new Engine();

    
            Car car = new Car(engine);

   
            car.Start();
            car.Stop();
        }
    }
}