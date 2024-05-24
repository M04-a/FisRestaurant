using Restaurant.Restaurant.Domain.Models.Utilizator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Restaurant.Domain.Interfaces
{
    internal interface IRepoUtilizator
    {
        public Utilizator extrageUtilizator(string username);
        public void adaugaUtilizator(Utilizator utilizator);
        public void eliminaUtilizator(Utilizator utilizator);
        public void actualizareUtilizator(string username,Utilizator utilizator);
    }
}
