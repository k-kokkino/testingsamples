namespace kkokkino.Calculator.Core;

/// <summary>
/// Calculator app demonstrating use of the "checked" keyword.
/// </summary>
public static class CalculatorApp
{
  public static int Add(int a, int b) => checked(a + b);

  public static int Subtract(int a, int b) => checked(a - b);
}
