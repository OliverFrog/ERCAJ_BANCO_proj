
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
        }
    }
}

