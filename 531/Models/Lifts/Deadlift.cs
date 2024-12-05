namespace _531.Models.Lifts
{
    internal class Deadlift : Workout
    {
        public double GetTM()
        {
            string path = Constants.TrainingMaxes.Deadlift.Path;
            string trainingMax = File.ReadAllText(path);
            Console.WriteLine($"Conventional Deadlift Training Max: {trainingMax}kg");

            return Convert.ToDouble(trainingMax);
        }
        public void UpdateTM(double updatedTM)
        {
            string path = Constants.TrainingMaxes.Deadlift.Path;
            string addToLog = updatedTM + " - " + DateTime.UtcNow.Date.ToShortDateString() + Environment.NewLine;
            File.AppendAllText(path, addToLog);
            Console.WriteLine($"A new TM PR of {updatedTM} was set for the Conventional Deadlift!");
        }
    }
}
