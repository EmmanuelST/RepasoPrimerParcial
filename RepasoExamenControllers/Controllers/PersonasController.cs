using Microsoft.EntityFrameworkCore;
using RepasoExamenControllers.Data;
using RepasoExamenControllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepasoExamenControllers.Controllers
{
    public class PersonasController
    {

        public bool Guardar(Personas entity)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Personas.Add(entity);
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }


            return paso;
        }

        public bool Modificar(Personas entity)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(entity).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }



            return paso;
        }

        public bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                Personas persona = db.Personas.Find(Id);
                db.Entry(persona).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;



            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public Personas Buscar(int Id)
        {
            Personas persona;
            Contexto db = new Contexto();
            try
            {
                persona = db.Personas.Find(Id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return persona;
        }
    }
}
