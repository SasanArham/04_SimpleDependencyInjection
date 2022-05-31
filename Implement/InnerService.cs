using DependencyInjection.Interface;
namespace DependencyInjection.Implement
{
    public class InnerService : IInnerService
    {
        string guId ;
        public InnerService()
        {
            guId = Guid.NewGuid().ToString() ;
        }

        public string getString()
        {
            return this.guId ;
        }
    }
}