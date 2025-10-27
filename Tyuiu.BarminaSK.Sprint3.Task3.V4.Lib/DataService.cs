using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BarminaSK.Sprint3.Task3.V4.Lib
{
    public class DataService : ISprint3Task3V4
    {
        public string DeleteCharInString(string value, char item)
        {
            string result = "";

            foreach (char c in value)
            {
                if (c != item)
                {
                    result += c;
                }
            }

            return result;
        }
    }
}
