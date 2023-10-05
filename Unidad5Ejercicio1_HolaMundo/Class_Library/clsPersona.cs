namespace Class_Library
{
    public class clsPersona
    {
        #region attributes
        public string name;
        public string lastNames;
        #endregion


        #region constructors
        public clsPersona()
        {
            name = "";
            lastNames = "";
        }

        public clsPersona(string name, string lastNames)
        {
            this.name = name;
            this.lastNames = lastNames;
        }
        #endregion


        #region properties
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public string LastNames
        {
            get { return lastNames; }
            set { lastNames = value; }
        }

    }
}