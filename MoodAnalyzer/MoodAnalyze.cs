using System.Reflection;

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
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            MoodAnalyze moodAnalyze = (MoodAnalyze)obj;
            return message == moodAnalyze.message;
        }
    }
    public class MoodAnalyserFactory
    {
        public static MoodAnalyze CreateMoodAnalyser()
        {
            try
            {
                Type moodAnalyserType = Type.GetType("MoodAnalyser");
                MoodAnalyze moodAnalyser = (MoodAnalyze)Activator.CreateInstance(moodAnalyserType);
                return moodAnalyser;
            }
            catch (TypeLoadException)
            {
                throw new MoodAnalysisException("No such class error");
            }
            catch (MissingMethodException)
            {
                throw new MoodAnalysisException("No such method error");
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