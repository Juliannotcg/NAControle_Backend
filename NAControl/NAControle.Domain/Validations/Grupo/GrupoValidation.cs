using FluentValidation;
using NAControle.Domain.Commands.Grupo;

namespace NAControle.Domain.Validations.Grupo
{
    public abstract class GrupoValidation<T> : AbstractValidator<T> where T : GrupoCommand
    {
        protected void ValidateNomeGrupo()
        {
            RuleFor(c => c.Nome)
                .NotNull()
                    .WithMessage("Envia dados a ANS");
        }
    }
}
