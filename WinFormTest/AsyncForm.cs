using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class AsyncForm : Form
    {
        Label label;
        Button button;
        public AsyncForm()
        {
            label = new Label { Location = new Point(10, 20), Text = "Length" };
            button = new Button { Location = new Point(10, 50), Text = "Click" };
            button.Click += DisplayWebsiteLength;
            AutoSize = true;
            Controls.Add(label);
            Controls.Add(button);
            //InitializeComponent();
        }

        async void DisplayWebsiteLength(object sender, EventArgs e)
        {
            label.Text = "Fetching...";
            using (HttpClient client = new HttpClient())
            {
                string text = await client.GetStringAsync("http://csharpindepth.com/");
                label.Text = text.Length.ToString();
            }

            Parallel.For(0,2,x=>{ GetLength(); });
        }


        public Task<int> GetLength()
        {
            return new Task<int>(() => { return 1; });           
        }

        public Task GetLength2()
        {
            return new Task(this.SetLength);


        }

        public void SetLength()
        {

        }

    }
}
