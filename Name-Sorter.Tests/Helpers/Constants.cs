using System;
using System.Collections.Generic;
using System.Text;

namespace Name_Sorter.Tests.Helpers
{
    /// <summary>
    /// Constants required for unit testing
    /// </summary>
    public class Constants
    {
        public static readonly string[] NAMEWITH1FORMINPUT = new string[] { "Zephir", "Bambang", "Lomo", "Kaka" };

        public static readonly string[] NAMEWITH1FORMOUTPUT = new string[] { "Bambang", "Kaka", "Lomo", "Zephir" };

        public static readonly string[] NAMEWITH2FORMINPUT = new string[] { "Anton Kaka", "Aini Subandi", "Aaron Subandi", "Kala Subandi" };

        public static readonly string[] NAMEWITH2FORMOUTPUT = new string[] { "Anton Kaka", "Aaron Subandi", "Aini Subandi", "Kala Subandi" };

        public static readonly string[] NAMEWITH3FORMINPUT = new string[] { "Nikita Alonso Zephir", "Bambang Gunandar Ini", "Lala Lili Lulu", "Kaka Kiki Kuku" };

        public static readonly string[] NAMEWITH3FORMOUTPUT = new string[] { "Bambang Gunandar Ini", "Kaka Kiki Kuku", "Lala Lili Lulu", "Nikita Alonso Zephir" };

        public static readonly string[] NAMEWITHMORETHAN4FORMINPUT = new string[] { "Al Maulidi Mal Mul Zoni", "Ali Mau Makan Bobo Lidi", "Amin Amun Amen Aman Amail Amama" };

        public static readonly string[] NAMEWITHMORETHAN4FORMOUTPUT = new string[] { "Amin Amun Amen Amama", "Ali Mau Makan Lidi", "Al Maulidi Mal Zoni" };
    }
}
