namespace TravelItineraryWizard_test;

using TravelItineraryWizard;

[TestClass]
public class UnitTest1
{
   [TestMethod]
   public void TestMethod1()
   {
      Itinerary i = Itinerary.instance;
      i.Close();
   }
}