// <auto-generated>
using System.Reflection;


namespace Microsoft.Extensions.Identity.Core
{
    internal static partial class Resources
    {
        private static global::System.Resources.ResourceManager s_resourceManager;
        internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(Resources)));
        internal static global::System.Globalization.CultureInfo Culture { get; set; }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        internal static string GetResourceString(string resourceKey, string defaultValue = null) =>  ResourceManager.GetString(resourceKey, Culture);

        private static string GetResourceString(string resourceKey, string[] formatterNames)
        {
           var value = GetResourceString(resourceKey);
           if (formatterNames != null)
           {
               for (var i = 0; i < formatterNames.Length; i++)
               {
                   value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
               }
           }
           return value;
        }

        /// <summary>Optimistic concurrency failure, object has been modified.</summary>
        internal static string ConcurrencyFailure => GetResourceString("ConcurrencyFailure");
        /// <summary>An unknown failure has occurred.</summary>
        internal static string DefaultError => GetResourceString("DefaultError");
        /// <summary>Email '{0}' is already taken.</summary>
        internal static string DuplicateEmail => GetResourceString("DuplicateEmail");
        /// <summary>Email '{0}' is already taken.</summary>
        internal static string FormatDuplicateEmail(object p0)
           => string.Format(Culture, GetResourceString("DuplicateEmail"), p0);

        /// <summary>Role name '{0}' is already taken.</summary>
        internal static string DuplicateRoleName => GetResourceString("DuplicateRoleName");
        /// <summary>Role name '{0}' is already taken.</summary>
        internal static string FormatDuplicateRoleName(object p0)
           => string.Format(Culture, GetResourceString("DuplicateRoleName"), p0);

        /// <summary>User name '{0}' is already taken.</summary>
        internal static string DuplicateUserName => GetResourceString("DuplicateUserName");
        /// <summary>User name '{0}' is already taken.</summary>
        internal static string FormatDuplicateUserName(object p0)
           => string.Format(Culture, GetResourceString("DuplicateUserName"), p0);

        /// <summary>Email '{0}' is invalid.</summary>
        internal static string InvalidEmail => GetResourceString("InvalidEmail");
        /// <summary>Email '{0}' is invalid.</summary>
        internal static string FormatInvalidEmail(object p0)
           => string.Format(Culture, GetResourceString("InvalidEmail"), p0);

        /// <summary>Type {0} must derive from {1}&lt;{2}&gt;.</summary>
        internal static string InvalidManagerType => GetResourceString("InvalidManagerType");
        /// <summary>Type {0} must derive from {1}&lt;{2}&gt;.</summary>
        internal static string FormatInvalidManagerType(object p0, object p1, object p2)
           => string.Format(Culture, GetResourceString("InvalidManagerType"), p0, p1, p2);

        /// <summary>The provided PasswordHasherCompatibilityMode is invalid.</summary>
        internal static string InvalidPasswordHasherCompatibilityMode => GetResourceString("InvalidPasswordHasherCompatibilityMode");
        /// <summary>The iteration count must be a positive integer.</summary>
        internal static string InvalidPasswordHasherIterationCount => GetResourceString("InvalidPasswordHasherIterationCount");
        /// <summary>Role name '{0}' is invalid.</summary>
        internal static string InvalidRoleName => GetResourceString("InvalidRoleName");
        /// <summary>Role name '{0}' is invalid.</summary>
        internal static string FormatInvalidRoleName(object p0)
           => string.Format(Culture, GetResourceString("InvalidRoleName"), p0);

        /// <summary>Invalid token.</summary>
        internal static string InvalidToken => GetResourceString("InvalidToken");
        /// <summary>User name '{0}' is invalid, can only contain letters or digits.</summary>
        internal static string InvalidUserName => GetResourceString("InvalidUserName");
        /// <summary>User name '{0}' is invalid, can only contain letters or digits.</summary>
        internal static string FormatInvalidUserName(object p0)
           => string.Format(Culture, GetResourceString("InvalidUserName"), p0);

        /// <summary>A user with this login already exists.</summary>
        internal static string LoginAlreadyAssociated => GetResourceString("LoginAlreadyAssociated");
        /// <summary>AddIdentity must be called on the service collection.</summary>
        internal static string MustCallAddIdentity => GetResourceString("MustCallAddIdentity");
        /// <summary>No IUserTwoFactorTokenProvider&lt;{0}&gt; named '{1}' is registered.</summary>
        internal static string NoTokenProvider => GetResourceString("NoTokenProvider");
        /// <summary>No IUserTwoFactorTokenProvider&lt;{0}&gt; named '{1}' is registered.</summary>
        internal static string FormatNoTokenProvider(object p0, object p1)
           => string.Format(Culture, GetResourceString("NoTokenProvider"), p0, p1);

        /// <summary>User security stamp cannot be null.</summary>
        internal static string NullSecurityStamp => GetResourceString("NullSecurityStamp");
        /// <summary>Incorrect password.</summary>
        internal static string PasswordMismatch => GetResourceString("PasswordMismatch");
        /// <summary>Passwords must have at least one digit ('0'-'9').</summary>
        internal static string PasswordRequiresDigit => GetResourceString("PasswordRequiresDigit");
        /// <summary>Passwords must have at least one lowercase ('a'-'z').</summary>
        internal static string PasswordRequiresLower => GetResourceString("PasswordRequiresLower");
        /// <summary>Passwords must have at least one non alphanumeric character.</summary>
        internal static string PasswordRequiresNonAlphanumeric => GetResourceString("PasswordRequiresNonAlphanumeric");
        /// <summary>Passwords must have at least one uppercase ('A'-'Z').</summary>
        internal static string PasswordRequiresUpper => GetResourceString("PasswordRequiresUpper");
        /// <summary>Passwords must be at least {0} characters.</summary>
        internal static string PasswordTooShort => GetResourceString("PasswordTooShort");
        /// <summary>Passwords must be at least {0} characters.</summary>
        internal static string FormatPasswordTooShort(object p0)
           => string.Format(Culture, GetResourceString("PasswordTooShort"), p0);

        /// <summary>Role {0} does not exist.</summary>
        internal static string RoleNotFound => GetResourceString("RoleNotFound");
        /// <summary>Role {0} does not exist.</summary>
        internal static string FormatRoleNotFound(object p0)
           => string.Format(Culture, GetResourceString("RoleNotFound"), p0);

        /// <summary>Store does not implement IQueryableRoleStore&lt;TRole&gt;.</summary>
        internal static string StoreNotIQueryableRoleStore => GetResourceString("StoreNotIQueryableRoleStore");
        /// <summary>Store does not implement IQueryableUserStore&lt;TUser&gt;.</summary>
        internal static string StoreNotIQueryableUserStore => GetResourceString("StoreNotIQueryableUserStore");
        /// <summary>Store does not implement IRoleClaimStore&lt;TRole&gt;.</summary>
        internal static string StoreNotIRoleClaimStore => GetResourceString("StoreNotIRoleClaimStore");
        /// <summary>Store does not implement IUserAuthenticationTokenStore&lt;User&gt;.</summary>
        internal static string StoreNotIUserAuthenticationTokenStore => GetResourceString("StoreNotIUserAuthenticationTokenStore");
        /// <summary>Store does not implement IUserClaimStore&lt;TUser&gt;.</summary>
        internal static string StoreNotIUserClaimStore => GetResourceString("StoreNotIUserClaimStore");
        /// <summary>Store does not implement IUserConfirmationStore&lt;TUser&gt;.</summary>
        internal static string StoreNotIUserConfirmationStore => GetResourceString("StoreNotIUserConfirmationStore");
        /// <summary>Store does not implement IUserEmailStore&lt;TUser&gt;.</summary>
        internal static string StoreNotIUserEmailStore => GetResourceString("StoreNotIUserEmailStore");
        /// <summary>Store does not implement IUserLockoutStore&lt;TUser&gt;.</summary>
        internal static string StoreNotIUserLockoutStore => GetResourceString("StoreNotIUserLockoutStore");
        /// <summary>Store does not implement IUserLoginStore&lt;TUser&gt;.</summary>
        internal static string StoreNotIUserLoginStore => GetResourceString("StoreNotIUserLoginStore");
        /// <summary>Store does not implement IUserPasswordStore&lt;TUser&gt;.</summary>
        internal static string StoreNotIUserPasswordStore => GetResourceString("StoreNotIUserPasswordStore");
        /// <summary>Store does not implement IUserPhoneNumberStore&lt;TUser&gt;.</summary>
        internal static string StoreNotIUserPhoneNumberStore => GetResourceString("StoreNotIUserPhoneNumberStore");
        /// <summary>Store does not implement IUserRoleStore&lt;TUser&gt;.</summary>
        internal static string StoreNotIUserRoleStore => GetResourceString("StoreNotIUserRoleStore");
        /// <summary>Store does not implement IUserSecurityStampStore&lt;TUser&gt;.</summary>
        internal static string StoreNotIUserSecurityStampStore => GetResourceString("StoreNotIUserSecurityStampStore");
        /// <summary>Store does not implement IUserAuthenticatorKeyStore&lt;User&gt;.</summary>
        internal static string StoreNotIUserAuthenticatorKeyStore => GetResourceString("StoreNotIUserAuthenticatorKeyStore");
        /// <summary>Store does not implement IUserTwoFactorStore&lt;TUser&gt;.</summary>
        internal static string StoreNotIUserTwoFactorStore => GetResourceString("StoreNotIUserTwoFactorStore");
        /// <summary>Recovery code redemption failed.</summary>
        internal static string RecoveryCodeRedemptionFailed => GetResourceString("RecoveryCodeRedemptionFailed");
        /// <summary>User already has a password set.</summary>
        internal static string UserAlreadyHasPassword => GetResourceString("UserAlreadyHasPassword");
        /// <summary>User already in role '{0}'.</summary>
        internal static string UserAlreadyInRole => GetResourceString("UserAlreadyInRole");
        /// <summary>User already in role '{0}'.</summary>
        internal static string FormatUserAlreadyInRole(object p0)
           => string.Format(Culture, GetResourceString("UserAlreadyInRole"), p0);

        /// <summary>User is locked out.</summary>
        internal static string UserLockedOut => GetResourceString("UserLockedOut");
        /// <summary>Lockout is not enabled for this user.</summary>
        internal static string UserLockoutNotEnabled => GetResourceString("UserLockoutNotEnabled");
        /// <summary>User {0} does not exist.</summary>
        internal static string UserNameNotFound => GetResourceString("UserNameNotFound");
        /// <summary>User {0} does not exist.</summary>
        internal static string FormatUserNameNotFound(object p0)
           => string.Format(Culture, GetResourceString("UserNameNotFound"), p0);

        /// <summary>User is not in role '{0}'.</summary>
        internal static string UserNotInRole => GetResourceString("UserNotInRole");
        /// <summary>User is not in role '{0}'.</summary>
        internal static string FormatUserNotInRole(object p0)
           => string.Format(Culture, GetResourceString("UserNotInRole"), p0);

        /// <summary>Store does not implement IUserTwoFactorRecoveryCodeStore&lt;User&gt;.</summary>
        internal static string StoreNotIUserTwoFactorRecoveryCodeStore => GetResourceString("StoreNotIUserTwoFactorRecoveryCodeStore");
        /// <summary>Passwords must use at least {0} different characters.</summary>
        internal static string PasswordRequiresUniqueChars => GetResourceString("PasswordRequiresUniqueChars");
        /// <summary>Passwords must use at least {0} different characters.</summary>
        internal static string FormatPasswordRequiresUniqueChars(object p0)
           => string.Format(Culture, GetResourceString("PasswordRequiresUniqueChars"), p0);

        /// <summary>No RoleType was specified, try AddRoles&lt;TRole&gt;().</summary>
        internal static string NoRoleType => GetResourceString("NoRoleType");
        /// <summary>Store does not implement IProtectedUserStore&lt;TUser&gt; which is required when ProtectPersonalData = true.</summary>
        internal static string StoreNotIProtectedUserStore => GetResourceString("StoreNotIProtectedUserStore");
        /// <summary>No IPersonalDataProtector service was registered, this is required when ProtectPersonalData = true.</summary>
        internal static string NoPersonalDataProtector => GetResourceString("NoPersonalDataProtector");

    }
}
