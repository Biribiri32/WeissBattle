namespace WeissBattle
{
    partial class Weiss
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
            this.P2_Card_Name = new System.Windows.Forms.TextBox();
            this.P1_Card_Name = new System.Windows.Forms.TextBox();
            this.P1_Card_Power = new System.Windows.Forms.MaskedTextBox();
            this.P2_Card_Power = new System.Windows.Forms.MaskedTextBox();
            this.P1_Group_Box = new System.Windows.Forms.GroupBox();
            this.P2_Group_Box = new System.Windows.Forms.GroupBox();
            this.Fight_Button = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.RichTextBox();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Card_Collection = new System.Windows.Forms.DataGridView();
            this.CardDataSet = new System.Data.DataSet();
            this.P1_Group_Box.SuspendLayout();
            this.P2_Group_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Card_Collection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // P2_Card_Name
            // 
            this.P2_Card_Name.Location = new System.Drawing.Point(20, 29);
            this.P2_Card_Name.Name = "P2_Card_Name";
            this.P2_Card_Name.Size = new System.Drawing.Size(264, 20);
            this.P2_Card_Name.TabIndex = 0;
            this.P2_Card_Name.Text = "<Card Name>";
            this.P2_Card_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // P1_Card_Name
            // 
            this.P1_Card_Name.Location = new System.Drawing.Point(20, 28);
            this.P1_Card_Name.Name = "P1_Card_Name";
            this.P1_Card_Name.Size = new System.Drawing.Size(264, 20);
            this.P1_Card_Name.TabIndex = 1;
            this.P1_Card_Name.Text = "<Card Name>";
            this.P1_Card_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // P1_Card_Power
            // 
            this.P1_Card_Power.Location = new System.Drawing.Point(124, 64);
            this.P1_Card_Power.Mask = "00000";
            this.P1_Card_Power.Name = "P1_Card_Power";
            this.P1_Card_Power.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.P1_Card_Power.Size = new System.Drawing.Size(56, 20);
            this.P1_Card_Power.TabIndex = 6;
            this.P1_Card_Power.Text = "00000";
            this.P1_Card_Power.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // P2_Card_Power
            // 
            this.P2_Card_Power.Location = new System.Drawing.Point(124, 64);
            this.P2_Card_Power.Mask = "00000";
            this.P2_Card_Power.Name = "P2_Card_Power";
            this.P2_Card_Power.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.P2_Card_Power.Size = new System.Drawing.Size(56, 20);
            this.P2_Card_Power.TabIndex = 7;
            this.P2_Card_Power.Text = "00000";
            this.P2_Card_Power.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // P1_Group_Box
            // 
            this.P1_Group_Box.BackColor = System.Drawing.Color.Navy;
            this.P1_Group_Box.Controls.Add(this.P1_Card_Name);
            this.P1_Group_Box.Controls.Add(this.P1_Card_Power);
            this.P1_Group_Box.ForeColor = System.Drawing.Color.White;
            this.P1_Group_Box.Location = new System.Drawing.Point(30, 33);
            this.P1_Group_Box.Name = "P1_Group_Box";
            this.P1_Group_Box.Size = new System.Drawing.Size(302, 102);
            this.P1_Group_Box.TabIndex = 8;
            this.P1_Group_Box.TabStop = false;
            this.P1_Group_Box.Text = "Player 1";
            // 
            // P2_Group_Box
            // 
            this.P2_Group_Box.BackColor = System.Drawing.Color.Maroon;
            this.P2_Group_Box.Controls.Add(this.P2_Card_Power);
            this.P2_Group_Box.Controls.Add(this.P2_Card_Name);
            this.P2_Group_Box.ForeColor = System.Drawing.Color.White;
            this.P2_Group_Box.Location = new System.Drawing.Point(30, 169);
            this.P2_Group_Box.Name = "P2_Group_Box";
            this.P2_Group_Box.Size = new System.Drawing.Size(302, 102);
            this.P2_Group_Box.TabIndex = 9;
            this.P2_Group_Box.TabStop = false;
            this.P2_Group_Box.Text = "Player 2";
            // 
            // Fight_Button
            // 
            this.Fight_Button.Location = new System.Drawing.Point(549, 33);
            this.Fight_Button.Name = "Fight_Button";
            this.Fight_Button.Size = new System.Drawing.Size(75, 23);
            this.Fight_Button.TabIndex = 10;
            this.Fight_Button.Text = "Fight";
            this.Fight_Button.UseVisualStyleBackColor = true;
            this.Fight_Button.Click += new System.EventHandler(this.Fight_Button_Click);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(338, 33);
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.Size = new System.Drawing.Size(205, 238);
            this.Log.TabIndex = 11;
            this.Log.Text = "";
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(439, 290);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 12;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Card_Collection
            // 
            this.Card_Collection.AllowUserToAddRows = false;
            this.Card_Collection.AllowUserToDeleteRows = false;
            this.Card_Collection.AllowUserToResizeColumns = false;
            this.Card_Collection.AllowUserToResizeRows = false;
            this.Card_Collection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Card_Collection.Location = new System.Drawing.Point(30, 290);
            this.Card_Collection.Name = "Card_Collection";
            this.Card_Collection.ReadOnly = true;
            this.Card_Collection.RowHeadersVisible = false;
            this.Card_Collection.ShowEditingIcon = false;
            this.Card_Collection.Size = new System.Drawing.Size(403, 138);
            this.Card_Collection.TabIndex = 13;
            // 
            // CardDataSet
            // 
            this.CardDataSet.DataSetName = "CardDataSet";
            // 
            // Weiss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(667, 441);
            this.Controls.Add(this.Card_Collection);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Fight_Button);
            this.Controls.Add(this.P2_Group_Box);
            this.Controls.Add(this.P1_Group_Box);
            this.Name = "Weiss";
            this.Text = "Weiss";
            this.P1_Group_Box.ResumeLayout(false);
            this.P1_Group_Box.PerformLayout();
            this.P2_Group_Box.ResumeLayout(false);
            this.P2_Group_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Card_Collection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox P2_Card_Name;
        private System.Windows.Forms.TextBox P1_Card_Name;
        private System.Windows.Forms.MaskedTextBox P1_Card_Power;
        private System.Windows.Forms.MaskedTextBox P2_Card_Power;
        private System.Windows.Forms.GroupBox P1_Group_Box;
        private System.Windows.Forms.GroupBox P2_Group_Box;
        private System.Windows.Forms.Button Fight_Button;
        private System.Windows.Forms.RichTextBox Log;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.DataGridView Card_Collection;
        private System.Data.DataSet CardDataSet;
    }
}

