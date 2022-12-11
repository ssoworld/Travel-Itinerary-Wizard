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
      private Excel.Application excel;
      private Excel.Workbook workbook;
      private Excel.Worksheet worksheet;
      private string file;
      private string? workingFile;
      private DateOnly startDate;

      private static readonly Lazy<Itinerary> _lazy = new Lazy<Itinerary>(() => new Itinerary());

      public static Itinerary instance { get { return _lazy.Value; } }
      public string WorkingFile { get => workingFile ?? "NA"; set => workingFile = value; }
      public DateOnly StartDate { get => startDate; set => startDate = value; }

      private Itinerary()
      {
         string cwd = AppDomain.CurrentDomain.BaseDirectory;
         file = System.IO.Path.Combine(cwd, @"..\..\..\Templates\TravelTemplate.xlsx");
         excel = new Excel.Application();
         workbook = excel.Workbooks.Open(file);
         worksheet = (Excel.Worksheet)workbook.ActiveSheet;
      }

      public void Close()
      {
         workbook.Close(false);
      }
   }
}
