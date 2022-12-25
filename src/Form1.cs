namespace TravelItineraryWizard
{
   using System.Windows.Forms;

   public partial class Form1 : Form
   {
      Itinerary itin;
      public Form1()
      {
         itin = Itinerary.Instance;
         InitializeComponent();
      }

      private void Form1_FormClosing(object sender, FormClosingEventArgs e)
      {
         //itin.Close();
      }

      private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
      {
         itin.StartDate = monthCalendar1.SelectionStart;
         itin.EndDate = monthCalendar1.SelectionEnd;
      }
   }
}
