namespace MoodAnalyzer
{
    public class MoodAnalyze
    {
        private string message;
        public MoodAnalyze(string message)
        {
            this.message = message;
        }
        public MoodAnalyze() 
        {
            message = "";
        }
        public string AnalyzeMood()
        {
            if (message.Contains("sad"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}