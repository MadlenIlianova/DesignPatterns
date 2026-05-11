using DesignPatternsCourseWork.Logger;
using DesignPatternsCourseWork.Models;

namespace DesignPatternsCourseWork.ChainOfResponsibility
{
    public class RegistrationHandler : BaseOrderHandler
    {
        private readonly OrderRegistry _registry;

        public RegistrationHandler(ILogger logger, OrderRegistry registry) : base(logger)
        {
            _registry = registry;
        }

        protected override bool CanHandle(Order order) => order != null;

        protected override void Process(Order order)
        {
            _registry.Register(order);
        }
    }
}
