namespace SLK.XClinic.Abstract;

public interface IEntity<TypeOfKey>
{
    TypeOfKey Id { get; set; }
}