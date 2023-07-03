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
            MoodAnalyze analyze = new MoodAnalyze("I am in sad Mood");
            string result = analyze.AnalyzeMood();
            Assert.AreEqual("SAD",result);
        }

        [TestMethod]
        public void GivenAnyMood_WhenAnalyze_ShouldReturnHappy()
        {
            MoodAnalyze analyze = new MoodAnalyze("I am in any Mood");
            string result = analyze.AnalyzeMood();
            Assert.AreEqual("HAPPY", result);
        }

        [TestMethod]
        public void GivenNullMood_WhenAnalyze_ShouldReturnHappy()
        {
            MoodAnalyze analyze = new MoodAnalyze(null);
            string result = analyze.AnalyzeMood();
            Assert.AreEqual("HAPPY", result);
        }
    }
}