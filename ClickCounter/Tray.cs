using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ClickCounter
{
    public class Tray : Form
    {
        public Tray()
        {
            ContextMenu trayMenu = new ContextMenu();
            NotifyIcon trayIcon = new NotifyIcon();

            trayMenu.MenuItems.Add("How many clicks I did?", OnClickInfo);
            trayMenu.MenuItems.Add("Exit", OnExit);

            trayIcon = new NotifyIcon();
            trayIcon.Text = "Mouse Clicker v0.1";
            trayIcon.Icon = new Icon(SystemIcons.Shield, 40, 40);

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible       = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar
            base.OnLoad(e);
        }

        private void OnClickInfo(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("You did:\r\n{0} left mouse clicks\r\n{1} right mouse clicks", MouseHook.LeftMouseClicks, MouseHook.RightMouseClicks));
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
