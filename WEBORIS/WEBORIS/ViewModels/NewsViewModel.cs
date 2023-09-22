using System;
using System.Globalization;

namespace WEBORIS.ViewModels;

public class NewsViewModel
{
    public int Id { get; set; }
    public string? Category { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public DateTime? DateTime { get; set; }
    public int ViewsCount { get; set; }
    public string? Description { get; set; }
    public string? ImagePath { get; set; }

    public string Date => DateTime.Value.ToString("MMMM dd, yyyy", new CultureInfo("en-US"));

    private NumberFormatInfo format = new NumberFormatInfo() { NumberGroupSeparator = ",", NumberDecimalDigits = 0};
    public string ViewsString => ViewsCount.ToString("N", format);


}