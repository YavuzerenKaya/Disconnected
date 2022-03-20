
namespace MovingInTable
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.backToFirstButon = new System.Windows.Forms.Button();
            this.goBackButon = new System.Windows.Forms.Button();
            this.goForwardButon = new System.Windows.Forms.Button();
            this.forwardToLastButon = new System.Windows.Forms.Button();
            this.tBox3 = new System.Windows.Forms.TextBox();
            this.tBox1 = new System.Windows.Forms.TextBox();
            this.tBox2 = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // backToFirstButon
            // 
            this.backToFirstButon.Location = new System.Drawing.Point(34, 90);
            this.backToFirstButon.Name = "backToFirstButon";
            this.backToFirstButon.Size = new System.Drawing.Size(75, 23);
            this.backToFirstButon.TabIndex = 0;
            this.backToFirstButon.Text = "|<";
            this.backToFirstButon.UseVisualStyleBackColor = true;
            this.backToFirstButon.Click += new System.EventHandler(this.backToFirstButon_Click);
            // 
            // goBackButon
            // 
            this.goBackButon.Location = new System.Drawing.Point(115, 90);
            this.goBackButon.Name = "goBackButon";
            this.goBackButon.Size = new System.Drawing.Size(75, 23);
            this.goBackButon.TabIndex = 1;
            this.goBackButon.Text = "<<";
            this.goBackButon.UseVisualStyleBackColor = true;
            this.goBackButon.Click += new System.EventHandler(this.goBackButon_Click);
            // 
            // goForwardButon
            // 
            this.goForwardButon.Location = new System.Drawing.Point(196, 90);
            this.goForwardButon.Name = "goForwardButon";
            this.goForwardButon.Size = new System.Drawing.Size(75, 23);
            this.goForwardButon.TabIndex = 2;
            this.goForwardButon.Text = ">>";
            this.goForwardButon.UseVisualStyleBackColor = true;
            this.goForwardButon.Click += new System.EventHandler(this.goForwardButon_Click);
            // 
            // forwardToLastButon
            // 
            this.forwardToLastButon.Location = new System.Drawing.Point(277, 90);
            this.forwardToLastButon.Name = "forwardToLastButon";
            this.forwardToLastButon.Size = new System.Drawing.Size(75, 23);
            this.forwardToLastButon.TabIndex = 3;
            this.forwardToLastButon.Text = ">|";
            this.forwardToLastButon.UseVisualStyleBackColor = true;
            this.forwardToLastButon.Click += new System.EventHandler(this.forwardToLastButon_Click);
            // 
            // tBox3
            // 
            this.tBox3.Location = new System.Drawing.Point(150, 64);
            this.tBox3.Name = "tBox3";
            this.tBox3.Size = new System.Drawing.Size(146, 20);
            this.tBox3.TabIndex = 4;
            // 
            // tBox1
            // 
            this.tBox1.Location = new System.Drawing.Point(150, 12);
            this.tBox1.Name = "tBox1";
            this.tBox1.Size = new System.Drawing.Size(146, 20);
            this.tBox1.TabIndex = 5;
            // 
            // tBox2
            // 
            this.tBox2.Location = new System.Drawing.Point(150, 38);
            this.tBox2.Name = "tBox2";
            this.tBox2.Size = new System.Drawing.Size(146, 20);
            this.tBox2.TabIndex = 6;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(34, 70);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(67, 13);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "Employee ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(34, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(84, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Employee Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(34, 45);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(98, 13);
            this.surnameLabel.TabIndex = 9;
            this.surnameLabel.Text = "Employee Surname";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 143);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.tBox2);
            this.Controls.Add(this.tBox1);
            this.Controls.Add(this.tBox3);
            this.Controls.Add(this.forwardToLastButon);
            this.Controls.Add(this.goForwardButon);
            this.Controls.Add(this.goBackButon);
            this.Controls.Add(this.backToFirstButon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToFirstButon;
        private System.Windows.Forms.Button goBackButon;
        private System.Windows.Forms.Button goForwardButon;
        private System.Windows.Forms.Button forwardToLastButon;
        private System.Windows.Forms.TextBox tBox3;
        private System.Windows.Forms.TextBox tBox1;
        private System.Windows.Forms.TextBox tBox2;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

