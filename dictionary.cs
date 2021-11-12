using System;
using System.Linq;

using System.Collections.Generic;

public class Program
{
  public static void Main()
  {
    var cities = new Dictionary<string, string>(){
      {"UK", "London, Manchester, Birmingham"},
      {"USA", "Chicago, New York, Washington"},
      {"India", "Mumbai, New Delhi, Pune"}
    };

    Console.WriteLine(cities["UK"]);
    Console.WriteLine(cities["USA"]);

    if (cities.ContainsKey("France"))
    {
      Console.WriteLine(cities["France"]);
    }
    // We can use TryGetValue() to get the value of an unknown key
    string result;

    if (cities.TryGetValue("France", out result))
    {
      Console.WriteLine(result);
    }
    Console.WriteLine("######----------- Using Loop --------#######");
    // We can use ElementAt() to get the key-value pair using index

    for (int i = 0; i < cities.Count; i++)
    {
      Console.WriteLine("Key: {0}, value: {1}", cities.ElementAt(i).Key, cities.ElementAt(i).Value);
    }


  }
}