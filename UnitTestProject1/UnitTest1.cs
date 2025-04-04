using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Variant2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateGrade_Excellent()
        {
            MainWindow form = new MainWindow();
            int dbScore = 22;
            int psScore = 38;
            int soScore = 20;

            string grade = form.CalculateGrade(dbScore, psScore, soScore);

            Assert.AreEqual("5 (отлично)", grade);
        }
        [TestMethod]
        public void CalculateGrade_MinimumValidScore()
        {
            int dbScore = 0;
            int psScore = 0;
            int soScore = 0;

            MainWindow form = new MainWindow();
            string grade = form.CalculateGrade(dbScore, psScore, soScore);

            Assert.AreEqual("2 (неудовлетворительно)", grade);
        }
        [TestMethod]
        public void CalculateGrade_InvalidScore_TooHigh()
        {
            int dbScore = 23; 
            int psScore = 39; 
            int soScore = 21; 

            MainWindow form = new MainWindow();
            string grade = form.CalculateGrade(dbScore, psScore, soScore);

            Assert.AreEqual("Ошибка: Баллы за модуль 'Разработка, администрирование и защита БД' должны быть от 0 до 22", grade);
        }
        [TestMethod]
        public void CalculateGrade_EmptyInputs()
        {
            int dbScore = 0; 
            int psScore = 0;
            int soScore = 0; 

            MainWindow form = new MainWindow();
            string grade = form.CalculateGrade(dbScore, psScore, soScore);

            Assert.AreEqual("2 (неудовлетворительно)", grade); 
        }
    }
}
