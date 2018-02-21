namespace Carlsuns.Framework.WindowUI
{
    partial class FM_Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FM_Base));
            this.se = new Sunisoft.IrisSkin.SkinEngine();
            this.SuspendLayout();
            // 
            // se
            // 
            this.se.@__DrawButtonFocusRectangle = true;
            this.se.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.se.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.se.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.se.SerialNumber = "";
            this.se.SkinFile = null;
            // 
            // FM_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FM_Base";
            this.Text = "FM_Base";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine se;
    }
}