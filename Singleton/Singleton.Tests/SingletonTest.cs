using FluentAssertions;

namespace Singleton.Tests;

public class SingletonTest
{
    [Fact]
    public void GetInstance_should_create_once_and_return_it()
    {
        var FirstSingletonInstance = Singleton.GetInstance();
        var SecondSingletonInstance = Singleton.GetInstance();

        FirstSingletonInstance.Guid.Should().Be(SecondSingletonInstance.Guid);
    }
}