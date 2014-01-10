using System;

// Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> 
// with corresponding tags [URL=…]…/URL]. 
// Sample HTML fragment:
    // <p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. 
    // Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>

    // <p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. 
    // Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

namespace ReplaceHTMLTags
{
    public  class Program
    {
        static void Main(string[] args)
        {
            string text = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course." +
                 @"Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
            Console.WriteLine("Text:\n{0}", text);

            string oldOpeningTag = @"<a href=""";
            string oldClosedTag = "</a>";
            string oldChar = @""">";

            string newOpeningTag = "[URL=";
            string newClosedTag = "[/URL]";
            string newChar = "]";

            text = text.Replace(oldOpeningTag, newOpeningTag);
            text = text.Replace(oldClosedTag, newClosedTag);
            text = text.Replace(oldChar, newChar);

            Console.WriteLine("\nResult:\n{0}", text);
        }
    }
}
