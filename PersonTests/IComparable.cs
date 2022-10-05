namespace PersonTests
{
    /// <summary>
    /// Represents the IComparable interface.
    /// </summary>
    /// <typeparam name="Person">Represents one Person.</typeparam>
    internal interface IComparable<Person>
    {
        /// <summary>
        /// Method of IComparable to compare to a Person.
        /// </summary>
        /// <param name="person">Holds an instance of a Person.</param>
        /// <returns>Returns an int value.</returns>
        public int CompareTo(Person person);
    }
}
