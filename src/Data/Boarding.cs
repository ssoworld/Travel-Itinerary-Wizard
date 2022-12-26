namespace TravelItineraryWizard.Data
{
   using System;
   using System.Text.Json;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;
   using System.Text.Json.Serialization;

   internal class Boarding
   {
      public float BaseRate { get; set; }
      public bool Utilize { get; set; } = false;
      public bool DropOffPrior { get; set; } = false;
      public bool PickUpAfter { get; set; } = false;
      public string? Location { get; set; }

      private TaxRate tr = new TaxRate();

      public Boarding()
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
            JsonElement boardingRoot = root.GetProperty("boarding");
            if (boardingRoot.TryGetProperty("location", out JsonElement locationElement))
            {
               Location = locationElement.ToString();
            }
            if (boardingRoot.TryGetProperty("base-rate", out JsonElement BaseRateElement))
            {
               BaseRate = BaseRateElement.GetSingle();
            }
         }
      }

      public float RateWithTax()
      {
         return BaseRate * (1 + tr.Home);
      }
   }
}
