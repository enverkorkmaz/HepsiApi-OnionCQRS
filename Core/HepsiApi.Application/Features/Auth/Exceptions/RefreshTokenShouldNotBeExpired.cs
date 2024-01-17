using HepsiApi.Application.Bases;

namespace HepsiApi.Application.Features.Auth.Exceptions
{
    public class RefreshTokenShouldNotBeExpired : BaseExceptions
    {
        public RefreshTokenShouldNotBeExpired() : base("Oturum Süresi Sona Ermiştir. Lütfen Tekrar Giriş Yapın") { }
    }
}

