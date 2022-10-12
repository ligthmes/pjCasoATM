namespace pjCasoATM
{
    internal class Pantalla
    {
        internal void MostrarLineaMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        internal void MostrarMensaje(string mensaje)
        {
            Console.Write(mensaje);
        }

        internal void MostrarMontoEnDolares(decimal monto)
        {
            Console.Write("{0:C}", monto);
        }
    }
}