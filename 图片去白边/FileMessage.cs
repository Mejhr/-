using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 图片去白边
{
    /// <summary>
    /// 位置类
    /// </summary>
    internal class FileMessage
    {
        /// <summary>
        /// 默认打开路径
        /// </summary>
        public string initiaPoint;
        /// <summary>
        /// 设置文件打开路径
        /// </summary>
        public string setFileOpenPath;
        public FileMessage()
        {
            initiaPoint = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            setFileOpenPath = "";
        }

    }
}
