namespace testcoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
            {
                int N = int.Parse(sr.ReadLine());
                List<(int age, string name, int index)> members = new List<(int, string, int)>();

                for (int i = 0; i < N; ++i)
                {
                    string[] input = sr.ReadLine().Split();
                    int age = int.Parse(input[0]);
                    string name = input[1];
                    members.Add((age, name, i));
                }

                members.Sort((a, b) =>
                {
                    int ageComparison = a.age.CompareTo(b.age);
                    if (ageComparison == 0)
                    {
                        return a.index.CompareTo(b.index);
                    }
                    return ageComparison;
                });

                foreach (var member in members)
                {
                    sw.WriteLine($"{member.age} {member.name}");
                }
            }
        }
    }
}