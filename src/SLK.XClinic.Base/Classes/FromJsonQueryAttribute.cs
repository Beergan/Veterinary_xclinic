using Microsoft.AspNetCore.Mvc;

namespace SLK.XClinic.Base;

public class FromJsonQueryAttribute : ModelBinderAttribute
{
    public FromJsonQueryAttribute()
    {
        BinderType = typeof(JsonQueryBinder);
    }
}