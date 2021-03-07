using System.Threading.Tasks;

namespace CourseSignUp.Infra.Caching
{
    public interface ICacheProvider
    {
        Task<string> GetCachedValue(string key);
        Task<string> Save(string key, string value);
    }
}
