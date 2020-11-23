using System;

namespace DataAccount.Entities.Exceptions {
    class DomainException : ApplicationException {
        public DomainException(string message) : base(message) {
        }
    }
}
