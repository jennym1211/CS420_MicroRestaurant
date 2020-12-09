using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroRestaurantFrontEnd
{
    public partial class Waiter : Form
    {
        public Waiter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            static async Task<string> PostURI(Uri u, HttpContent c)
            {
                var response = string.Empty;
                using (var client = new HttpClient())
                {
                    HttpResponseMessage result = await client.PostAsync(u, c);
                    if (result.IsSuccessStatusCode)
                    {
                        response = result.StatusCode.ToString();
                    }
                }
                return response;
            }

            Uri u = new Uri("https://localhost:32912/api/Waiter/FoodReady");

            DateTime time = DateTime.Now;
            //string time = "2020-12-03T03:18:08.070Z";

            string foo = time.ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");

            string on = OrderNumber.Text;
            string fn = FoodName.Text;
            string tn = TableNumber.Text;

            string payload = "{\"timeStamp\":\"" + foo + "\",\"Order Number\":" + on + ",\"Food Name\":\"" + fn + "\",\"Table Number:\":{\"" + tn + "\":0}}";

            HttpContent c = new StringContent(payload, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(u, c));
            t.Wait();

            Console.WriteLine(t.Result);
            Console.ReadLine();
        }
    }
}