namespace Codeforces.Construction.Tests;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

[TestClass]
public class Codeforces_1956_C_Tests
{
    [TestMethod]
    public void Test()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        List<Object> res = new();

        string inputPath = "Codeforces.Tests.input." + this.GetType().Name + "_Input.txt";
        using (Stream stream = assembly.GetManifestResourceStream(inputPath))
        {
            using (StreamReader reader = new StreamReader(stream))
            {
                int t = int.Parse(reader.ReadLine());
                for (int i = 0; i < t; i++)
                {
                    int n = int.Parse(reader.ReadLine());
                    res.AddRange(Codeforces_1956_C.Solve(n));
                }
            }
        }

        Console.WriteLine(string.Join(" ", res));
    }
}
