namespace TaskManagement.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Reflection;

public static class HtmlHelperExtensions
{
    public static IHtmlContent SimpleInputFor<TModel, TProperty>(
        this IHtmlHelper<TModel> htmlHelper,
        Expression<Func<TModel, TProperty>> expression)
    {
        // -----------------------------
        // Extract property info
        // -----------------------------
        var member = expression.Body as MemberExpression;
        var property = member.Member as PropertyInfo;
        var name = property.Name;

        // -----------------------------
        // Read Data Annotations
        // -----------------------------
        var required = property.GetCustomAttribute<RequiredAttribute>();
        var stringLength = property.GetCustomAttribute<StringLengthAttribute>();
        var range = property.GetCustomAttribute<RangeAttribute>();
        var regex = property.GetCustomAttribute<RegularExpressionAttribute>();

        // -----------------------------
        // Start building input
        // -----------------------------
        var input = new TagBuilder("input");
        input.TagRenderMode = TagRenderMode.SelfClosing;

        input.Attributes["class"] = "form-control";
        input.Attributes["name"] = name;
        input.Attributes["id"] = name;

        // Add required
        if (required != null)
        {
            input.Attributes["required"] = "required";
        }

        // Add min/max length
        if (stringLength != null)
        {
            if (stringLength.MaximumLength > 0)
                input.Attributes["maxlength"] = stringLength.MaximumLength.ToString();
        }

        // Add range values
        if (range != null)
        {
            input.Attributes["min"] = range.Minimum.ToString();
            input.Attributes["max"] = range.Maximum.ToString();
        }

        // Add regex pattern
        if (regex != null)
        {
            input.Attributes["pattern"] = regex.Pattern;
        }

        // -----------------------------
        // Validation message (Bootstrap)
        // -----------------------------
        var validationMessage = new HtmlString(
            $"<div class=\"invalid-feedback\">{required?.ErrorMessage ?? "Invalid field."}</div>"
        );

        // -----------------------------
        // Generate final HTML block
        // -----------------------------
        var label = new HtmlString($"<label for=\"{name}\" class=\"form-label\">{name}</label>");

        var container = new HtmlContentBuilder()
            .AppendHtml("<div class=\"mb-3\">")
            .AppendHtml(label)
            .AppendHtml(input)
            .AppendHtml(validationMessage)
            .AppendHtml("</div>");

        return container;
    }
}
