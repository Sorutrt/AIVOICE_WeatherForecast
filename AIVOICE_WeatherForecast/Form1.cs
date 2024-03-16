using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http; // HTTPclientクラスを使うんだと思う
using RestSharp;
using AI.Talk.Editor.Api; // AIVOICE api

namespace AIVOICE_WeatherForecast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // クライアント＆リクエストの作成
            var client = new RestClient("https://weather.tsukumijima.net/api/forecast"); //リクエスト先のURL（今回は大阪）
            var request = new RestRequest("/city/270000");
            var response = await client.GetAsync(request);
            // メソッド、パラメータの指定
            request.Method = Method.POST;
            request.AddParameter("パラメータ名", "パラメータの値", ParameterType.GetOrPost);
            // ParameterTypeはいろいろあるが、GETとPOSTで特に指定なく
            // stringパラメータを設定する場合は、GetOrPost


        }
        // "天気予報"ボタンをクリックしたとき
        private void btnWeatherForecast_Click(object sender, EventArgs e)
        {
            // リクエスト送信
            var response = client.Execute(request);
        }
    }

}
