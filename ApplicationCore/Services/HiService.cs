
using ApplicationCore.IServices;

namespace ApplicationCore.Services
{
    public class HiService : IHiService
    {
        public string SayHi()
        {
            return "Hello world";
        }
    }
}