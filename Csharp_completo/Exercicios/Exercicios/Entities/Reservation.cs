using System;
using Exercicios.Entities.Exceptions;

namespace Exercicios.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() 
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (CheckOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after Check-in");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public void UpdateDates(DateTime checkIn,  DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now ||  checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }

            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after Check-in");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;

            
        }
    }
}
