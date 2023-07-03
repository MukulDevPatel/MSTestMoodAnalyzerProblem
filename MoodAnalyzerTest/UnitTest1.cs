global using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMood_WhenAnalyze_ShouldReturnSad()
        {
            string message = "I am in sad Mood";
            MoodAnalyze analyze = new MoodAnalyze(message);
            string result = analyze.AnalyzeMood(message);
            Assert.AreEqual("SAD",result);
        }

        [TestMethod]
        public void GivenAnyMood_WhenAnalyze_ShouldReturnHappy()
        {
            string message = "I am in any Mood";
            MoodAnalyze analyze = new MoodAnalyze(message);
            string result = analyze.AnalyzeMood(message);
            Assert.AreEqual("HAPPY", result);
        }
    }
}