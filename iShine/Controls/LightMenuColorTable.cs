using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iShine.Controls
{
    class LightMenuColorTable : ProfessionalColorTable
    {
        Color lightLight = Color.FromArgb(255, 255, 255);
        Color darkLight = Color.FromArgb(247, 247, 247);

        public override Color MenuItemSelected
        {
            get { return darkLight; }
        } 

        public override Color MenuBorder
        {
            get { return Color.FromArgb(230, 230, 230); }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return lightLight;
            }
        }

    }
}
