using Mkay;

namespace MkayDemo.Models
{
    public class Turtle
    {
        [Mkay("eval .")]
        public string Me { get; set; }

        [Mkay("eval .")]
        public string Too { get; set; }
    }
}