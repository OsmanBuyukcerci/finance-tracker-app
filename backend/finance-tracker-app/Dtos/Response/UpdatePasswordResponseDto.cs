namespace finance_tracker_app.Dtos.Response
{
    public class UpdatePasswordResponseDto
    {
        public UpdatePasswordStatus Status { get; set; }
    }

    public enum UpdatePasswordStatus
    {
        Success,
        InvalidOldPassword,
        PasswordTooShort,
        PasswordTooLong,
        PasswordsDoNotMatch
    }
}
