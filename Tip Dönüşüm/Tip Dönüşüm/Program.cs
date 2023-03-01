namespace Tip_Dönüşüm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion 
            Console.WriteLine("-----Implicit Conversion-----");

            byte a = 7;
            sbyte b = 13;
            short c = 20;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long e = d;
            Console.WriteLine("h: " + e);

            float f = e;                     
            Console.WriteLine("f: " + e);

            string g = "mehmetcan";
            char h = 'i';
            object i = g + h + e;
            Console.WriteLine("i: " + i);

            Console.WriteLine("");

            // Explicit Conversion
            Console.WriteLine("-----Explicit Conversion-----");

            int j = 255;
            byte k = (byte)j;
            Console.WriteLine("k: " + k);

            int l = 256;
            byte m = (byte)l;
            Console.WriteLine("m: " + m); 

            float n = 20.7f;
            byte o = (byte)n;
            Console.WriteLine("o: " + o); 

            Console.WriteLine("");

            // ToString Methodu
            Console.WriteLine("-----ToString Method-----");

            int aa = 20;
            string bb = aa.ToString();
            Console.WriteLine("bb: " + bb);

            string cc = 19.4f.ToString();
            Console.WriteLine("cc: " + cc);

            Console.WriteLine("");

            // System.Convert
            Console.WriteLine("-----System.Convert-----");

            string x = "26", y = "34";
            int x1, y1;
            int total;

            x1 = Convert.ToInt32(x);
            y1 = Convert.ToInt32(y);

            total = x1 + y1;
            Console.WriteLine("Total: " + total);

            Console.WriteLine("");

            // Parse Method
            Console.WriteLine("-----Parse Method-----");

            string text1 = "15";
            string text2 = "23.17";

            int number1 = Int32.Parse(text1);         
            double number2 = Double.Parse(text2);

            Console.WriteLine("Number1: " + number1);
            Console.WriteLine("Number2: " + number2);


        }
    }
}