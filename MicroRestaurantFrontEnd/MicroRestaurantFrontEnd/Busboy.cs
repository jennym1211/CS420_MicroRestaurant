// ***********************************************************************
// Assembly         : MicroRestaurantFrontEnd
// Author           : Jennifer
// Created          : 12-10-2020
//
// Last Modified By : Jennifer
// Last Modified On : 12-10-2020
// ***********************************************************************
// <copyright file="Busboy.cs" company="">
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
    /// Class Busboy.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Busboy : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Busboy"/> class.
        /// </summary>
        public Busboy()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button to invoke the clean table action
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void CleanTable_Click(object sender, EventArgs e)
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

            Uri ur = new Uri("https://localhost:49177/api/BusBoy/CleanTable");

            DateTime time = DateTime.Now;
            string ti = time.ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
            string tn = TableNum.Text;
            string st = SeatCount.Text;

            string payload = "{\"tableNumber\":\"" + tn + "\",\"seatCount\":" + st + ",\"timeStamp\":\"" + ti + "\"}";

            HttpContent ci = new StringContent(payload, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(ur, ci));
            t.Wait();

            Console.WriteLine(t.Result);
            Console.ReadLine();
            TableNum.Text = string.Empty;
            SeatCount.Text = string.Empty;
        }

        /// <summary>
        /// Button for getting the check
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            CheckRetrieveBox.Text = string.Empty;
            var client = new WebClient();
            var output = client.DownloadString("https://localhost:49177/api/BusBoy/GetCheckPaid");
            CheckRetrieveBox.Text += Environment.NewLine + output;
        }

        /// <summary>
        /// The button that returns the user back to the index.
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
        /// Loads the busboy window
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Busboy_Load(object sender, EventArgs e)
        {
        }
    }
}