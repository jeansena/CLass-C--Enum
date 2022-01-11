using ExeciciosEnum.Entities.Enums;
using System;
using System.Collections.Generic;


namespace ExeciciosEnum.Entities
{
    //class trabalhador
    class Worker
    {
        //atributo
        public String Name { get; set; }

        //atributo WorkerLevel refe ao enum
        public WorkerLevel Level {get; set;}

        //atributo
        public double BaseSalary { get; set; }

        //associação da "class Worker e a class Departmant"
        public Department Department { get; set; }

        //associação de "class Worker e a HourContract"
        // neste caso trabalhomos com lista "list"
        // pq o cliente pode te varios contratos
        // e tambem ja instanciando a list para que ela nao seja vazia
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        //contrutor padrao
        public Worker()
        {
        }

        //sempre que tiver uma associação para muito 
        // vc nao vai passa ela para o contrutor
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //adicionar as horas do contrato 
        public void AddContract(HourContract contract)
        {
            //vai adicionar na lista list
            Contracts.Add(contract);
        }

        
        public void RemoveContract(HourContract contract)
        {
            //remove da lista
            Contracts.Remove(contract);            
        }

        //metodo da soma do ganho
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
             //foreach vai percore as lista de contrato
            foreach(HourContract contract in Contracts)
            {   
                //se o dia do contrato for iqual ao dia do argumento
                //e tbm o mes for igual a mes passado no argumento
                // entao soma e retorna o valor 
                if(contract.Data.Year == year && contract.Data.Month == month)
                {
                    
                    //o "TotalValue()" e referencia da class HourContract
                    sum += contract.TotalValue();
                }                    
            }

            return sum;
                
        }



    }
}
