using System.Reflection;

namespace SLK.XClinic.Abstract;

public interface IAssemblyProvider
{
    Assembly[] GetAssemblies();
}