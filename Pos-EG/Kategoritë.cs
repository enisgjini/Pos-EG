using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos_EG
{
    public partial class Kategoritë : DevExpress.XtraEditors.XtraUserControl
    {
        private static Kategoritë _instance;
        public static Kategoritë Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Kategoritë();
                }
                return _instance;
            }
        }
        public Kategoritë()
        {
            InitializeComponent();
        }
    }
}
