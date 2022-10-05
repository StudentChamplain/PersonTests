namespace PersonTests
{
    /// <summary>
    /// Represents one person saving their name.
    /// </summary>
    public class Person : IMeasurable, IResettable, IDisplayable, IComparable<Person>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// Constructor for a person optionally adding their name.
        /// </summary>
        /// <param name="name">Person's name, empty by default.</param>
        public Person(string name = "")
        {
            this.Name = name.Trim();
        }

        /// <summary>
        /// Gets or sets the name of the person.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets the name length and returns it as an int .
        /// </summary>
        public int Size => this.Name.Length;

        /// <summary>
        /// Returns a string that represents the person.
        /// </summary>
        /// <returns>String that represents the person.</returns>
        public override string ToString()
        {
            return this.Name;
        }

        /// <summary>
        /// This public method will reset the Name value to an empty string.
        /// </summary>
        public void Reset()
        {
            this.Name = string.Empty;
        }

        /// <summary>
        /// Method inherited from the interface IDisplayable to display a persons name.
        /// </summary>
        public void Display()
        {
            MessageBox.Show(this.ToString());
        }

        /// <summary>
        /// Method from IComparable interface that compares two Persons.
        /// </summary>
        /// <param name="person">Holds an instance of a Person.</param>
        /// <returns>Returns an int value.</returns>
        public int CompareTo(Person person)
        {
            if (this.Name == person.Name)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
