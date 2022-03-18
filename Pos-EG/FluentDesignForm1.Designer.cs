
namespace Pos_EG
{
    partial class FluentDesignForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.arka = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.përdoruesit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.kategoritë = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.artikujt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.accordionControlElement10 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement11 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement12 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement13 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.Simple;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.arka,
            this.përdoruesit,
            this.kategoritë,
            this.artikujt});
            this.accordionControl1.Location = new System.Drawing.Point(0, 27);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(279, 705);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // arka
            // 
            this.arka.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.arka.Appearance.Hovered.Options.UseFont = true;
            this.arka.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arka.Appearance.Normal.Options.UseFont = true;
            this.arka.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.arka.Appearance.Pressed.Options.UseFont = true;
            this.arka.Name = "arka";
            this.arka.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.arka.Text = "Arka";
            this.arka.Click += new System.EventHandler(this.arka_Click);
            // 
            // përdoruesit
            // 
            this.përdoruesit.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.përdoruesit.Appearance.Hovered.Options.UseFont = true;
            this.përdoruesit.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.përdoruesit.Appearance.Normal.Options.UseFont = true;
            this.përdoruesit.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.përdoruesit.Appearance.Pressed.Options.UseFont = true;
            this.përdoruesit.Name = "përdoruesit";
            this.përdoruesit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.përdoruesit.Text = "Përdoruesit";
            this.përdoruesit.Click += new System.EventHandler(this.përdoruesit_Click);
            // 
            // kategoritë
            // 
            this.kategoritë.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.kategoritë.Appearance.Hovered.Options.UseFont = true;
            this.kategoritë.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoritë.Appearance.Normal.Options.UseFont = true;
            this.kategoritë.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.kategoritë.Appearance.Pressed.Options.UseFont = true;
            this.kategoritë.Name = "kategoritë";
            this.kategoritë.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.kategoritë.Text = "Kategoritë";
            this.kategoritë.Click += new System.EventHandler(this.kategoritë_Click);
            // 
            // artikujt
            // 
            this.artikujt.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.artikujt.Appearance.Hovered.Options.UseFont = true;
            this.artikujt.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artikujt.Appearance.Normal.Options.UseFont = true;
            this.artikujt.Appearance.Pressed.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.artikujt.Appearance.Pressed.Options.UseFont = true;
            this.artikujt.Name = "artikujt";
            this.artikujt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.artikujt.Text = "Artikujt";
            this.artikujt.Click += new System.EventHandler(this.artikujt_Click);
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.DockingEnabled = false;
            this.fluentFormDefaultManager1.Form = this;
            // 
            // accordionControlElement10
            // 
            this.accordionControlElement10.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement10.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement10.Name = "accordionControlElement10";
            this.accordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement10.Text = "Arka";
            // 
            // accordionControlElement11
            // 
            this.accordionControlElement11.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement11.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement11.Name = "accordionControlElement11";
            this.accordionControlElement11.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement11.Text = "Arka";
            // 
            // accordionControlElement12
            // 
            this.accordionControlElement12.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement12.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement12.Name = "accordionControlElement12";
            this.accordionControlElement12.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement12.Text = "Arka";
            // 
            // accordionControlElement13
            // 
            this.accordionControlElement13.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement13.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement13.Name = "accordionControlElement13";
            this.accordionControlElement13.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement13.Text = "Arka";
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(279, 27);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(861, 705);
            this.container.TabIndex = 2;
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1140, 27);
            this.fluentDesignFormControl1.TabIndex = 3;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // FluentDesignForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 732);
            this.ControlContainer = this.container;
            this.Controls.Add(this.container);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.ShowIcon = false;
            this.Name = "FluentDesignForm1";
            this.NavigationControl = this.accordionControl1;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement arka;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement përdoruesit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement kategoritë;
        private DevExpress.XtraBars.Navigation.AccordionControlElement artikujt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement10;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement11;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement12;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement13;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
    }
}