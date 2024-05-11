namespace Codeforces.BinarySearch.Tests;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

[TestClass]
public class Codeforces_1971_E_Tests
{
    [TestMethod]
    public void Test()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        List<object> res = new();

        string inputPath = "Codeforces.Tests.input." + this.GetType().Name + "_Input.txt";
        using (Stream stream = assembly.GetManifestResourceStream(inputPath))
        {
            using (StreamReader reader = new StreamReader(stream))
            {
                int t = int.Parse(reader.ReadLine());
                for (int i = 0; i < t; i++)
                {
                    string nkq = reader.ReadLine();
                    string[] tokens = nkq.Split(' ');
                    int n = int.Parse(tokens[0]);
                    int k = int.Parse(tokens[1]);
                    int q = int.Parse(tokens[2]);

                    string aStr = reader.ReadLine();
                    List<long> a = aStr.Split(' ').Select(long.Parse).ToList();

                    string bStr = reader.ReadLine();
                    List<long> b = bStr.Split(' ').Select(long.Parse).ToList();

                    List<long> queries = new();
                    for (int j = 0; j < q; j++)
                    {
                        string queryStr = reader.ReadLine();
                        queries.Add(long.Parse(queryStr));
                    }

                    res.AddRange(Codeforces_1971_E.Solve(n, k, q, a, b, queries));
                }
            }
        }

        string outputPath = "Codeforces.Tests.output." + this.GetType().Name + "_Output.txt";
        using (Stream stream = assembly.GetManifestResourceStream(outputPath))
        {
            using (StreamReader reader = new StreamReader(stream))
            {
                int i = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] tokens = line.Trim().Split(' ');
                    Console.WriteLine(line);
                    foreach (string token in tokens)
                    {
                        Assert.AreEqual(token, res[i].ToString());
                        i++;
                    }
                }
            }
        }
    }
}
