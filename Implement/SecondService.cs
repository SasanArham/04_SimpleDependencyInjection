using  DependencyInjection.Interface ;
namespace DependencyInjection.Implement 
{
    public class SecondService : IMyService2
    {
        private readonly IInnerService _innerService ;
        public SecondService(IInnerService innerService)
        {
            _innerService = innerService ;
        }
        public string getString()
        {
            return  _innerService.getString() ;
        }
    }
    
}