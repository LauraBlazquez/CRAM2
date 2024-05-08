using System.Threading;

namespace CRAM2
{
    public class HelperClass
    {
        public static double CalculateTurtleGA(RescueDTO rescue)
        {
            const int Two = 2, Three = 3, Twenty = 20, RescueTurtle = 15;
            return (Two * rescue.AffectationDegree + Three) - ((rescue.AffectationDegree - Twenty) * Two) - RescueTurtle;
        }
        public static double CalculateBirdGA(RescueDTO rescue, bool option)
        {
            const int Five = 5, LocalRescueBirds = 5;
            if (option == true)
                return Math.Floor((double)(rescue.AffectationDegree - LocalRescueBirds) / Five);
            return Math.Floor((double)rescue.AffectationDegree / Five);
        }
        public static double CalculateCetaceanGA(RescueDTO rescue, bool option)
        {
            const int Five = 5, LocalRescueCetacean = 50;
            if (option == true)
                return Math.Floor((double)rescue.AffectationDegree - (rescue.AffectationDegree / Five) - LocalRescueCetacean);
            return Math.Floor((double)rescue.AffectationDegree - (rescue.AffectationDegree / Five));
        }
        public static int RandomValues(int min, int max)
        {
            var Random = new Random();
            return Random.Next(min, max + 1);
        }
        public static string RandomStrings(string[] values)
        {
            var Random = new Random();
            return values[Random.Next(values.Length)];
        }
    }
}
