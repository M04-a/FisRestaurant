using Restaurant.Restaurant.Domain.Models.Utilizator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Restaurant.Domain.Interfaces
{
    internal interface IAutentificare
    {
        public Utilizator? autentificare(string username ,string parola);
        public bool deconectare(Utilizator utilizator);
        public string genereazaToken(Utilizator utilizator);

        public Utilizator? validareToken(string token);
    }
}
