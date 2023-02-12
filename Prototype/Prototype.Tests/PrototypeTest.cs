using FluentAssertions;

namespace Prototype.Tests;

public class PrototypeTest
{
    private readonly Person _person;
    private const int ID = 1000; 
    private const int NEWID = 1100; 
    private const int AGE = 28; 
    private const int NEWAGE = 30; 
    public PrototypeTest()
    {
        _person = new Person()
        {
            IdInfo = new IdInfo(ID),
            Age = AGE,
            Name = "Saeed",
            BirthDate = DateTime.Now
        };
    }
    [Fact]
    public void ShallowClone_should_clone_and_reference_value_change_with_new_changes()
    {
        Person person1 = _person.ShallowClone();
        person1.IdInfo.IdNumber = NEWID;
        person1.Age = NEWAGE;

        _person.IdInfo.IdNumber.Should().Be(person1.IdInfo.IdNumber);
        _person.Age.Should().NotBe(person1.Age);
    }
    [Fact]
    public void DeepClone_should_clone_and_value_type_dont_change_with_new_changes()
    {
        Person person1 = _person.DeepClone();
        person1.IdInfo.IdNumber = NEWID;
        person1.Age = NEWAGE;

        _person.IdInfo.IdNumber.Should().NotBe(person1.IdInfo.IdNumber);
        _person.Age.Should().NotBe(person1.Age);
    }
}