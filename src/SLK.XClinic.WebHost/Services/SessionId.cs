using SLK.XClinic.Abstract;

namespace SLK.XClinic.WebHost;

public class SessionId : ISessionId
{
    private Guid _value = Guid.NewGuid();

    public string Value => _value.ToString();
}