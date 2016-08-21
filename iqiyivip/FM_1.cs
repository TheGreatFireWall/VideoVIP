using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iqiyivip
{
    public partial class FM_1 : Form
    {
        public FM_1()
        {
            InitializeComponent();
            xl2.Checked = true;
            checkBox.Checked = true;
        }

        /// <summary>
        /// 打开地址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_url_Click(object sender, EventArgs e)
        {
            if (text_url.Text.Replace(" ", "") == "")
                return;
            if (checkBox.Checked == true)
            {
                FM_watch son = new FM_watch(text_url.Text);
                son.Owner = this;
                son.Show();
            }
            else
                System.Diagnostics.Process.Start(text_url.Text);
        }

        /// <summary>
        /// 检查地址栏
        /// </summary>
        /// <returns></returns>
        private bool check()
        {
            string test = text_url.Text.Replace(" ", "");
            if (videosource(test) == "")
            {
                MessageBox.Show("输入地址不正确或不支持该视频网站");
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// VIP看视频
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_vip_Click(object sender, EventArgs e)
        {
            string url = "";
            if (!check())
                return;
            if (xl1.Checked)
                url = xianlu(1, text_url.Text);
            if (xl2.Checked)
                url = xianlu(2, text_url.Text);
            if (xl3.Checked)
                url = xianlu(3, text_url.Text);
            if (xl4.Checked)
                url = xianlu(4, text_url.Text);
            if (xl5.Checked)
                url = xianlu(5, text_url.Text);
            if (checkBox.Checked == true)
            {
                if (xl1.Checked)
                {
                    MessageBox.Show("该线路不可以在软件中播放");
                    return;
                }
                if (url != "")
                {
                    FM_watch son = new FM_watch(url);
                    son.Owner = this;
                    son.Show();
                }
                else
                    return;
            }
            else
            {
                if (url == "")
                    return;
                System.Diagnostics.Process.Start(url);
            }
        }

        /// <summary>
        /// 说明
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_readme_Click(object sender, EventArgs e)
        {
            FM_readme son = new FM_readme();
            son.Owner = this;
            son.Show();
        }

        /// <summary>
        /// 高级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_senior_Click(object sender, EventArgs e)
        {
            FM_senior son = new FM_senior();
            son.Owner = this;
            son.Show();
        }

        /// <summary>
        /// 直播
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_tv_Click(object sender, EventArgs e)
        {
            string url = "http://tv.bingdou.net/live.html";
            if (checkBox.Checked == true)
            {
                //DialogResult a= MessageBox.Show("直播在软件中首次加载较慢，建议在浏览器中打开\n继续在播放器中打开？", "", 
                //    MessageBoxButtons.YesNo,MessageBoxIcon.None,MessageBoxDefaultButton.Button2);
                //if (a.ToString()=="No")
                //{
                //    return;
                //}
                MessageBox.Show("直播在软件中播放首次加载较慢\n若无法等待加载可在浏览器中打开\n而且，软件中直播换台不太好用……", "注意！");
                FM_watch son = new FM_watch(url);
                son.Owner = this;
                son.Show();
            }
            else
                System.Diagnostics.Process.Start(url);
        }

        /// <summary>
        /// 返回链接所属网站
        /// </summary>
        /// <param name="url"></param>
        /// <returns>string,不支持的网站返回空</returns>
        private string videosource(string url)
        {
            if (url.IndexOf("youku.com") != -1)
                return "youku";
            else if (url.IndexOf("iqiyi.com") != -1)
                return "iqiyi";
            else if (url.IndexOf("tudou.com") != -1)
                return "tudou";
            else if (url.IndexOf("qq.com") != -1)
                return "qq";
            else if (url.IndexOf("mgtv.com") != -1)
                return "mgtv";
            else if (url.IndexOf("letv.com") != -1)
                return "le";
            else if (url.IndexOf("le.com") != -1)
                return "le";
            else
                return "";
        }

        /// <summary>
        /// 线路
        /// </summary>
        /// <param name="num">选择线路号</param>
        /// <param name="url">地址</param>
        /// <returns></returns>
        private string xianlu(int num, string url)
        {
            if (num == 1)   //线路1(爱奇艺)
            {
                if (videosource(url) != "iqiyi")
                {
                    MessageBox.Show("线路1只支持爱奇艺！");
                    return "";
                }
                else
                {
                    url = "http://vip.it666.cc/iqiyi/?url=" + url.Replace("http://", "");
                    return url;
                }
            }
            if (num == 2)   //线路2(通用)
            {
                if (videosource(url) == "qq")
                    url = "http://api.aikantv.cc/qq.php?url=http://" + url.Replace("http://", "");
                else if (videosource(url) == "iqiyi")
                    url = "http://api.aikantv.cc/qiyi.php?url=http://" + url.Replace("http://", "");
                else if (videosource(url) == "mgtv")
                    url = "http://api.aikantv.cc/mgvip.php?url=http://" + url.Replace("http://", "");
                else if (videosource(url) == "le")
                    url = "http://api.aikantv.cc/letv,php?url=http://" + url.Replace("http://", "");
                else if (videosource(url) == "youku")
                    url = "http://api.aikantv.cc/youku.php?url=http://" + url.Replace("http://", "");
                else
                    url = "http://api.aikantv.cc/?url=http://" + url.Replace("http://", "");
                return url;
            }
            if (num == 3)   //线路3(通用)
            {
                url = "http://ckplayer.duapp.com/player.php?url=http://" + url.Replace("http://", "");
                return url;
            }
            if (num == 4)  //线路4(通用)
            {
                url = "http://cs.71ki.com/ydisk/?url=http://" + url.Replace("http://", "");
                return url;
            }
            if (num == 5)  //线路5(的除QQ的解析死了)
            {
                if (videosource(url) == "qq")
                    url = "http://www.avziliao.com/ydisk/qq.php?url=http://" + url.Replace("http://", "");
                else
                {
                    MessageBox.Show("线路5的除QQ的解析死了");
                    return "";
                    //url = "http://www.avziliao.com/ydisk/index.php?url=http://" + url.Replace("http://", "");
                }
                return url;
            }
            else
                return "";
        }
    }
}

//VIP列表
//http://film.qq.com/cover/s/s1oedlknt72vvqt.html
//http://v.qq.com/x/cover/slu2iapi5vnct1z/d002116zz40.html
//http://www.iqiyi.com/v_19rrljceco.html
//http://v.youku.com/v_show/id_XMTY4MzIwMjQ2NA==.html
//http://www.tudou.com/albumplay/dNyv9o4aFto.html
//http://www.mgtv.com/v/3/106652/f/3132209.html vip用券
//http://www.mgtv.com/v/3/158766/f/1775962.html

//万能解析支持以下站点：
//优酷网VIP、乐视网VIP、芒果VIP、奇艺VIP、腾讯VIP、土豆网、哔哩哔哩、AC弹幕网、华数网、酷6网、56网、CNTV网、
//风行网、搜狐视频、糖豆网、微录客、哇趣网、爱拍网、音悦台、优米网、m1905网、秒拍网、美拍网、6房间、网易公开课、
//暴风影音、爆米花、虎牙视频、凤凰视频、龙珠视频、新浪视频、YY神曲等等

//腾讯VIP解析接口 : http://cs.71ki.com/ydisk/qq.php?url=后面加上播放的地址即可
//优酷云解析接口 : http://cs.71ki.com/ydisk/yc.php?vid=后面加上C值即可
//万能解析统一接口 : http://cs.71ki.com/ydisk/?url=后面加上播放的地址即可


//    （8月20日）解析接口更新
//通用解析接口 http://api.aikantv.cc/?url=
//优酷解析接口 http://api.aikantv.cc/youku.php?url=
//优酷云C值解析接口 http://api.aikantv.cc/yc.php?vid=
//新增以下接口
//乐视 http://api.aikantv.cc/letv.php?url=
//芒果 http://api.aikantv.cc/mgvip.php?url=
//奇异 http://api.aikantv.cc/qiyi.php?url=
//腾讯 http://api.aikantv.cc/qq.php?url=
//【其中腾讯的暂时限制了青云志，其他的都可以】

