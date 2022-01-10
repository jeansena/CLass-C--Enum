using System;
using System.Collections.Generic;


namespace ExeciciosEnum.Entities
{
    class HourContract
    {    //atributo datas
        public DateTime Data { get; set; }
        //atributo valor da horas
        public double ValueParHour { get; set; }
        //atributo da horas
        public int Hours { get; set; }

        //contrutor padrao sem paramentros
        public HourContract()
        {
        }

        //construtor com paramentros
        public HourContract(DateTime data, double valueParHour, int hours)
        {
            Data = data;
            ValueParHour = valueParHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValueParHour * Hours;
        }
    }
}
