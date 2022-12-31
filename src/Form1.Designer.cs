namespace TravelItineraryWizard
{
   using System.Diagnostics.CodeAnalysis;

   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      [ExcludeFromCodeCoverage]
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      [ExcludeFromCodeCoverage]
      private void InitializeComponent()
      {
         this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
         this.SuspendLayout();
         // 
         // monthCalendar1
         // 
         this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
         this.monthCalendar1.Name = "monthCalendar1";
         this.monthCalendar1.TabIndex = 0;
         this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.monthCalendar1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
         this.ResumeLayout(false);

      }

      #endregion

      private MonthCalendar monthCalendar1;
   }
}