namespace pjCasoATM
{
    internal class BaseDatosBanco
    {
        private Cuenta[] cuentas;

        public BaseDatosBanco()
        {
            cuentas = new Cuenta[2];
            cuentas[0] = new Cuenta(12345, 4321, 1000.00M);
            cuentas[1] = new Cuenta(98765, 6789, 200.00M);
        }

        internal bool AutenticarUsuario(int numeroCuenta, int PINUsuario)
        {
            Cuenta cuentaUsuario = ObtenerCuenta(numeroCuenta);

            if (cuentaUsuario != null)
                return cuentaUsuario.ValidarPIN(PINUsuario);
            else
                return false;
        }

        private Cuenta ObtenerCuenta(int numeroCuenta)
        {
            foreach(Cuenta cuentaActual in cuentas)
            {
                if(cuentaActual.NumeroCuenta == numeroCuenta)
                    return cuentaActual;
            }

            return null;
        }

        internal decimal ObtenerSaldoTotal(int numeroCuenta)
        {
            Cuenta cuentaUsuario = ObtenerCuenta(numeroCuenta);
            return cuentaUsuario.SaldoTotal;
        }

        internal void Debitar(int numeroCuenta, decimal monto)
        {
            Cuenta cuentaUsuario = ObtenerCuenta(numeroCuenta);
            cuentaUsuario.Debitar(monto);
        }
    }
}