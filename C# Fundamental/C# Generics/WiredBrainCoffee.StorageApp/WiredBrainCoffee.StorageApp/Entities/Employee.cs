using System;

namespace WiredBrainCoffee.StorageApp.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public Guid GUID { get; set; }
        public string? Firstname { get; set; }

        public override string ToString() => $"$Id: {Id} ,Guid: {GUID} ,FirstName: {Firstname}"; 
    }
}
