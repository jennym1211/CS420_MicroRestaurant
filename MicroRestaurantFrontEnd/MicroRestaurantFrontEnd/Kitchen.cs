// ***********************************************************************
// Assembly         : MicroRestaurantFrontEnd
// Author           : Jennifer
// Created          : 12-09-2020
//
// Last Modified By : Jennifer
// Last Modified On : 12-10-2020
// ***********************************************************************
// <copyright file="Kitchen.cs" company="">
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
    /**Reference Used.
 *  Code for pulling JSOn data through a URI referenced at:
 *
 *
 *
 *  Reference -> https://carldesouza.com/httpclient-getasync-postasync-sendasync-c/
 *
 *
 *
 */

    /// <summary>
    /// Class Kitchen.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Kitchen : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Kitchen"/> class.
        /// </summary>
        public Kitchen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Label1s the click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void label1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Invokes the Complete Order api actions
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            static async Task<string> PostURI(Uri ur, HttpContent ci)
            {
                var response = string.Empty;
                using (var client = new HttpClient())
                {
                    HttpResponseMessage result = await client.PostAsync(ur, ci);
                    if (result.IsSuccessStatusCode)
                    {
                        response = result.StatusCode.ToString();
                    }
                }
                return response;
            }

            Uri ur = new Uri("https://localhost:49175/api/Kitchen/CompleteOrder");

            DateTime time = DateTime.Now;
            string ti = time.ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
            string on = OrderNumber.Text;
            string tn = TableNumber.Text;
            string fn = FoodName.Text;

            string payload = "{\"orderNumber\":\"" + on + "\",\"tableNumber\":" + tn + ",\"foodName\":\"" + fn + "\",\"foodName\":\"" + ti + "\"}";

            HttpContent ci = new StringContent(payload, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(ur, ci));
            t.Wait();

            Console.WriteLine(t.Result);
            Console.ReadLine();
            OrderNumber.Text = string.Empty;
            TableNumber.Text = string.Empty;
            FoodName.Text = string.Empty;
        }

        /// <summary>
        /// Invokes the get order action
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            OutputTextbox.Text = string.Empty;
            var client = new WebClient();
            var output = client.DownloadString("https://localhost:49175/api/Kitchen/GetOrder");
            OutputTextbox.Text += Environment.NewLine + output;
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