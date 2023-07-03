namespace MoodAnalyzer
{
    public enum MoodAnalysisError
    {
        EMPTY,
        NULL
    }
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
                //Check if message is null
                if (message == null)
                {
                    throw new MoodAnalysisException(MoodAnalysisError.NULL.ToString());
                }

                //Check if message is empty
                if (string.IsNullOrEmpty(message))
                {
                    throw new MoodAnalysisException(MoodAnalysisError.EMPTY.ToString());
                }

                //Pass the message sad or happy
                if (message.Contains("sad"))
                {
                    return "SAD";
                }
                else {
                    return "HAPPY"; 
                }
            }catch (MoodAnalysisException ex)
            {
                return ex.Message;
            }
        }
    }

    public class MoodAnalysisException : Exception
    {
        public MoodAnalysisException (string message) : base(message)
        {

        }
    }
}