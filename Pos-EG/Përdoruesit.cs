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
    public partial class Përdoruesit : DevExpress.XtraEditors.XtraUserControl
    {
        private static Përdoruesit _instance;
        public static Përdoruesit Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Përdoruesit();
                }
                return _instance;
            }
        }
        public Përdoruesit()
        {
            InitializeComponent();
        }
    }
}
