namespace Backyard.Tests;

public class TuiTests
{
    [Theory]
    [InlineData(0, 0, 10, 10, 0)]
    [InlineData(0, 3, 4, 10, 0)]
    [InlineData(0, 6, 4, 10, 3)]
    [InlineData(3, 2, 4, 10, 2)]
    [InlineData(5, 9, 4, 10, 6)]
    [InlineData(4, 5, 4, 6, 2)]
    public void ScrollTop_KeepsSelectedRowVisible(int top, int selectedRow, int fit, int total, int expected) =>
        Assert.Equal(expected, Tui.ScrollTop(top, selectedRow, fit, total));
}
