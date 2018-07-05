namespace ForMatter
{
    partial class formatter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formatter));
            this.label1 = new System.Windows.Forms.Label();
            this.offsetval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sizeval = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statecap = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dump = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.length_cap = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OFFSET:";
            // 
            // offsetval
            // 
            this.offsetval.Enabled = false;
            this.offsetval.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.offsetval.Location = new System.Drawing.Point(96, 98);
            this.offsetval.MaxLength = 7;
            this.offsetval.Name = "offsetval";
            this.offsetval.Size = new System.Drawing.Size(70, 21);
            this.offsetval.TabIndex = 1;
            this.offsetval.Text = "0";
            this.offsetval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.offsetval.TextChanged += new System.EventHandler(this.offsetval_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SIZE:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sizeval
            // 
            this.sizeval.Enabled = false;
            this.sizeval.Location = new System.Drawing.Point(233, 98);
            this.sizeval.MaxLength = 7;
            this.sizeval.Name = "sizeval";
            this.sizeval.Size = new System.Drawing.Size(70, 21);
            this.sizeval.TabIndex = 3;
            this.sizeval.Text = "16";
            this.sizeval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sizeval.TextChanged += new System.EventHandler(this.sizeval_TextChanged);
            this.sizeval.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sizeval_KeyDown);
            this.sizeval.Validating += new System.ComponentModel.CancelEventHandler(this.sizeval_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OPEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statecap
            // 
            this.statecap.Location = new System.Drawing.Point(2, 38);
            this.statecap.Name = "statecap";
            this.statecap.Size = new System.Drawing.Size(350, 34);
            this.statecap.TabIndex = 5;
            this.statecap.Text = "File: <File not loaded>";
            this.statecap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statecap.UseCompatibleTextRendering = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = resources.GetString("openFileDialog1.Filter");
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = resources.GetString("saveFileDialog1.Filter");
            // 
            // dump
            // 
            this.dump.CausesValidation = false;
            this.dump.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dump.Enabled = false;
            this.dump.HideSelection = false;
            this.dump.Location = new System.Drawing.Point(25, 157);
            this.dump.MaxLength = 48;
            this.dump.Multiline = true;
            this.dump.Name = "dump";
            this.dump.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dump.Size = new System.Drawing.Size(310, 107);
            this.dump.TabIndex = 6;
            this.dump.CursorChanged += new System.EventHandler(this.dump_CursorChanged);
            this.dump.TextChanged += new System.EventHandler(this.dump_TextChanged);
            this.dump.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dump_KeyDown);
            this.dump.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dump_KeyPress);
            this.dump.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dump_KeyUp);
            this.dump.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dump_MouseDown);
            this.dump.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dump_PreviewKeyDown);
            this.dump.Validating += new System.ComponentModel.CancelEventHandler(this.dump_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "FRAME SIGNATURE:";
            // 
            // savebtn
            // 
            this.savebtn.Enabled = false;
            this.savebtn.Location = new System.Drawing.Point(25, 298);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(310, 23);
            this.savebtn.TabIndex = 8;
            this.savebtn.Text = "SAVE";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Input bytes separated by comma";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // length_cap
            // 
            this.length_cap.AutoSize = true;
            this.length_cap.Location = new System.Drawing.Point(112, 72);
            this.length_cap.Name = "length_cap";
            this.length_cap.Size = new System.Drawing.Size(133, 13);
            this.length_cap.TabIndex = 11;
            this.length_cap.Text = "Length: <File not loaded>";
            this.length_cap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // err
            // 
            this.err.Location = new System.Drawing.Point(25, 267);
            this.err.Name = "err";
            this.err.Size = new System.Drawing.Size(310, 28);
            this.err.TabIndex = 12;
            // 
            // formatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 333);
            this.Controls.Add(this.err);
            this.Controls.Add(this.length_cap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dump);
            this.Controls.Add(this.statecap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sizeval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.offsetval);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formatter";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ForMatter v0.1 (C) sirbytealot";
            this.Load += new System.EventHandler(this.ForM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox offsetval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sizeval;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label statecap;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox dump;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label length_cap;
        private System.Windows.Forms.Label err;
    }
}

