﻿namespace Boilerplate.Shared.Dtos.Identity;

[DtoResourceType(typeof(AppStrings))]
public class ConfirmPhoneRequestDto
{
    [Required(ErrorMessage = nameof(AppStrings.RequiredAttribute_ValidationError))]
    [Phone(ErrorMessage = nameof(AppStrings.PhoneAttribute_ValidationError))]
    [Display(Name = nameof(AppStrings.PhoneNumber))]
    public string? PhoneNumber { get; set; }

    [Required(ErrorMessage = nameof(AppStrings.RequiredAttribute_ValidationError))]
    public string? Token { get; set; }
}

public class ChangePhoneNumberRequestDto : ConfirmPhoneRequestDto
{
    // This class needs the same set of properties as ConfirmPhoneNumberRequestDto
}
