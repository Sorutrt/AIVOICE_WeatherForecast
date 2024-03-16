namespace AIVOICE_WeatherForecast
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWeatherForecast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWeatherForecast
            // 
            this.btnWeatherForecast.Location = new System.Drawing.Point(85, 343);
            this.btnWeatherForecast.Name = "btnWeatherForecast";
            this.btnWeatherForecast.Size = new System.Drawing.Size(75, 23);
            this.btnWeatherForecast.TabIndex = 0;
            this.btnWeatherForecast.Text = "天気予報";
            this.btnWeatherForecast.UseVisualStyleBackColor = true;
            this.btnWeatherForecast.Click += new System.EventHandler(this.btnWeatherForecast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWeatherForecast);
            this.Name = "Form1";
            this.Text = "A.I.VOICE 天気予報";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWeatherForecast;
    }
}

