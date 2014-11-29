using System;
using ZamówieniaRabaty.Contract;

namespace ZamówieniaRabaty.Model.Deliveries
{
    public class DPDDelivery : IDelivery
    {
        public double Cost { get; set; }
    }
}
