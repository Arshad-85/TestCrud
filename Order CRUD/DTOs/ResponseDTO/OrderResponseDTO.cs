﻿using Order_CRUD.Entity;

namespace Order_CRUD.DTOs.ResponseDTO
{
    public class OrderResponseDTO
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public status Status { get; set; }
    }
}
