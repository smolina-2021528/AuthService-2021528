namespace AuthServiceIN6BM.Domain.Constants;

public static class RoleConstants
{
    public const string ADMIN_ROLE = "ADMIN_ROLE";
    public const string USER_ROLE = "USER_ROLE";

    public static readonly string[] AllowedRole = { ADMIN_ROLE, USER_ROLE };
}