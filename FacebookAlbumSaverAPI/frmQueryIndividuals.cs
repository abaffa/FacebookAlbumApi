using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.IO.Compression;
using System.Collections.Specialized;
using System.Net;
using System.Threading;

namespace FacebookAlbumSaverAPI
{
    public partial class frmQueryIndividuals : Form
    {
        public frmQueryIndividuals()
        {
            InitializeComponent();
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://developers.facebook.com/tools/explorer/";
            linkLabel1.Links.Add(link);
            txtAccessToken.Text = FacebookAlbumSaverAPI.Properties.Settings.Default.accessToken;
            txtItemID.Text = FacebookAlbumSaverAPI.Properties.Settings.Default.albumID;
        }

        Hashtable genres = new Hashtable();

        private Dictionary<string, string> convertUrl(string queryString)
        {
            Dictionary<string, string> queryParameters = new Dictionary<string, string>();
            string[] querySegments = queryString.Split('&');
            foreach (string segment in querySegments)
            {
                string[] parts = segment.Split('=');
                if (parts.Length > 0)
                {
                    string key = parts[0].Trim(new char[] { '?', ' ' });
                    string val = parts[1].Trim();
                    if (!key.Equals("access_token"))
                        queryParameters.Add(key, val);
                }
            }

            return queryParameters;
        }



        private void button1_Click(object sender, EventArgs e)
        {


            //var args = FacebookGraphAPI.GetUserFromCookie(Request.Cookies, "YOUR_APP_ID", "YOUR_APP_SECRET");
            String accessToken = txtAccessToken.Text;
            String albumId = txtItemID.Text;


            FacebookGraphAPI facebook = new FacebookGraphAPI(accessToken);//rgs["access_token"]);

            //get my profile
            Dictionary<string, string> args = new Dictionary<string, string>();


            args.Add("limit", "1000");
            //args.Add("access_token", accessToken);

            bool hasNext = true;
            bool save = false;
            String startAt = ""; //"2015-08-02_20-54-12_1900302160195003";

            while (hasNext)
            {

                //var photos = facebook.Request("1827361037489116/photos", args, null);
                var photos = facebook.Request(albumId + "/photos", args, null);
                foreach (var photo in photos["data"])
                {
                    String photoid = (String)photo["id"];
                    String photo_name = (((DateTime)photo["created_time"]).ToString("yyyy-MM-dd_HH-mm-ss")) + "_" + (String)photo["id"];

                    if (!save)
                        if (photo_name == startAt || startAt == "")
                            save = true;

                    if (save)
                        savePhoto(photoid, photo_name);


                }
                hasNext = false;
                if (photos["paging"] != null)
                    if (photos["paging"]["next"] != null)
                    {
                        String next = (String)photos["paging"]["next"];
                        if (next.IndexOf("?") > -1 && next.Length > next.IndexOf("?") + 1)
                            next = next.Substring(next.IndexOf("?") + 1);
                        args = convertUrl(next);
                        hasNext = true;
                    }


            }
        }

        private void savePhoto(string id, string name)
        {
            String url = "http://graph.facebook.com/" + id + "/picture?type=normal";

            if (chkSaveImage.Checked)
            {
                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string folder = System.IO.Path.GetDirectoryName(path) + @"\photos";
                string filename = name + ".jpg";
                ImageUtils.DownloadImage(url, folder, filename);

                if (chkShowPhotos.Checked)
                {
                            pictureBox1.Image = ImageUtils.ResizeImage(ImageUtils.LoadImage(folder, filename), pictureBox1, true);
                }

            }
            else
            {
                if (chkShowPhotos.Checked)
                    pictureBox1.Image = ImageUtils.ResizeImage(ImageUtils.LoadImageFromUrl(url), pictureBox1, true);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
            System.Diagnostics.Process.Start(e.Link.LinkData as string);
        }

        private void txtAccessToken_TextChanged(object sender, EventArgs e)
        {
            FacebookAlbumSaverAPI.Properties.Settings.Default.accessToken = txtAccessToken.Text;
            FacebookAlbumSaverAPI.Properties.Settings.Default.Save();
        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {
            FacebookAlbumSaverAPI.Properties.Settings.Default.albumID = txtItemID.Text;
            FacebookAlbumSaverAPI.Properties.Settings.Default.Save();
        }
    }
}
