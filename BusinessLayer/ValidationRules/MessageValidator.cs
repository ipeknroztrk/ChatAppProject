using System;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules { 

	public class MessageValidator:AbstractValidator<Message>
	{
		public MessageValidator()
		{
			RuleFor(x => x.Subject).NotEmpty().WithMessage("Mesaj kısmı boş geçilemez...");
			RuleFor(x => x.ReRecieverMail).NotEmpty().WithMessage("Lütfen Alıcının Mail Adresini Giriniz .");
		}
	}
}

