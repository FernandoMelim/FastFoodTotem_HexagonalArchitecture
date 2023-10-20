﻿using FastFoodTotem.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace FastFoodTotem.Domain.Entities
{
    public class OrderEntity
    {
        protected OrderEntity() { }

        [Key]
        public Guid Id { get; private set; }
        public ClientEntity Client { get; set; }
        public Guid ClientId { get; private set; }
        public OrderStatus Status { get; private set; }
        public IEnumerable<OrderedItemEntity> OrderedItems { get; private set; } = Enumerable.Empty<OrderedItemEntity>();
    }
}
