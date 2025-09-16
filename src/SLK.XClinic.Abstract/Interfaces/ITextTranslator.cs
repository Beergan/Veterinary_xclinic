
using System.Threading.Tasks;

namespace SLK.XClinic.Abstract;

public interface ITextTranslator
{
    string this[string en, string vi]
    {
        get;
    }

    string this[string str]
    {
        get;
    }

    string CurrentLang {get;}

    void SetLang(string lang);
}