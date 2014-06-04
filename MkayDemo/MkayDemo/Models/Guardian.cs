using Mkay;

namespace MkayDemo.Models
{
    public class Guardian
    {
        public string Rule { get; set; }

        [Mkay("eval Rule")]
        public string Value { get; set; }
    }
}