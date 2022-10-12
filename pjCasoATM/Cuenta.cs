namespace pjCasoATM
{
    internal class Cuenta
    {
        private int numeroCuenta;
        private int pin;
        private decimal saldoTotal;

        public Cuenta(int numeroCuenta, int pin, decimal saldoTotal)
        {
            this.numeroCuenta = numeroCuenta;
            this.pin = pin;
            this.saldoTotal = saldoTotal;
        }

        public int NumeroCuenta
        { get { return numeroCuenta; } }

        public decimal SaldoTotal
        { get { return saldoTotal; } }

        internal bool ValidarPIN(int pINUsuario)
        {
            return (pin == pINUsuario);
        }

        internal void Debitar(decimal monto)
        {
            saldoTotal -= monto;
        }
    }
}