using  DependencyInjection.Interface ;
namespace DependencyInjection.Implement 
{
    public class MyService : IMyService
    {
        private string guID ;
        private readonly IInnerService _innerService ;
        public MyService(IInnerService innerService)
        {
            _innerService = innerService ;
            this.guID = Guid.NewGuid().ToString() ;
        }
        public string getString()
        {
            return  _innerService.getString() ;
        }
    }
    
}