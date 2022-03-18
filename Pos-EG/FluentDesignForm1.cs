using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pos_EG
{
    public partial class FluentDesignForm1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FluentDesignForm1()
        {
            InitializeComponent();
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void arka_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(Arka.Instance))
            {
                container.Controls.Add(Arka.Instance);
                Arka.Instance.Dock = DockStyle.Fill;
                Arka.Instance.BringToFront();
            }

            Arka.Instance.BringToFront();
        }

        private void përdoruesit_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(Përdoruesit.Instance))
            {
                container.Controls.Add(Përdoruesit.Instance);
                Përdoruesit.Instance.Dock = DockStyle.Fill;
                Përdoruesit.Instance.BringToFront();
            }

            Përdoruesit.Instance.BringToFront();
        }

        private void kategoritë_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(Kategoritë.Instance))
            {
                container.Controls.Add(Kategoritë.Instance);
                Kategoritë.Instance.Dock = DockStyle.Fill;
                Kategoritë.Instance.BringToFront();
            }

            Kategoritë.Instance.BringToFront();
        }

        private void artikujt_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(Artikujt.Instance))
            {
                container.Controls.Add(Artikujt.Instance);
                Artikujt.Instance.Dock = DockStyle.Fill;
                Artikujt.Instance.BringToFront();
            }

            Artikujt.Instance.BringToFront();
        }
    }
}
