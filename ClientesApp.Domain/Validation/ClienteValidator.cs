using ClientesApp.Domain.Entities;
using FluentValidation;

namespace ClientesApp.Domain.Validation
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage("O id do cliente é obrigatório.");

            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O nome do cliente é obrigatório.")
                .Length(6, 150).WithMessage("O nome deve ter de 6 a 150 caracteres.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("O Email do cliente é obrigatório.")
                .EmailAddress().WithMessage("O endereço de email não é válido.");

            RuleFor(c => c.Cpf)
                .NotEmpty().WithMessage("O cpf do cliente é obrigatório.")
                .Matches(@"^\d{11}$").WithMessage("O cpf do cliente deve ter exatamente 11 digitos.");

            RuleFor(c => c.DataInclusao).NotEmpty().WithMessage("A data de inclusão é obrigatório.");
            RuleFor(c => c.DataUltimaAlteracao).NotEmpty().WithMessage("A data da última alteração do cliente é obrigatório");
            RuleFor(c => c.Ativo).NotEmpty().WithMessage("A informação do Ativo ou Inativo do cliente é obrigatório");
        }
    }
}
