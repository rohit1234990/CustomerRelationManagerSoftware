using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;

namespace CustomerRelationManager
{
    public static class Util
    {
        public static short ServiceAfterMonths = 0 , MinimumDaysToResovle = 0;
        static Util()
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT * FROM Settings";
            DataTable dt = dbWrapper.SelectData(cmd);

            if (dt.Rows.Count > 0)
            {
                ServiceAfterMonths = Convert.ToInt16(dt.Rows[0]["ServiceAfterMonths"]);
                MinimumDaysToResovle = Convert.ToInt16(dt.Rows[0]["MinimumDaysToResolve"]);
            }    
        }

        public static string UppercaseWords(string value)
        {
            char[] array = value.ToCharArray();
            // Handle the first letter in the string.
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }
    }
}
