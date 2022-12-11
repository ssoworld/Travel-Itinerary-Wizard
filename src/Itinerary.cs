namespace TravelItineraryWizard
{
   using Microsoft.Office.Interop.Excel;
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;
   using Excel = Microsoft.Office.Interop.Excel;

   public sealed class Itinerary
   {
      Excel.Application excel;
      Excel.Workbook workbook;

      private static readonly Lazy<Itinerary> _lazy = new Lazy<Itinerary>(() => new Itinerary());

      public static Itinerary instance {  get { return _lazy.Value; } }

      private Itinerary()
      {
         string cwd = AppDomain.CurrentDomain.BaseDirectory;
         string file = System.IO.Path.Combine(cwd, @"..\..\..\Templates\TravelTemplate.xlsx");
         excel = new Excel.Application();
         workbook = excel.Workbooks.Open(file);
      }
   }
}
