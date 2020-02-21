using System.IO;

namespace name_sorter.Helpers
{
    /// <summary>
    /// Validator class
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Validate input arguments
        /// </summary>
        /// <param name="args">input arguments</param>
        /// <returns>True if the input is valid, false otherwise</returns>
        public static bool ValidateInput(string[] args)
        {
            // check arguments count
            if (args.Length != 1)
            {
                return false;
            }

            // invalid when the file not found
            if (!File.Exists(args[0]))
            {
                return false;
            }

            return true;
        }
    }
}
