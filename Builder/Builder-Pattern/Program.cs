using System.Text;

var hello = "hello";

var sb = new StringBuilder();
sb.Append("<p>");
sb.Append(hello);
sb.Append("</p>");



var words = new[] { "hello", "world" };
sb.Clear();
sb.Append("<ul>");
foreach (var word in words)
{
    sb.AppendFormat("<li>" + word + "</li>");
}
sb.Append("</ul>");
Console.WriteLine(sb);