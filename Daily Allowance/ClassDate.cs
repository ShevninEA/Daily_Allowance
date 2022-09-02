
namespace Daily_Allowance
{
    class ClassDate
    {
        /// <summary>
        /// Свойства для центрирования текста
        /// </summary>
        public int CenterX { get; set; }
        public int CenterY { get; set; }

        /// <summary>
        /// Сумма за один день
        /// </summary>
        protected static int summ = 0;
        public int Summ
        {
            get { return summ; }
            set { summ = value; }
        }

        /// <summary>
        ///Дата отъезда 
        /// </summary>
        public string DateStart { get; set; }

        /// <summary>
        /// Дата приезда
        /// </summary>
        public string DateEnd { get; set; }
    }
}
