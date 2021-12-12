using System;

namespace WiredBrainCoffee.StorageApp.Entities
{
    public class Organization
    {
        public int Id { get; set; }
        public Guid GUID { get; set; }
        public string? Name { get; set; }
        public override string ToString() => $"$Id: {Id} ,Guid: {GUID} ,FirstName: {Name}";
    }
}
