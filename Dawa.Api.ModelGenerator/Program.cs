using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Dawa.Api.ModelGenerator.models;

namespace Dawa.Api.ModelGenerator
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            string url = "https://dawa.aws.dk/replikering/datamodel";
            if (args.Any())
            {
                url = args[0];
            }

            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Failed to load data from url: {url} - response: {response.StatusCode}");
            }

            var result = await response.Content.ReadAsStringAsync();

            var resultDic = JsonSerializer.Deserialize<Dictionary<string, DataModelDescription>>(result);

            var directory = @"C:\Users\Stefan\source\repos\DawaApiClient\Dawa.Api.Model\";
            var namespaceString = "Dawa.Api.Model";
            foreach (var kv in resultDic)
            {
                var fileName = kv.Key + ".cs";
                var completePath = Path.Combine(directory, fileName);
                var sb = new StringBuilder();
                // open namespace
                sb.AppendLine($"namespace {namespaceString} " + " {");

                // class description
                sb.AppendLine("\t ///<summary>")
                  .AppendLine("\t /// " + kv.Value.GetKey())
                  .AppendLine("\t ///</summary>");
                // open class
                sb.AppendLine($"\t public class {kv.Key} " + "{");
                sb.AppendLine("");
                kv.Value.GetProperties().Select(s =>
                {
                    foreach (var innerS in s)
                    {
                        sb.AppendLine("\t\t" + innerS);
                    }

                    return sb.AppendLine("");
                }).ToArray();
                // close class
                sb.AppendLine("\t}");
                // close namespace
                sb.AppendLine("}");

                if (File.Exists(completePath))
                {
                    File.Delete(completePath);
                }
                await File.WriteAllTextAsync(completePath, sb.ToString());
                Console.WriteLine($"Generated file: {kv.Key}");
            }

            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
