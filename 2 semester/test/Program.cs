namespace DestructorTest
{
    class Class1
    {
        public Class1()
        {
            Console.WriteLine("call constructotr...");
        }
        ~Class1()
        {
            Console.WriteLine("call destructor...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0;i<3;i++)
            {
                Class1 c = new Class1();
            }
            GC.Collect(); 
            
        }
    }
}