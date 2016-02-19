using System.Collections.Generic;
using Xunit;
namespace RepeatCounter.Objects
{
  public class FindAndReplaceTest
  {
    [Fact]
    public void Test1_IfInput1WillCountInput2LowerCase_ReturnCount()
    {
      //Arrange
      string input1 = "Hello";
      string input2 = "hello";
      RepeatCounter testWord = new RepeatCounter(input1, input2);

      //Act
      int result = testWord.CountRepeats();

      //Assert
      Assert.Equal(1, result);
    }
    [Fact]
    public void Test2_IfInput1WillCountInput2WithMoreThanOneWord_ReturnCount()
    {
      //Arrange
      string input1 = "Hello everybody";
      string input2 = "hello";
      RepeatCounter testWord = new RepeatCounter(input1, input2);

      //Act
      int result = testWord.CountRepeats();

      //Assert
      Assert.Equal(1, result);

  }
}
