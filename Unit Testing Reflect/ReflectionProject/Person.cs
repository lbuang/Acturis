namespace ConsoleAppRoslyn
{
    public class Person
    {
        public string Name
        {
            get;
            set;
        }

        public string Surname
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public void SetNameSurnameAndAge()
        {
            this.Name = "Lucky";
            this.Surname = "Buang";
            this.Age = 25;
        }

        private long IdNumber
        {
            get;
            set;
        }

        private int ContactNumber
        {
            get;
            set;
        }

        private void SetContactNumberAndIdNumber()
        {
            this.IdNumber = 9407230000001;
            this.ContactNumber = 0813926534;
        }
    }
}