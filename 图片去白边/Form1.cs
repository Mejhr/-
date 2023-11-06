using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Xml;
using System.Reflection;
using System.Configuration.Assemblies;
using System.Diagnostics;

namespace 图片去白边
{
    public partial class Form1 : Form
    {
        private string saveName = "";
        private string newFile;
        /// <summary>
        /// 打开文件选择窗口
        /// </summary>
        private SaveFileDialog save;
        /// <summary>
        /// 需要处理的图片路径集合
        /// </summary>
        private List<string> files;

        private DialogResult dr;

        /// <summary>
        /// 位置类
        /// </summary>
        private FileMessage message;

        private ImagerDispose dispose;

        private bool isFileOpen;

        /// <summary>
        /// 总个数
        /// </summary>
        private int count = 0;
        /// <summary>
        /// 处理个数
        /// </summary>
        private int edgeCount = 0;

        /// <summary>
        /// 异常个数
        /// </summary>
        private int abnormal = 0;

        /// <summary>
        /// 默认打开路径
        /// </summary>
        private string moRenOpenPath;

        public Form1()
        {
            InitializeComponent();
            message = new FileMessage();
            moRenOpenPath = message.initiaPoint;
            OpenPoint();
            //初始化选择文件夹
            save = new SaveFileDialog();
            save.Title = "打开文件夹";
            save.Filter = "文件夹|*.";
            // 设置对话框的初始目录
            save.InitialDirectory = moRenOpenPath;
            save.FileName = "New Name";
            //初始化
            files = new List<string>();
            isFileOpen = false;
            lbText.Text = "";
            dispose = new ImagerDispose();
            cbRectangle.Checked = true;
        }

        /// <summary>
        /// 打开位置
        /// </summary>
        private void OpenPoint()
        {
            if (File.Exists("xml.text"))
            {
                XmlDocument xml = new XmlDocument();
                xml.Load("xml.text");
                XmlElement root = xml.DocumentElement;
                XmlNodeList xmlNode = root.ChildNodes;
                XmlNode node = xmlNode.Item(1);
                message.setFileOpenPath = node.InnerText;
                if (Directory.Exists(message.setFileOpenPath))
                {
                    moRenOpenPath = message.setFileOpenPath;
                    return;
                }
            }
            moRenOpenPath = message.initiaPoint;
        }

        /// <summary>
        /// 执行图片去除白边
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExecuteImageWipeOffWhiteEdge(object sender, EventArgs e)
        {
            ExecuteWipeOffWhiteEdge();
        }

        private void ExecuteWipeOffWhiteEdge()
        {
            //没有选择路径的情况
            if (Directory.Exists(tbFilePath.Text) && files.Count <= 0)
            {
                SetText("请先选择路径");
                return;
            }
            //检测当前路径是否存在
            if (Directory.Exists(tbSavePath.Text))
            {
                saveName = Path.Combine(tbSavePath.Text, "处理后的图片");
            }
            else
            {
                saveName = Path.Combine(tbFilePath.Text, "处理后的图片");
            }
            if (!Directory.Exists(saveName))
            {
                //创建新路径
                Directory.CreateDirectory(saveName);
            }
            count = files.Count;
            edgeCount = 0;
            abnormal = 0;
            ImagerDispose.ImagerType imager = cbRectangle.Checked ? ImagerDispose.ImagerType.Square : ImagerDispose.ImagerType.None;
            foreach (string filePath in files)
            {
                string name = Path.GetFileName(filePath);
                string[] name2 = name.Split('.');
                string saveFilePath = Path.Combine(saveName, name2[0] + "副本." + name2[1]);

                if (!isFileOpen)
                {
                    if (File.Exists(saveFilePath))
                    {
                        dr = MessageBox.Show("当前文件夹中的图片已处理过，是否继续处理（将删除之前已经处理的文件）", "警告！", MessageBoxButtons.YesNoCancel);
                        if (dr == DialogResult.Yes)
                        {
                            isFileOpen = true;
                        }
                        else if (dr == DialogResult.No || dr == DialogResult.Cancel)
                        {
                            break;
                        }
                    }
                }

                if (Path.GetFileName(filePath).IndexOf("主图") < 0||checkBox.Checked)
                {
                    if (dispose.RemoveWhiteEdge(filePath, saveFilePath, 700, imager) == -1)
                    {
                        abnormal++;
                    }
                    edgeCount++;
                }
                else
                {
                    if (!File.Exists(saveFilePath))
                        //复制图片到指定为止
                        File.Copy(filePath, saveFilePath);
                }

            }
            isFileOpen = false;
            dr = DialogResult.None;

            SetText("已完成！！！" + Path.GetDirectoryName(tbFilePath.Text) + "   总数：" + count + "   处理个数：" + edgeCount + "  异常个数：" + abnormal);
        }

        private void SetText(string str)
        {
            lbText.Text = str;
        }

        /// <summary>
        /// 选择文件夹路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSelectFilePath(object sender, EventArgs e)
        {
            if (save.ShowDialog() == DialogResult.OK)
            {
                //显示到文本框中
                tbFilePath.Text = System.IO.Path.GetDirectoryName(save.FileName);
                //获取选中的文件夹中的所有文件
                DirectoryInfo directoryInfo = new DirectoryInfo(tbFilePath.Text);
                //移除所有路径
                files.Clear();
                FileInfo[] f = directoryInfo.GetFiles();
                foreach (FileInfo fi in f)
                {
                    if (fi.Name.IndexOf("jpg") > 0 || fi.Name.IndexOf("jpeg") > 0)
                        files.Add(fi.FullName);
                }
            }
        }

        /// <summary>
        /// 设置默认打开窗口按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSetOpenPoint_Click(object sender, EventArgs e)
        {
            if (save.ShowDialog() == DialogResult.OK)
            {
                XmlDocument xml = new XmlDocument();
                XmlDeclaration d = xml.CreateXmlDeclaration("1.0", "UTF-8", "");
                xml.AppendChild(d);

                Type t = typeof(FileMessage);
                FieldInfo[] info = t.GetFields();
                XmlElement head = xml.CreateElement("data");

                XmlElement initia = xml.CreateElement(info[0].Name);
                initia.InnerText = message.initiaPoint;
                head.AppendChild(initia);

                XmlElement setFile = xml.CreateElement(info[1].Name);
                setFile.InnerText = System.IO.Path.GetDirectoryName(save.FileName);
                head.AppendChild(setFile);

                xml.AppendChild(head);

                xml.Save("xml.text");
                save.InitialDirectory = save.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(saveName))
            {
                Process.Start(saveName);
            }
            else
            {
                SetText("当前没有处理后的文件夹");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\zm\360下载位置\佳多美\财阀甜心蝴蝶结流苏耳钉女轻奢小众高级感设计耳饰女独特耳环耳夹-淘宝网\详情-08.jpg");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Height += 1;
        }
    }
}