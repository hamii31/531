using System.Text;

namespace _531.Models
{
    public class Workout
    {
        public double AddToTM(int topSet, double TM)
        {
            double add = topSet == 1 ? 2.5
                       : topSet == 2 ? 2.5
                       : topSet == 3 ? 2.5
                       : topSet == 4 ? 5
                       : topSet == 5 ? 7.5
                       : topSet > 5 ? 10 : 0;

            return TM += add;
        }

        public string DisplayWorkSets(string[] mainSets, double TM)
        {
            StringBuilder sb = new StringBuilder();

            if (mainSets.Length == 0 || mainSets.Length > 3)
            {
                return "Invalid main sets.";
            }

            sb.AppendLine(mainSets[0] + " x " + (TM * Constants.Percentages.firstSet).ToString());
            sb.AppendLine(mainSets[1] + " x " + (TM * Constants.Percentages.secondSet).ToString());
            sb.AppendLine(mainSets[2] + " x " + (TM * Constants.Percentages.thirdSet).ToString());

            return sb.ToString();
        }
    }
}
