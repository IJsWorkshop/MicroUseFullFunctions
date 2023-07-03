namespace MicroUseFullFunctions.Convert
{
    public static class Convert
    {
        /// <summary>
        /// Convert string into a DateTime string with formating
        /// </summary>
        /// <param name="datestring"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ToDateTime(this string datestring, string format = "ddd dd")
        {
            var dstring = datestring;

            if (DateTime.TryParse(datestring, out DateTime dTime))
            {
                dstring = dTime.ToString(format);
            }

            return dstring;
        }
    }
}