using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListviewExample
{
    public partial class Form1 : Form
    {
        ListView listView1;
        public Form1()
        {
            InitializeComponent();
            listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(0, 0), new Size(350, 250));
            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.CheckBoxes = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = false;
            listView1.Sorting = SortOrder.Ascending;

            ListViewItem item1 = new ListViewItem("auto", 0);
            item1.Checked = true; 
            item1.SubItems.Add("1000000");
            ListViewItem item2 = new ListViewItem("moto", 1);
            item2.Checked = false;
            item2.SubItems.Add("400000");
            ListViewItem item3 = new ListViewItem("velo", 2);
            item3.Checked = true; 
            item3.SubItems.Add("20000");
            ListViewItem item4 = new ListViewItem("house", 3);
            item4.Checked = true;
            item4.SubItems.Add("1500000");
            ListViewItem item5 = new ListViewItem("plane", 4);
            item5.Checked = false; 
            item5.SubItems.Add("20000000");
            listView1.Columns.Add("Name", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("Price", 150, HorizontalAlignment.Center);
            
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4, item5 });
            ImageList imageListSmall = new ImageList();
            imageListSmall.Images.Add(Bitmap.FromFile("auto.jpg"));
            imageListSmall.Images.Add(Bitmap.FromFile("moto.jpg"));
            imageListSmall.Images.Add(Bitmap.FromFile("velo.jpg"));
            imageListSmall.Images.Add(Bitmap.FromFile("dom.jpg"));
            imageListSmall.Images.Add(Bitmap.FromFile("avia.jpg"));
            listView1.SmallImageList = imageListSmall;
            listView1.BackColor = Color.AliceBlue;
            this.Controls.Add(listView1);
            this.Text = "Wish List";
            Width = 350; 
            Height = 250;
                        
        }
    }
}
