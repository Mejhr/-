using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 图片去白边
{
    internal class ImagerDispose
    {
        public enum ImagerType
        {
            None,
            Square
        }

        /// <summary>
        /// 裁剪图片（去掉百边）
        /// </summary>
        /// <param name="FilePath">图片路径</param>
        /// <param name="saveFilePath">保存路径</param>
        /// <param name="min">图片最小多少个像素</param>
        /// <returns>返回执行后的情况 1：去白边成功，-1：错误 -2：图片小于最小像素</returns>
        public int RemoveWhiteEdge(string FilePath, string saveFilePath, int min, ImagerType imagerType)
        {
            try
            {
                Bitmap bmp = new Bitmap(FilePath);
                //上左右下
                int top = 0, left = 0, right = bmp.Width, bottom = bmp.Height;

                //寻找最上面的标线,从左(0)到右，从上(0)到下
                for (int i = 0; i < bmp.Height; i++)//行
                {
                    bool find = false;
                    for (int j = 0; j < 15/*bmp.Width*/; j++)//列
                    {
                        Color c = bmp.GetPixel(j, i);
                        if (!IsWhite(c))
                        {
                            top = i;
                            find = true;
                            break;
                        }
                    }
                    if (find)
                        break;
                }

                //寻找最左边的标线，从上（top位）到下，从左到右
                for (int i = left; i < 15/*bmp.Width*/; i++)//列
                {
                    bool find = false;
                    for (int j = top; j < bmp.Height; j++)//行
                    {
                        Color c = bmp.GetPixel(i, j);
                        if (!IsWhite(c))
                        {
                            left = i;
                            find = true;
                            break;
                        }
                    }
                    if (find)
                        break;
                }

                //寻找最下边标线，从下到上，从左到右
                for (int i = bmp.Height - 1; i >= 0; i--)//行
                {
                    bool find = false;
                    for (int j = left; j < 15/*bmp.Width*/; j++)//列
                    {
                        Color c = bmp.GetPixel(j, i);
                        if (!IsWhite(c))
                        {
                            bottom = i;
                            find = true;
                            break;
                        }
                    }
                    if (find)
                        break;
                }
                //寻找最右边的标线，从上到下，从右往左
                for (int i = bmp.Width - 1; i >= 0; i--)//列
                {
                    bool find = false;
                    for (int j = 0; j <= bottom; j++)//行
                    {
                        Color c = bmp.GetPixel(i, j);
                        if (!IsWhite(c))
                        {
                            right = i;
                            find = true;
                            break;
                        }
                    }
                    if (find)
                        break;
                }
                int width = right - left;
                int height = bottom - top;
                if (imagerType == ImagerType.Square)
                {
                    if (width > height)
                    {
                        width = height;
                    }
                    else if (width < height)
                    {
                        height = width;
                    }
                }
                if (width < min)
                {
                    //throw new Exception("图片大小小于700像素");
                    return -2;
                }
                //克隆位图对象的一部分。
                Rectangle cloneRect = new Rectangle(left, top, width, height);
                Bitmap cloneBitmap = bmp.Clone(cloneRect, bmp.PixelFormat);
                cloneBitmap.Save(saveFilePath, ImageFormat.Jpeg);
                bmp.Dispose();
                return 1;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        private bool IsWhite(Color color)
        {
            int tolerance = 24; // 容错范围
            return color.R >= 255 - tolerance && color.G >= 255 - tolerance && color.B >= 255 - tolerance;
        }
    }
}
