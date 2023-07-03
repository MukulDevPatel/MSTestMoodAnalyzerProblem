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
            try
            {
                //Check message should not be empty
                if (string.IsNullOrEmpty(message))
                {
                    throw new ArgumentNullException("message", "Mood can't be null or empty");
                }

                //Pass the message sad or happy
                if (message.Contains("sad"))
                {
                    return "SAD";
                }
                else {
                    return "HAPPY"; 
                }
            }catch (ArgumentNullException)
            {
                return "HAPPY";
            }
        }
    }
}