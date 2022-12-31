namespace TravelItineraryWizard
{
   using System;
   using System.Text.Json;

   public sealed class Itinerary
   {
      JsonSerializerOptions options = new JsonSerializerOptions
      {
         ReadCommentHandling = JsonCommentHandling.Skip,
         AllowTrailingCommas = true,
      };
      private static Lazy<Itinerary> _lazy = new Lazy<Itinerary>(() => new Itinerary());

      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }
      public static Itinerary Instance { get => _lazy.Value; }

      private Itinerary() {  }

      public int Nights()
      {
         double nights = (EndDate - StartDate).TotalDays;
         return (int)nights;
      }
   }
}
