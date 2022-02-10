using System;

namespace OrderProcessing.Mapper.Dto.Order
{
    public class ResponseOrderDto
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public int Valume { get; set; }
        public int Code { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
