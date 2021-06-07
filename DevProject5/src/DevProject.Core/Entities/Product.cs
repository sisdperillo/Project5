using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProject.Core.Entities
{
    public class Product : BaseEntity
    {
        public Product(string name, string description, decimal value, int quantity)
        {
            Name = name;
            Description = description;
            Value = value;
            Quantity = quantity;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Value { get; private set; }
        public int Quantity { get; private set; }

        public void IncrementQuantity(int quantity)
        {
            Quantity += quantity;
        }

        public void DecrementQuantity(int quantity)
        {
            Quantity -= quantity;
        }

        public void ChangeQuantity(int newQuantity)
        {
            Quantity = newQuantity;
        }

        public void ChangeValue(decimal newValue)
        {
            Value = newValue;
        }
    }
}
