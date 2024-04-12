using System.ComponentModel.DataAnnotations;

namespace InluppASP_NET1.Filters;

public class CheckboxRequired : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        return value is bool b && b;
    }
}
