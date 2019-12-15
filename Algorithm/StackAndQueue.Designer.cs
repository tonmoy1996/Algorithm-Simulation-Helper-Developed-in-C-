namespace Algorithm
{
    partial class StackAndQueue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StackAndQueue));
            this.btnQsize = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.QueueListBox = new System.Windows.Forms.ListBox();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.textElement1 = new System.Windows.Forms.TextBox();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.btnSize = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StackListBox = new System.Windows.Forms.ListBox();
            this.btnPop = new System.Windows.Forms.Button();
            this.txtElement = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQsize
            // 
            this.btnQsize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQsize.BackColor = System.Drawing.Color.Purple;
            this.btnQsize.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQsize.ForeColor = System.Drawing.Color.White;
            this.btnQsize.Location = new System.Drawing.Point(446, 545);
            this.btnQsize.Name = "btnQsize";
            this.btnQsize.Size = new System.Drawing.Size(182, 42);
            this.btnQsize.TabIndex = 34;
            this.btnQsize.Text = "Queue Size";
            this.btnQsize.UseVisualStyleBackColor = false;
            this.btnQsize.Click += new System.EventHandler(this.btnQsize_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(95, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Please Enter a value";
            // 
            // QueueListBox
            // 
            this.QueueListBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueueListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QueueListBox.FormattingEnabled = true;
            this.QueueListBox.ItemHeight = 22;
            this.QueueListBox.Location = new System.Drawing.Point(681, 413);
            this.QueueListBox.Name = "QueueListBox";
            this.QueueListBox.Size = new System.Drawing.Size(146, 158);
            this.QueueListBox.TabIndex = 31;
            // 
            // btnDequeue
            // 
            this.btnDequeue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDequeue.BackColor = System.Drawing.Color.Purple;
            this.btnDequeue.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDequeue.ForeColor = System.Drawing.Color.White;
            this.btnDequeue.Location = new System.Drawing.Point(446, 497);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(182, 42);
            this.btnDequeue.TabIndex = 30;
            this.btnDequeue.Text = "Dequeue";
            this.btnDequeue.UseVisualStyleBackColor = false;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // textElement1
            // 
            this.textElement1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textElement1.Location = new System.Drawing.Point(287, 444);
            this.textElement1.Multiline = true;
            this.textElement1.Name = "textElement1";
            this.textElement1.Size = new System.Drawing.Size(79, 42);
            this.textElement1.TabIndex = 28;
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnqueue.BackColor = System.Drawing.Color.Purple;
            this.btnEnqueue.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnqueue.ForeColor = System.Drawing.Color.White;
            this.btnEnqueue.Location = new System.Drawing.Point(446, 432);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(182, 42);
            this.btnEnqueue.TabIndex = 29;
            this.btnEnqueue.Text = "Enqueue";
            this.btnEnqueue.UseVisualStyleBackColor = false;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // btnSize
            // 
            this.btnSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSize.BackColor = System.Drawing.Color.Purple;
            this.btnSize.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSize.ForeColor = System.Drawing.Color.White;
            this.btnSize.Location = new System.Drawing.Point(465, 240);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(182, 42);
            this.btnSize.TabIndex = 26;
            this.btnSize.Text = "Size";
            this.btnSize.UseVisualStyleBackColor = false;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPeek.BackColor = System.Drawing.Color.Purple;
            this.btnPeek.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeek.ForeColor = System.Drawing.Color.White;
            this.btnPeek.Location = new System.Drawing.Point(465, 192);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(182, 42);
            this.btnPeek.TabIndex = 25;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = false;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(55, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Please Enter a value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(369, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "Implementing Queue";
            // 
            // StackListBox
            // 
            this.StackListBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StackListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StackListBox.FormattingEnabled = true;
            this.StackListBox.ItemHeight = 22;
            this.StackListBox.Location = new System.Drawing.Point(691, 111);
            this.StackListBox.Name = "StackListBox";
            this.StackListBox.Size = new System.Drawing.Size(146, 158);
            this.StackListBox.TabIndex = 19;
            // 
            // btnPop
            // 
            this.btnPop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPop.BackColor = System.Drawing.Color.Purple;
            this.btnPop.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPop.ForeColor = System.Drawing.Color.White;
            this.btnPop.Location = new System.Drawing.Point(465, 138);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(182, 42);
            this.btnPop.TabIndex = 18;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = false;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // txtElement
            // 
            this.txtElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElement.Location = new System.Drawing.Point(311, 151);
            this.txtElement.Multiline = true;
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(67, 41);
            this.txtElement.TabIndex = 4;
            // 
            // btnPush
            // 
            this.btnPush.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPush.BackColor = System.Drawing.Color.Purple;
            this.btnPush.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPush.ForeColor = System.Drawing.Color.White;
            this.btnPush.Location = new System.Drawing.Point(465, 76);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(182, 42);
            this.btnPush.TabIndex = 13;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = false;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(324, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Implementing Stacks";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.BackgroundImage = global::Algorithm.Properties.Resources.download_animated_scary_desktop_backgrounds_software_nrg_orb_animated_1543193980;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnQsize);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.QueueListBox);
            this.groupBox1.Controls.Add(this.btnDequeue);
            this.groupBox1.Controls.Add(this.textElement1);
            this.groupBox1.Controls.Add(this.btnEnqueue);
            this.groupBox1.Controls.Add(this.btnSize);
            this.groupBox1.Controls.Add(this.btnPeek);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.StackListBox);
            this.groupBox1.Controls.Add(this.btnPop);
            this.groupBox1.Controls.Add(this.txtElement);
            this.groupBox1.Controls.Add(this.btnPush);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(2, -20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1080, 704);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(29, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 37);
            this.button1.TabIndex = 35;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StackAndQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 631);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StackAndQueue";
            this.Text = "StackAndQueue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StackAndQueue_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQsize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox QueueListBox;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.TextBox textElement1;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox StackListBox;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.TextBox txtElement;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}