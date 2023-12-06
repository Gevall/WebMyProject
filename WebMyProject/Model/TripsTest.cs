namespace WebMyProject.Model
{
    public class TripsTest
    {
        private static List<Trips>? _trips;
        public static List<Trips>? trips = GetTrips();

        /// <summary>
        /// Тестовая таблица с командировками
        /// </summary>
        /// <returns>Нсортированый list</returns>
        private static List<Trips> GetTrips()
        {
            _trips = new List<Trips>
            {
                new Trips {Manager="Иванов Иван", Docs="Да", ReadySort="Нет", LoadCrm="Нет", Specialist="Петров Николай", DateTrip = new DateTime(2023-10-01)},
                new Trips {Manager="Сидоров Иван", Docs="Нет", ReadySort="Да", LoadCrm="Да", Specialist="Николаев Петр", DateTrip=new DateTime(2023-11-12)},
                new Trips {Manager="Куликов Иван", Docs="Нет", ReadySort="Да", LoadCrm="Нет", Specialist="Петров Николай", DateTrip=new DateTime(2023-10-01)},
                new Trips {Manager="Иванов Иван", Docs="Нет", ReadySort="Нет", LoadCrm="Да", Specialist="Сидоров Глеб", DateTrip=new DateTime(2023-12-21)},
                new Trips {Manager="Сидоров Иван", Docs="Да", ReadySort="Да", LoadCrm="Да", Specialist="Петров Николай", DateTrip=new DateTime(2023-11-01)},
                new Trips {Manager="Иванов Иван", Docs="Да", ReadySort="Нет", LoadCrm="Нет", Specialist="Николаев Иван", DateTrip=new DateTime(2023-10-12)}
            };

            return _trips;
        }
    }
}
