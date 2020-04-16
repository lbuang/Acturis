namespace ConsoleAppRoslyn
{
    public class classPerson
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

        private int ContactNumber
        {
            get;
            set;
        }

        private long IdNumber
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
    }
}