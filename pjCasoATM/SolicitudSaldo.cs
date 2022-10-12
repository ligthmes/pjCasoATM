using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjCasoATM
{
    internal class SolicitudSaldo : Transaccion
    {

        public SolicitudSaldo(
            int cuentaUsuario, Pantalla pantalla, BaseDatosBanco baseDatos) 
            : base(cuentaUsuario, pantalla, baseDatos)
        {

        }

        internal override void Ejecutar()
        {
            decimal saldoTotal = BaseDatos.ObtenerSaldoTotal(NumeroCuenta);
            PantallaUsuario.MostrarLineaMensaje("\nInformación del saldo:");
            PantallaUsuario.MostrarMensaje("\n - Saldo total: ");
            PantallaUsuario.MostrarMontoEnDolares(saldoTotal);
            PantallaUsuario.MostrarLineaMensaje("");
        }
    }
}
