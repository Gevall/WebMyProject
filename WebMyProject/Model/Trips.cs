namespace WebMyProject.Model
{
    public class Trips
    {
        public Trips() { }

        private string manager; //фио менеджера
        private string loadCrm; //Статус загруски документов в CRM
        private string docs; // Сдал акт или нет
        private string readySoft; // Собранность СЗИ
        private string specialis; // Фамилия исполнителя
        private DateTime dateTrip; // Дата выезда
        //private string dateLoad; // Дата Занесения
        //private string dateSale; // Дата заключения договора
        //private string deadline; // Дедлайн договора
        //private string dateSoft; // Дата ожидания СЗИ
        //private string company; // От кого выезд
        //private string numberOfDoc; // Номер договора
        //private string customer; // Заказчик
        //private string address; // Адрес выезда
        //private string contactInfo; // Контактная информация
        //private string comment; // Коментарий, если есть

        public string Manager { get { return this.manager; } set { this.manager = value; } }
        public string LoadCrm { get { return this.loadCrm; } set { this.loadCrm = value; } }
        public string Docs { get { return this.docs; } set { this.docs = value; } }
        public string ReadySort { get { return this.readySoft; } set { this.readySoft = value; } }
        public string Specialist { get { return this.specialis; } set { this.specialis = value; } }
        public DateTime DateTrip { get { return this.dateTrip; } set { this.dateTrip = value; } }
        //public string DateLoad { get { return this.dateLoad; } set { this.dateLoad = value; } }
        //public string DateSale { get { return this.dateSale; } set { this.dateSale = value; } }
        //public string Deadline { get { return this.deadline; } set { this.deadline = value; } }
        //public string DateSoft { get { return this.dateSoft; } set { this.dateSoft = value; } }
        //public string Company { get { return this.company; } set { this.company = value; } }
        //public string NumberOfDoc { get { return this.numberOfDoc; } set { this.numberOfDoc = value; } }
        //public string Customer { get { return this.customer; } set { this.customer = value; } }
        //public string Address { get { return this.address; } set { this.address = value; } }
        //public string ContactInfo { get { return this.contactInfo; } set { this.contactInfo = value; } }
        //public string Comment { get { return this.comment; } set { this.comment = value; } }

    }
}
