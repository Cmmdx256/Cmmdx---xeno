using Microsoft.Web.WebView2.WinForms;
using Newtonsoft;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media;
using XenoUI;

namespace CmmdxExecut
{
    public partial class Form1 : Form
    {
        private const int MAX_TABS = 11;

        string[] words = { "Injector", "Loader", "Manager", "Justice", "Your own dream", "No pain no gain", "Cool", "Explorer", "Projects", "Reverse Engineering", "31", "sex", "DAD", "TAK TAK", "life is just PORRO", "I dont given any sh*t", "illegal", "Life is consist of Ýllegal", "I used to play in old streets" };
        int index = 0;

        System.Windows.Forms.Timer changeTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();

        float opacity = 1f;
        bool fadingOut = false;


        System.Windows.Forms.ToolTip TL = new System.Windows.Forms.ToolTip();


        public Form1()
        {
            InitializeComponent();





            AddTab.Enabled = true;


            label1.Text = "Cmmdx " + words[index];
            using var _ = label1.Font = new Font("Arial", 24, System.Drawing.FontStyle.Bold);


            changeTimer.Interval = 5000;
            changeTimer.Tick += timer1_Tick;
            changeTimer.Start();


            fadeTimer.Interval = 50;
            fadeTimer.Tick += timer2_Tick;
            fadeTimer.Start();

            ClientsWindow.Initialize(false);

            InitializeEditorAsync();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        private readonly string sTabsConfig;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        bool isInjected = false;
        private System.Windows.Input.MouseButtonEventHandler TabSelected;
        private System.Windows.Input.MouseButtonEventArgs e2;

        public int FadeTimer_Elapsed { get; }
        public EventHandler FadeTimer_Tick { get; }
        public EventHandler ChangeTimer_Tick { get; }
        public object tabControlScripts { get; private set; }

        [DllImport("Xeno.dll", CallingConvention = (CallingConvention)2)]
        public static extern void Initialize(bool useConsole);

        [DllImport("Xeno.dll", CallingConvention = (CallingConvention)2, CharSet = CharSet.Ansi)]
        private static extern IntPtr GetClients();

        [DllImport("Xeno.dll", CallingConvention = (CallingConvention)2, CharSet = CharSet.Ansi)]
        private static extern void Execute(byte[] script, int[] PIDs, int count);

        [DllImport("Xeno.dll", CallingConvention = (CallingConvention)2)]
        public static extern void Attach();

        [DllImport("Xeno.dll", CallingConvention = (CallingConvention)2, CharSet = CharSet.Ansi)]
        private static extern IntPtr Version();




        private List<List<object>> GetAllClients()
        {
            try
            {
                IntPtr clientsPtr = GetClients();
                if (clientsPtr == IntPtr.Zero) return new List<List<object>>();

                string clientsJson = Marshal.PtrToStringAnsi(clientsPtr);
                var clientsList = JsonConvert.DeserializeObject<List<List<object>>>(clientsJson);

                return clientsList ?? new List<List<object>>();
            }
            catch
            {
                return new List<List<object>>();
            }
        }




        private List<int> GetReadyClientPIDs()
        {
            var pids = new List<int>();

            try
            {
                IntPtr clientsPtr = GetClients();
                if (clientsPtr == IntPtr.Zero) return pids;

                string clientsJson = Marshal.PtrToStringAnsi(clientsPtr);
                var clientsList = JsonConvert.DeserializeObject<List<List<object>>>(clientsJson);

                if (clientsList != null)
                {
                    foreach (var client in clientsList)
                    {
                        if (client.Count >= 4)
                        {
                            int pid = Convert.ToInt32(client[0]);
                            int state = Convert.ToInt32(client[3]);

                            if (state == 3) // Ready state
                            {
                                pids.Add(pid);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return pids;
        }



        private void ExecuteScriptOnClients(string script)
        {
            if (string.IsNullOrWhiteSpace(script))
            {
                System.Windows.MessageBox.Show("Script is empty.", "Empty Script", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Warning);
                return;
            }

            var clientPIDs = GetReadyClientPIDs();

            if (clientPIDs.Count == 0)
            {
                System.Windows.MessageBox.Show("No ready clients found.\n\nMake sure you've pressed Attach and waited for injection to complete.",
                    "No Ready Clients", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                Execute(Encoding.UTF8.GetBytes(script + "\0"), clientPIDs.ToArray(), clientPIDs.Count);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"Script execution failed:\n{ex.Message}", "Execution Error",
                    (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
            }
        }

        private async Task InitializeEditorAsync()
        {
            try
            {
                await Editor.EnsureCoreWebView2Async();

                string htmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Editor", "index.html");
                string uri = new Uri(htmlPath).AbsoluteUri;

                Editor.CoreWebView2.Navigate(uri);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"Error initializing WebView2:\n{ex.Message}", "Initialization Error", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
            }
        }

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            index = (index + 1) % words.Length;
            fadingOut = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (fadingOut)
            {
                opacity -= 0.05f;

                if (opacity <= 0f)
                {
                    opacity = 0f;
                    fadingOut = false;
                    label1.Text = "Cmmdx " + words[index];
                }
            }
            else
            {
                opacity += 0.05f;

                if (opacity >= 1f)
                {
                    opacity = 1f;
                }
            }


            label1.ForeColor = System.Drawing.Color.FromArgb(
                (int)(opacity * 255),
                label1.ForeColor.R,
                label1.ForeColor.G,
                label1.ForeColor.B
            );
        }



        private async void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {


        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void Editor_Click(object sender, EventArgs e)
        {

        }

        /*
        private void AddTab_Click(object sender, EventArgs e)
        {
            
            if (this.tabControlScripts.Items.Count - 1 > 10)
            {
                System.Windows.MessageBox.Show("Maximum tabs exceeded", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            Dictionary<string, List<object>> tabsData = JsonConvert.DeserializeObject<Dictionary<string, List<object>>>(this.sTabsConfig);
            if (tabsData == null)
            {
                System.Windows.MessageBox.Show("JsonConvert.DeserializeObject returned null", "Newtonsoft.Json Error", MessageBoxButton.OK, MessageBoxImage.Hand);
                return;
            }
            string tGuid = Guid.NewGuid().ToString();
            DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
            defaultInterpolatedStringHandler.AppendLiteral("Tab ");
            defaultInterpolatedStringHandler.AppendFormatted<int>(this.tabControlScripts.Items.Count);
            string tabName = defaultInterpolatedStringHandler.ToStringAndClear();
            TabItem newTab = new TabItem
            {
                Header = tabName,
                Uid = tGuid
            };
            newTab.MouseDoubleClick += this.Tab_DoubleClick;
            newTab.PreviewMouseLeftButtonDown += this.TabSelected;
            ContextMenu contextMenu = new ContextMenu();
            MenuItem mDelete = new MenuItem
            {
                Header = "Delete"
            };
            mDelete.Click += delegate (object s, RoutedEventArgs e)
            {
                this.DeleteTab(newTab);
            };
            MenuItem mRename = new MenuItem
            {
                Header = "Rename"
            };
            mRename.Click += delegate (object s, RoutedEventArgs e)
            {
                this.Tab_DoubleClick(newTab, null);
            };
            contextMenu.Items.Add(mDelete);
            contextMenu.Items.Add(mRename);
            newTab.ContextMenu = contextMenu;
            this.TabSelected(newTab, e2);
            this.tabControlScripts.Items.Insert(this.tabControlScripts.Items.Count - 1, newTab);
            tabsData[tGuid] = new List<object>
    {
        tabName,
        true
    };
            this.sTabsConfig = JsonConvert.SerializeObject(tabsData, Formatting.Indented);
            e2.Handled = true;
        }
            
        private void DeleteTab(TabItem newTab)
        {
            throw new NotImplementedException();
        }

        private int GetSmallestAvailableTabNumber()
        {
            for (int i = 1; i <= MAX_TABS; i++)
            {
                if (!tabs.ContainsKey(i)) return i;
            }
            return -1;
        }

        private void CreateTab(int number, bool select)
        {
            // 1) Tab butonu oluþtur
            var btn = new Guna.UI2.WinForms.Guna2Button();
            btn.Text = $"TAB {number}";
            btn.Tag = number;
            btn.AutoRoundedCorners = true;
            btn.Height = 26;
            btn.Padding = new Padding(8, 0, 8, 0);
            btn.Margin = new Padding(4, 4, 4, 4);
            btn.BorderRadius = 6;
            btn.Font = new Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            btn.FillColor = System.Drawing.Color.FromArgb(40, 40, 40);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Cursor = Cursors.Hand;
            btn.TabStop = false;

            // Buton click seçme
            btn.Click += (s, e) =>
            {
                SelectTab((int)btn.Tag);
            };

            // Butona sað týk baðla (Context menu)
            var ctx = new ContextMenuStrip();
            var miRename = new ToolStripMenuItem("Rename");
            var miClose = new ToolStripMenuItem("Close");
            var miDelete = new ToolStripMenuItem("Delete");

            miRename.Click += (s, e) => RenameTab((int)btn.Tag);
            miClose.Click += (s, e) => CloseTab((int)btn.Tag);
            miDelete.Click += (s, e) => DeleteTab((int)btn.Tag);

            ctx.Items.AddRange(new ToolStripItem[] { miRename, miClose, miDelete });

            btn.MouseUp += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    ctx.Show(btn, e.Location);
                }
            };

            // 2) Tab içeriði panelini oluþtur
            var content = new System.Windows.Forms.Panel();
            content.Dock = DockStyle.Fill;
            content.Visible = false; // seçilince görünür olacak
            content.BackColor = System.Drawing.Color.Black; // arkaplan

            // 3) Editor kontrolünü oluþtur (örnek TextBox). BURAYA kendi Editor kontrolünü koy.
            System.Windows.Forms.Control editor = CreateEditorForTab(number);
            editor.Dock = DockStyle.Fill;
            content.Controls.Add(editor);

            // 4) TabInfo oluþturup dictionary'ye ekle
            var info = new TabInfo
            {
                Number = number,
                Button = btn,
                ContentPanel = content,
                EditorControl = editor
            };
            tabs[number] = info;

            // 5) panelTabBar içine butonu ekle, ama AddTab butonunun solunda olacak þekilde ekle
            // YALIN yaklaþým: AddTab zaten panelTabBar içindeyse, AddTab'ýn index'ini alýp önüne ekle.
            panelTabBar.Controls.Add(btn);
            // AddTab referansýný panelin sonuna taþý (her zaman en son)
            if (!object.ReferenceEquals(AddTab.Parent, panelTabBar))
            {
                // Designer'da AddTab panelTabBar içinde deðilse, panelTabBar'a taþý
                panelTabBar.Controls.Add(AddTab);
            }
            // Butonlarýn istediðimiz sýra için AddTab'ý en sona koy
            panelTabBar.Controls.SetChildIndex(AddTab, 0); // 0 index olmasý sað tarafta görünmesi için layout'a göre deðiþebilir
                                                           // Eðer dizilim ters görünürse SetChildIndex(AddTab, panelTabBar.Controls.Count - 1) deneyebilirsin.

            // 6) panelMain içine content ekle
            panelMain.Controls.Add(content);

            // 7) otomatik seç
            if (select) SelectTab(number);
        }

        private Control CreateEditorForTab(int number)
        {
            var tb = new TextBox();
            tb.Multiline = true;
            tb.Font = new Font("Consolas", 11);
            tb.BackColor = System.Drawing.Color.FromArgb(12, 12, 12);
            tb.ForeColor = System.Drawing.Color.FromArgb(200, 200, 255);
            tb.BorderStyle = BorderStyle.None;
            tb.Text = number == 1 ? "print(\"Hello World\")" : ""; // örnek baþlangýç
                                                                   // Ýstersen satýr numarasý ve syntax highlighter ek
            return tb;
        }

        private void SelectTab(int number)
        {
            if (!tabs.ContainsKey(number)) return;

            // önce hepsini kapat / buton stillerini resetle
            foreach (var kv in tabs.Values)
            {
                kv.ContentPanel.Visible = false;
                kv.Button.FillColor = System.Drawing.Color.FromArgb(40, 40, 40);
                kv.Button.ForeColor = System.Drawing.Color.White;
            }

            // seçiliyi aç
            var t = tabs[number];
            t.ContentPanel.Visible = true;
            t.Button.FillColor = System.Drawing.Color.FromArgb(200, 40, 40); // seçili renklendirme (kýrmýzý ton)
            t.Button.ForeColor = System.Drawing.Color.White;

            selectedTabNumber = number;
        }

        private void RenameTab(int number)
        {
            if (!tabs.ContainsKey(number)) return;
            var t = tabs[number];

            string oldName = t.Button.Text;
            string input = Microsoft.VisualBasic.Interaction.InputBox("Yeni sekme adý:", "Rename Tab", oldName);
            if (!string.IsNullOrWhiteSpace(input))
            {
                t.Button.Text = input;
            }
        }

        private void CloseTab(int number)
        {
            if (!tabs.ContainsKey(number)) return;
            var t = tabs[number];

            // sadece content kapat, butonu silme? Kullanýmýna göre
            t.ContentPanel.Visible = false;
            t.Button.FillColor = System.Drawing.Color.FromArgb(40, 40, 40);
            if (selectedTabNumber == number) selectedTabNumber = -1;
        }

        private void DeleteTab(int number)
        {
            if (!tabs.ContainsKey(number)) return;
            var t = tabs[number];

            // Eðer sadece tek tab kaldý izin verme (opsiyonel)
            if (tabs.Count == 1)
            {
                MessageBox.Show("En az bir sekme olmalý.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Controls'dan kaldýr
            if (t.Button.Parent != null) t.Button.Parent.Controls.Remove(t.Button);
            if (t.ContentPanel.Parent != null) t.ContentPanel.Parent.Controls.Remove(t.ContentPanel);

            // Dispose
            t.Button.Dispose();
            t.ContentPanel.Dispose();
            if (t.EditorControl != null) t.EditorControl.Dispose();

            tabs.Remove(number);

            // Eðer silinen seçiliydi, bir baþka tablo seç
            if (selectedTabNumber == number)
            {
                var any = tabs.Keys.OrderBy(x => x).First();
                SelectTab(any);
            }
        }

        private void ExecuteCurrentTab()
        {
            if (selectedTabNumber == -1) return;
            if (!tabs.ContainsKey(selectedTabNumber)) return;

            var editor = tabs[selectedTabNumber].EditorControl;
            string script = "";

            if (editor is TextBox tb) script = tb.Text;
            else
            {
                // Eðer WebView2 veya Editor ise onun metodu ile text al
                // script = GetTextFromYourEditor(editor);
            }

            // send script to clients / ya da kendi Execute fonksiyonunu çaðýr
            ExecuteScriptOnClients(script); // Form1'de zaten tanýmlý fonksiyonsa kullan
        }

        */


        private void TabButton_Click(object sender, EventArgs e)
        {

        }




        private void Tabs_Click(object sender, EventArgs e)
        {

        }

        private void Tabs_MouseDown(object sender, MouseEventArgs e)
        {



        }

        private void Tab_Click(object sender, EventArgs e)
        {

        }

        private void Tab_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnInject_Click(object sender, EventArgs e)
        {

        }

        private async Task siticoneButtonAdvanced1_ClickAsync(object sender, EventArgs e)
        {

        }

        private void siticoneButtonAdvanced2_Click(object sender, EventArgs e)
        {
            label1.Text = "Attaching to target process...";
            Attach();
        }

        private void siticoneButtonAdvanced1_Click(object sender, EventArgs e)
        {
            var clients = GetAllClients();
            Form2 fr2 = new Form2(clients);
            fr2.Show();
        }



        private async void siticoneButtonAdvanced3_Click(object sender, EventArgs e)
        {
            string scriptToExecute = await Editor.ExecuteScriptAsync("GetText();");
            string rawScript = JsonConvert.DeserializeObject<string>(scriptToExecute);
            string trimmedScript = rawScript.Trim();
            double scriptLength = trimmedScript.Length;
            if (scriptLength == 0)
            {
                System.Windows.MessageBox.Show("Script is empty.", "Empty Script", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Warning);
                return;
            }
            string script = JsonConvert.DeserializeAnonymousType<string>(scriptToExecute, rawScript);
            ExecuteScriptOnClients(script);
        }

        private void siticoneButtonAdvanced4_Click(object sender, EventArgs e)
        {
            DialogResult result = (DialogResult)System.Windows.MessageBox.Show(
            "Do you want to exit Cmmdx with Xeno?",
            "Exit ?!?!??!?!??",
            (MessageBoxButton)MessageBoxButtons.YesNo,
            (MessageBoxImage)MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {

            }
        }
    }
}



