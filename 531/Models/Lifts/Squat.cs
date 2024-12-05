namespace _531.Models.Lifts
{
    public class Squat : Workout
    {
        public double GetTM()
        {
            string path = Constants.TrainingMaxes.Squat.Path;
            string[] trainingMax = File.ReadLines(path).Last().Replace(" ", "").Split("-");
            Console.WriteLine($"Zercher Squat Training Max: {trainingMax[0]}kg");

            return Convert.ToDouble(trainingMax[0]);
        }
        public void UpdateTM(double updatedTM)
        {
            string path = Constants.TrainingMaxes.Squat.Path;
            string addToLog = updatedTM + " - " + DateTime.UtcNow.Date.ToShortDateString() + Environment.NewLine;
            File.AppendAllText(path, addToLog);
            Console.WriteLine($"A new TM PR of {updatedTM}kg was set for the Zercher Squat!");
        }
    }
}
