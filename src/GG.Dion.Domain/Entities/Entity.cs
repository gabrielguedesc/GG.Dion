using FluentValidation.Results;
using System;

namespace GG.Dion.Domain.Entities
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; protected set; }
        public ValidationResult ValidationResult { get; protected set; }
    }
}
