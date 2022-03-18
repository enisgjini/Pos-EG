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
    public partial class Arka : DevExpress.XtraEditors.XtraUserControl
    {
        private static Arka _instance;
        public static Arka Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Arka();
                }
                return _instance;
            }
        }
        public Arka()
        {
            InitializeComponent();
        }
    }
}
