namespace WindowsFormsFinanseSystem.BusinessLogic
{
     public class Payment
    {
        /// <summary>
        /// Номер месяца
        /// </summary>
        public int Month { get; set; }

        /// <summary>
        /// Сумма платежа
        /// </summary>
        private decimal pay;
        public decimal Pay
        {
            get
            { return pay; }
            set
            {
                if (value >= 0) pay = value;
                else pay = 0;
            }
        }

        /// <summary>
        /// Сумма по процентам в платеже
        /// </summary>
        private decimal percents;
        public decimal Percents
        {
            get { return percents; }
            set
            {
                if (value >= 0) percents = value;
                else percents = 0;
            }
        }

        /// <summary>
        /// Остаток по кредиту
        /// </summary>
        private decimal last;
        public decimal Last
        {
            get { return last; }
            set
            {
                if (value >= 0) last = value;
                else last = 0;
            }
        }
    }
}


