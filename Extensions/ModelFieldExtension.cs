using System.Linq.Expressions;
using System.Reflection;

namespace EmployeeManagementApp.Extensions;

public static class ModelFieldExtension
{
    public static void SetPropertyValue<T, TValue>(this T target, Expression<Func<T, TValue>> memberExpression, TValue value)
    {
        var memberSelectorExpression = memberExpression.Body as MemberExpression;
        if (memberSelectorExpression != null)
        {
            var property = memberSelectorExpression.Member as PropertyInfo;
            if (property != null)
            {
                property.SetValue(target, value, null);
            }
        }
    }
    public static TValue? GetPropertyValue<T, TValue>(this T target, Expression<Func<T, TValue>> memberExpression)
    {
        var memberSelectorExpression = memberExpression.Body as MemberExpression;
        if (memberSelectorExpression != null)
        {
            var property = memberSelectorExpression.Member as PropertyInfo;
            if (property != null)
            {
                return (TValue?)property.GetValue(target);
            }
        }
        return default;
    }
}