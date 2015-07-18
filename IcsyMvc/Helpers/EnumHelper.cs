using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace IcsyMvc.Helpers
{
    public static class EnumHelper
    {
        public static string GetName(this Enum value)
        {
            return Enum.GetName(value.GetType(), value);
        }

        public static string GetDescription(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.GetName());
            var descriptionAttribute = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;
            return descriptionAttribute == null ? value.GetName() : descriptionAttribute.Description;
        }

        public static MvcHtmlString EnumDropDownListForEx<TModel, TEnum>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TEnum>> enumAccessor, object htmlAttributes)
        {
            var propertyInfo = enumAccessor.ToPropertyInfo();
            var enumType = propertyInfo.PropertyType;
            var enumValues = Enum.GetValues(enumType).Cast<Enum>();
            var selectItems = enumValues.Select(s => new SelectListItem
            {
                Text = s.GetDescription(),
                Value = s.ToString()
            });

            return htmlHelper.DropDownListFor(enumAccessor, selectItems, htmlAttributes);
        }

        public static PropertyInfo ToPropertyInfo(this LambdaExpression expression)
        {
            var memberExpression = expression.Body as MemberExpression;
            return (memberExpression == null) ? null : memberExpression.Member as PropertyInfo;
        }
    }
}