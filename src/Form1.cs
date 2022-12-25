namespace TravelItineraryWizard
{
   using System.Diagnostics.CodeAnalysis;
   using System.Windows.Forms;

   public partial class Form1 : Form
   {
      Itinerary itin;
      [ExcludeFromCodeCoverage]
      public Form1()
      {
         itin = Itinerary.Instance;
         InitializeComponent();
      }

      [ExcludeFromCodeCoverage]
      private void Form1_FormClosing(object sender, FormClosingEventArgs e)
      {
         //itin.Close();
      }

      [ExcludeFromCodeCoverage]
      private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
      {
         PopulateStartAndEndDate();
      }

      [ExcludeFromCodeCoverage]
      private void PopulateStartAndEndDate()
      {
         itin.StartDate = monthCalendar1.SelectionStart;
         itin.EndDate = monthCalendar1.SelectionEnd;
      }
   }
}
