namespace pjCasoATM
{
    internal abstract class Transaccion
    {
        private int numeroCuenta;
        private Pantalla pantallaUsuario;
        private BaseDatosBanco baseDatos;

        public Transaccion(
            int cuentaUsuario, Pantalla pantalla, BaseDatosBanco baseDatos)
        {
            numeroCuenta = cuentaUsuario;
            pantallaUsuario = pantalla;
            this.baseDatos = baseDatos;
        }

        public int NumeroCuenta
        {
            get { return numeroCuenta; }
        }

        public Pantalla PantallaUsuario
        {
            get { return pantallaUsuario; }
        }

        public BaseDatosBanco BaseDatos
        {
            get { return baseDatos; }
        }

        internal abstract void Ejecutar();
    }
}