using System;

namespace OrderProcessing.Mapper.Dto.Product
{
    public class ResponseProductDto
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public int Valume { get; set; }
        public int Code { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
