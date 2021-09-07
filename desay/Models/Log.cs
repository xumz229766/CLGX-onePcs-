using System;
using System.Domain;

namespace desay.Models
{
    /// <summary>
    ///     日志
    /// </summary>
    public class Log : Entity
    {
        /// <summary>
        ///     用户
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        ///     行为
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        ///     发生时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        public virtual User User { get; set; }
    }
}