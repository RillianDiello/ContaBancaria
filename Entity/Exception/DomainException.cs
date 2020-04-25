using System;
namespace ContaBancaria.Entity.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message): base(message){
            
        }
    }
}