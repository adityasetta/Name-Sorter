namespace name_sorter.Utils
{
    public interface ISorting
    {
        /// <summary>
        /// Sort the name
        /// </summary>
        public void Sort();

        /// <summary>
        /// The sorted name list
        /// </summary>
        public string[] SortedNames { get; }
    }
}
