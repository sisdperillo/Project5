using System;


namespace DevProject.Core.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; private set; } = Guid.NewGuid();

        public bool Active { get; private set; } = true;

        public void SetActive()
        {
            Active = true;
        }

        public void SetInactive()
        {
            Active = false;
        }
    }
}

