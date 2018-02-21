using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Carlsuns.Framework.WindowUI
{
    public partial class FM_Base : Form
    {
        public FM_Base()
        {
            InitializeComponent();
            this.se.SkinFile = System.AppDomain.CurrentDomain.BaseDirectory + SoftConfig.SkinFile; //皮肤文件.ssk
        }
    }
}
