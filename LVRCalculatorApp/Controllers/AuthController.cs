﻿using LVRCalculatorApp.Dtos;
using LVRCalculatorApp.Models;
using LVRCalculatorApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace LVRCalculatorApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo) 
        {
            _authRepo = authRepo;
        }

        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _authRepo.Register(
                new User { Username = request.Username }, request.Password
            );
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("createtoken")]
        public async Task<ActionResult<ServiceResponse<string>>> CreateToken(UserLoginDto request)
        {
            var response = await _authRepo.CreateToken(request.Username, request.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
