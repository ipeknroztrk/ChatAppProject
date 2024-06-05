using System;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
	public class NewMessageValıdator:AbstractValidator<Message>
	{
		public NewMessageValıdator()
		{
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen mesajınızı giriniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Lütfen konu giriniz.");
            RuleFor(x => x.ReRecieverMail).NotEmpty().WithMessage("Lütfen Alıcı Mail adresini giriniz.")
                .EmailAddress();
        }
	}
}

