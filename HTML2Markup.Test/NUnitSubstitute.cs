
namespace NUnit.Framework
{

    public class Assert
    {
        public static bool AreEqual(string a, string b)
        {
            return string.Equals(a, b, System.StringComparison.Ordinal);
        }
    }


    public class TestFixtureAttribute
        : System.Attribute
    {

    }

    public class TestAttribute
        : System.Attribute
    {
    }


    public class SetUpAttribute
        : System.Attribute
    {
    }

    public class TearDownAttribute
        : System.Attribute
    {
    }


}
