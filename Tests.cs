using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace cSharpTutorials
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void FindPassingStudents_ReturnsCorrectStudents() {
            // Arrange
            LinqPractice lp = new LinqPractice();
            var students = new List<Student>
            {
                new Student("John", new List<int> { 10, 20, 30 }),
                new Student("Steve", new List<int> { 40, 50, 90 }),
                new Student("Bryan", new List<int> { 90, 0, 100 })
            };
            int passMark = 40;

            // Act        
            var passingStudents = lp.FindPassingStudents(students, passMark);

        // Assert
        Assert.AreEqual(2, passingStudents.Count());
        Assert.IsTrue(passingStudents.Any(s => s.Name == "Steve"));
        Assert.IsTrue(passingStudents.Any(s => s.Name == "Bryan"));
        }
    }
}
