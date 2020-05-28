namespace ShapesDrawing
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateShapesButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.canvas = new System.Windows.Forms.Panel();
            this.SaveShapesButton = new System.Windows.Forms.Button();
            this.LoadShapesButton = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateShapesButton
            // 
            this.CreateShapesButton.Location = new System.Drawing.Point(695, 17);
            this.CreateShapesButton.Name = "CreateShapesButton";
            this.CreateShapesButton.Size = new System.Drawing.Size(100, 30);
            this.CreateShapesButton.TabIndex = 0;
            this.CreateShapesButton.Text = "Создать";
            this.CreateShapesButton.UseVisualStyleBackColor = true;
            this.CreateShapesButton.Click += new System.EventHandler(this.CreateShapesButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.canvas);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox.Size = new System.Drawing.Size(677, 426);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Полотно";
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(8, 19);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(660, 397);
            this.canvas.TabIndex = 2;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            // 
            // SaveShapesButton
            // 
            this.SaveShapesButton.Location = new System.Drawing.Point(695, 53);
            this.SaveShapesButton.Name = "SaveShapesButton";
            this.SaveShapesButton.Size = new System.Drawing.Size(100, 30);
            this.SaveShapesButton.TabIndex = 2;
            this.SaveShapesButton.Text = "Сохранить";
            this.SaveShapesButton.UseVisualStyleBackColor = true;
            this.SaveShapesButton.Click += new System.EventHandler(this.SaveShapesButton_Click);
            // 
            // LoadShapesButton
            // 
            this.LoadShapesButton.Location = new System.Drawing.Point(695, 89);
            this.LoadShapesButton.Name = "LoadShapesButton";
            this.LoadShapesButton.Size = new System.Drawing.Size(100, 30);
            this.LoadShapesButton.TabIndex = 3;
            this.LoadShapesButton.Text = "Загрузить";
            this.LoadShapesButton.UseVisualStyleBackColor = true;
            this.LoadShapesButton.Click += new System.EventHandler(this.LoadShapesButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadShapesButton);
            this.Controls.Add(this.SaveShapesButton);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.CreateShapesButton);
            this.Name = "Main";
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateShapesButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Button SaveShapesButton;
        private System.Windows.Forms.Button LoadShapesButton;
    }
}

