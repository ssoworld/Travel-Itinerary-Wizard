namespace TravelItineraryWizard
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;
   using System.Text.Json;
   using System.Text.Json.Serialization;

   public sealed class Itinerary
   {
      JsonSerializerOptions options = new JsonSerializerOptions
      {
         ReadCommentHandling = JsonCommentHandling.Skip,
         AllowTrailingCommas = true,
      };
      
      private DateTime startDate;
      private DateTime endDate;

      private static Lazy<Itinerary> _lazy = new Lazy<Itinerary>(() => new Itinerary());

      public DateTime StartDate { get => startDate; set => startDate = value; }
      public DateTime EndDate { get => endDate; set => endDate = value; }
      public static Itinerary Instance { get => _lazy.Value; }

      private Itinerary() {;}

      public int Nights()
      {
         double nights = (endDate - startDate).TotalDays;
         return (int)nights;
      }

   }
}
