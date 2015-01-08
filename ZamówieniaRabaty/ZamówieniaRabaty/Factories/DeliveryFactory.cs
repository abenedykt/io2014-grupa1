using ZamówieniaRabaty.Contract;
using ZamówieniaRabaty.Contract.Factories;
using ZamówieniaRabaty.Model.Deliveries;

namespace ZamówieniaRabaty.Factories
{
    public class DeliveryFactory: IDeliveryFactory
    {
        public IDelivery GetDPDDelivery()
        {
            IDelivery delivery = new DPDDelivery()
            {
                Cost = 15.00
            };

            return delivery;
        }
    }
}
