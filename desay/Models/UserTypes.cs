using System;
using System.Toolkit.Attributes;
using desay.Properties;

namespace desay.Models
{
    /// <summary>
    ///     用户类型
    /// </summary>
    [Flags]
    public enum UserTypes
    {
        /// <summary>
        ///     设备维护
        /// </summary>
        [LocalizableDescription(@"UserTypeMaintain", typeof (Resources))]
        Maintain = 1,

        /// <summary>
        ///     管理员
        /// </summary>
        [LocalizableDescription(@"UserTypeAdmin", typeof(Resources))]
        Admin = 2,

        /// <summary>
        ///     普通
        /// </summary>
        [LocalizableDescription(@"UserTypeStandard", typeof (Resources))]
        Standard = 4
    }
}