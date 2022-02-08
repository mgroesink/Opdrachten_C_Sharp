namespace Opdrachten_C_Sharp
{
    public static class StaticMethods
    {
        public static string LuizenMoeder()
        {
            return "Hallo allemaal wat leuk dat jullie er zijn";
        }

        public static int Power(int baseNumber , int pow)
        {
            var result = baseNumber;
            for(int i = 0; i < pow; i++)
            {
                result *= baseNumber;
                //result = result * baseNumber;
            }
            return result;
        }

        public static int AddNumbers(int v1, int v2)
        {
            return v1 + v2;
        }
    }
}
