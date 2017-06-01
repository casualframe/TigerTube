namespace SoundCloudPLAYER
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serachbtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.videoid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.playvideo = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox2 = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // serachbtn
            // 
            this.serachbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serachbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serachbtn.Location = new System.Drawing.Point(956, 32);
            this.serachbtn.Name = "serachbtn";
            this.serachbtn.Size = new System.Drawing.Size(75, 23);
            this.serachbtn.TabIndex = 3;
            this.serachbtn.Text = "Search";
            this.serachbtn.UseVisualStyleBackColor = true;
            this.serachbtn.Click += new System.EventHandler(this.serachbtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(1, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1039, 615);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "\n\n\n\n\n\n\n";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(728, 32);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(212, 23);
            this.materialSingleLineTextField1.TabIndex = 5;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            this.materialSingleLineTextField1.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            this.materialSingleLineTextField1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialSingleLineTextField1_Click);
            // 
            // videoid
            // 
            this.videoid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.videoid.Depth = 0;
            this.videoid.Hint = "";
            this.videoid.Location = new System.Drawing.Point(129, 32);
            this.videoid.MouseState = MaterialSkin.MouseState.HOVER;
            this.videoid.Name = "videoid";
            this.videoid.PasswordChar = '\0';
            this.videoid.SelectedText = "";
            this.videoid.SelectionLength = 0;
            this.videoid.SelectionStart = 0;
            this.videoid.Size = new System.Drawing.Size(212, 23);
            this.videoid.TabIndex = 6;
            this.videoid.Text = "Video ID here";
            this.videoid.UseSystemPasswordChar = false;
            // 
            // playvideo
            // 
            this.playvideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playvideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playvideo.Location = new System.Drawing.Point(347, 32);
            this.playvideo.Name = "playvideo";
            this.playvideo.Size = new System.Drawing.Size(75, 23);
            this.playvideo.TabIndex = 7;
            this.playvideo.Text = "Play";
            this.playvideo.UseVisualStyleBackColor = true;
            this.playvideo.Click += new System.EventHandler(this.playvideo_Click_1);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(222, 148);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(632, 381);
            this.webBrowser1.TabIndex = 8;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.BackColor = System.Drawing.Color.White;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.ForeColor = System.Drawing.Color.Transparent;
            this.materialCheckBox1.Location = new System.Drawing.Point(867, 72);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(164, 30);
            this.materialCheckBox1.TabIndex = 9;
            this.materialCheckBox1.Text = "Show YouTube Player";
            this.materialCheckBox1.UseVisualStyleBackColor = false;
            this.materialCheckBox1.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // materialCheckBox2
            // 
            this.materialCheckBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckBox2.AutoSize = true;
            this.materialCheckBox2.BackColor = System.Drawing.Color.White;
            this.materialCheckBox2.Depth = 0;
            this.materialCheckBox2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox2.ForeColor = System.Drawing.Color.Transparent;
            this.materialCheckBox2.Location = new System.Drawing.Point(867, 113);
            this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox2.Name = "materialCheckBox2";
            this.materialCheckBox2.Ripple = true;
            this.materialCheckBox2.Size = new System.Drawing.Size(159, 30);
            this.materialCheckBox2.TabIndex = 10;
            this.materialCheckBox2.Text = "Stop YouTube Player";
            this.materialCheckBox2.UseVisualStyleBackColor = false;
            this.materialCheckBox2.CheckedChanged += new System.EventHandler(this.materialCheckBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 677);
            this.Controls.Add(this.materialCheckBox2);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.playvideo);
            this.Controls.Add(this.videoid);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.serachbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TigerTube";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button serachbtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField videoid;
        private System.Windows.Forms.Button playvideo;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox2;
    }
}

