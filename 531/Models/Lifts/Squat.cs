using System.IO;
using _531.Models;

namespace _531.Models.Lifts
{
    public class Squat : Workout
    {
        public double GetTM()
        {
            string path = Constants.TrainingMaxes.Squat.Path;
            string trainingMax = File.ReadAllText(path);
            Console.WriteLine($"Zercher Squat Training Max: {trainingMax}kg");

            return Convert.ToDouble(trainingMax);
        }
        public void UpdateTM(double updatedTM)
        {
            string path = Constants.TrainingMaxes.Squat.Path;
            string addToLog = updatedTM + " - " + DateTime.UtcNow.Date.ToShortDateString() + Environment.NewLine;
            File.AppendAllText(path, addToLog);
            Console.WriteLine($"A new TM PR of {updatedTM} was set for the Zercher Squat!");
        }
    }
}
