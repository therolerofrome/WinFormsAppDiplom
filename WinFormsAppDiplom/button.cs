using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsAppDiplom
{
    internal class button : Button
    {
        public void CreateMyButton(Button btn, string str, Form frm, int x, int y, int w, int h, EventHandler evh)
        {
            btn = new Button();

            btn.Text = str;
            btn.Location = new Point(x, y);
            btn.Size = new Size(w, h);
            btn.Click += evh;

            frm.Controls.Add(btn);
        }
    }
}
