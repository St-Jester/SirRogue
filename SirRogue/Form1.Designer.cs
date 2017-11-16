namespace SirRogue
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InventoryPanel = new System.Windows.Forms.TableLayoutPanel();
            this.money = new System.Windows.Forms.Label();
            this.MoneyBox = new System.Windows.Forms.TextBox();
            this.HeroBox = new System.Windows.Forms.GroupBox();
            this.PlayerAvatar = new System.Windows.Forms.PictureBox();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatsText = new System.Windows.Forms.TextBox();
            this.StatsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EquipedText = new System.Windows.Forms.TextBox();
            this.EquipedPanel = new System.Windows.Forms.TableLayoutPanel();
            this.JournalBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.InventoryPanel.SuspendLayout();
            this.HeroBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InventoryPanel);
            this.groupBox1.Controls.Add(this.money);
            this.groupBox1.Controls.Add(this.MoneyBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(153, 433);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory";
            // 
            // InventoryPanel
            // 
            this.InventoryPanel.BackColor = System.Drawing.Color.BurlyWood;
            this.InventoryPanel.ColumnCount = 4;
            this.InventoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InventoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InventoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InventoryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InventoryPanel.Controls.Add(this.button1, 0, 0);
            this.InventoryPanel.Controls.Add(this.button2, 1, 0);
            this.InventoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryPanel.Location = new System.Drawing.Point(4, 17);
            this.InventoryPanel.Name = "InventoryPanel";
            this.InventoryPanel.RowCount = 10;
            this.InventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.InventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.InventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.InventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.InventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.InventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.InventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.InventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.InventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.InventoryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.InventoryPanel.Size = new System.Drawing.Size(145, 384);
            this.InventoryPanel.TabIndex = 2;
            this.InventoryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InventoryPanel_Paint);
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.money.Location = new System.Drawing.Point(4, 401);
            this.money.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(43, 15);
            this.money.TabIndex = 1;
            this.money.Text = "Money";
            // 
            // MoneyBox
            // 
            this.MoneyBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.MoneyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MoneyBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MoneyBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.MoneyBox.Location = new System.Drawing.Point(4, 416);
            this.MoneyBox.Margin = new System.Windows.Forms.Padding(4);
            this.MoneyBox.Name = "MoneyBox";
            this.MoneyBox.ReadOnly = true;
            this.MoneyBox.Size = new System.Drawing.Size(145, 13);
            this.MoneyBox.TabIndex = 0;
            this.MoneyBox.Text = "100";
            // 
            // HeroBox
            // 
            this.HeroBox.Controls.Add(this.PlayerAvatar);
            this.HeroBox.Controls.Add(this.PlayerName);
            this.HeroBox.Controls.Add(this.panel1);
            this.HeroBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeroBox.ForeColor = System.Drawing.Color.DarkMagenta;
            this.HeroBox.Location = new System.Drawing.Point(153, 0);
            this.HeroBox.Margin = new System.Windows.Forms.Padding(4);
            this.HeroBox.Name = "HeroBox";
            this.HeroBox.Padding = new System.Windows.Forms.Padding(4);
            this.HeroBox.Size = new System.Drawing.Size(261, 433);
            this.HeroBox.TabIndex = 2;
            this.HeroBox.TabStop = false;
            this.HeroBox.Text = "Hero";
            // 
            // PlayerAvatar
            // 
            this.PlayerAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayerAvatar.Location = new System.Drawing.Point(4, 37);
            this.PlayerAvatar.Name = "PlayerAvatar";
            this.PlayerAvatar.Size = new System.Drawing.Size(253, 150);
            this.PlayerAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerAvatar.TabIndex = 0;
            this.PlayerAvatar.TabStop = false;
            // 
            // PlayerName
            // 
            this.PlayerName.BackColor = System.Drawing.Color.Tan;
            this.PlayerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PlayerName.Location = new System.Drawing.Point(4, 17);
            this.PlayerName.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            this.PlayerName.Size = new System.Drawing.Size(253, 20);
            this.PlayerName.TabIndex = 2;
            this.PlayerName.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StatsText);
            this.panel1.Controls.Add(this.StatsPanel);
            this.panel1.Controls.Add(this.EquipedText);
            this.panel1.Controls.Add(this.EquipedPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 242);
            this.panel1.TabIndex = 1;
            // 
            // StatsText
            // 
            this.StatsText.BackColor = System.Drawing.Color.Tan;
            this.StatsText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.StatsText.Location = new System.Drawing.Point(0, 2);
            this.StatsText.Name = "StatsText";
            this.StatsText.ReadOnly = true;
            this.StatsText.Size = new System.Drawing.Size(253, 20);
            this.StatsText.TabIndex = 0;
            this.StatsText.Text = "Stats";
            // 
            // StatsPanel
            // 
            this.StatsPanel.ColumnCount = 2;
            this.StatsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.2253F));
            this.StatsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.7747F));
            this.StatsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatsPanel.Location = new System.Drawing.Point(0, 22);
            this.StatsPanel.Name = "StatsPanel";
            this.StatsPanel.RowCount = 4;
            this.StatsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.StatsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.StatsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.StatsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.StatsPanel.Size = new System.Drawing.Size(253, 100);
            this.StatsPanel.TabIndex = 1;
            // 
            // EquipedText
            // 
            this.EquipedText.BackColor = System.Drawing.Color.Tan;
            this.EquipedText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EquipedText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EquipedText.Location = new System.Drawing.Point(0, 122);
            this.EquipedText.Name = "EquipedText";
            this.EquipedText.ReadOnly = true;
            this.EquipedText.Size = new System.Drawing.Size(253, 20);
            this.EquipedText.TabIndex = 2;
            this.EquipedText.Text = "Equiped";
            // 
            // EquipedPanel
            // 
            this.EquipedPanel.ColumnCount = 2;
            this.EquipedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.2253F));
            this.EquipedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.7747F));
            this.EquipedPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EquipedPanel.Location = new System.Drawing.Point(0, 142);
            this.EquipedPanel.Name = "EquipedPanel";
            this.EquipedPanel.RowCount = 4;
            this.EquipedPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EquipedPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EquipedPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EquipedPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.EquipedPanel.Size = new System.Drawing.Size(253, 100);
            this.EquipedPanel.TabIndex = 3;
            // 
            // JournalBox
            // 
            this.JournalBox.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.JournalBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.JournalBox.ForeColor = System.Drawing.Color.DarkMagenta;
            this.JournalBox.Location = new System.Drawing.Point(414, 0);
            this.JournalBox.Margin = new System.Windows.Forms.Padding(4);
            this.JournalBox.Name = "JournalBox";
            this.JournalBox.Padding = new System.Windows.Forms.Padding(4);
            this.JournalBox.Size = new System.Drawing.Size(144, 433);
            this.JournalBox.TabIndex = 0;
            this.JournalBox.TabStop = false;
            this.JournalBox.Text = "Journal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(558, 433);
            this.Controls.Add(this.HeroBox);
            this.Controls.Add(this.JournalBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.InventoryPanel.ResumeLayout(false);
            this.HeroBox.ResumeLayout(false);
            this.HeroBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox HeroBox;
        private System.Windows.Forms.GroupBox JournalBox;
        private System.Windows.Forms.TextBox MoneyBox;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.PictureBox PlayerAvatar;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox StatsText;
        private System.Windows.Forms.TableLayoutPanel EquipedPanel;
        private System.Windows.Forms.TextBox EquipedText;
        private System.Windows.Forms.TableLayoutPanel StatsPanel;
        private System.Windows.Forms.TableLayoutPanel InventoryPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

