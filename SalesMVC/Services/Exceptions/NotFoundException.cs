using System;


namespace SalesMVC.Services.Exceptions
{

    //Exceções personalizadas
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
