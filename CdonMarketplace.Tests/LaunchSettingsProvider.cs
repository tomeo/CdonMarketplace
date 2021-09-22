using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace CdonMarketplace.Tests
{
    public static class LaunchSettingsProvider
    {
        public static IReadOnlyDictionary<string, string> GetEnvironmentalVariables()
        {
            var launchSettings = ProjectFileProvider.ReadAllText("Properties/launchSettings.json");

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
