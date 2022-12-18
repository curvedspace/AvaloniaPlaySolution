using System;
using System.Globalization;

namespace PlaySolution.Models;

public class DataRecord
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public DateTimeOffset StartDate { get; set; }
    public CodeTable MyCodeTable { get; set; }

    public DataRecord()
    {
        StartDate = new DateTimeOffset(DateTime.Now);
        MyCodeTable = new CodeTable();
    }
}