namespace _531.Models.Lifts
{
    public class Press : Workout
    {
        public double GetTM()
        {
            string path = Constants.TrainingMaxes.Press.Path;
            string trainingMax = File.ReadAllText(path);
            Console.WriteLine($"Z Press Training Max: {trainingMax}kg");

            return Convert.ToDouble(trainingMax);
        }
        public void UpdateTM(double updatedTM)
        {
            string path = Constants.TrainingMaxes.Press.Path;
            string addToLog = updatedTM + " - " + DateTime.UtcNow.Date.ToShortDateString() + Environment.NewLine;
            File.AppendAllText(path, addToLog);
            Console.WriteLine($"A new TM PR of {updatedTM} was set for the Z Press!");
        }
    }
}
