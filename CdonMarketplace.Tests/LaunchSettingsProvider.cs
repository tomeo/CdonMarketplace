using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace CdonMarketplace.Tests
{
    public static class LaunchSettingsProvider
    {
        private static string ProjectDirectory() => Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)
            ?.Parent?.Parent?.Parent?.FullName;

        public static IReadOnlyDictionary<string, string> GetEnvironmentalVariables()
        {
            var path = Path.Combine(
                ProjectDirectory() ?? string.Empty,
                "Properties/launchSettings.json"
            );

            var launchSettings = File.ReadAllText(path);

            var projectName = Assembly.GetCallingAssembly().GetName().Name ?? string.Empty;
            var attributes = JObject.Parse(launchSettings)
                ["profiles"]?
                [projectName]?
                ["environmentVariables"];

            var dict = new Dictionary<string, string>();
            foreach (JProperty property in attributes)
            {
                var key = property.Name;
                var value = property.Value.ToString();
                dict.Add(key, value);
            }

            return dict;
        }
    }
}
