using _531.Models.Lifts;

namespace _531.Services
{
    public class PressService
    {
        public static void TrainingDay(string[] mainSets)
        {
            Press press = new Press();

            double TM = press.GetTM();

            Console.WriteLine(press.DisplayWorkSets(mainSets, TM));

            Console.Write("Enter top set: ");
            int topSet = int.Parse(Console.ReadLine()!);
            double updatedTM = press.AddToTM(topSet, TM);

            if (TM < updatedTM)
            {
                press.UpdateTM(updatedTM);
            }

            return;
        }
    }
}
