using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniSolution.Models.Repositories
{
    public static class TanqueRepository
    {
        internal static List<Tanque> GetTanques()
        {
            using (var contexto = new ApplicationContext())
            {
                return contexto.Tanque.ToList();
            }
        }

        internal static Tanque GetTanque(string deposito)
        {
            using (var contexto = new ApplicationContext())
            {
                return contexto.Tanque.Where(x => x.Deposito == deposito).FirstOrDefault();
            }
        }

        internal static void SaveTanque(Tanque tanque)
        {
            using (var contexto = new ApplicationContext())
            {
                contexto.Add(tanque);

                contexto.SaveChanges();
            }
        }

        internal static void DeleteTanque(string deposito)
        {
            using (var contexto = new ApplicationContext())
            {
                Tanque tanque = GetTanque(deposito);
                contexto.Remove(tanque);

                contexto.SaveChanges();
            }
        }

        internal static void UpdateTanque(Tanque tanque)
        {
            using (var contexto = new ApplicationContext())
            {
                var founded = GetTanque(tanque.Deposito) != null; // encontrou
                if (founded)
                {
                    contexto.Update(tanque);
                }

                contexto.SaveChanges();
            }

        }
    }
}