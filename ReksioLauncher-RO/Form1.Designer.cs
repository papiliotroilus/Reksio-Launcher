using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ReksioLauncher
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pirati = new Button();
            ozn = new Button();
            magic = new Button();
            actiune = new Button();
            nemo = new Button();
            timp = new Button();
            SuspendLayout();
            // 
            // pirati
            // 
            pirati.BackColor = Color.White;
            pirati.BackgroundImageLayout = ImageLayout.None;
            pirati.Cursor = Cursors.Hand;
            pirati.FlatAppearance.BorderColor = Color.Black;
            pirati.FlatAppearance.BorderSize = 0;
            pirati.FlatAppearance.MouseDownBackColor = Color.PaleGoldenrod;
            pirati.FlatAppearance.MouseOverBackColor = Color.OldLace;
            pirati.FlatStyle = FlatStyle.Flat;
            pirati.Font = new Font("Ink Free", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            pirati.ForeColor = Color.MidnightBlue;
            pirati.Image = (Image)resources.GetObject("pirati.Image");
            pirati.ImageAlign = ContentAlignment.TopCenter;
            pirati.Location = new Point(12, 12);
            pirati.Name = "pirati";
            pirati.Padding = new Padding(5, 5, 5, 0);
            pirati.Size = new Size(290, 314);
            pirati.TabIndex = 0;
            pirati.Text = "Reksio si Comoara Piratilor";
            pirati.TextAlign = ContentAlignment.BottomCenter;
            pirati.UseVisualStyleBackColor = false;
            pirati.Click += pirati_Click;
            // 
            // ozn
            // 
            ozn.Anchor = AnchorStyles.Top;
            ozn.BackColor = Color.White;
            ozn.BackgroundImageLayout = ImageLayout.None;
            ozn.Cursor = Cursors.Hand;
            ozn.FlatAppearance.BorderColor = Color.Black;
            ozn.FlatAppearance.BorderSize = 0;
            ozn.FlatAppearance.MouseDownBackColor = Color.PaleGoldenrod;
            ozn.FlatAppearance.MouseOverBackColor = Color.OldLace;
            ozn.FlatStyle = FlatStyle.Flat;
            ozn.Font = new Font("Ink Free", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ozn.ForeColor = Color.MidnightBlue;
            ozn.Image = (Image)resources.GetObject("ozn.Image");
            ozn.ImageAlign = ContentAlignment.TopCenter;
            ozn.Location = new Point(318, 12);
            ozn.Name = "ozn";
            ozn.Padding = new Padding(5, 5, 5, 0);
            ozn.Size = new Size(290, 314);
            ozn.TabIndex = 1;
            ozn.Text = "Reksio si OZN-ul";
            ozn.TextAlign = ContentAlignment.BottomCenter;
            ozn.UseVisualStyleBackColor = false;
            ozn.Click += Button1_Click;
            // 
            // magic
            // 
            magic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            magic.BackColor = Color.White;
            magic.BackgroundImageLayout = ImageLayout.None;
            magic.Cursor = Cursors.Hand;
            magic.FlatAppearance.BorderColor = Color.Black;
            magic.FlatAppearance.BorderSize = 0;
            magic.FlatAppearance.MouseDownBackColor = Color.PaleGoldenrod;
            magic.FlatAppearance.MouseOverBackColor = Color.OldLace;
            magic.FlatStyle = FlatStyle.Flat;
            magic.Font = new Font("Ink Free", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            magic.ForeColor = Color.MidnightBlue;
            magic.Image = (Image)resources.GetObject("magic.Image");
            magic.ImageAlign = ContentAlignment.TopCenter;
            magic.Location = new Point(623, 12);
            magic.Name = "magic";
            magic.Padding = new Padding(5, 5, 5, 0);
            magic.Size = new Size(290, 314);
            magic.TabIndex = 2;
            magic.Text = "Reksio si Magicienii";
            magic.TextAlign = ContentAlignment.BottomCenter;
            magic.UseVisualStyleBackColor = false;
            magic.Click += magic_Click;
            // 
            // actiune
            // 
            actiune.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            actiune.BackColor = Color.White;
            actiune.BackgroundImageLayout = ImageLayout.None;
            actiune.Cursor = Cursors.Hand;
            actiune.FlatAppearance.BorderColor = Color.Black;
            actiune.FlatAppearance.BorderSize = 0;
            actiune.FlatAppearance.MouseDownBackColor = Color.PaleGoldenrod;
            actiune.FlatAppearance.MouseOverBackColor = Color.OldLace;
            actiune.FlatStyle = FlatStyle.Flat;
            actiune.Font = new Font("Ink Free", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            actiune.ForeColor = Color.MidnightBlue;
            actiune.Image = (Image)resources.GetObject("actiune.Image");
            actiune.ImageAlign = ContentAlignment.TopCenter;
            actiune.Location = new Point(623, 340);
            actiune.Name = "actiune";
            actiune.Padding = new Padding(5, 5, 5, 0);
            actiune.Size = new Size(290, 314);
            actiune.TabIndex = 5;
            actiune.Text = "Reksio si Kretes in Actiune";
            actiune.TextAlign = ContentAlignment.BottomCenter;
            actiune.UseVisualStyleBackColor = false;
            actiune.Click += actiune_Click;
            // 
            // nemo
            // 
            nemo.Anchor = AnchorStyles.Bottom;
            nemo.BackColor = Color.White;
            nemo.BackgroundImageLayout = ImageLayout.None;
            nemo.Cursor = Cursors.Hand;
            nemo.FlatAppearance.BorderColor = Color.Black;
            nemo.FlatAppearance.BorderSize = 0;
            nemo.FlatAppearance.MouseDownBackColor = Color.PaleGoldenrod;
            nemo.FlatAppearance.MouseOverBackColor = Color.OldLace;
            nemo.FlatStyle = FlatStyle.Flat;
            nemo.Font = new Font("Ink Free", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nemo.ForeColor = Color.MidnightBlue;
            nemo.Image = (Image)resources.GetObject("nemo.Image");
            nemo.ImageAlign = ContentAlignment.TopCenter;
            nemo.Location = new Point(318, 340);
            nemo.Name = "nemo";
            nemo.Padding = new Padding(5, 5, 5, 0);
            nemo.Size = new Size(290, 314);
            nemo.TabIndex = 4;
            nemo.Text = "Reksio si Capitanul Nemo";
            nemo.TextAlign = ContentAlignment.BottomCenter;
            nemo.UseVisualStyleBackColor = false;
            nemo.Click += nemo_Click;
            // 
            // timp
            // 
            timp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            timp.BackColor = Color.White;
            timp.BackgroundImageLayout = ImageLayout.None;
            timp.Cursor = Cursors.Hand;
            timp.FlatAppearance.BorderColor = Color.Black;
            timp.FlatAppearance.BorderSize = 0;
            timp.FlatAppearance.MouseDownBackColor = Color.PaleGoldenrod;
            timp.FlatAppearance.MouseOverBackColor = Color.OldLace;
            timp.FlatStyle = FlatStyle.Flat;
            timp.Font = new Font("Ink Free", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            timp.ForeColor = Color.MidnightBlue;
            timp.Image = (Image)resources.GetObject("timp.Image");
            timp.ImageAlign = ContentAlignment.TopCenter;
            timp.Location = new Point(12, 340);
            timp.Name = "timp";
            timp.Padding = new Padding(5, 5, 5, 0);
            timp.Size = new Size(290, 314);
            timp.TabIndex = 3;
            timp.Text = "Reksio si Masina Timpului";
            timp.TextAlign = ContentAlignment.BottomCenter;
            timp.UseVisualStyleBackColor = false;
            timp.Click += timp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(924, 666);
            Controls.Add(actiune);
            Controls.Add(nemo);
            Controls.Add(timp);
            Controls.Add(magic);
            Controls.Add(ozn);
            Controls.Add(pirati);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aventurile lui Reksio";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        internal Button pirati;
        internal Button ozn;
        internal Button magic;
        internal Button actiune;
        internal Button nemo;
        internal Button timp;
    }
}