using HepsiApi.Application.Bases;

namespace HepsiApi.Application.Features.Auth.Exceptions
{
    public class EmailAddressShouldbeValidException : BaseExceptions
    {
        public EmailAddressShouldbeValidException() : base("Böyle bir email adresi bulunmamaktadır") { }
    }
}

