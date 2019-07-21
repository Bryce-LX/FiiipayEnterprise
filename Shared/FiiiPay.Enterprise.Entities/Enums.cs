using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiiiPay.Enterprise.Entities
{
    /// <summary>
    /// 账户状态
    /// </summary>
    public enum AccountStatus
    {
        /// <summary>
        /// 已禁用
        /// </summary>
        Disabled,
        /// <summary>
        /// 已注册，未绑定邮箱与设置密码
        /// </summary>
        Registered,
        /// <summary>
        /// 正常状态
        /// </summary>
        Active
    }
}
