using System.Collections.Generic;
using Xunit;
namespace RepeatCounterNS.Objects
{
  public class RepeatCounterTest
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
    [Fact]
    public void Test3_IfInput1WillCountInput2AndAddMultipleCounts_ReturnCount()
    {
      //Arrange
      string input1 = "Hello hello Hello hello";
      string input2 = "hello";
      RepeatCounter testWord = new RepeatCounter(input1, input2);

      //Act
      int result = testWord.CountRepeats();

      //Assert
      Assert.Equal(4, result);
    }
    [Fact]
    public void Test4_IfInput1WillCountInput2IfThereIsPunctuation_ReturnCount()
    {
      //Arrange
      string input1 = "Hi my name is Simon. Simon is a name I like.";
      string input2 = "simon";
      RepeatCounter testWord = new RepeatCounter(input1, input2);

      //Act
      int result = testWord.CountRepeats();

      //Assert
      Assert.Equal(2, result);
    }
  }
}
