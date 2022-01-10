


namespace ExeciciosEnum.Entities
{
    class Department
    { 
        //atributo
        public string Name { get; set; }

        //construtor padrao que e fazio sem  argumento
        public Department()
        {
        }

        //construtor com argumento ou parametro
        public Department(string name)
        {
            Name = name;
        }
    }
}
