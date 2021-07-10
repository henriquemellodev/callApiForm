
namespace ConsumerAPIServices.Forms
{
    partial class CallAPI
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPut = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnGetALL = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(408, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 58);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPut
            // 
            this.btnPut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPut.Location = new System.Drawing.Point(339, 25);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(63, 60);
            this.btnPut.TabIndex = 1;
            this.btnPut.Text = "PUT";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPost.Location = new System.Drawing.Point(266, 27);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(67, 60);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnGetALL
            // 
            this.btnGetALL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGetALL.Location = new System.Drawing.Point(12, 27);
            this.btnGetALL.Name = "btnGetALL";
            this.btnGetALL.Size = new System.Drawing.Size(68, 60);
            this.btnGetALL.TabIndex = 3;
            this.btnGetALL.Text = "GET ALL";
            this.btnGetALL.UseVisualStyleBackColor = true;
            this.btnGetALL.Click += new System.EventHandler(this.btnGetALL_Click);
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGet.Location = new System.Drawing.Point(86, 56);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(84, 31);
            this.btnGet.TabIndex = 4;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(86, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(84, 23);
            this.txtId.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(176, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(84, 23);
            this.txtName.TabIndex = 6;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(176, 56);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(84, 23);
            this.txtJob.TabIndex = 7;
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(12, 113);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(460, 324);
            this.txtResponse.TabIndex = 11;
            this.txtResponse.Text = "";
            // 
            // CallAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnGetALL);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnPut);
            this.Controls.Add(this.btnDelete);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "CallAPI";
            this.Text = "CallAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnGetALL;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.RichTextBox txtResponse;
    }
}