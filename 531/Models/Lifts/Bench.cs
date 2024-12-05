namespace _531.Models.Lifts
{
    public class Bench : Workout
    {
        public double GetTM()
        {
            string path = Constants.TrainingMaxes.InclineBench.Path;
            string[] trainingMax = File.ReadLines(path).Last().Replace(" ", "").Split("-");
            Console.WriteLine($"Incline Bench Training Max: {trainingMax[0]}kg");

            return Convert.ToDouble(trainingMax[0]);
        }
        public void UpdateTM(double updatedTM)
        {
            string path = Constants.TrainingMaxes.InclineBench.Path;
            string addToLog = updatedTM + " - " + DateTime.UtcNow.Date.ToShortDateString() + Environment.NewLine;
            File.AppendAllText(path, addToLog);
            Console.WriteLine($"A new TM PR of {updatedTM}kg was set for the Incline Bench!");
        }
    }
}
