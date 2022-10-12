using BeniplasApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BeniplasApi.Controllers
{
    public class EmpleadosController : ApiController
    {
        Conexion2 bd = new Conexion2();
        [ActionName("InsertarEmpleado")]
        [HttpPost]

        public bool InsertarEmpleado(Empleadoes Empleado)
        {
            try
            {
                bd.Empleadoes.Add(Empleado);
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        [ActionName ("MostrarEmpleados")]
        [HttpGet]
        public IQueryable<EmpleadoDTO> Get()
        {
            IQueryable<EmpleadoDTO> empleados = from BaseDatos in bd.Empleadoes
                                                   select new EmpleadoDTO
                                                   {
                                                       ID = BaseDatos.ID,
                                                       NombreUsuario = BaseDatos.NombreUsuario,
                                                       ApellidoP = BaseDatos.ApellidoP,
                                                       ApellidoM = BaseDatos.ApellidoM,
                                                       NumTel = BaseDatos.NumTel,
                                                       Contrasena = BaseDatos.Contrasena,
                                                       Status = BaseDatos.Status,
                                                       Codigo = BaseDatos.Codigo,
                                                       Sucursal_ID = BaseDatos.Sucursal_ID
                                                   };
            return empleados;
        }

        [ActionName("ActualizarDatos")]
        [HttpPut]

        public bool ActualizarDatos(Empleadoes empleadoes)
        {
            try
            {
                bd.Entry(empleadoes).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
