using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Restaurant.Domain.Models.Utilizator;
namespace Restaurant.Restaurant.Domain.Interfaces
{
    internal interface IComanda
    {
        //TODO: REturneaza Comanda
        public void creazaComanda(Utilizator utilizator);
        public void finalizareComanda(Object plata);
    }
}
