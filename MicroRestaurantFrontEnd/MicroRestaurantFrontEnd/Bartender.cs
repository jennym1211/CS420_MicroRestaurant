// ***********************************************************************
// Assembly         : MicroRestaurantFrontEnd
// Author           : Jennifer
// Created          : 12-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 12-10-2020
// ***********************************************************************
// <copyright file="Bartender.cs" company="">
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
    /// Class Bartender.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Bartender : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bartender"/> class.
        /// </summary>
        public Bartender()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns user to main
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void IndexButton_Click(object sender, EventArgs e)
        {
            Hide();
            Main main = new Main();
            main.Show();
        }

        /// <summary>
        /// Invokes the DrinkReady api action
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ServeDrinkButton_Click(object sender, EventArgs e)
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

            Uri ur = new Uri("https://localhost:49209/api/Bartender/DrinkReady");

            DateTime time = DateTime.Now;
            //string time = "2020-12-03T03:18:08.070Z";

            string ti = time.ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");

            string TN = TableNum.Text;
            string ON = OrdNum.Text;
            string DN = DrinkName.Text;

            string payload = "{\"timeStamp\":\"" + ti + "\",\"orderNumber\":" + ON + ",\"tableNumber\":\"" + TN + "\",\"drink\":{\"" + DN + "\":0}}";

            HttpContent ci = new StringContent(payload, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(ur, ci));
            t.Wait();

            Console.WriteLine(t.Result);
            Console.ReadLine();
            TableNum.Text = string.Empty;
            OrdNum.Text = string.Empty;
            DrinkName.Text = string.Empty;
        }

        /// <summary>
        /// Invokes the Get Drink Order API action
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void DOrderBtn_Click(object sender, EventArgs e)
        {
            DrinkOutput.Text = string.Empty;
            var client = new WebClient();
            var output = client.DownloadString("https://localhost:49209/api/Bartender/GetDrinkOrder");
            DrinkOutput.Text += Environment.NewLine + output;
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