using Qa517.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Qa517.Permissions
{
    public class Qa517PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(Qa517Permissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(Qa517Permissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<Qa517Resource>(name);
        }
    }
}
