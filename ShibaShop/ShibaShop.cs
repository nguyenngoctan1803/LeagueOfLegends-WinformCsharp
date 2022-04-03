using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Media;
using System.IO;
using System.Diagnostics;



namespace ShibaShop
{

    public partial class ShibaShop : Form
    {
        DataTable lol = new DataTable();
        public ShibaShop()
        {
            InitializeComponent();
            lol.Columns.Add("Skin", typeof(string));
            lol.Columns.Add("Gia", typeof(string));
            lol.Columns.Add("GioHang", typeof(Boolean));
            lol.Columns.Add("NgayMua", typeof(DateTime));

        }

       
        private void ShibaShop_Load(object sender, EventArgs e)
        {
            string path = "D:\\C#\\shiba_C#\\musiclol.wav";
            playSound(path);
            lol.Rows.Add("YASUO CHÂN LONG KIẾM", "10300",false, null );
            lol.Rows.Add("YASUO HUYỄN LONG KIẾM", "10300",false, null);
            lol.Rows.Add("YASUO HOA LINH LỤC ĐỊA", "6300",false,null);
            lol.Rows.Add("YASUO MA KIẾM", "4800",false, null);
            lol.Rows.Add("YASUO CAO BỒI", "3400",false, null);
            lol.Rows.Add("YASUO TRUE DAMAGE", "3400",false, null);
            lol.Rows.Add("YONE HỌC VIỆN CHIẾN BINH", "6300",false, null);
            lol.Rows.Add("YONE THẦN KIẾM", "7800",false, null);
            lol.Rows.Add("YONE TẢ ẢNH SONG KIẾM", "4800",false, null);
            lol.Rows.Add("ZED QUÁN QUÂN", "4800",false, null);
            lol.Rows.Add("ZED LÔI KIẾM", "4800",false, "15/1/2021");
            lol.Rows.Add("ZED SIÊU PHẨM", "10300",false, "15/2/2021");
            lol.Rows.Add("ZED HUNG THẦN KHÔNG GIAN", "6300",false, "15/3/2021");
            lol.Rows.Add("LEESIN TUYỆT VÔ THẦN", "6300",false, null);
            lol.Rows.Add("LEESIN QUYỀN THÁI", "3400", false, null);
            lol.Rows.Add("LEESIN NỘ LONG CƯỚC", "7800",false, null);
            lol.Rows.Add("LEESIN MA SỨ", "4800",false, null);           
        }

        
        private void playSound(string path)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = path;
            player.Load();       
            player.PlayLooping();           
        }
        private void SoundClick()
        {
            string pat = "D:\\C#\\shiba_C#\\clickbutton.wav";
            SoundPlayer vov = new SoundPlayer();
            vov.SoundLocation = pat;
            vov.Load();
            vov.Play();
        }
        private void SoundClose()
        {
            string pat = "D:\\C#\\shiba_C#\\closebutton.wav";
            SoundPlayer vov = new SoundPlayer();
            vov.SoundLocation = pat;
            vov.Load();
            vov.Play();
        }
        private void SoundChangeSkin()
        {
            string pat = "D:\\C#\\shiba_C#\\changeskin.wav";
            SoundPlayer vov = new SoundPlayer();
            vov.SoundLocation = pat;
            vov.Load();
            vov.Play();
        }
        private void SoundChangeChamp()
        {
            string pat = "D:\\C#\\shiba_C#\\changechamp.wav";
            SoundPlayer vov = new SoundPlayer();
            vov.SoundLocation = pat;
            vov.Load();
            vov.Play();
        }
        private void SoundBuySkin()
        {
            string pat = "D:\\C#\\shiba_C#\\buyskin.wav";
            SoundPlayer vov = new SoundPlayer();
            vov.SoundLocation = pat;
            vov.Load();
            vov.Play();
        }

        int result = 0;
        int flag = 0;
        string chose = "yasuo";
        string skin = "YASUO CHÂN LONG KIẾM";

        private void Next_picture(object sender, EventArgs e)
        {
            SoundChangeSkin();
            
            if(chose =="yasuo")
            {
                switch(result)
                {
                    case 0:
                        picture_leftt.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = picture_rightt.BackgroundImage;
                        picture_rightt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_makiem;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "YASUO HUYỄN LONG KIẾM";
                        result = 1;
                        break;
                    case 1:
                        picture_leftt.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = picture_rightt.BackgroundImage;
                        picture_rightt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_caoboi;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "YASUO HOA LINH LỤC ĐỊA";
                        result = 2;
                        break;
                    case 2:
                        picture_leftt.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = picture_rightt.BackgroundImage;
                        picture_rightt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_truedame;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "YASUO MA KIẾM";
                        result = 3;
                        break;
                    case 3:
                        picture_leftt.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = picture_rightt.BackgroundImage;
                        picture_rightt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_chanlong;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "YASUO CAO BỒI";
                        result = 4;
                        break;
                    case 4:
                        picture_leftt.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = picture_rightt.BackgroundImage;
                        picture_rightt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_huyenlong;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "YASUO TRUE DAMAGE";
                        result = 5;
                        break;
                    case 5:
                        picture_leftt.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = picture_rightt.BackgroundImage;
                        picture_rightt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_linhhoa;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "YASUO CHÂN LONG KIẾM";
                        result = 0;
                        break;
                }
                
               
            }
            else if (chose == "yone")
            {
                switch (result)
                {
                    case 0:
                        picture_chose_left.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.yone_taanhsongkiem;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "YONE THẦN KIẾM";
                        result = 1;
                        break;
                    case 1:
                        picture_chose_left.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.yone_chienbinh;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "YONE TẢ ẢNH SONG KIẾM";
                        result = 2;
                        break;
                    case 2:
                        picture_chose_left.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.yone_thankiem;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "YONE HỌC VIỆN CHIẾN BINH";
                        result = 0;
                        break;
                    
                }
            }

           
            else if(chose =="zed")
            {
                switch (result)
                {
                    case 0:
                        picture_chose_left.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.zed_sieupham;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "ZED LÔI KIẾM";
                        result = 1;
                        break;
                    case 1:
                        picture_chose_left.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.zed_hungthan;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "ZED SIÊU PHẨM";
                        result = 2;
                        break;
                    case 2:
                        picture_chose_left.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.Zed_quanquan;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "ZED HUNG THẦN KHÔNG GIAN";
                        result = 3;
                        break;
                    case 3:
                        picture_chose_left.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.zed_loikiem;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "ZED QUÁN QUÂN";
                        result = 0;
                        break;
                }
            }
          
            else if(chose =="leesin")
            {
                switch (result)
                {
                    case 0:
                        picture_chose_left.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_nolongcuoc;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "LEESIN QUYỀN THÁI";
                        result = 1;
                        break;
                    case 1:
                        picture_chose_left.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_fpx;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "LEESIN NỘ LONG CƯỚC";
                        result = 2;
                        break;
                    case 2:
                        picture_chose_left.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_tuyetvothan;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "LEESIN MA SỨ";
                        result = 3;
                        break;
                    case 3:
                        picture_chose_left.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_moaythai;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "LEESIN TUYỆT VÔ THẦN";
                        result = 0;
                        break;
                }
            }


            


        }

        private void Undo_picture(object sender, EventArgs e)
        {
            SoundChangeSkin();
            
            if (chose == "yasuo")
            {
                switch (result)
                {
                    case 0:
                        picture_rightt.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = picture_leftt.BackgroundImage;                       
                        picture_leftt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_makiem;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "YASUO TRUE DAMAGE";
                        result = 5;
                        break;
                    case 1:
                        picture_rightt.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = picture_leftt.BackgroundImage;
                        picture_leftt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_caoboi;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "YASUO CHÂN LONG KIẾM";
                        result = 0;
                        break;
                    case 2:
                        picture_rightt.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = picture_leftt.BackgroundImage;
                        picture_leftt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_truedame;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "YASUO HUYỄN LONG KIẾM";
                        result = 1;
                        break;
                    case 3:
                        picture_rightt.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = picture_leftt.BackgroundImage;
                        picture_leftt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_chanlong;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "YASUO HOA LINH LỤC ĐỊA";
                        result = 2;
                        break;
                    case 4:
                        picture_rightt.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = picture_leftt.BackgroundImage;
                        picture_leftt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_huyenlong;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "YASUO MA KIẾM";
                        result = 3;
                        break;
                    case 5:
                        picture_rightt.BackgroundImage = picture_chose_right.BackgroundImage;
                        picture_chose_right.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = picture_leftt.BackgroundImage;
                        picture_leftt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_linhhoa;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "YASUO CAO BỒI";
                        result = 4;
                        break;
                }

            }
            else if (chose == "yone")
            {
                switch (result)
                {
                    case 0:
                        picture_chose_right.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.yone_thankiem;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "YONE TẢ ẢNH SONG KIẾM";
                        result = 2;
                        break;
                    case 1:
                        picture_chose_right.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.yone_taanhsongkiem;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "YONE HỌC VIỆN CHIẾN BINH";
                        result = 0;
                        break;
                    case 2:
                        picture_chose_right.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.yone_chienbinh;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "YONE THẦN KIẾM";
                        result = 1;
                        break;

                }
            }


            else if (chose == "zed")
            {
                switch (result)
                {
                    case 0:
                        picture_chose_right.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.zed_sieupham;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "ZED HUNG THẦN KHÔNG GIAN";
                        result = 3;
                        break;
                    case 1:
                        picture_chose_right.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.zed_hungthan;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "ZED QUÁN QUÂN";
                        result = 0;
                        break;
                    case 2:
                        picture_chose_right.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.Zed_quanquan;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "ZED LÔI KIẾM";
                        result = 1;
                        break;
                    case 3:
                        picture_chose_right.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.zed_loikiem;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "ZED SIÊU PHẨM";
                        result = 2;
                        break;
                }
            }

            else if (chose == "leesin")
            {
                switch (result)
                {
                    case 0:
                        picture_chose_right.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_nolongcuoc;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "LEESIN MA SỨ";
                        result = 3;
                        break;
                    case 1:
                        picture_chose_right.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_fpx;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "LEESIN TUYỆT VÔ THẦN";
                        result = 0;
                        break;
                    case 2:
                        picture_chose_right.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_tuyetvothan;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "LEESIN QUYỀN THÁI";
                        result = 1;
                        break;
                    case 3:
                        picture_chose_right.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_chose_show.BackgroundImage = picture_chose_left.BackgroundImage;
                        picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_moaythai;
                        picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                        picture_max.Text = "LEESIN NỘ LONG CƯỚC";
                        result = 2;
                        break;
                }
            }
        }

        private void picture_0_Click(object sender, EventArgs e)
        {
            SoundClick();
        }
        void champion_chosed(string t)
        {           
            if (t == "yone")
            {
                chose = "yone";
                picture_max.Text = "YONE HỌC VIỆN CHIẾN BINH";
                picture_max.BackgroundImage = global::ShibaShop.Properties.Resources.yone_chienbinh;
                picture_chose_show.BackgroundImage = picture_max.BackgroundImage;
                picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.yone_taanhsongkiem;
                picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.yone_thankiem;
                               
            }
            else if (t == "yasuo") 
            {
                picture_max.Text = "YASUO CHÂN LONG KIẾM";
                picture_max.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_chanlong;
                picture_chose_show.BackgroundImage = picture_max.BackgroundImage;
                picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_truedame;
                picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_huyenlong;
                picture_leftt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_caoboi;
                picture_rightt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_linhhoa;
                

            }
            else if (t == "zed")
            {
                picture_max.Text = "ZED QUÁN QUÂN";
                picture_max.BackgroundImage = global::ShibaShop.Properties.Resources.Zed_quanquan;
                picture_chose_show.BackgroundImage = picture_max.BackgroundImage;
                picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.zed_hungthan;
                picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.zed_loikiem;
               
            }
            else if (t == "leesin")
            {
                chose = "leesin";
                picture_max.Text = "LEESIN TUYỆT VÔ THẦN";
                picture_max.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_tuyetvothan;
                picture_chose_show.BackgroundImage = picture_max.BackgroundImage;
                picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_fpx;
                picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_moaythai;
               
            }
        }
        private void chose_yasuo(string yasuo)
        {
            if(yasuo=="yasuo")
            {
                picture_leftt.Visible = true;
                picture_rightt.Visible = true;
                not_yasuo_left.Visible = false;
                not_yasuo_right.Visible = false;
                next_button.Visible = true;
                undo_button.Visible = true;
            }
            else
            {
                picture_leftt.Visible = false; 
                picture_rightt.Visible = false; 
                not_yasuo_left.Visible = true;
                not_yasuo_right.Visible = true;
                next_button.Visible = false;
                undo_button.Visible = false;
            }
        }
        private void picture_1_Click(object sender, EventArgs e)
        {
            SoundChangeChamp();
            result = 0;
            timer_left.Interval = 1;
            timer_left.Start();
            chose = picture_1.Text;
            chose_yasuo(chose);
            champion_chosed(chose);
            picture_0.FlatAppearance.BorderColor = Color.Yellow;

            switch (flag)
            {
                case 0:
                    picture_2.BackgroundImage = picture_0.BackgroundImage;
                    picture_2.Text = picture_0.Text;
                    picture_0.BackgroundImage = picture_1.BackgroundImage;
                    picture_0.Text = picture_1.Text;
                    picture_1.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_tuyetvothan;
                    picture_1.Text = "leesin";
                    flag = 3;
                    break;
                case 1:

                    picture_2.BackgroundImage = picture_0.BackgroundImage;
                    picture_2.Text = picture_0.Text;
                    picture_0.BackgroundImage = picture_1.BackgroundImage;
                    picture_0.Text = picture_1.Text;
                    picture_1.BackgroundImage = global::ShibaShop.Properties.Resources.yone_chienbinh;
                    picture_1.Text = "yone";
                    flag = 0;
                    break;
                case 2:

                    picture_2.BackgroundImage = picture_0.BackgroundImage;
                    picture_2.Text = picture_0.Text;
                    picture_0.BackgroundImage = picture_1.BackgroundImage;
                    picture_0.Text = picture_1.Text;
                    picture_1.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_chanlong;
                    picture_1.Text = "yasuo";
                    flag = 1;
                    break;
                case 3:
                    picture_2.BackgroundImage = picture_0.BackgroundImage;
                    picture_2.Text = picture_0.Text;
                    picture_0.BackgroundImage = picture_1.BackgroundImage;
                    picture_0.Text = picture_1.Text;
                    picture_1.BackgroundImage = global::ShibaShop.Properties.Resources.Zed_quanquan;
                    picture_1.Text = "zed";
                    flag = 2;
                    break;
            }

            arrow.Visible = false;
        }

        private void picture_2_Click(object sender, EventArgs e)
        {
            SoundChangeChamp();
            result = 0;
            timer_left.Interval = 1;
            timer_left.Start();
            chose = picture_2.Text;
            chose_yasuo(chose);
            champion_chosed(chose);
            picture_0.FlatAppearance.BorderColor = Color.Yellow;

            switch (flag)
            {
                case 0:
                    picture_1.BackgroundImage = picture_0.BackgroundImage;
                    picture_1.Text = picture_0.Text;
                    picture_0.BackgroundImage = picture_2.BackgroundImage;
                    picture_0.Text = picture_2.Text;
                    picture_2.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_tuyetvothan;
                    picture_2.Text = "leesin";
                    flag = 1;
                    break;
                case 1:
                    picture_1.BackgroundImage = picture_0.BackgroundImage;
                    picture_1.Text = picture_0.Text;
                    picture_0.BackgroundImage = picture_2.BackgroundImage;
                    picture_0.Text = picture_2.Text;
                    picture_2.BackgroundImage = global::ShibaShop.Properties.Resources.yone_chienbinh;
                    picture_2.Text = "yone";
                    flag = 2;
                    break;
                case 2:
                    picture_1.BackgroundImage = picture_0.BackgroundImage;
                    picture_1.Text = picture_0.Text;
                    picture_0.BackgroundImage = picture_2.BackgroundImage;
                    picture_0.Text = picture_2.Text;
                    picture_2.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_chanlong;
                    picture_2.Text = "yasuo";
                    flag = 3;
                    break;
                case 3:
                    picture_1.BackgroundImage = picture_0.BackgroundImage;
                    picture_1.Text = picture_0.Text;
                    picture_0.BackgroundImage = picture_2.BackgroundImage;
                    picture_0.Text = picture_2.Text;
                    picture_2.BackgroundImage = global::ShibaShop.Properties.Resources.Zed_quanquan;
                    picture_2.Text = "zed";
                    flag = 0;
                    break;

            }
        
            arrow.Visible = false;

        }

        int move = 0;
        private void Picture_run(object sender, EventArgs e)
        {
            if(move<10)
            {
                picture_0.Left += 5;
            }
            else
            {

                timer_left.Stop();
                picture_0.FlatAppearance.BorderColor = Color.DodgerBlue;
                move = 0;
                timer_top.Interval = 1;
                timer_top.Start();
            }
            move += 1;
        }
        private void picture_out(object sender, EventArgs e)
        {
            if (move < 10)
            {
                picture_0.Left -= 5;
                
            }
            else
            {
                timer_top.Stop();
                arrow.Visible = true;
                move = 0;
            }
            move += 1;
        }


        string ytUrl;
        Boolean play = true;
        public string Videoid
        {
            get
            {
                var ytmatch = new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)").Match(ytUrl);
                return ytmatch.Success ? ytmatch.Groups[1].Value : string.Empty;
            }
        }  
        private void play_button_Click(object sender, EventArgs e)
        {
            SoundClose();
            if(play)
            {
                if (picture_max.Text == "YASUO CHÂN LONG KIẾM")
                {
                    ytUrl = "https://youtu.be/X-UFgwX8R0c";
                }
                else if (picture_max.Text == "YASUO HUYỄN LONG KIẾM")
                {
                    ytUrl = "https://youtu.be/u6LKM03ZJm0";
                }

                else if (picture_max.Text=="YASUO HOA LINH LỤC ĐỊA")
                {
                    ytUrl = "https://youtu.be/PBmh_LcdNGU";
                }
                else if(picture_max.Text == "YASUO MA KIẾM")
                {
                    ytUrl = "https://youtu.be/69uXNoB5iV8";
                }
                else if(picture_max.Text == "YASUO CAO BỒI")
                {
                    ytUrl = "https://youtu.be/i78jQE8MLLA";
                }
                else if (picture_max.Text == "YASUO TRUE DAMAGE")
                {
                    ytUrl = "https://youtu.be/w0a6rMbGRnk";
                }
                else if (picture_max.Text == "YONE HỌC VIỆN CHIẾN BINH")
                {
                    ytUrl = "https://youtu.be/WygR25LZpkQ";
                }
                else if (picture_max.Text == "YONE THẦN KIẾM")
                {
                    ytUrl = "https://youtu.be/tiujs0KWecM";
                }
                else if (picture_max.Text == "YONE TẢ ẢNH SONG KIẾM")
                {
                    ytUrl = "https://youtu.be/_BPfvYyDLWM";
                }
                else if (picture_max.Text == "ZED QUÁN QUÂN")
                {
                    ytUrl = "https://youtu.be/hxC0xlSLHSw";
                }
                else if (picture_max.Text == "ZED LÔI KIẾM")
                {
                    ytUrl = "https://youtu.be/ak9f5j-Itkg";
                }
                else if (picture_max.Text == "ZED SIÊU PHẨM")
                {
                    ytUrl = "https://youtu.be/SVyYEwjK9oE";
                }
                else if (picture_max.Text == "ZED HUNG THẦN KHÔNG GIAN")
                {
                    ytUrl = "https://youtu.be/lXLsP26vn18";
                }
                else if (picture_max.Text == "LEESIN TUYỆT VÔ THẦN")
                {
                    ytUrl = "https://youtu.be/pGP0ODn-C60";
                }
                else if (picture_max.Text == "LEESIN QUYỀN THÁI")
                {
                    ytUrl = "https://youtu.be/7pBm07jRoF0";
                }
                else if (picture_max.Text == "LEESIN NỘ LONG CƯỚC")
                {
                    ytUrl = "https://youtu.be/VS4bi0KW3tA";
                }
                else if (picture_max.Text == "LEESIN MA SỨ")
                {
                    ytUrl = "https://youtu.be/doxV5OTgSkg";
                }
                
                youtube.Visible = true;
                youtube.Navigate($"http://youtube.com/v/{Videoid}?version=3");
                play_button.BackgroundImage = global::ShibaShop.Properties.Resources.cancel;
                play = false;
                champ_panel.Visible = false;
                skin_onechamp_panel.Visible = false;
                lock_unlock_button.Visible = false;
            }
            else
            {
                youtube.Url=null;
                youtube.Visible = false;
                play = true;
                play_button.BackgroundImage = global::ShibaShop.Properties.Resources.play1;
                champ_panel.Visible = true;
                skin_onechamp_panel.Visible = true;
                lock_unlock_button.Visible = true;
            }
            
        }

        private void Mua(object sender, EventArgs e)
        {
            SoundClick();
        }
        
        private void logo_Click(object sender, EventArgs e)
        {
            SoundClick();
            bag.BackColor = Color.Transparent;
            account.BackColor = Color.Transparent;
            giohang.BackColor = Color.Transparent;

            home_panel.Visible = true;
            Giohang_panel.Visible = false;
            Bag_panel.Visible = false;
            account_panel.Visible = false;

            if (picture_max.Visible == false)
            {
                an_hien_while_muaskin();
            }
           
        }

        private void account_Click(object sender, EventArgs e)
        {
            SoundClick();
            bag.BackColor = Color.Transparent;
            account.BackColor = Color.DarkOliveGreen;
            giohang.BackColor = Color.Transparent;

            account_panel.Visible = true;
            home_panel.Visible = false;
            Bag_panel.Visible = false;
            Giohang_panel.Visible = false;
        }

       

        private void bag_Click(object sender, EventArgs e)
        {
            SoundClick();
            bag.BackColor = Color.DarkOliveGreen;
            account.BackColor = Color.Transparent;
            giohang.BackColor = Color.Transparent;

            Bag_panel.Visible = true;
            Giohang_panel.Visible = false;
            home_panel.Visible = false;
            account_panel.Visible = false;

            table_mokhoa.Controls.Clear();
            foreach (DataRow x in lol.Rows)
            {
                if (Convert.ToString(x["NgayMua"]) != "")
                {
                    skin = x["Skin"].ToString();
                    Button b = new Button();
                    b.Click += button_bag_click;
                    b.Width = 1000; b.Height = 215;
                    b.FlatStyle = FlatStyle.Standard;
                    b.TextAlign = ContentAlignment.BottomCenter;
                    b.Font = new Font("Tahoma", 10, FontStyle.Bold);
                    b.ForeColor = Color.Yellow;
                    b.BackgroundImageLayout = ImageLayout.Stretch;
                    add_button_2(b, skin);
                    table_mokhoa.Controls.Add(b);
                }
            }
            skin_sohuu.Text = table_mokhoa.Controls.Count + "\nTRANG PHỤC\nĐÃ SỞ HỮU";
        }

        private void shop_Click(object sender, EventArgs e)
        {
            SoundClick();

            bag.BackColor = Color.Transparent;
            account.BackColor = Color.Transparent;
            giohang.BackColor = Color.DarkOliveGreen;

            Giohang_panel.Visible = true;
            Bag_panel.Visible = false;
            home_panel.Visible = false;
            account_panel.Visible = false;

            table_giohang.Controls.Clear();
            foreach(DataRow x in lol.Rows)
            {
                if(Convert.ToBoolean(x["GioHang"])==true)
                {
                    skin = x["Skin"].ToString();
                    Button b = new Button();
                    b.Click += button_added_giohang_click;
                    b.Width = 1000; b.Height = 215;
                    b.FlatStyle = FlatStyle.Standard;
                    b.TextAlign = ContentAlignment.BottomCenter;
                    b.Font = new Font("Tahoma", 10, FontStyle.Bold);
                    b.ForeColor = Color.Yellow;
                    b.BackgroundImageLayout = ImageLayout.Stretch;
                    add_button_2(b, skin);
                    table_giohang.Controls.Add(b);

                }
            }
            giohang_dathem.Text = table_giohang.Controls.Count + "\nTRANG PHỤC\nĐÃ THÊM";

        }

        private void lock_unlock_Click(object sender, EventArgs e)
        {         
            SoundClick();
            picture_buy.BackgroundImage = picture_max.BackgroundImage;
            picture_buy.Text = picture_max.Text;
            DataRow[] gt = lol.Select("Skin= '" + picture_buy.Text + "'");

            if (Convert.ToBoolean(gt[0]["GioHang"]) == true || Convert.ToString(gt[0]["NgayMua"]) != "") 
            {
                add_giohang_button.ForeColor = Color.Olive;
                add_giohang_button.Enabled = false;
            }
            else
            {
                add_giohang_button.ForeColor = Color.Yellow;
                add_giohang_button.Enabled = true;
            }
            if (gt[0]["NgayMua"].ToString() != "")
            {
                button_gia.Text = "ĐÃ MỞ KHÓA";
                kdth.Visible = false;
                button_gia.Image = null;
                button_gia.Enabled = false;
                
            }
            else
            {
                button_gia.Text = gt[0]["Gia"].ToString();
                button_gia.Image = global::ShibaShop.Properties.Resources.tinhhoamini;
                int gia = Int32.Parse(button_gia.Text);
                int money = Int32.Parse(tinhhoa.Text);
                if (gia <= money)
                {
                    button_gia.ForeColor = Color.Yellow;
                    button_gia.Enabled = true;
                    kdth.Visible = false;
                }
                else
                {
                    button_gia.ForeColor = Color.Olive;
                    button_gia.Enabled = false;
                    kdth.Visible = true;
                }
            }


           
            an_hien_while_muaskin();

        }
        private void close_buy_panel_click(object sender, EventArgs e)
        {
            SoundClose();
            an_hien_while_muaskin();
            lock_unlock_change(sender, e);
        }
        private void close_buy_giohang_click(object sender, EventArgs e)
        {
            SoundClose();

            table_giohang.Visible = true;
            giohang_mini_panel.Visible = false;
            
        }


        Button btt = new Button();
        private void button_added_giohang_click(object sender,EventArgs e)
        {
            SoundClick();
            
            giohang_mini_panel.Visible = true;
            table_giohang.Visible = false;
            btt = (Button)sender;
            picture_buy_giohang.BackgroundImage = btt.BackgroundImage;
            picture_buy_giohang.Text = btt.Text;
            DataRow[] gt = lol.Select("Skin= '" + picture_buy_giohang.Text + "'");
                      
            if (gt[0]["NgayMua"].ToString() != "")
            {
                button_gia_giohang.Text = "ĐÃ MỞ KHÓA";
                kdth1.Visible = false;
                button_gia_giohang.Image = null;
                button_gia_giohang.Enabled = false;
            }
            else
            {
                button_gia_giohang.Text = gt[0]["Gia"].ToString();
                button_gia_giohang.Image = global::ShibaShop.Properties.Resources.tinhhoamini;
                int gia = Int32.Parse(button_gia_giohang.Text);
                int money = Int32.Parse(tinhhoa.Text);
                if (gia <= money)
                {
                    button_gia_giohang.ForeColor = Color.Yellow;
                    button_gia_giohang.Enabled = true;
                    kdth1.Visible = false;
                }
                else
                {
                    button_gia_giohang.ForeColor = Color.Olive;
                    button_gia_giohang.Enabled = false;
                    kdth1.Visible = true;
                }
               
            }

        }

        private void an_hien_while_muaskin()
        {
            
            if(home_mini_panel.Visible==false)
            {
                home_panel.Hide();
                lock_unlock_button.Visible = false;
                home_mini_panel.Visible = true;
                picture_max.Visible = false;               
                skin_onechamp_panel.Visible = false;
                champ_panel.Visible = false;
                play_button.Visible = false;
                home_panel.Show();
            }
            else
            {
                home_panel.Hide();
                lock_unlock_button.Visible = true;
                home_mini_panel.Visible = false;              
                picture_max.Visible = true;              
                skin_onechamp_panel.Visible = true;
                champ_panel.Visible = true;
                play_button.Visible = true;
                home_panel.Show();
            }
            
        }
        

        int mk = 0;
        int gh = 0;
        Button[] ctrl_gh = new Button[20];
        Button[] ctrl_mk = new Button[20];

       
        private void themvaogiohang(object sender, EventArgs e)
        {
            SoundClose();
            DataRow[] giohang = lol.Select("Skin='" + picture_buy.Text + "' ");            
            giohang[0]["GioHang"] = true;
            skin = picture_buy.Text;
            Button b = new Button();                      
            b.Click += button_added_giohang_click;
            b.Width = 1000; b.Height = 215;
            b.FlatStyle = FlatStyle.Standard;
            b.TextAlign = ContentAlignment.BottomCenter;
            b.Font = new Font("Tahoma", 10, FontStyle.Bold);
            //size word
            
            b.ForeColor = Color.Yellow;
            b.BackgroundImageLayout = ImageLayout.Stretch;
            
            add_button_2(b, skin);
            ctrl_gh[gh] = b;
            gh += 1;
            edit_tablepanel(gh,mk);

            
            an_hien_while_muaskin();
      

        }

        //chia bảng(thêm cột,hàng)
        private void edit_tablepanel(int x,int y)
        {

            if (x == 10||x==13||x==16)
            {
                table_giohang.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / 3));
                table_giohang.RowCount = table_giohang.RowStyles.Count;
                table_giohang.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / 3));
                table_giohang.ColumnCount = table_giohang.ColumnStyles.Count;
                
            }

            if(y==10||y==13||y==16)
            {
                table_mokhoa.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / 3));
                table_mokhoa.RowCount = table_mokhoa.RowStyles.Count;
                table_mokhoa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / 3));
                table_mokhoa.ColumnCount = table_mokhoa.ColumnStyles.Count;
            }

        }

        int omg = 0;
        private void unlock_skin(object sender, EventArgs e)
        {
            SoundBuySkin();
            DataRow[] buyskin = new DataRow[0]; 
            if (home_panel.Visible==true)
            {
                buyskin = lol.Select("Skin='" + picture_buy.Text + "' ");
                skin = picture_buy.Text;
                omg = 0;

            }
            else if(Giohang_panel.Visible==true)
            {
                buyskin = lol.Select("Skin='" + picture_buy_giohang.Text + "' ");
                skin = picture_buy_giohang.Text;
                gh -= 1;
                omg = 1;
            }

            
            DateTime d = DateTime.Now;
            buyskin[0]["NgayMua"] = d;
            buyskin[0]["GioHang"] = false;
            int tien_cl = Int32.Parse(tinhhoa.Text);
            int tien_skin = Int32.Parse(buyskin[0]["Gia"].ToString());
            tien_cl = tien_cl - tien_skin;
            tinhhoa.Text = tien_cl.ToString();
           
            Button b = new Button();
            b.Click += button_bag_click;
            b.Width = 1000; b.Height = 215;
            b.FlatStyle = FlatStyle.Standard;
            b.TextAlign = ContentAlignment.BottomCenter;
            b.Font = new Font("Tahoma", 10, FontStyle.Bold);
            b.ForeColor = Color.Yellow;
            b.BackgroundImageLayout = ImageLayout.Stretch;

            
                
            add_button_2(b,skin);
            ctrl_mk[mk] = b;
            mk += 1;
            edit_tablepanel(gh, mk);          
          

           
            lock_unlock_change(sender, e);          
            close_buy_giohang_click(sender, e);
            an_hien_while_muaskin();
            shop_Click(sender, e);
            if(omg==0)
            {
                logo_Click(sender, e);
            }
            SoundBuySkin();
      
        }
        private void delete_click(object sender, EventArgs e)
        {
            DataRow[] del = lol.Select("Skin='" + picture_buy_giohang.Text + "' ");
            del[0]["GioHang"] = false;
            close_buy_giohang_click(sender, e);
            shop_Click(sender, e);
            SoundClose();
        }

        private void button_bag_click(object sender, EventArgs e)
        {
            SoundClick();
            Button btn = (Button)sender;
            picture_bag.BackgroundImage = btn.BackgroundImage;
            picture_bag.Text = btn.Text;
            panel_mini_bag.Visible = true;
            bag_show_panel.Visible = false;

        }
        private void close_mini_bagg(object sender, EventArgs e)
        {
            SoundClose();
            panel_mini_bag.Visible = false;
            bag_show_panel.Visible = true;
        }
        private void add_button_2(Button b, string s)
        {
            switch (s)
            {
                case "YASUO CHÂN LONG KIẾM":
                    b.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_chanlong;
                    b.Text = s;
                    break;
                case "YASUO HUYỄN LONG KIẾM":
                    b.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_huyenlong;
                    b.Text = s;
                    break;
                case "YASUO HOA LINH LỤC ĐỊA":
                    b.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_linhhoa;
                    b.Text = s;
                    break;
                case "YASUO MA KIẾM":
                    b.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_makiem;
                    b.Text = s;
                    break;
                case "YASUO CAO BỒI":
                    b.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_caoboi;
                    b.Text = s;
                    break;
                case "YASUO TRUE DAMAGE":
                    b.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_truedame;
                    b.Text = s;
                    break;
                case "YONE HỌC VIỆN CHIẾN BINH":
                    b.BackgroundImage = global::ShibaShop.Properties.Resources.yone_chienbinh;
                    b.Text = s;
                    break;
                case "YONE THẦN KIẾM":
                    b.BackgroundImage = global::ShibaShop.Properties.Resources.yone_thankiem;
                    b.Text = s;
                    break;
                case "YONE TẢ ẢNH SONG KIẾM":
                    b.BackgroundImage = global::ShibaShop.Properties.Resources.yone_taanhsongkiem;
                    b.Text = s;
                    break;
                case "ZED QUÁN QUÂN":
                    b.BackgroundImage = global::ShibaShop.Properties.Resources.Zed_quanquan;
                    b.Text = s;
                    break;
                case "ZED LÔI KIẾM":
                    b.BackgroundImage = global::ShibaShop.Properties.Resources.zed_loikiem;
                    b.Text = s;
                    break;
                case "ZED SIÊU PHẨM":
                    b.BackgroundImage = global::ShibaShop.Properties.Resources.zed_sieupham;
                    b.Text = s;
                    break;
                case "ZED HUNG THẦN KHÔNG GIAN":
                    b.BackgroundImage = global::ShibaShop.Properties.Resources.zed_hungthan;
                    b.Text = s;
                    break;
                case "LEESIN TUYỆT VÔ THẦN":
                    b.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_tuyetvothan;
                    b.Text = s;
                    break;
                case "LEESIN QUYỀN THÁI":
                    b.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_moaythai;
                    b.Text = s;
                    break;
                case "LEESIN NỘ LONG CƯỚC":
                    b.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_nolongcuoc;
                    b.Text = s;
                    break;
                case "LEESIN MA SỨ":
                    b.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_fpx;
                    b.Text = s;
                    break;

            }
        }
        

        private void lock_unlock_change(object sender, EventArgs e)
        {
            DataRow[] ys = lol.Select("Skin='" + picture_max.Text + "'");
            if (Convert.ToString(ys[0]["NgayMua"]) != "") 
            {
                lock_unlock_button.BackgroundImage = global::ShibaShop.Properties.Resources.unlock;               
            }
            else
            {
                lock_unlock_button.BackgroundImage = global::ShibaShop.Properties.Resources.padlock1;             
            }
            
        }

        private void Undo_undo_picture(object sender, EventArgs e)
        {
            Undo_picture(sender, e);
            Undo_picture(sender, e);
        }

        private void Next_next_picture(object sender, EventArgs e)
        {
            Next_picture(sender, e);
            Next_picture(sender, e);
        }


        private void day(object sender, EventArgs e)
        {
            table_giohang.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            table_giohang.ColumnCount = table_giohang.ColumnStyles.Count;
        }


        private void suggest_word(object sender, EventArgs e)
        {
            string word = key_word.Text;
            word.Replace(" ", "");
            string[] VietNamChar = new string[]
                {
                    "aAeEoOuUiIdDyY",
                    "áàạảãâấầậẩẫăắằặẳẵ",
                    "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
                    "éèẹẻẽêếềệểễ",
                    "ÉÈẸẺẼÊẾỀỆỂỄ",
                    "óòọỏõôốồộổỗơớờợởỡ",
                    "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
                    "úùụủũưứừựửữ",
                    "ÚÙỤỦŨƯỨỪỰỬỮ",
                    "íìịỉĩ",
                    "ÍÌỊỈĨ",
                    "đ",
                    "Đ",
                    "ýỳỵỷỹ",
                    "ÝỲỴỶỸ"
                };

            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                    word = word.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
            }

            word = word.ToLower();


            if (home_panel.Visible == true) 
            {
               
                if (word.Contains("ya"))
                {
                    suggest_button.Text = "yasuo";
                    if (word.Contains("huyen"))
                    {
                        suggest_button.Text = "yasuo huyễn long kiếm";
                    }
                    else if (word.Contains("chan"))
                    {
                        suggest_button.Text = "yasuo chân long kiếm";
                    }
                    
                    else if (word.Contains("hoa") || word.Contains("linh") || word.Contains("luc") || word.Contains("dia"))
                    {
                        suggest_button.Text = "yasuo hoa linh lục địa";
                    }
                    else if (word.Contains("ma"))
                    {
                        suggest_button.Text = "yasuo ma kiếm";
                    }
                    else if (word.Contains("cao") || word.Contains("boi"))
                    {
                        suggest_button.Text = "yasuo cao bồi";
                    }
                    else if (word.Contains("tru") || word.Contains("dam"))
                    {
                        suggest_button.Text = "yasuo true damage";
                    }

                }
                else if (word.Contains("yo"))
                {
                    suggest_button.Text = "yone";

                    if (word.Contains("chien") || word.Contains("binh") || word.Contains("hoc") || word.Contains("vien"))
                    {
                        suggest_button.Text = "yone học viện chiến binh";
                    }
                    else if (word.Contains("than"))
                    {
                        suggest_button.Text = "yone thần kiếm";
                    }
                    else if (word.Contains("ta") || word.Contains("anh") || word.Contains("song"))
                    {
                        suggest_button.Text = "yone tả ảnh song kiếm";
                    }
                }
                else if (word.Contains("z"))
                {
                    suggest_button.Text = "zed";

                    if (word.Contains("quan"))
                    {
                        suggest_button.Text = "zed quán quân";
                    }
                    else if (word.Contains("loi") || word.Contains("kiem"))
                    {
                        suggest_button.Text = "zed lôi kiếm";
                    }
                    else if (word.Contains("sieu"))
                    {
                        suggest_button.Text = "zed siêu phẩm";
                    }
                    else if (word.Contains("than") || word.Contains("hung") || word.Contains("khong"))
                    {
                        suggest_button.Text = "zed hung thần không gian";
                    }

                }
                else if (word.Contains("le"))
                {
                    suggest_button.Text = "leesin";

                    if (word.Contains("than") || word.Contains("tuyet") || word.Contains("vo"))
                    {
                        suggest_button.Text = "leesin tuyệt vô thần";
                    }
                    else if (word.Contains("quyen") || word.Contains("thai"))
                    {                    
                        suggest_button.Text = "leesin quyền thái";
                    }
                    else if (word.Contains("no") || word.Contains("long") || word.Contains("cuoc"))
                    {
                        suggest_button.Text = "leesin nộ long cước";
                    }
                    else if (word.Contains("ma") || word.Contains("su"))
                    {
                        suggest_button.Text = "leesin ma sứ";
                    }

                }
                else
                {
                    suggest_button.Text = "";
                }
             
            }
        }

        private void edit_word(string w)
        {
            string[] VietNamChar = new string[]
                {
                    "aAeEoOuUiIdDyY",
                    "áàạảãâấầậẩẫăắằặẳẵ",
                    "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
                    "éèẹẻẽêếềệểễ",
                    "ÉÈẸẺẼÊẾỀỆỂỄ",
                    "óòọỏõôốồộổỗơớờợởỡ",
                    "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
                    "úùụủũưứừựửữ",
                    "ÚÙỤỦŨƯỨỪỰỬỮ",
                    "íìịỉĩ",
                    "ÍÌỊỈĨ",
                    "đ",
                    "Đ",
                    "ýỳỵỷỹ",
                    "ÝỲỴỶỸ"
                };

            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                    w = w.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
            }

        }

        private void Search(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                string word = suggest_button.Text;
                key_word.Text = suggest_button.Text;
                suggest_button.Text = "";

                if (word == "yasuo chân long kiếm" || word == "yasuo")
                {
                    flag = 0;
                    result = 0;
                    chose = "yasuo";
                    search_champ(flag, result);
                }
                if (word.Contains("yasuo huyễn long kiếm"))
                {
                    flag = 0;
                    result = 1;
                    chose = "yasuo";
                    search_champ(flag, result);
                }
                if (word.Contains("yasuo hoa linh lục địa"))
                {
                    flag = 0;
                    result = 2;
                    chose = "yasuo";
                    search_champ(flag, result);
                }
                if (word.Contains("yasuo ma kiếm"))
                {
                    flag = 0;
                    result = 3;
                    chose = "yasuo";
                    search_champ(flag, result);
                }
                if (word.Contains("yasuo cao bồi"))
                {
                    flag = 0;
                    result = 4;
                    chose = "yasuo";
                    search_champ(flag, result);
                }
                if (word.Contains("yasuo true damage"))
                {
                    flag = 0;
                    result = 5;
                    chose = "yasuo";
                    search_champ(flag, result);
                }
                if (word.Contains("zed") || word.Contains("zed quán quân"))
                {
                    flag = 1;
                    result = 0;
                    chose = "zed";
                    search_champ(flag, result);
                }
                if (word.Contains("zed lôi kiếm"))
                {
                    flag = 1;
                    result = 1;
                    chose = "zed";
                    search_champ(flag, result);
                }
                if (word.Contains("zed siêu phẩm"))
                {
                    flag = 1;
                    result = 2;
                    chose = "zed";
                    search_champ(flag, result);
                }
                if (word.Contains("zed hung thần không gian"))
                {
              
                    flag = 1;
                    result = 3;
                    chose = "zed";
                    search_champ(flag, result);
                }
                if (word.Contains("leesin") || word.Contains("leesin tuyệt vô thần"))
                {
                   
                    flag = 2;
                    result = 0;
                    chose = "leesin";
                    search_champ(flag, result);
                }
                if (word.Contains("leesin quyền thái"))
                {
                    flag = 2;
                    result = 1;
                    chose = "leesin";
                    search_champ(flag, result);
                }
                if (word.Contains("leesin nộ long cước"))
                {
                    flag = 2;
                    result = 2;
                    chose = "leesin";
                    search_champ(flag, result);
                }
                if (word.Contains("leesin ma sứ"))
                {
                    flag = 2;
                    result = 3;
                    chose = "leesin";
                    search_champ(flag, result);
                }
                if (word.Contains("yone") || word.Contains("yone học viện chiến binh"))
                {
                    flag = 3;
                    result = 0;
                    chose = "yone";
                    search_champ(flag, result);
                }
                if (word.Contains("yone thần kiếm"))
                {
                    flag = 3;
                    result = 1;
                    chose = "yone";
                    search_champ(flag, result);
                }
                if (word.Contains("yone tả ảnh song kiếm"))
                {
                    flag = 3;
                    result = 2;
                    chose = "yone";
                    search_champ(flag, result);
                }

            }

        }

        private void search_button_click(object sender, EventArgs e)
        {
            string ww = suggest_button.Text;
            key_word.Text = suggest_button.Text;
            suggest_button.Text = "";
            if (ww.Contains("yasuo") || ww.Contains("yasuo chân long kiếm"))
            {
                flag = 0;
                result = 0;
                chose = "yasuo";
                search_champ(flag, result);
            }
            if (ww.Contains("yasuo huyễn long kiếm"))
            {
                flag = 0;
                result = 1;
                chose = "yasuo";
                search_champ(flag, result);
            }
            if (ww.Contains("yasuo hoa linh lục địa"))
            {
                flag = 0;
                result = 2;
                chose = "yasuo";
                search_champ(flag, result);
            }
            if (ww.Contains("yasuo ma kiếm"))
            {
                flag = 0;
                result = 3;
                chose = "yasuo";
                search_champ(flag, result);
            }
            if (ww.Contains("yasuo cao bồi"))
            {
                flag = 0;
                result = 4;
                chose = "yasuo";
                search_champ(flag, result);
            }
            if (ww.Contains("yasuo true damage"))
            {
                flag = 0;
                result = 5;
                chose = "yasuo";
                search_champ(flag, result);
            }
            if (ww.Contains("zed") || ww.Contains("zed quán quân"))
            {
                flag = 1;
                result = 0;
                chose = "zed";
                search_champ(flag, result);
            }
            if (ww.Contains("zed lôi kiếm"))
            {
                flag = 1;
                result = 1;
                chose = "zed";
                search_champ(flag, result);
            }
            if (ww.Contains("zed siêu phẩm"))
            {
                flag = 1;
                result = 2;
                chose = "zed";
                search_champ(flag, result);
            }
            if (ww.Contains("zed hung thần không gian"))
            {               
                flag = 1;
                result = 3;
                chose = "zed";
                search_champ(flag, result);
            }
            if (ww.Contains("leesin") ||ww.Contains("leesin tuyệt vô thần"))
            {        
                suggest_button.Text = "leesin tuyệt vô thần";
                flag = 2;
                result = 0;
                chose = "leesin";
                search_champ(flag, result);
            }
            if (ww.Contains("leesin quyền thái"))
            {
                flag = 2;
                result = 1;
                chose = "leesin";
                search_champ(flag, result);
            }
            if (ww.Contains("leesin nộ long cước"))
            {
                flag = 2;
                result = 2;
                chose = "leesin";
                search_champ(flag, result);
            }
            if (ww.Contains("leesin ma sứ"))
            {
                flag = 2;
                result = 3;
                chose = "leesin";
                search_champ(flag, result);
            }
            if (ww.Contains("yone") || ww.Contains("yone học viện chiến binh"))
            {
                flag = 3;
                result = 0;
                chose = "yone";
                search_champ(flag, result);
            }
            if (ww.Contains("yone thần kiếm"))
            {
                flag = 3;
                result = 1;
                chose = "yone";
                search_champ(flag, result);
            }
            if (ww.Contains("yone tả ảnh song kiếm"))
            {
                flag = 3;
                result = 2;
                chose = "yone";
                search_champ(flag, result);
            }
        }

        private void search_champ(int x,int y)
        {
            switch(x)
            {
                case 0:
                    picture_0.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_chanlong;                  
                    picture_1.BackgroundImage = global::ShibaShop.Properties.Resources.yone_chienbinh;
                    picture_2.BackgroundImage = global::ShibaShop.Properties.Resources.Zed_quanquan;
                    picture_0.Text = "yasuo";
                    picture_1.Text = "yone";
                    picture_2.Text = "zed";
                    chose_yasuo("yasuo");
                    switch(y)
                    {
                        case 0:
                            picture_leftt.BackgroundImage=global::ShibaShop.Properties.Resources.yasuo_caoboi;
                            picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_truedame;
                            picture_chose_show.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_chanlong;
                            picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_huyenlong;
                            picture_rightt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_linhhoa;
                            picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                            picture_max.Text = "YASUO CHÂN LONG KIẾM";
                            break;
                        case 1:
                            picture_leftt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_truedame;
                            picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_chanlong;
                            picture_chose_show.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_huyenlong;
                            picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_linhhoa;
                            picture_rightt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_makiem;
                            picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                            picture_max.Text = "YASUO HUYỄN LONG KIẾM";
                            break;
                        case 2:
                            picture_leftt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_chanlong;
                            picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_huyenlong;
                            picture_chose_show.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_linhhoa;
                            picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_makiem;
                            picture_rightt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_caoboi;
                            picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                            picture_max.Text = "YASUO HOA LINH LỤC ĐỊA";
                            break;
                        case 3:
                            picture_leftt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_huyenlong;
                            picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_linhhoa;
                            picture_chose_show.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_makiem;
                            picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_caoboi;
                            picture_rightt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_truedame;
                            picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                            picture_max.Text = "YASUO MA KIẾM";
                            break;
                        case 4:
                            picture_leftt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_linhhoa;
                            picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_makiem;
                            picture_chose_show.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_caoboi;
                            picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_truedame;
                            picture_rightt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_chanlong;
                            picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                            picture_max.Text = "YASUO CAO BỒI";
                            break;
                        case 5:
                            picture_leftt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_makiem;
                            picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_caoboi;
                            picture_chose_show.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_truedame;
                            picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_chanlong;
                            picture_rightt.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_huyenlong;
                            picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                            picture_max.Text = "YASUO TRUE DAMAGE";
                            break;
                    }
                    break;
                case 1:
                    picture_0.BackgroundImage = global::ShibaShop.Properties.Resources.Zed_quanquan;
                    picture_1.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_chanlong;
                    picture_2.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_tuyetvothan;
                    picture_0.Text = "zed";
                    picture_1.Text = "yasuo";
                    picture_2.Text = "leesin";
                    chose_yasuo("zed");
                    switch (y)
                    {
                        case 0:                        
                            picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.zed_hungthan;
                            picture_chose_show.BackgroundImage = global::ShibaShop.Properties.Resources.Zed_quanquan;
                            picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.zed_loikiem;
                            picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                            picture_max.Text = "ZED QUÁN QUÂN";
                            break;
                        case 1:
                            picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.Zed_quanquan;
                            picture_chose_show.BackgroundImage = global::ShibaShop.Properties.Resources.zed_loikiem;
                            picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.zed_sieupham;
                            picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                            picture_max.Text = "ZED LÔI KIẾM";
                            break;
                        case 2:
                            picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.zed_loikiem;
                            picture_chose_show.BackgroundImage = global::ShibaShop.Properties.Resources.zed_sieupham;
                            picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.zed_hungthan;
                            picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                            picture_max.Text = "ZED SIÊU PHẨM";
                            break;
                        case 3:
                            picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.zed_sieupham;
                            picture_chose_show.BackgroundImage = global::ShibaShop.Properties.Resources.zed_hungthan;
                            picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.Zed_quanquan;
                            picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                            picture_max.Text = "ZED HUNG THẦN KHÔNG GIAN";
                            break;
                    }
                    break;
                case 2:
                    picture_0.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_tuyetvothan;
                    picture_1.BackgroundImage = global::ShibaShop.Properties.Resources.Zed_quanquan;
                    picture_2.BackgroundImage = global::ShibaShop.Properties.Resources.yone_chienbinh;
                    picture_0.Text = "leesin";
                    picture_1.Text = "zed";
                    picture_2.Text = "yone";
                    chose_yasuo("leesin");
                    switch (y)
                    {
                        case 0:
                            picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_fpx;
                            picture_chose_show.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_tuyetvothan;
                            picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_moaythai;
                            picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                            picture_max.Text = "LEESIN TUYỆT VÔ THẦN";
                            break;
                        case 1:
                            picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_tuyetvothan;
                            picture_chose_show.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_moaythai;
                            picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_nolongcuoc;
                            picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                            picture_max.Text = "LEESIN QUYỀN THÁI";
                            break;
                        case 2:
                            picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_moaythai;
                            picture_chose_show.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_nolongcuoc;
                            picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_fpx;
                            picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                            picture_max.Text = "LEESIN NỘ LONG CƯỚC";
                            break;
                        case 3:
                            picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_nolongcuoc;
                            picture_chose_show.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_fpx;
                            picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_tuyetvothan;
                            picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                            picture_max.Text = "LEESIN MA SỨ";
                            break;
                    }
                    break;
                case 3:
                    picture_0.BackgroundImage = global::ShibaShop.Properties.Resources.yone_chienbinh;
                    picture_1.BackgroundImage = global::ShibaShop.Properties.Resources.leesin_tuyetvothan;
                    picture_2.BackgroundImage = global::ShibaShop.Properties.Resources.yasuo_chanlong;
                    picture_0.Text = "yone";
                    picture_1.Text = "leesin";
                    picture_2.Text = "yasuo";
                    chose_yasuo("yone");
                    switch (y)
                    {
                        case 0:
                            picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.yone_taanhsongkiem;
                            picture_chose_show.BackgroundImage = global::ShibaShop.Properties.Resources.yone_chienbinh;
                            picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.yone_thankiem;
                            picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                            picture_max.Text = "YONE HỌC VIỆN CHIẾN BINH";
                            break;
                        case 1:
                            picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.yone_chienbinh;
                            picture_chose_show.BackgroundImage = global::ShibaShop.Properties.Resources.yone_thankiem;
                            picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.yone_taanhsongkiem;
                            picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                            picture_max.Text = "YONE THẦN KIẾM";
                            break;
                        case 2:
                            picture_chose_left.BackgroundImage = global::ShibaShop.Properties.Resources.yone_thankiem;
                            picture_chose_show.BackgroundImage = global::ShibaShop.Properties.Resources.yone_taanhsongkiem;
                            picture_chose_right.BackgroundImage = global::ShibaShop.Properties.Resources.yone_chienbinh;
                            picture_max.BackgroundImage = picture_chose_show.BackgroundImage;
                            picture_max.Text = "YONE TẢ ẢNH SONG KIẾM";
                            break;
                    }
                    break;
            }

            
        }


        
        private void thongke_skin(object sender, EventArgs e)
        {
            SoundClose();
            int dd = 0;
            int mm = 0;
            int yy = 0;
            lol.DefaultView.Sort = "NgayMua DESC";
            lol = lol.DefaultView.ToTable();
            table_mokhoa.Controls.Clear();
            if (thongke.SelectedIndex == 1)
            {
                table_mokhoa.Controls.Clear();
                DateTime d = DateTime.Today;      
                foreach (DataRow x in lol.Rows)
                {
                    if(x["NgayMua"].ToString()!="")
                    {
                        DateTime t = Convert.ToDateTime(x["NgayMua"]);
                        if (t.Month == d.Month && t.Year == d.Year)
                        {
                            skin = x["Skin"].ToString();
                            Button b = new Button();
                            b.Width = 1000; b.Height = 215;
                            b.FlatStyle = FlatStyle.Standard;
                            b.TextAlign = ContentAlignment.BottomCenter;
                            b.Font = new Font("Tahoma", 12, FontStyle.Bold);
                            b.ForeColor = Color.Yellow;
                            b.BackgroundImageLayout = ImageLayout.Stretch;

                            add_button_2(b, skin);
                            edit_tablepanel(gh, mm);
                            mm += 1;

                            table_mokhoa.Controls.Add(b);
                        }
                        
                    }
                }
                
                
            }
            else if (thongke.SelectedIndex == 0)
            {
                table_mokhoa.Controls.Clear();
                DateTime d = DateTime.Today;
                foreach (DataRow x in lol.Rows)
                {
                    if (x["NgayMua"].ToString() != "")
                    {
                        DateTime t = Convert.ToDateTime(x["NgayMua"]);
                        if (t.Day == d.Day && t.Month == d.Month && t.Year == d.Year) 
                        {
                            skin = x["Skin"].ToString();
                            Button b = new Button();
                            b.Width = 1000; b.Height = 215;
                            b.FlatStyle = FlatStyle.Standard;
                            b.TextAlign = ContentAlignment.BottomCenter;
                            b.Font = new Font("Tahoma", 12, FontStyle.Bold);
                            b.ForeColor = Color.Yellow;
                            b.BackgroundImageLayout = ImageLayout.Stretch;

                            add_button_2(b, skin);
                            edit_tablepanel(gh, dd);
                            dd += 1;

                            table_mokhoa.Controls.Add(b);
                        }

                    }
                }


            }
            else if (thongke.SelectedIndex == 2)
            {
                table_mokhoa.Controls.Clear();
                DateTime d = DateTime.Today;
                foreach (DataRow x in lol.Rows)
                {
                    if (x["NgayMua"].ToString() != "")
                    {
                        DateTime t = Convert.ToDateTime(x["NgayMua"]);
                        if (t.Year == d.Year)
                        {
                            skin = x["Skin"].ToString();
                            Button b = new Button();
                            b.Width = 1000; b.Height = 215;
                            b.FlatStyle = FlatStyle.Standard;
                            b.TextAlign = ContentAlignment.BottomCenter;
                            b.Font = new Font("Tahoma", 12, FontStyle.Bold);
                            b.ForeColor = Color.Yellow;
                            b.BackgroundImageLayout = ImageLayout.Stretch;

                            add_button_2(b, skin);
                            edit_tablepanel(gh, yy);
                            yy += 1;

                            table_mokhoa.Controls.Add(b);
                        }

                    }
                }

            }
            else if (thongke.SelectedIndex == 3)
            {
                table_mokhoa.Controls.Clear();
                
                foreach (DataRow x in lol.Rows)
                {
                    if (x["NgayMua"].ToString() != "")
                    {
                        skin = x["Skin"].ToString();
                        Button b = new Button();
                        b.Width = 1000; b.Height = 215;
                        b.FlatStyle = FlatStyle.Standard;
                        b.TextAlign = ContentAlignment.BottomCenter;
                        b.Font = new Font("Tahoma", 12, FontStyle.Bold);
                        b.ForeColor = Color.Yellow;
                        b.BackgroundImageLayout = ImageLayout.Stretch;

                        add_button_2(b, skin);
                        edit_tablepanel(gh, yy);
                        yy += 1;

                        table_mokhoa.Controls.Add(b);

                    }
                }

            }
        }
       

        private void change_account(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files(.png; *.jpg; *.jpeg; *.gif; *.bmp)|.png; *.jpg; *.jpeg; *.gif; *.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    avatar.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var browser = new ProcessStartInfo("chrome.exe");
            browser.Arguments = "https://napthe.vn/app/32787/buy/0";
            Process.Start(browser);
        }

        
    }
    
}
