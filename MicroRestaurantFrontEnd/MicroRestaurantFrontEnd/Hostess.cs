using RabbitMQ.Client;
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
    public partial class Hostess : Form
    {
        public Hostess()
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

            Uri u = new Uri("https://localhost:32841/api/Hostess/GetReservation");

            DateTime time = DateTime.Now;
            //string time = "2020-12-03T03:18:08.070Z";

            string foo = time.ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");

            string gc = GuestCount.Text;
            string na = CustomerName.Text;
            string pn = PhoneNumber.Text;

            string payload = "{\"timeStamp\":\"" + foo + "\",\"Guest Count\":" + gc + ",\"Customer Name\":\"" + na + "\",\"Phone Number:\":{\"" + pn + "\":0}}";

            HttpContent c = new StringContent(payload, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(u, c));
            t.Wait();

            Console.WriteLine(t.Result);
            Console.ReadLine();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var factory = new ConnectionFactory() { HostName = "host.docker.internal" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                //channel.BasicAck(data.DeliveryTag, false);

                uint output = channel.MessageCount("reservationfilled");

                CustomerName.Text += Environment.NewLine + output;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}