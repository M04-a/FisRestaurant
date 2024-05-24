using Restaurant.Restaurant.Domain.Models;

namespace Restaurant.Restaurant.Domain.Interfaces
{
    internal interface IProcesarePlataCard
    {
        public bool procesarePlataCard(PlataCard plata);
    }
}