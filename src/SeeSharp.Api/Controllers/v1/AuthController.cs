﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using SeeSharp.Application.Features.Authentication.Commands.AuthUserCommand;
using SeeSharp.Application.Features.Authentication.Commands.CreateUserCommand;
using SeeSharp.Application.Features.Authentication.Commands.GoogleAuthUserCommand;
using SeeSharp.Application.Features.Authentication.Commands.GoogleRegisterUserCommand;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SeeSharp.Api.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
[Route("/api/v{version:apiVersion}/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IMediator _mediator;

    public AuthController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("Register")]
    public async Task<string> CreateUser([FromBody] CreateUserCommand command)
    {
        return await _mediator.Send(command);
    }

    [HttpPost("Login")]
    public async Task<AuthResponseDto> Login([FromBody] AuthUserCommand command)
    {
        return await _mediator.Send(command);
    }

    [HttpPost("RegisterWithGoogle")]
    public async Task<string> RegisterWithGoogle([FromBody] GoogleRegisterUserCommand command)
    {
        return await _mediator.Send(command);
    }

    [HttpPost("LoginWithGoogle")]
    public async Task<GoogleAuthResponseDto> LoginWithGoogle([FromBody] GoogleAuthUserCommand command)
    {
        return await _mediator.Send(command);
    }
    //[HttpGet("Validate")]
    //public async Task<List<string>> IsAuthenticated([FromBody]ValidateJwtQuery query)
    //{
    //    return await _mediator.Send(query);
    //}
}

