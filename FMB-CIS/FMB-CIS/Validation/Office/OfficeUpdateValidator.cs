﻿using FluentValidation;
using FMB_CIS.Models;

namespace FMB_CIS.Validation
{
    public class OfficeUpdateValidator : AbstractValidator<OfficeUpdateViewModel>
    {
        public OfficeUpdateValidator()
        {
            // Check od is not null, empty
            RuleFor(officeType => officeType.id).NotNull().NotEmpty();
            // Check name is not null, empty and is between 1 and 300 characters
            RuleFor(officeType => officeType.office_name).NotNull().NotEmpty().Length(1, 300); RuleFor(office => office.region_id).NotNull().NotEmpty().GreaterThan(0); //nvarcharmax
            RuleFor(office => office.department).NotNull(); //nvarcharmax               RuleFor(office => office.region_id).NotNull().NotEmpty().GreaterThan(0); //nvarcharmax
            RuleFor(office => office.region_id).NotNull().NotEmpty().GreaterThan(0); //nvarcharmax

        }
    }
}