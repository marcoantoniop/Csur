﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csur.Datos;

namespace Csur.Modelo
{
    public static class ClassVenta
    {
        #region propiedadesPrivadas
        private static EntidadLOTE entidadLote;
        private static EntidadVENTA entidadVenta;
        private static EntidadPERSONA entidadPersona;
        private static bool entidadLoteLlenado = false;
        private static EntidadCLIENTE entidadCliente;
        private static EntidadCOMISION entidadComision;
        private static decimal montoPrimerPago;
        private static int numPagos;
        private static bool planCuentasGenerado = false;
        private static List<EntidadPLANCUENTAS> listaPlanCuentas = new List<EntidadPLANCUENTAS>();
        private static string modalidadPago;
        private static string observacionVenta;
        #endregion

        #region propiedadesPublicas
        public static EntidadLOTE EntidadLote { get => entidadLote; set => entidadLote = value; }
        public static bool EntidadLoteLlenado { get => entidadLoteLlenado; set => entidadLoteLlenado = value; }
        public static EntidadCLIENTE EntidadCliente { get => entidadCliente; set => entidadCliente = value; }
        public static decimal MontoPrimerPago { get => montoPrimerPago; set => montoPrimerPago = value; }
        public static int NumPagos { get => numPagos; set => numPagos = value; }
        public static List<EntidadPLANCUENTAS> ListaPlanCuentas { get => listaPlanCuentas; set => listaPlanCuentas = value; }
        public static bool PlanCuentasGenerado { get => planCuentasGenerado; set => planCuentasGenerado = value; }
        public static string ModalidadPago { get => modalidadPago; set => modalidadPago = value; }
        public static string ObservacionVenta { get => observacionVenta; set => observacionVenta = value; }
        public static EntidadVENTA EntidadVenta { get => entidadVenta; set => entidadVenta = value; }
        public static EntidadPERSONA EntidadPersona { get => entidadPersona; set => entidadPersona = value; }
        public static EntidadCOMISION EntidadComision { get => entidadComision; set => entidadComision = value; }
        #endregion

        #region MetodosIniciales

        public static void InicializarObjetos()
        {

        }
        #endregion


        #region Verificadores

        /// <summary>
        /// VERIFICAR PASO A
        /// SELECCIONAMOS EL LOTE A VENDER
        /// </summary>
        /// <returns></returns>
        public static bool VerificaPasoA()
        {
            bool resultado = false;
            /**************************
             *  INICIO DEL VERIFICADOR
             **************************/
            if (entidadLoteLlenado)
            {
                resultado = true;
            }
            /**************************
             *  FIN DEL VERIFICADOR
             **************************/
            return resultado;
        }

        /// <summary>
        /// VERIFICAR CLIENTE
        /// </summary>
        /// <returns></returns>
        public static bool VerificaPasoB()
        {
            bool resultado = false;
            /**************************
             *  INICIO DEL VERIFICADOR
             **************************/
            if (entidadCliente.IdCliente > 0)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            /**************************
             *  FIN DEL VERIFICADOR
             **************************/
            return resultado;
        }

        /// <summary>
        /// VERIFICA PLAN DE CUENTAS
        /// </summary>
        /// <returns></returns>
        public static bool VerificaPasoC()
        {
            bool resultado = false;
            /**************************
             *  INICIO DEL VERIFICADOR
             **************************/
            if (planCuentasGenerado)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            /**************************
             *  FIN DEL VERIFICADOR
             **************************/
            return resultado;
        }

        /// <summary>
        /// PLAN CUENTAS
        /// </summary>
        /// <returns></returns>
        public static bool VerificaPasoD()
        {
            bool resultado = true;
            /**************************
             *  INICIO DEL VERIFICADOR
             **************************/
            if (planCuentasGenerado)
            {

            }
            /**************************
             *  FIN DEL VERIFICADOR
             **************************/
            return resultado;
        }
        public static bool VerificaPasoE()
        {
            bool resultado = true;
            /**************************
             *  INICIO DEL VERIFICADOR
             **************************/

            /**************************
             *  FIN DEL VERIFICADOR
             **************************/
            return resultado;
        }
        public static bool VerificaPasoF()
        {
            bool resultado = true;
            /**************************
             *  INICIO DEL VERIFICADOR
             **************************/

            /**************************
             *  FIN DEL VERIFICADOR
             **************************/
            return resultado;
        }
        #endregion
    }
}
