using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiiiPay.Enterprise.Entities
{
    public class News
    {
        public Guid Id { get; set; }
        /// <summary>
        /// 中文标题
        /// </summary>
        public string CNTitle { get; set; }
        /// <summary>
        /// 英文标题
        /// </summary>
        public string ENTitle { get; set; }
        /// <summary>
        /// 浏览量
        /// </summary>
        public int? PageView { get; set; }
        /// <summary>
        /// 中文正文
        /// </summary>
        public string CNContent { get; set; }
        /// <summary>
        /// 英文正文
        /// </summary>
        public string ENContent { get; set; }
        /// <summary>
        /// 中文关键字
        /// </summary>
        public string CNKeyword { get; set; }
        /// <summary>
        /// 英文关键字
        /// </summary>
        public string ENKeyword { get; set; }
        /// <summary>
        /// 中文版封面图片
        /// </summary>
        public Guid CNCoverPicture { get; set; }
        /// <summary>
        /// 英文版封面图片
        /// </summary>
        public Guid ENCoverPicture { get; set; }
        /// <summary>
        /// 状态;已保存，展示中，已下架
        /// </summary>
        public byte Status { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }

    }
}
