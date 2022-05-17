namespace Timesheets.Models
{
    public class Invoice
    {
       public Tasks Tasks { get; set; }

        public DateTime Dateinvoice { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
