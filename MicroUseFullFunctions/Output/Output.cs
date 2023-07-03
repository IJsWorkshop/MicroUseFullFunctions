using System.Diagnostics;


namespace MicroUseFullFunctions.Output
{
    public static class Output
    {
        public static void ToDebugWindow<T>(this List<T> list)
        {
            foreach (var lis in list)
            {
                foreach (var prop in lis.GetType().GetProperties())
                {
                    Debug.WriteLine($"{prop.Name} : {prop.GetValue(lis, null)} ");
                }

                Debug.WriteLine("");
            }
        }

        public static void ToConsoleWindow<T>(this List<T> list)
        {
            foreach (var lis in list)
            {
                foreach (var prop in lis.GetType().GetProperties())
                {
                    Console.WriteLine($"{prop.Name} : {prop.GetValue(lis, null)} ");
                }

                Console.WriteLine("");
            }
        }

    }
}
