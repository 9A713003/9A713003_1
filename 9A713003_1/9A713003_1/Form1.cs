﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Final_report_9A713008
{
    public partial class FM1 : Form
    {
        private object pB1Result;
        public FM1()
        {
            InitializeComponent();
        }
        public class resp
        {
            public List<img> data { get; set; }
        }
        public class img
        {
            public string link { get; set; }
        }
        private resp GetImages(string albumHash, string clientId)
        {
            resp result = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://api.imgur.com/3/album/ELrKOLy/images");
                //Add Header 
                WebHeaderCollection webHeaderCollection = request.Headers;
                webHeaderCollection.Add("Authorization", $"Client-ID {clientId}");

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                string json = readStream.ReadToEnd();

                result = JsonConvert.DeserializeObject<resp>(json);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
            return result;
        }
        private void picture1_Click(object sender, EventArgs e)
        {

        }

        private void buton1_Click(object sender, EventArgs e)
        {
            // 抓API list 出有多少東西
            var m = GetImages("ELrKOLy", "a61e62507733e2b");

            if (m == null)
            {
                return;
            }
            int randomNum = new Random().Next(14);
            string url = m.data[randomNum].link;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream receiveStream = response.GetResponseStream();
            var image = Image.FromStream(receiveStream);

            Console.WriteLine(image.Width);
            picture1.Image = image;
        }


        private void Label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}