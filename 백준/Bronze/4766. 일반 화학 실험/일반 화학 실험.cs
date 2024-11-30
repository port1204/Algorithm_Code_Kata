using System.Globalization;

namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), bufferSize: 1048576))
            {
                double d = 0.0;
                bool isF = true;

                while (true)
                {
                    string input = sr.ReadLine();
                    double currentTemperature = double.Parse(input, CultureInfo.InvariantCulture);

                    if (currentTemperature == 999)
                    {
                        break;
                    }

                    if (isF)
                    {
                        d = currentTemperature;
                        isF = false;
                    }
                    else
                    {
                        double difference = currentTemperature - d;
                        sw.WriteLine(difference.ToString("F2", CultureInfo.InvariantCulture));
                        d = currentTemperature;
                    }
                }
            } // using
        } // Main
    } // class
} // namespace