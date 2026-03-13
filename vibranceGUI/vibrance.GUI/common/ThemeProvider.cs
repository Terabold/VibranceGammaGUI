using System;
using System.Drawing;
using System.Windows.Forms;

namespace vibrance.GUI.common
{
    /// <summary>
    /// Modern dark mode theme provider with clean UI colors
    /// </summary>
    public static class ThemeProvider
    {
        // Dark mode color palette
        public static class DarkTheme
        {
            public static readonly Color BackgroundPrimary = Color.FromArgb(20, 20, 20);      // #141414
            public static readonly Color BackgroundSecondary = Color.FromArgb(30, 30, 30);    // #1E1E1E
            public static readonly Color BackgroundTertiary = Color.FromArgb(40, 40, 40);     // #282828
            public static readonly Color ForegroundPrimary = Color.FromArgb(240, 240, 240);   // #F0F0F0
            public static readonly Color ForegroundSecondary = Color.FromArgb(170, 170, 170); // #AAAAAA
            public static readonly Color AccentColor = Color.FromArgb(0, 150, 136);           // Teal accent
            public static readonly Color AccentColorHover = Color.FromArgb(0, 180, 160);      // Lighter teal
            public static readonly Color BorderColor = Color.FromArgb(50, 50, 50);            // #323232
        }

        // Light mode color palette
        public static class LightTheme
        {
            public static readonly Color BackgroundPrimary = Color.FromArgb(245, 245, 245);   // #F5F5F5
            public static readonly Color BackgroundSecondary = Color.FromArgb(255, 255, 255); // #FFFFFF
            public static readonly Color BackgroundTertiary = Color.FromArgb(240, 240, 240);  // #F0F0F0
            public static readonly Color ForegroundPrimary = Color.FromArgb(32, 32, 32);      // #202020
            public static readonly Color ForegroundSecondary = Color.FromArgb(100, 100, 100); // #646464
            public static readonly Color AccentColor = Color.FromArgb(0, 150, 136);           // Teal accent
            public static readonly Color AccentColorHover = Color.FromArgb(0, 120, 110);      // Darker teal
            public static readonly Color BorderColor = Color.FromArgb(220, 220, 220);         // #DCDCDC
        }

        /// <summary>
        /// Apply modern dark theme to form and controls
        /// </summary>
        public static void ApplyDarkTheme(Form form)
        {
            form.BackColor = DarkTheme.BackgroundPrimary;
            form.ForeColor = DarkTheme.ForegroundPrimary;

            ApplyThemeToControl(form, DarkTheme.BackgroundPrimary, 
                DarkTheme.BackgroundSecondary, DarkTheme.BorderColor, 
                DarkTheme.ForegroundPrimary, DarkTheme.AccentColor);
        }

        /// <summary>
        /// Recursively apply dark theme to all controls
        /// </summary>
        private static void ApplyThemeToControl(Control parent, Color background, 
            Color groupBackground, Color borderColor, Color foreground, Color accentColor)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    groupBox.BackColor = background;
                    groupBox.ForeColor = foreground;
                    groupBox.Paint -= GroupBox_Paint;
                    groupBox.Paint += GroupBox_Paint;
                }
                else if (control is Button button)
                {
                    button.BackColor = groupBackground;
                    button.ForeColor = foreground;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderColor = accentColor;
                    button.FlatAppearance.BorderSize = 1;
                }
                else if (control is CheckBox || control is RadioButton)
                {
                    control.BackColor = background;
                    control.ForeColor = foreground;
                    ((CheckBox)control).FlatStyle = FlatStyle.Flat;
                }
                else if (control is Label)
                {
                    control.BackColor = background;
                    control.ForeColor = foreground;
                }
                else if (control is TrackBar trackBar)
                {
                    trackBar.BackColor = background;
                    trackBar.ForeColor = accentColor;
                }
                else if (control is ListView listView)
                {
                    listView.BackColor = groupBackground;
                    listView.ForeColor = foreground;
                }
                else if (control is TextBox textBox)
                {
                    textBox.BackColor = groupBackground;
                    textBox.ForeColor = foreground;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    control.BackColor = background;
                    control.ForeColor = foreground;
                }

                // Recursively apply to nested controls
                if (control.HasChildren)
                {
                    ApplyThemeToControl(control, background, groupBackground, borderColor, foreground, accentColor);
                }
            }
        }

        private static void GroupBox_Paint(object sender, PaintEventArgs e)
        {
            GroupBox gb = sender as GroupBox;
            Color accentColor = Color.FromArgb(0, 150, 136);
            e.Graphics.Clear(DarkTheme.BackgroundPrimary);
            e.Graphics.DrawRectangle(new Pen(accentColor, 1), 0, 6, gb.Width - 1, gb.Height - 7);
            e.Graphics.DrawString(gb.Text, gb.Font, new SolidBrush(DarkTheme.ForegroundPrimary), 10, 0);
        }
    }
}
