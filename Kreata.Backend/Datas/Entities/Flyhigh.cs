using Kreata.Backend.Datas.Enums;

namespace Kreata.Backend.Datas.Entities
{
    public class Flyhigh
    {
        public Flyhigh(Guid id, string firstName, string lastName, DateTime birthsDay, PlaceClassType travelClass, bool isWooman)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            TravelClass = travelClass;
            IsWoomen = isWooman;
        }

        public Flyhigh(string firstName, string lastName, DateTime birthsDay, PlaceClassType travelClass, bool isWooman)
        {
            Id = new Guid();
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            TravelClass = travelClass;
            IsWoomen = isWooman;
        }

        public Flyhigh()
        {
            Id = new Guid();
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthsDay = new DateTime();
            TravelClass = PlaceClassType.ClassTurist;
            IsWoomen = false;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthsDay { get; set; }
        public PlaceClassType TravelClass { get; set; }
        public bool IsWoomen { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName} ({TravelClass}), Szül: ({String.Format("{0:yyyy.MM.dd.}", BirthsDay)}), Osztály szint: ({TravelClass})";
        }
    }
}
