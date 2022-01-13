using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopSektirme_Proje5
{
    public class RoundedButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(pevent);

        }
        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);
        //    GraphicsPath gp = new GraphicsPath();
        //    Rectangle rect = new Rectangle(Point.Empty, this.Size);
        //    gp.AddEllipse(rect);
        //    Region = new System.Drawing.Region(gp);
        //}

    }
}
