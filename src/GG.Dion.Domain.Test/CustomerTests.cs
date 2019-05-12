using GG.Dion.Domain.Entities;
using System;
using Xunit;

namespace GG.Dion.Domain.Test
{
    public class CustomerTests
    {
        [Fact]
        public void IsValidForNewRegister_Success()
        {
            var customer = new Customer("Gabriel Guedes", "g4brielguedes@gmail.com", new DateTime(1990, 1, 1));

            customer.IsValidForNewRegister();

            Assert.True(customer.ValidationResult.IsValid);
        }

        [Fact]
        public void IsValidForUpdate_Sucess()
        {
            var customer = new Customer("Gabriel Guedes", "g4brielguedes@gmail.com", new DateTime(1990, 1, 1));

            customer.IsValidForUpdate();

            Assert.True(customer.ValidationResult.IsValid);
        }

        [Fact]
        public void IsValidForRemove_Sucess()
        {
            var customer = new Customer(Guid.NewGuid());

            customer.IsValidForRemove();

            Assert.True(customer.ValidationResult.IsValid);
        }
    }
}
