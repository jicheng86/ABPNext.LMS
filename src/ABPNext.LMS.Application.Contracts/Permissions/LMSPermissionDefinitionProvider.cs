﻿using ABPNext.LMS.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ABPNext.LMS.Permissions
{
    public class LMSPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(LMSPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(LMSPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<LMSResource>(name);
        }
    }
}
