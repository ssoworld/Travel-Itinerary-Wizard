namespace TravelItineraryWizard.Data;

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Nodes;
using DocumentFormat.OpenXml.Wordprocessing;

internal class TaxRate
{
   public TaxRate()
   {
      string filename = Path.GetFullPath(@"..\..\..\..\data\properties.jsonc");
      string jsonString = File.ReadAllText(filename);
      JsonDocumentOptions documentOptions = new JsonDocumentOptions
      {
         CommentHandling = JsonCommentHandling.Skip
      };
      using (JsonDocument document = JsonDocument.Parse(jsonString))
      {
         JsonElement root = document.RootElement;
         JsonElement homeTaxRate = root.GetProperty("home-tax-rate");
         Home = (float) Math.Round(homeTaxRate.GetDouble(), 3);
      }
   }

   public float Home { get; set; }
}
