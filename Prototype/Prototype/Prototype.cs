namespace Prototype;

public interface ICloneable<T> where T : class
{
    T ShallowClone();
    T DeepClone();
}
public class Person : ICloneable<Person>
{
    public int Age;
    public DateTime BirthDate;
    public string Name;
    public IdInfo IdInfo;
    
    public Person ShallowClone()
    {
        return (Person) this.MemberwiseClone();
    }

    public Person DeepClone()
    {
        Person clone = (Person) this.MemberwiseClone();
        clone.IdInfo = new IdInfo(IdInfo.IdNumber);
        clone.Name = String.Copy(Name);
        // clone.Age = Age;
        // clone.BirthDate = BirthDate;
        return clone;
    }
}
public class IdInfo
{
    public IdInfo(int idNumber)
    {
        IdNumber = idNumber;
    }

    public int IdNumber;
}