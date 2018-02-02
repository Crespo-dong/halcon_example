using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;

//C#调用halcon读取图片步骤
//1,安装HALCON Various Inspect必须先安装.NET4.7
//2,项目属性-生成-平台必须选择X64（安装64bits版本），否则报错halcondll bad image
//3,添加dll-donet35-halcondonet.dll
//4,添加工具箱-donet35-halcondonet.dll
//5，添加窗体控件hWindowControl1
//6，添加halcon 导出的cs 实例化
namespace _001读取图片
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HDevelopExport hd = new HDevelopExport();
            hd.RunHalcon(hWindowControl1.HalconWindow);
        }
    }
}
