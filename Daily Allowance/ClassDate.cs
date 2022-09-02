using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Allowance
{
    class ClassDate
    {
        /// <summary>
        /// Сумма за один день
        /// </summary>
        protected int summ = 1500;

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
