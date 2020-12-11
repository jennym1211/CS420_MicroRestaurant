// ***********************************************************************
// Assembly         : MicroRestaurantFrontEnd
// Author           : Jennifer
// Created          : 12-09-2020
//
// Last Modified By : Jennifer
// Last Modified On : 12-10-2020
// ***********************************************************************
// <copyright file="Waiter.cs" company="">
//     Copyright ©  2020
// </copyright>
// <summary></summary>
// ***********************************************************************
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

namespace MicroRestaurantFrontEnd
{
    /// <summary>
    /// Class Waiter.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Waiter : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Waiter"/> class.
        /// </summary>
        public Waiter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Invokes the Take Order API action
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

            Uri ur = new Uri("https://localhost:49180/api/Waiter/TakeFoodOrder");

            DateTime time = DateTime.Now;
            string tm = time.ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
            string on = OrderNumber.Text;
            string foodname = FoodName.Text;
            string tn = TableNumber.Text;

            string payload = "{\"orderNumber\":\"" + on + "\",\"name\":" + foodname + ",\"tableNumber\":\"" + tn + "\",\"timeStamp\":\"" + tm + "\"}";

            HttpContent ci = new StringContent(payload, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(ur, ci));
            t.Wait();

            Console.WriteLine(t.Result);
            Console.ReadLine();
            OrderNumber.Text = string.Empty;
            FoodName.Text = string.Empty;
            TableNumber.Text = string.Empty;
        }

        /// <summary>
        /// Invokes the Take Drink Order Action
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void button3_Click(object sender, EventArgs e)
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

            Uri ur = new Uri("https://localhost:49180/api/Waiter/TakeDrinkOrder");

            DateTime time = DateTime.Now;
            string tm = time.ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
            string on = DOrderNum.Text;
            string drinkname = DrinkName.Text;
            string tn = DTableNum.Text;

            string payload = "{\"orderNumber\":\"" + on + "\",\"name\":" + drinkname + ",\"tableNumber\":\"" + tn + "\",\"timeStamp\":\"" + tm + "\"}";

            HttpContent ci = new StringContent(payload, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(ur, ci));
            t.Wait();

            Console.WriteLine(t.Result);
            Console.ReadLine();
            DOrderNum.Text = string.Empty;
            DrinkName.Text = string.Empty;
            DTableNum.Text = string.Empty;
        }

        /// <summary>
        /// Invokes the Tender Check API action
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void button5_Click(object sender, EventArgs e)
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

            Uri ur = new Uri("https://localhost:49180/api/Waiter/TenderCheck");

            DateTime time = DateTime.Now;
            string tm = time.ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
            string ctn = CheckTableNum.Text;

            string payload = "{\"tableNumber\":\"" + ctn + "\",\"paid\":true," + "\",\"timeStamp\":\"" + tm + "\"}";

            HttpContent ci = new StringContent(payload, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(ur, ci));
            t.Wait();

            Console.WriteLine(t.Result);
            Console.ReadLine();
            CheckTableNum.Text = string.Empty;
        }

        /// <summary>
        /// Invokes the DrinkReady API action
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            DrinkOutput.Text = string.Empty;
            var client = new WebClient();
            var output = client.DownloadString("https://localhost:49180/api/Waiter/DrinkReady");
            DrinkOutput.Text += Environment.NewLine + output;
        }

        /// <summary>
        /// Invokes the food ready API action
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void FoodOutBtn_Click(object sender, EventArgs e)
        {
            FoodOutput.Text = string.Empty;
            var client = new WebClient();
            var output = client.DownloadString("https://localhost:49180/api/Waiter/FoodReady");
            FoodOutput.Text += Environment.NewLine + output;
        }

        /// <summary>
        /// Invokes the Ready to Pay method
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ReadyBtn_Click(object sender, EventArgs e)
        {
            ReadyOutput.Text = string.Empty;
            var client = new WebClient();
            var output = client.DownloadString("https://localhost:49180/api/Waiter/ReadyToPay");
            ReadyOutput.Text += Environment.NewLine + output;
        }

        /// <summary>
        /// Returns user to main
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Main main = new Main();
            main.Show();
        }
    }
}