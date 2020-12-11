// ***********************************************************************
// Assembly         : MicroRestaurantFrontEnd
// Author           : Jennifer
// Created          : 12-08-2020
//
// Last Modified By : Jennifer
// Last Modified On : 12-10-2020
// ***********************************************************************
// <copyright file="Hostess.cs" company="">
//     Copyright ©  2020
// </copyright>
// <summary></summary>
// ***********************************************************************
using RabbitMQ.Client;
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

namespace MicroRestaurantFrontEnd
{
    /// <summary>
    /// Class Hostess.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// /**Reference Used.
    /// *  Code for pulling JSOn data through a URI referenced at:
    /// *
    /// *
    /// *
    /// *  Reference -&gt; https://carldesouza.com/httpclient-getasync-postasync-sendasync-c/
    /// *
    /// *
    /// *
    /// */

    public partial class Hostess : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Hostess"/> class.
        /// </summary>
        public Hostess()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Invokes the Take Reservation API action
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
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

            Uri u = new Uri("https://localhost:49173/api/Hostess/TakeReservation");

            DateTime time = DateTime.Now;
            //string time = "2020-12-03T03:18:08.070Z";

            string foo = time.ToUniversalTime()
                          .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");

            string gc = GuestCount.Text;
            string na = CustomerName.Text;
            string pn = PhoneNumber.Text;

            string payload = "{\"timeStamp\":\"" + foo + "\",\"guestCount\":" + gc + ",\"name\":\"" + na + "\",\"phoneNumber\":\"" + pn + "\"}";

            HttpContent c = new StringContent(payload, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(u, c));
            t.Wait();

            Console.WriteLine(t.Result);
            Console.ReadLine();
            GuestCount.Text = string.Empty;
            CustomerName.Text = string.Empty;
            PhoneNumber.Text = string.Empty;
        }

        /// <summary>
        /// Texts the box1 text changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Invokes the Get Reservation API action
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            ReservationOutputBox.Text = string.Empty;
            var client = new WebClient();
            var output = client.DownloadString("https://localhost:49173/api/Hostess/GetReservation");
            ReservationOutputBox.Text += Environment.NewLine + output;
        }

        /// <summary>
        /// Texts the box2 text changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Invokes the Table Ready API action
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            ReadyTableOutput.Text = string.Empty;
            var client = new WebClient();
            var output = client.DownloadString("https://localhost:49173/api/Hostess/TableReady");
            ReadyTableOutput.Text += Environment.NewLine + output;
        }

        /// <summary>
        /// Invokes the Seat to Table Action
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void button4_Click(object sender, EventArgs e)
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

            Uri u = new Uri("https://localhost:49173/api/Hostess/SeatToTable");

            DateTime time = DateTime.Now;
            //string time = "2020-12-03T03:18:08.070Z";

            string foo = time.ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");

            string tn = TableNumberSeat.Text;
            string gc = GuestToSeat.Text;

            string payload = "{\"guestCount\":\"" + gc + "\",\"tableNumber\":" + tn + ",\"timeStamp\":\"" + foo + "\"}";

            HttpContent c = new StringContent(payload, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(u, c));
            t.Wait();

            Console.WriteLine(t.Result);
            Console.ReadLine();
            GuestToSeat.Text = string.Empty;
            TableNumberSeat.Text = string.Empty;
        }

        /// <summary>
        /// Returns user to main
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Main main = new Main();
            main.Show();
        }
    }
}