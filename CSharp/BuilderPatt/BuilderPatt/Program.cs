using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatt
{
    public class HtmlElement
    {
        private const int indentsz = 2;
        public string Name, Text;
        public List<HtmlElement> Elements = new List<HtmlElement>();

        public HtmlElement()
        {
            
        }

        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }

        private string CustToString(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentsz*indent);

            sb.AppendLine($"{i}<{Name}>");

            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', indentsz * indent+1);
                sb.AppendLine(Text);
                
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return CustToString(0);
        }

    }

    public class HtmlBuilder
    {
        private readonly string rootname;
        private HtmlElement root = new HtmlElement();

        public HtmlBuilder(string arootname)
        {
            this.rootname = arootname;
            root.Name = rootname;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var hellomess = "hello";

            var stribu = new StringBuilder();

            //Paragraph print into console
            stribu.Append("<p>");
            stribu.Append("Fake the Mars Landing");
            stribu.Append("</p>");
            Console.WriteLine(stribu);

            //
            var words = new[] {"bla bla testing an array"};
            stribu.Clear();

            stribu.Append("<ul>");
            foreach(var somewd in words)
            {
                stribu.AppendFormat("<li>{0}</li>",somewd);
            }

            stribu.Append("</ul>");

            Console.WriteLine(stribu);



        }
    }
}
