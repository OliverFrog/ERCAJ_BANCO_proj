
using FastMember;
using FluentValidation;
using veXMAX.Shared.Models.Primitives;

namespace ERCAJ_BANCO_proj.Components
{
    public class CAJ_BANCOValidator : AbstractValidator<CAJ_BANCO>
    {
        public CAJ_BANCOValidator()
        {
            var cb = new CAJ_BANCO();

            var m = TypeAccessor.Create(typeof(CAJ_BANCO));

            //TODO: check rules with accessor
            RuleFor(x => x.SYSUDN_CODIGO_K)
                .Must(x => x.All(char.IsUpper)).WithMessage("La UDN especificada no debe contener minúsculas");
        }
    }
}

