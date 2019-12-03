using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Components;

namespace HCM.Client
{
    public class ItemModel : ComponentBase
    {
        public string Title => "Render Markdown";

        public string MarkdownContent { get; set; }

        protected override void OnInitialized()
        {
            MarkdownContent = GetInitialMarkdown();
        }

        private string GetInitialMarkdown()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = assembly.GetManifestResourceNames().Single(x => x.EndsWith("InitialMarkdown.md"));

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}