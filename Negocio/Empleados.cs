﻿using Datos;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Negocio.Empleados;
namespace Negocio
{
    public class Empleados : Conectar
    {

        #region Variables
        public static int IdTrabajador { get; private set; }
        public static string NombreTrabajador { get; private set; }
        public static int idCategoria { get; set; }


        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public int idtrabajador { get; private set; }
        public int IdCat {  get; private set; }
        
        
        
        #endregion
        
        public static void IngresoEmpleados(int documento, string contraseña)
        {
            Conectar capaDatos = new Conectar();
            DataTable TablaEmpleados = capaDatos.BuscarEmpleados();
            bool usuarioEncontrado = false;

            foreach (DataRow Fila in TablaEmpleados.Rows)
            {

                if (Fila["documentoTR"] != DBNull.Value)
                {
                    int Documentoint = Convert.ToInt32(Fila["documentoTR"]);


                    if (Documentoint == documento)
                    {

                        string ContraseñaEnBD = Fila["contraseñaTR"].ToString();
                        if (ContraseñaEnBD == contraseña)
                        {
                            usuarioEncontrado = true;
                            int Idtrabajador = capaDatos.TraeId(documento);
                            IdTrabajador = Idtrabajador;
                            string Nomtrabajador = capaDatos.BuscarEmp(Idtrabajador);
                            NombreTrabajador = Nomtrabajador;
                            string detalle = "Acceso al sistema";
                            string tabla = "Trabajador";
                            int idCategoriaEmpleado = capaDatos.TraeIdCategoriaEmpleado(documento);
                            idCategoria = idCategoriaEmpleado;
                            AgregarBitacora(Idtrabajador, detalle, tabla);
                            return;
                        }
                        else
                        {
                            throw new Exception("Contraseña no válida");
                        }
                    }
                }
                else
                {

                    throw new Exception("El numero de documento es inválido.");
                }
            }


            if (!usuarioEncontrado)
            {
                throw new Exception("Empleado no encontrado");
            }
        }

        public static void CargaDeEmpleado(string Nombre, string Apellido, int Documento, string Contraseña, int Telefono, int categoria)
        {
            Conectar capaDatos = new Conectar();
            DataTable TablaEmpleados = capaDatos.BuscarEmpleados();
            bool usuarioEncontrado = false;


            foreach (DataRow Fila in TablaEmpleados.Rows)
            {
                string DocumentoEnBD = Fila["documentoTR"].ToString();
                int Documentoint = Convert.ToInt32(DocumentoEnBD);
                if (Documentoint == Documento)
                {
                    usuarioEncontrado = true;
                    throw new Exception("Ya existe un empleado con este documento");


                }

            }
            if (!usuarioEncontrado)
            {
                string Estado = "ACT";
                Conectar.AgregarEmpleados(Nombre, Apellido, Documento, Contraseña, Telefono, categoria, Estado);
                string detalle = "Cargar un empleado";
                string tabla = "Trabajador";
                AgregarBitacora(IdTrabajador, detalle, tabla);
                return;
                // agregar un registro a la bitacora de que se agrega un empleado 

            }
        }
        public DataTable ObtenerCategorias()
        {
            Conectar capaDatos = new Conectar();

            return capaDatos.TraerTablaCategorias();
        }


        public static void ModificarEmpleado(int idTrabajadorUPD, int idCategoriaUPD, string NombreUPD, string ApellidoUPD, int DNIUPD, string ContraseñaUPD, int CelularUPD)
        {
            try
            {
                Conectar.ActualizarEmpleado(idTrabajadorUPD, idCategoriaUPD, NombreUPD, ApellidoUPD, DNIUPD, ContraseñaUPD, CelularUPD);
                string detalle = "Modificacion de un empleado";
                string tabla = "Trabajador";
                AgregarBitacora(IdTrabajador, detalle, tabla);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar el empleado en la base de datos: {ex.Message}");
            }
        }

        public static void CambiarEstado(int idTrabajador, string Estado)
        {
            try
            {

                Conectar.EstadoEmpleado(idTrabajador, Estado);
                string detalle = "Cambio de estado de un empleado";
                string tabla = "Trabajador";
                AgregarBitacora(IdTrabajador, detalle, tabla);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cambiar el estado del empleado: {ex.Message}");
            }
        }
        public static List<Empleados> ObtenerTrabajador()
        {
            Conectar conexion = new Conectar();
            DataTable TrabajadorTabla = conexion.BuscarEmpleados();

            List<Empleados> Trabajador = new List<Empleados>();
            foreach (DataRow row in TrabajadorTabla.Rows)
            {
                if (row["ESTADO"].ToString() == "ACT")
                {
                    Trabajador.Add(new Empleados
                    {
                        idtrabajador = Convert.ToInt32(row["idTrabajador"]),
                        Nombre = row["NomTR"].ToString(),
                        Apellido = row["ApeTR"].ToString(),
                        IdCat = Convert.ToInt32(row["idCategoria"]),


                    });
                }
            }

            return Trabajador;
        }

        
    }

}
