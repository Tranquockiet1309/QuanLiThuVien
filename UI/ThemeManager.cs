using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public static class ThemeManager
    {
        // Brand Colors
        public static Color BackgroundColor = Color.FromArgb(243, 244, 246);   // Light Gray TailWind
        public static Color PrimaryColor = Color.FromArgb(59, 130, 246);       // Blue 500
        public static Color HoverColor = Color.FromArgb(37, 99, 235);          // Blue 600
        public static Color SurfaceColor = Color.White;
        public static Color TextDark = Color.FromArgb(31, 41, 55);             // Gray 800
        public static Color TextLight = Color.FromArgb(107, 114, 128);         // Gray 500
        public static Color BorderColor = Color.FromArgb(229, 231, 235);       // Gray 200

        public static void Apply(Form form)
        {
            if (form == null) return;
            form.BackColor = BackgroundColor;
            // Optionally set font for standard look if not already customized
            // form.Font = new Font("Segoe UI", 10F, FontStyle.Regular); 

            ApplyToControls(form.Controls);
        }

        private static void ApplyToControls(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                ApplyStyling(c);
                if (c.HasChildren)
                {
                    ApplyToControls(c.Controls);
                }
            }
        }

        private static void ApplyStyling(Control c)
        {
            if (c is Button btn)
            {
                // Basic buttons are styled flat primary. (You can add Tag checks if some buttons need different colors)
                if (btn.FlatStyle != FlatStyle.Flat) 
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    btn.Cursor = Cursors.Hand;
                }
                
                // Add hover effect unless it is a special sidebar nav button
                if (!btn.Name.StartsWith("mnu") && !btn.Name.StartsWith("btnTim") && !btn.Name.StartsWith("btnNhan"))
                {
                    btn.MouseEnter -= Btn_MouseEnter;
                    btn.MouseLeave -= Btn_MouseLeave;
                    btn.MouseEnter += Btn_MouseEnter;
                    btn.MouseLeave += Btn_MouseLeave;
                }
            }
            else if (c is TextBox txt)
            {
                txt.BorderStyle = BorderStyle.FixedSingle;
                // txt.BackColor = SurfaceColor;
            }
            else if (c is DataGridView dgv)
            {
                StyleDataGridView(dgv);
            }
            else if (c is ComboBox cbx)
            {
                cbx.FlatStyle = FlatStyle.Flat;
            }
        }

        private static void StyleDataGridView(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.BackgroundColor = SurfaceColor;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.GridColor = BorderColor;
            dgv.RowHeadersVisible = false;

            // Column Header Style
            var headerStyle = new DataGridViewCellStyle();
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = BackgroundColor;
            headerStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            headerStyle.ForeColor = TextDark;
            headerStyle.Padding = new Padding(10, 8, 10, 8);
            headerStyle.SelectionBackColor = BackgroundColor;
            headerStyle.SelectionForeColor = TextDark;
            headerStyle.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = headerStyle;
            dgv.ColumnHeadersHeight = 45;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Default Cell Style
            var cellStyle = new DataGridViewCellStyle();
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = SurfaceColor;
            cellStyle.Font = new Font("Segoe UI", 9.5F);
            cellStyle.ForeColor = TextDark;
            cellStyle.Padding = new Padding(10, 5, 10, 5);
            cellStyle.SelectionBackColor = Color.FromArgb(239, 246, 255); // Blue 50
            cellStyle.SelectionForeColor = HoverColor;
            cellStyle.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = cellStyle;
            dgv.RowTemplate.Height = 45;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private static void Btn_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                // Save original back color in Tag if empty
                if (btn.Tag == null) btn.Tag = btn.BackColor;
                if ((Color)btn.Tag == PrimaryColor)
                    btn.BackColor = HoverColor;
            }
        }

        private static void Btn_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag != null)
            {
                btn.BackColor = (Color)btn.Tag;
            }
        }
    }
}
