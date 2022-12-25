using TravelItineraryWizard;

namespace XUnit.Coverlet.MSBuild;

public class ItineraryTest
{
   readonly Itinerary _it;

   public ItineraryTest() { _it = Itinerary.Instance; }

   [Fact]
   public void NightsTest()
   {
      _it.StartDate = new System.DateTime(2022, 12, 1, 12, 0, 0);
      _it.EndDate = new System.DateTime(2022, 12, 2, 12, 0, 0);
      Assert.Equal((int)1, (int)_it.Nights());
   }
}