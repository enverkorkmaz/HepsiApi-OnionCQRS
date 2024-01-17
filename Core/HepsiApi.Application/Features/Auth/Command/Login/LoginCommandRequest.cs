using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApi.Application.Features.Auth.Command.Login
{
    public class LoginCommandRequest : IRequest<LoginCommandResponse>
    {
        [DefaultValue("enver@gmail.com")]
        public string Email { get; set; }
        [DefaultValue("12345Enver.")]
        public string Password { get; set; }
    }
}
