using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace KP
{
    public class Class1 : Button
    {
        public Color ColorTop { get; set; } = Color.FromArgb(250, 235, 215);
        public Color ColorBottom { get; set; } = Color.FromArgb(178, 162, 148);
        protected override void OnPaint(PaintEventArgs e)
        {
                        LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,       
                ColorTop,                   
                ColorBottom,                
                LinearGradientMode.Vertical 
            );

            
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
                      
            brush.Dispose();            
            TextRenderer.DrawText(
                e.Graphics,
                this.Text,
                this.Font,
                this.ClientRectangle,
                this.ForeColor, 
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }
    }
}
