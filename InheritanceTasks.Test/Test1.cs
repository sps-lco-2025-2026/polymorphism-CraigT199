using InheritanceTask.Lib;

namespace InheritanceTasks.Test;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        var person = new Person("Toby", "Craig", "2009-06-02");
        Assert.IsTrue(person.Valid);
    }
}
