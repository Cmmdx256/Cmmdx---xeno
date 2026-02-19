using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CmmdxExecut
{
    public partial class Form2 : Form
    {
        private List<List<object>> _clients;


        ToolTip tool = new ToolTip();

        public Form2(List<List<object>> clients)
        {
            InitializeComponent();
            tool.SetToolTip(btnBack, "Closes this page.");

            _clients = clients;

            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.DrawItem += listBox1_DrawItem;
            listBox1.DoubleClick += listBox1_DoubleClick;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

            LoadList();
        }

        private void LoadList()
        {
            listBox1.Items.Clear();

            foreach (var c in _clients)
            {
                listBox1.Items.Add(c);
            }
        }


        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var client = (List<object>)listBox1.Items[e.Index];

            int pid = Convert.ToInt32(client[0]);
            string name = client[1].ToString();
            string path = client[2].ToString();
            int state = Convert.ToInt32(client[3]);

            string stateText = state switch
            {
                3 => "Ready",
                2 => "Injected",
                _ => "Error"
            };

            Color stateColor = state switch
            {
                3 => Color.LimeGreen,
                2 => Color.DeepSkyBlue,
                _ => Color.Red
            };


            e.DrawBackground();


            string text = $"{pid}   |   {name}   |   {stateText}";


            Brush normalBrush = new SolidBrush(Color.White);


            Brush stateBrush = new SolidBrush(stateColor);


            e.Graphics.DrawString($"{pid}   |   {name}   |   ",
                e.Font, normalBrush, e.Bounds);


            var size = e.Graphics.MeasureString($"{pid}   |   {name}   |   ", e.Font);
            var stateLocation = new PointF(e.Bounds.Left + size.Width - 5, e.Bounds.Top);

            e.Graphics.DrawString(stateText, e.Font, stateBrush, stateLocation);

            e.DrawFocusRectangle();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;

            var c = (List<object>)listBox1.SelectedItem;

            int pid = Convert.ToInt32(c[0]);
            string name = c[1].ToString();
            string path = c[2].ToString();
            int state = Convert.ToInt32(c[3]);

            string stateText = state switch
            {
                3 => "Ready",
                2 => "Injected",
                _ => "Error"
            };

            MessageBox.Show(
                $"PID: {pid}\nName: {name}\nPath: {path}\nState: {stateText}",
                "Client Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;

            var c = (List<object>)listBox1.SelectedItem;

            int pid = Convert.ToInt32(c[0]);

            try
            {
                Process.Start("explorer.exe", $"/select,\"{Process.GetProcessById(pid).MainModule.FileName}\"");
            }
            catch
            {
                MessageBox.Show("Process açılamadı.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButtonAdvanced1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}