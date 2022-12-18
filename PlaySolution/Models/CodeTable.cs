using System;
using System.Globalization;

namespace PlaySolution.Models;

public class CodeTable
{
    public long Id { get; set; }
    public string Code { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;

    public CodeTable()
    {
        Id = 0;
    }
    
    public override string ToString()
    {
        return this.Description;
    }
}