﻿using FluentValidation;
using MediatR;
using SeeSharp.Application.Common.Interfaces;
using SeeSharp.Application.Features.BlogPosts.Commands.UpdateBlogPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp.Application.Features.UserManagement.Commands.UpdateUserProfileCommand;
public class UpdateUserProfileCommandValidator : AbstractValidator<UpdateUserProfileCommand>
{
    public UpdateUserProfileCommandValidator()
    {
        RuleFor(v => v.UserName)
           .NotEmpty();

        RuleFor(v => v.FullName)
            .MaximumLength(255)
            .NotEmpty();

        RuleFor(v => v.OldPassword)
            .MaximumLength(255)
            .NotEmpty();

        RuleFor(v => v.NewPassword)
            .MaximumLength(255)
            .NotEmpty();

        RuleFor(v => v.UserEmail)
            .NotEmpty()
            .EmailAddress();
    }
   
}
