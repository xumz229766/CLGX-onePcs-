using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using desay.Helpers;
namespace desay.ProductData
{
    [Serializable]
    public class Position : NotificationObject
    {
        public static Position Instance = new Position();
        /// <summary>
        ///     左侧tray盘ID
        /// </summary>
        public string LeftTrayID { get; set; } = "Lens";
        /// <summary>
        ///     右侧tray盘ID
        /// </summary>
        public string RightTrayID { get; set; } = "Lens";
        /// <summary>
        ///     镜筒tray盘ID
        /// </summary>
        public string ConeTrayID { get; set; } = "Cone";
        /// <summary>
        ///     LensOK总数
        /// </summary>
        public int LensOkTotal { get; set; } = 100;

        /// <summary>
        ///     LensNG总数
        /// </summary>
        public int LensNgTotal { get; set; } = 1000;


        public int ConeOkTotal { get; set; }
        public int ConeNgTotal { get; set; }

        public int LensIndex { get; set; }
        public int ConeIndex { get; set; }

        public int LensInhaleContinuNg { get; set; }
        public int LensContinuousNg { get; set; }
        public int ConeContinuousNg { get; set; }
    }
}
