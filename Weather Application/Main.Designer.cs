
namespace Weather_Application
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.pb = new Telerik.WinControls.UI.RadPictureBox();
            this.lbDescription = new Telerik.WinControls.UI.RadLabel();
            this.lbCity = new Telerik.WinControls.UI.RadLabel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.lbTemperature = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.lbWind = new Telerik.WinControls.UI.RadLabel();
            this.lbssssssss = new Telerik.WinControls.UI.RadLabel();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.lbHumdity = new Telerik.WinControls.UI.RadLabel();
            this.lbssss = new Telerik.WinControls.UI.RadLabel();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radRepeatButton1 = new Telerik.WinControls.UI.RadRepeatButton();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbssssssss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            this.radPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbHumdity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbssss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRepeatButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radPanel1.Controls.Add(this.radRepeatButton1);
            this.radPanel1.Controls.Add(this.pb);
            this.radPanel1.Controls.Add(this.lbDescription);
            this.radPanel1.Controls.Add(this.lbCity);
            this.radPanel1.Location = new System.Drawing.Point(238, 12);
            this.radPanel1.Name = "radPanel1";
            // 
            // 
            // 
            this.radPanel1.RootElement.BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radPanel1.RootElement.BorderHighlightThickness = 0;
            this.radPanel1.RootElement.EnableFocusBorderAnimation = false;
            this.radPanel1.RootElement.FocusBorderColor = System.Drawing.Color.Transparent;
            this.radPanel1.RootElement.FocusBorderWidth = 0;
            this.radPanel1.RootElement.ShadowColor = System.Drawing.Color.Transparent;
            this.radPanel1.RootElement.ShadowDepth = 0;
            this.radPanel1.RootElement.Shape = null;
            this.radPanel1.Size = new System.Drawing.Size(329, 224);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel1.GetChildAt(0))).FocusBorderWidth = 0;
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel1.GetChildAt(0))).BorderHighlightThickness = 0;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.Transparent;
            this.pb.Image = ((System.Drawing.Image)(resources.GetObject("pb.Image")));
            this.pb.Location = new System.Drawing.Point(92, 63);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(129, 114);
            this.pb.TabIndex = 1;
            this.pb.ThemeName = "MaterialPink";
            // 
            // lbDescription
            // 
            this.lbDescription.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.ForeColor = System.Drawing.Color.White;
            this.lbDescription.Location = new System.Drawing.Point(88, 183);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(152, 38);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Description";
            this.lbDescription.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbDescription.ThemeName = "MaterialPink";
            // 
            // lbCity
            // 
            this.lbCity.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCity.ForeColor = System.Drawing.Color.White;
            this.lbCity.Location = new System.Drawing.Point(92, 13);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(140, 38);
            this.lbCity.TabIndex = 0;
            this.lbCity.Text = "City Name";
            this.lbCity.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbCity.ThemeName = "MaterialPink";
            // 
            // radPanel2
            // 
            this.radPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radPanel2.Controls.Add(this.lbTemperature);
            this.radPanel2.Controls.Add(this.radLabel3);
            this.radPanel2.Location = new System.Drawing.Point(44, 293);
            this.radPanel2.Name = "radPanel2";
            // 
            // 
            // 
            this.radPanel2.RootElement.BorderHighlightThickness = 0;
            this.radPanel2.RootElement.EnableFocusBorderAnimation = false;
            this.radPanel2.RootElement.FocusBorderWidth = 0;
            this.radPanel2.Size = new System.Drawing.Size(194, 147);
            this.radPanel2.TabIndex = 0;
            this.radPanel2.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel2.GetChildAt(0))).FocusBorderWidth = 0;
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel2.GetChildAt(0))).BorderHighlightThickness = 0;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // lbTemperature
            // 
            this.lbTemperature.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemperature.ForeColor = System.Drawing.Color.White;
            this.lbTemperature.Location = new System.Drawing.Point(64, 87);
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(59, 51);
            this.lbTemperature.TabIndex = 0;
            this.lbTemperature.Text = "35";
            this.lbTemperature.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbTemperature.ThemeName = "MaterialPink";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.ForeColor = System.Drawing.Color.White;
            this.radLabel3.Location = new System.Drawing.Point(12, 20);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(171, 38);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "Temperature";
            this.radLabel3.ThemeName = "MaterialPink";
            // 
            // radPanel3
            // 
            this.radPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radPanel3.Controls.Add(this.lbWind);
            this.radPanel3.Controls.Add(this.lbssssssss);
            this.radPanel3.Location = new System.Drawing.Point(305, 293);
            this.radPanel3.Name = "radPanel3";
            // 
            // 
            // 
            this.radPanel3.RootElement.BorderHighlightThickness = 0;
            this.radPanel3.RootElement.EnableFocusBorderAnimation = false;
            this.radPanel3.RootElement.FocusBorderWidth = 0;
            this.radPanel3.Size = new System.Drawing.Size(194, 147);
            this.radPanel3.TabIndex = 0;
            this.radPanel3.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel3.GetChildAt(0))).FocusBorderWidth = 0;
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel3.GetChildAt(0))).BorderHighlightThickness = 0;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel3.GetChildAt(0).GetChildAt(1))).BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel3.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // lbWind
            // 
            this.lbWind.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWind.ForeColor = System.Drawing.Color.White;
            this.lbWind.Location = new System.Drawing.Point(67, 87);
            this.lbWind.Name = "lbWind";
            this.lbWind.Size = new System.Drawing.Size(59, 51);
            this.lbWind.TabIndex = 0;
            this.lbWind.Text = "35";
            this.lbWind.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbWind.ThemeName = "MaterialPink";
            // 
            // lbssssssss
            // 
            this.lbssssssss.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbssssssss.ForeColor = System.Drawing.Color.White;
            this.lbssssssss.Location = new System.Drawing.Point(53, 20);
            this.lbssssssss.Name = "lbssssssss";
            this.lbssssssss.Size = new System.Drawing.Size(74, 38);
            this.lbssssssss.TabIndex = 0;
            this.lbssssssss.Text = "Wind";
            this.lbssssssss.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbssssssss.ThemeName = "MaterialPink";
            // 
            // radPanel4
            // 
            this.radPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radPanel4.Controls.Add(this.lbHumdity);
            this.radPanel4.Controls.Add(this.lbssss);
            this.radPanel4.Location = new System.Drawing.Point(566, 293);
            this.radPanel4.Name = "radPanel4";
            // 
            // 
            // 
            this.radPanel4.RootElement.BorderHighlightThickness = 0;
            this.radPanel4.RootElement.EnableFocusBorderAnimation = false;
            this.radPanel4.RootElement.FocusBorderWidth = 0;
            this.radPanel4.Size = new System.Drawing.Size(194, 147);
            this.radPanel4.TabIndex = 0;
            this.radPanel4.ThemeName = "Material";
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel4.GetChildAt(0))).FocusBorderWidth = 0;
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel4.GetChildAt(0))).BorderHighlightThickness = 0;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel4.GetChildAt(0).GetChildAt(1))).BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel4.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // lbHumdity
            // 
            this.lbHumdity.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHumdity.ForeColor = System.Drawing.Color.White;
            this.lbHumdity.Location = new System.Drawing.Point(72, 87);
            this.lbHumdity.Name = "lbHumdity";
            this.lbHumdity.Size = new System.Drawing.Size(59, 51);
            this.lbHumdity.TabIndex = 0;
            this.lbHumdity.Text = "35";
            this.lbHumdity.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbHumdity.ThemeName = "MaterialPink";
            // 
            // lbssss
            // 
            this.lbssss.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbssss.ForeColor = System.Drawing.Color.White;
            this.lbssss.Location = new System.Drawing.Point(36, 20);
            this.lbssss.Name = "lbssss";
            this.lbssss.Size = new System.Drawing.Size(122, 38);
            this.lbssss.TabIndex = 0;
            this.lbssss.Text = "Humidity";
            this.lbssss.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbssss.ThemeName = "MaterialPink";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(238, 242);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(329, 36);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Select Location";
            this.radButton1.ThemeName = "Material";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radRepeatButton1
            // 
            this.radRepeatButton1.BackColor = System.Drawing.Color.Transparent;
            this.radRepeatButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radRepeatButton1.BackgroundImage")));
            this.radRepeatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radRepeatButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radRepeatButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radRepeatButton1.Location = new System.Drawing.Point(13, 13);
            this.radRepeatButton1.Name = "radRepeatButton1";
            this.radRepeatButton1.Size = new System.Drawing.Size(37, 33);
            this.radRepeatButton1.TabIndex = 2;
            this.radRepeatButton1.ThemeName = "Material";
            this.radRepeatButton1.Click += new System.EventHandler(this.radRepeatButton1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 452);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radPanel4);
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Main";
            // 
            // 
            // 
            this.RootElement.BorderHighlightColor = System.Drawing.Color.Transparent;
            this.RootElement.BorderHighlightThickness = 0;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Application";
            this.ThemeName = "Material";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            this.radPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbssssssss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            this.radPanel4.ResumeLayout(false);
            this.radPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbHumdity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbssss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRepeatButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPictureBox pb;
        private Telerik.WinControls.UI.RadLabel lbDescription;
        private Telerik.WinControls.UI.RadLabel lbCity;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadLabel lbTemperature;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadLabel lbWind;
        private Telerik.WinControls.UI.RadLabel lbssssssss;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private Telerik.WinControls.UI.RadLabel lbHumdity;
        private Telerik.WinControls.UI.RadLabel lbssss;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadRepeatButton radRepeatButton1;
    }
}

