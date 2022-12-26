using System;
using TravelItineraryWizard.Data;

namespace XUnit.Coverlet.MSBuild;

public class BoardingTest
{
   [Fact]
   public void Boarding_ClassNotNullTest()
   {
      var boarding = new Boarding();
      Assert.NotNull(boarding);
   }

   [Fact]
   public void Boarding_LocationNotNullTest()
   {
      var boarding = new Boarding();
      Assert.NotNull(boarding.Location);
   }

   [Fact]
   public void Boarding_LocationDefaultTest()
   {
      var boarding = new Boarding();
      Assert.Equal("Family Pet Hospital", boarding.Location);
   }

   [Fact]
   public void Boarding_BaseRateTest()
   {
      var boarding = new Boarding();
      Assert.Equal(31.75, boarding.BaseRate);
   }

   [Fact]
   public void Boarding_RateWithTaxTest()
   {
      var boarding = new Boarding();
      Assert.Equal(33.50, Math.Round(boarding.RateWithTax(),2));
   }
}

