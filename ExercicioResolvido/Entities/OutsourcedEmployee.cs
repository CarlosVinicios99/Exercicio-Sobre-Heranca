namespace ExercicioResolvido.Entitites
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge {get; set;}

        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        private double Bonus()
        {
            return AdditionalCharge * 1.1;
        }

        public sealed override double Payment()
        {
            return base.Payment() + Bonus();
        }
    }
}