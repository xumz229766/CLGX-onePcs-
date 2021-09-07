using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace desay.Models
{
    /// <summary>
    ///     支持报警通知接口
    /// </summary>
    public interface ISupportAlarm
    {
        /// <summary>
        ///     报警明细列表
        /// </summary>
        /// <returns></returns>
        IList<Alarm> Alarms { get; }

        /// <summary>
        ///     报警属性改变通知
        /// </summary>
        event EventHandler<PropertyChangedEventArgs> AlarmChanged;
    }
}