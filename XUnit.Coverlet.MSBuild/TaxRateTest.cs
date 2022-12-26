using System;
using TravelItineraryWizard.Data;

namespace XUnit.Coverlet.MSBuild;

public class TaxRateTest
{
   [Fact]
   public void HomeRateTest()
   {
      TaxRate _tr = new TaxRate();
      Assert.Equal(0.055, Math.Round(_tr.Home, 3));
   }
}
