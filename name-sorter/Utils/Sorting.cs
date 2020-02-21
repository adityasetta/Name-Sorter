using name_sorter.Models;
using System.Collections.Generic;
using System.Linq;

namespace name_sorter.Utils
{
    /// <summary>
    /// Sorting
    /// </summary>
    public class Sorting : ISorting
    {
        /// <summary>
        /// Raw name list from input
        /// </summary>
        private string[] rawNameList;

        /// <summary>
        /// List of name details
        /// </summary>
        private List<Name> nameList;

        /// <summary>
        /// Sorted output name list
        /// </summary>
        private List<string> sortedNameList;

        /// <summary>
        /// Initialize values
        /// </summary>
        /// <param name="inputNames">input name list</param>
        public Sorting(string[] inputNames)
        {
            rawNameList = inputNames;
            nameList = new List<Name>();
        }

        /// <summary>
        /// Sort the name
        /// </summary>
        public void Sort()
        {
            sortedNameList = new List<string>();
            foreach(string name in rawNameList)
            {
                Name nameDetails = new Name(name);
                nameList.Add(nameDetails);
            }

            // Sort list by last name
            nameList = nameList.OrderBy(x=>x.LastName).ToList();

            // Get and distinct the list to get the unique last names
            IEnumerable<string> distinctedNameList = nameList.Select(x => x.LastName).ToList().Distinct();

            foreach(string lastName in distinctedNameList)
            {
                List<string> otherNames = nameList.Where(y => y.LastName == lastName).Select(x => x.OtherName).ToList();

                otherNames.Sort();

                foreach(string otherName in otherNames)
                {
                    if (otherName.Equals(string.Empty))
                    {
                        sortedNameList.Add(lastName);
                    }
                    else
                    {
                        sortedNameList.Add(string.Format("{0} {1}", otherName, lastName));
                    }
                }
            }
        }

        /// <summary>
        /// The sorted name list
        /// </summary>
        public string[] SortedNames
        {
            get
            {
                return sortedNameList.ToArray();
            }     
        }
    }
}
