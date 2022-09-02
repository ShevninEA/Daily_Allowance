
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
        static public int Summ { get; set; }

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
