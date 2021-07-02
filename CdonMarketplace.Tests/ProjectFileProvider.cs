using System;
using System.IO;

namespace CdonMarketplace.Tests
{
    public static class ProjectFileProvider
    {
        private static string ProjectDirectory() => Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)
            ?.Parent?.Parent?.Parent?.FullName;

        public static string ReadAllText(string relativePath)
        {
            var fullPath = Path.Combine(
                ProjectDirectory() ?? string.Empty,
                relativePath
            );

            return File.ReadAllText(fullPath);
        }
    }
}
