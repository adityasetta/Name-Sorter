using name_sorter.Helpers;
using System.Linq;

namespace name_sorter.Models
{
    /// <summary>
    /// The name details
    /// </summary>
    public class Name
    {
        /// <summary>
        /// Initialize the name details value
        /// </summary>
        /// <param name="name">The full name</param>
        public Name(string name)
        {
            string[] splittedName = name.Split(' ');
            this.LastName = splittedName[splittedName.Length - 1];

            // Take maximum 3 given name
            int givenName = splittedName.Length > 4 ? Constants.MAX_GIVEN_NAME : splittedName.Length - 1;

            string[] otherName = splittedName.Take(givenName).ToArray();
            this.OtherName = string.Join(" ", otherName);            
        }

        /// <summary>
        /// The last name
        /// </summary>
        public string LastName { get; private set; }

        /// <summary>
        /// The Other name
        /// </summary>
        public string OtherName { get; private set; }
    }
}
