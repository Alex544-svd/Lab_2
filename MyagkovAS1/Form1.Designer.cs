namespace MyagkovAS1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListNet = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SSID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Signal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Crypt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListNet
            // 
            this.ListNet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SSID,
            this.Signal,
            this.Type,
            this.Crypt});
            this.ListNet.HideSelection = false;
            this.ListNet.LargeImageList = this.imageList1;
            this.ListNet.Location = new System.Drawing.Point(12, 12);
            this.ListNet.Name = "ListNet";
            this.ListNet.Size = new System.Drawing.Size(490, 412);
            this.ListNet.SmallImageList = this.imageList1;
            this.ListNet.TabIndex = 0;
            this.ListNet.UseCompatibleStateImageBehavior = false;
            this.ListNet.View = System.Windows.Forms.View.Details;
            this.ListNet.SelectedIndexChanged += new System.EventHandler(this.ListNet_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "WIFI.png");
            // 
            // SSID
            // 
            this.SSID.Text = "SSID";
            this.SSID.Width = 100;
            // 
            // Signal
            // 
            this.Signal.Text = "Качество";
            this.Signal.Width = 100;
            // 
            // Type
            // 
            this.Type.Text = "Тип безопасности";
            this.Type.Width = 121;
            // 
            // Crypt
            // 
            this.Crypt.Text = "Тип шифрования";
            this.Crypt.Width = 100;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(527, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.ListNet);
            this.Name = "Form1";
            this.Text = "Wi-Fi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListNet;
        private System.Windows.Forms.ColumnHeader SSID;
        private System.Windows.Forms.ColumnHeader Signal;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Crypt;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnRefresh;
    }
}

