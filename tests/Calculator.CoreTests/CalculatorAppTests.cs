namespace Calculator.CoreTests;

using kkokkino.Calculator.Core;

using Xunit;
/// <summary>
/// Tests for the calculator app demonstrating use of Xunit
/// </summary>
public class CalculatorAppTests
{
  [Fact]
  public void Add_Two_Numbers()
  {
    var r = CalculatorApp.Add(2, 1);
    Assert.Equal(3, r);
  }

  [Theory]
  [InlineData(2, 3)]
  public void Foo(int a, int b)
  {
    var r = CalculatorApp.Add(a ,b);
    Assert.True(r > 0);
  }
}
