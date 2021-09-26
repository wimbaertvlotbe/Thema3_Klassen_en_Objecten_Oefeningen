namespace OefeningenOOP
{
    //Voorbeeld van hoe je een klasse in een namespace schrijft
    public class Test
    {
        string name;

        public Test()
        {
            this.name = string.Empty;
        }

        public Test(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return "Instantiëren van het Test-object " + name + " gelukt!";
        }
    }
}