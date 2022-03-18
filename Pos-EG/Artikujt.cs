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
    public partial class Artikujt : DevExpress.XtraEditors.XtraUserControl
    {
        private static Artikujt _instance;
        public static Artikujt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Artikujt();
                }
                return _instance;
            }
        }
        public Artikujt()
        {
            InitializeComponent();
        }
    }
}
