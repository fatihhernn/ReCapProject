﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.Description).Must(StartWithA).WithMessage("Tanım alanı Büyük A harfi ile başlamalı");
        }
        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
