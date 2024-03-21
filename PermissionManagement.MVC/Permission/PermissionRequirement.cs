using Microsoft.AspNetCore.Authorization;

namespace PermissionManagement.MVC.Permission
{
    internal class PermissionRequirement : IAuthorizationRequirement//, IAuthorizationRequirementData
    {
        public string Permission { get; private set; }

        public PermissionRequirement(string permission)
        {
            Permission = permission;
        }
    }
}