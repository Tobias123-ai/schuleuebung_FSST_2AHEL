namespace Schulübung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Points = 66;
            string Grade = "";

            if (Points >= 85)
            {
                Grade = "Excellent";
            }
            else if (Points >= 75)
            {
                Grade = "Good";
            }
            else if (Points >= 65)
            {
                Grade = "OK";
            }
            else if (Points >= 50)
            {
                Grade = "Pass";
            }
            else
            {
                Grade = "Fail";
            }
            Console.WriteLine(Grade);

        }
    }
