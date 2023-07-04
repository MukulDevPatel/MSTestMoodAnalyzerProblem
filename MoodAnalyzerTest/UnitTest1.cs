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

        [TestMethod]
        public void GivenNullMood_WhenAnalyze_ShouldThrowMoodAnalysisException()
        {
            MoodAnalyze analyze = new MoodAnalyze(null);
            string mood = analyze.AnalyzeMood();
            Assert.AreEqual(MoodAnalysisError.NULL.ToString(),mood);
        }

        [TestMethod]
        public void GivenEmptyMood_WhenAnalyze_ShouldThrowMoodAnalysisException()
        {
            MoodAnalyze analyze = new MoodAnalyze("");
            string mood = analyze.AnalyzeMood();
            Assert.AreEqual(MoodAnalysisError.EMPTY.ToString(), mood);
        }

        [TestMethod]
        public void CreateMoodAnalyser_WithValidClassName_ReturnsMoodAnalyserObject()
        {
            // Arrange
            MoodAnalyze expectedMoodAnalyser = new MoodAnalyze();

            // Act
            MoodAnalyze actualMoodAnalyser = MoodAnalyserFactory.CreateMoodAnalyser();
                
            // Assert
            Assert.AreEqual(expectedMoodAnalyser, actualMoodAnalyser);
        }

        [TestMethod]
        public void CreateMoodAnalyser_WithInvalidClassName_ThrowsMoodAnalysisException()
        {
            // Arrange, Act & Assert
            Assert.ThrowsException<MoodAnalysisException>(() => MoodAnalyserFactory.CreateMoodAnalyser());
        }

        [TestMethod]
        public void Equals_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            MoodAnalyze moodAnalyser1 = new MoodAnalyze("I am in a Happy Mood");
            MoodAnalyze moodAnalyser2 = new MoodAnalyze("I am in a Happy Mood");

            // Act
            bool result = moodAnalyser1.Equals(moodAnalyser2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Equals_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            MoodAnalyze moodAnalyser1 = new MoodAnalyze("I am in a Happy Mood");
            MoodAnalyze moodAnalyser2 = new MoodAnalyze("I am in a Sad Mood");

            // Act
            bool result = moodAnalyser1.Equals(moodAnalyser2);

            // Assert
            Assert.IsFalse(result);
        }
    }
}