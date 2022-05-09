using System.Collections;
using NUnit.Framework;

namespace ShoppingCartKata;

public class TestItemData
{
    public static IEnumerable Items
    {
        get
        {
            yield return new TestCaseData(new List<string> {"A"}).Returns(50).SetName("A");
            yield return new TestCaseData(new List<string> {"B"}).Returns(30).SetName("B");
            yield return new TestCaseData(new List<string> {"C"}).Returns(20).SetName("C");
            yield return new TestCaseData(new List<string> {"D"}).Returns(15).SetName("D");
            yield return new TestCaseData(new List<string> {"A", "B", "C", "D"}).Returns(115).SetName("ABCD");
            yield return new TestCaseData(new List<string> {"A", "A"}).Returns(100).SetName("AA");
            yield return new TestCaseData(new List<string> {"A", "A", "A"}).Returns(130).SetName("AAA");
            yield return new TestCaseData(new List<string> {"A", "A", "A", "A"}).Returns(180).SetName("AAAA");
            yield return new TestCaseData(new List<string> {"A", "A", "A", "A", "A", "A"}).Returns(260).SetName("AAAAAA");
            yield return new TestCaseData(new List<string> {"B", "B"}).Returns(45).SetName("BB");
            yield return new TestCaseData(new List<string> {"B", "B", "B"}).Returns(75).SetName("BBB");
            yield return new TestCaseData(new List<string> {"B", "B", "B", "B"}).Returns(90).SetName("BBBB");
            yield return new TestCaseData(new List<string> {"A", "B", "A", "B", "A"}).Returns(175).SetName("ABABA");
            yield return new TestCaseData(new List<string> {"A", "B", "A", "B", "A", "C", "C", "D"}).Returns(230).SetName("ABABACCD");
        }
    }  
}