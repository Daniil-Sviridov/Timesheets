namespace Timesheets.Models
{
    public class Contract
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// 0 - не валидный
        /// 1 - подготовлен 
        /// 2 - текущий/ в работе
        /// </summary>
        public int Status { get; set; }

        public int MainPerformer { get; }

        public Tasks? Tasks { get; set; }
    }
}
