using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Core.Events
{
    public class Message : IRequest<bool>
    {

        public string MessageType { get; private set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
