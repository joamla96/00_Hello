namespace _00_Hello
{
    public class Functions
    {
        public static string Hello(string Input = null)
        {
            string rs = "hello";
            
            if(Input != null)
            {
                rs = rs + ", " + Input;
            }

            return rs;
        }
    }
}