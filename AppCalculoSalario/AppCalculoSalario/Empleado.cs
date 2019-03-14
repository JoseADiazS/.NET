namespace AppCalculoSalario
{
    internal class Empleado
    {
        private string nombre;
        private double numHorasMes;
        private double valHora;
        private double sueldoBruto;

        public Empleado(string nombre, double numHorasMes, double valHora, double sueldoBruto)
        {
            this.Nombre = nombre;
            this.NumHorasMes = numHorasMes;
            this.ValHora = valHora;
            this.SueldoBruto = sueldoBruto;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double NumHorasMes { get => numHorasMes; set => numHorasMes = value; }
        public double ValHora { get => valHora; set => valHora = value; }
        public double SueldoBruto { get => sueldoBruto; set => sueldoBruto = value; }

        public double GetSueldoBruto()
        {
            SueldoBruto = NumHorasMes * ValHora;
            return SueldoBruto;
        }

        public double GetSueldoTotal(double deducciones)
        {
            return SueldoBruto - deducciones;
        }
    }
}