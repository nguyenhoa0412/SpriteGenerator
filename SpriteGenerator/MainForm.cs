using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SpriteGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (var i = 0; i < (int)numHorizontalItemCount.Value; i++)
            {
                AddPic();
            }
        }

        private PictureBox AddPic()
        {
            var pic = new PictureBox
                          {
                              Width = (int) numWidth.Value + 2,
                              Height = (int) numHeight.Value + 2,
                              BorderStyle = BorderStyle.FixedSingle,
                              Cursor = Cursors.Hand,
                              Tag = new SpriteItem()
                          };
            pic.Click += pic_Click;
            pic.DoubleClick += pic_DoubleClick;
            pnlItems.Controls.Add(pic);
            return pic;
        }

        void pic_DoubleClick(object sender, EventArgs e)
        {
            btnItemSourceChooser_Click(sender, e);
        }

        private PictureBox _selectedItem;
        void pic_Click(object sender, EventArgs e)
        {
            if (_selectedItem != null)
                _selectedItem.BorderStyle = BorderStyle.FixedSingle;
            
            _selectedItem = (PictureBox) sender;
            if (_selectedItem != null)
                _selectedItem.BorderStyle = BorderStyle.Fixed3D;
            else
                return;

            var spriteItem = _selectedItem.Tag as SpriteItem;
            if (spriteItem == null) return;

            txtItemName.Text = spriteItem.Name;
            txtItemSource.Text = spriteItem.Source;
        }

        private void btnItemSourceChooser_Click(object sender, EventArgs e)
        {
            if (fItemChooser.ShowDialog(this) != DialogResult.OK) return;
            txtItemSource.Text = fItemChooser.FileName;
            var dotIndex = fItemChooser.SafeFileName.LastIndexOf('.');
            txtItemName.Text = fItemChooser.SafeFileName.Substring(0, dotIndex);
            txtItemName_Leave(sender, e);
            txtItemSource_Leave(sender, e);
        }

        private void txtItemName_Leave(object sender, EventArgs e)
        {
            if (_selectedItem == null) return;
            var spriteItem = _selectedItem.Tag as SpriteItem;
            if (spriteItem == null) return;
            spriteItem.Name = txtItemName.Text;
        }

        private void txtItemSource_Leave(object sender, EventArgs e)
        {
            if (_selectedItem == null) return;
            var spriteItem = _selectedItem.Tag as SpriteItem;
            if (spriteItem == null) return;
            spriteItem.Source = txtItemSource.Text;
            _selectedItem.ImageLocation = txtItemSource.Text;
        }

        private void btnOutputFolderChooser_Click(object sender, EventArgs e)
        {
            if (fOutputChooser.ShowDialog(this) != DialogResult.OK) return;
            txtOutputFolder.Text = fOutputChooser.SelectedPath;
        }

        private void numWidth_ValueChanged(object sender, EventArgs e)
        {
            AdjustWidth();
            var width = (int) numWidth.Value + 2;
            foreach (Control pic in pnlItems.Controls)
            {
                pic.Width = width;
            }
        }

        private void numHeight_ValueChanged(object sender, EventArgs e)
        {
            var height = (int)numHeight.Value + 2;
            foreach (Control pic in pnlItems.Controls)
            {
                pic.Height = height;
            }
        }


        private void AdjustWidth()
        {
            var columnCount = (int) numHorizontalItemCount.Value;
            var margin = pnlItems.Controls.Count > 0
                             ? pnlItems.Controls[0].Margin.Left + pnlItems.Controls[0].Margin.Right
                             : 0;
            var panelWidth = pnlItems.Padding.Left + pnlItems.Padding.Right +
                             ((int) numWidth.Value + 2 + margin)* columnCount + 2 +
                             (HasVScrollBar() ? SystemInformation.VerticalScrollBarWidth : 0);
            
            pnlItems.Width = panelWidth;
            Width = panelWidth < 406 ? 454 : panelWidth + 48;
            var addedCount = ((pnlItems.Controls.Count - 1)/columnCount + 1)*columnCount - pnlItems.Controls.Count;

            for (var i = 0; i < addedCount; i++) AddPic();
        }

        private bool HasVScrollBar()
        {
            if (pnlItems.Controls.Count == 0) return false;
            var height = (pnlItems.Controls[0].Margin.Top + pnlItems.Controls[0].Margin.Bottom + (int) numHeight.Value +
                          2)*((pnlItems.Controls.Count - 1)/(int) numHorizontalItemCount.Value + 1) +
                         pnlItems.Padding.Top - pnlItems.Padding.Bottom;
            return height > pnlItems.Height;
        }

        private void numHorizontalItemCount_ValueChanged(object sender, EventArgs e)
        {
            AdjustWidth();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var col = (int) numHorizontalItemCount.Value;
            var w = (int) numWidth.Value;
            var h = (int) numHeight.Value;
            var width = col*w;
            var height = ((pnlItems.Controls.Count - 1) / (int)numHorizontalItemCount.Value + 1) * h;
            var bmp = new Bitmap(width, height);
            var g = Graphics.FromImage(bmp);
            var i = 0;
            var j = 0;
            foreach (PictureBox pic in pnlItems.Controls)
            {
                if (pic.Image != null) g.DrawImage(pic.Image, i * w, j * h, w, h);
                i++;
                if (i >= col)
                {
                    i = 0;
                    j++;
                }
            }
            if (!Directory.Exists(txtOutputFolder.Text + "\\" + txtImagesFolderName.Text + "\\"))
                Directory.CreateDirectory(txtOutputFolder.Text + "\\" + txtImagesFolderName.Text + "\\");
            bmp.Save(txtOutputFolder.Text + "\\" + txtImagesFolderName.Text + "\\" + txtSpriteImageName.Text + ".png", ImageFormat.Png);
            
            File.WriteAllText(txtOutputFolder.Text + "\\" + txtIconClassName.Text + ".less", GenerateLessCode());
            File.WriteAllText(txtOutputFolder.Text + "\\" + txtIconClassName.Text + ".html", GenerateHtmlPreview());
            File.WriteAllText(txtOutputFolder.Text + "\\less.js", less);
        }

        private string GenerateLessCode()
        {
            var w = (int) numWidth.Value;
            var h = (int) numHeight.Value;
            var col = (int) numHorizontalItemCount.Value;

            var sb = new StringBuilder();
            sb.AppendFormat(
                ".{0}{{\r\n\twidth: {1}px;\r\n\theight: {2}px;\r\n\tdisplay: inline-block;\r\n\tbackground: url({3}/{4}.png) transparent no-repeat;\r\n",
                txtIconClassName.Text, w, h, txtImagesFolderName.Text, txtSpriteImageName.Text);

            
            var i = 0;
            var j = 0;
            foreach (Control pic in pnlItems.Controls)
            {
                var name = ((SpriteItem) pic.Tag).Name;
                if (!string.IsNullOrEmpty(name))
                    sb.AppendFormat("\t&.icon-{0}{{background-position: -{1}px -{2}px;}}\r\n", name, i*w, j*h);
                
                i++;
                if (i >= col)
                {
                    i = 0;
                    j++;
                }
            }
            sb.Append("}");
            return sb.ToString();
        }

        private string GenerateHtmlPreview()
        {
            var sb = new StringBuilder();
            sb.AppendFormat(
                "<!doctype html>\r\n<html>\r\n<head>\r\n\t<meta charset='utf-8' />\r\n\t<link rel='stylesheet/less' type='text/css' href='{0}.less'>\r\n\t<script src='less.js' type='text/javascript'></script>\r\n</head>\r\n<body>\r\n",
                txtIconClassName.Text);


            foreach (Control pic in pnlItems.Controls)
            {
                var name = ((SpriteItem)pic.Tag).Name;
                if (!string.IsNullOrEmpty(name))
                    sb.AppendFormat("\t<i class='{0} icon-{1}'></i>\r\n", txtIconClassName.Text, name);
            }
            sb.Append("</body>\r\n</html>");
            return sb.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var data = new SpriteData
                           {
                               ItemWidth = (int)numWidth.Value,
                               ItemHeight = (int)numHeight.Value,
                               ColumnCount = (int)numHorizontalItemCount.Value,
                               OutputFolderName = txtOutputFolder.Text,
                               ImagesFolderName = txtImagesFolderName.Text,
                               IconClassName = txtIconClassName.Text,
                               SpriteImageName = txtSpriteImageName.Text,
                           };
            foreach (Control pic in pnlItems.Controls)
            {
                data.SpriteItems.Add((SpriteItem)pic.Tag);
            }
            var xmlSerializer = new XmlSerializer(data.GetType());
            using (var fs = new FileStream(txtOutputFolder.Text + "\\" + txtIconClassName.Text+".spr", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, data);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var xmlSerializer = new XmlSerializer(typeof(SpriteData));
            using (var fs = new FileStream(txtOutputFolder.Text + "\\" + txtIconClassName.Text + ".spr", FileMode.Open))
            {
                var data = (SpriteData)xmlSerializer.Deserialize(fs);
                numWidth.Value = data.ItemWidth;
                numHeight.Value = data.ItemHeight;
                numHorizontalItemCount.Value = data.ColumnCount;
                txtOutputFolder.Text = data.OutputFolderName;
                txtImagesFolderName.Text = data.ImagesFolderName;
                txtIconClassName.Text = data.IconClassName;
                txtSpriteImageName.Text = data.SpriteImageName;
                pnlItems.Controls.Clear();
                foreach (var spriteItem in data.SpriteItems)
                {
                    var pic = AddPic();
                    pic.Tag = spriteItem;
                    pic.ImageLocation = spriteItem.Source;
                }
            }
        }
    }
}
