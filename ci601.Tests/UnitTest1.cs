namespace ci601.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var list = new List<int> { 1, 2, 3, 4, 5 };
            //Act
            list.Add(6);
            //Assert
            Assert.Contains(6, list);
            Assert.Equal(6, list.Count);
        }
    }
}