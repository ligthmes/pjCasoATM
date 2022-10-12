namespace pjCasoATM
{
    internal class DispensadorEfectivo
    {
        // el número inicial predeterminado de billetes en el dispensador de efectivo
        private const int CUENTA_INICIAL = 500;
        private int cuentaBilletes; // número restante de billetes de $20

        public DispensadorEfectivo()
        {
            cuentaBilletes = CUENTA_INICIAL;
        }
        internal bool HaySufienteEfectivoDisponible(decimal monto)
        {
            int billetesRequeridos = ((int)monto) / 20;
            return (cuentaBilletes >= billetesRequeridos);
        }

        internal void DispensarEfectivo(decimal monto)
        {
            int billetesRequeridos = ((int)monto) / 20;
            cuentaBilletes -= billetesRequeridos;
        }
    }
}