namespace WinFormSynchrone
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            tlpMain = new TableLayoutPanel();
            lbNumber = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbTime = new Label();
            btSynchro = new Button();
            tlpMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.Controls.Add(lbNumber, 0, 0);
            tlpMain.Controls.Add(tableLayoutPanel1, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 75.3333359F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 24.666666F));
            tlpMain.Size = new Size(800, 450);
            tlpMain.TabIndex = 0;
            // 
            // lbNumber
            // 
            lbNumber.Dock = DockStyle.Fill;
            lbNumber.FormattingEnabled = true;
            lbNumber.ItemHeight = 15;
            lbNumber.Location = new Point(3, 3);
            lbNumber.Name = "lbNumber";
            lbNumber.Size = new Size(794, 333);
            lbNumber.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.8337555F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.1662464F));
            tableLayoutPanel1.Controls.Add(lbTime, 1, 0);
            tableLayoutPanel1.Controls.Add(btSynchro, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 342);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(794, 105);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lbTime
            // 
            lbTime.Anchor = AnchorStyles.None;
            lbTime.AutoSize = true;
            lbTime.Location = new Point(663, 45);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(85, 15);
            lbTime.TabIndex = 0;
            lbTime.Text = "Temps écoulé :";
            // 
            // btSynchro
            // 
            btSynchro.Anchor = AnchorStyles.None;
            btSynchro.Location = new Point(242, 25);
            btSynchro.Name = "btSynchro";
            btSynchro.Size = new Size(134, 55);
            btSynchro.TabIndex = 1;
            btSynchro.Text = "Synchrone";
            btSynchro.UseVisualStyleBackColor = true;
            btSynchro.Click += btSynchro_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task";
            tlpMain.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private ListBox lbNumber;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbTime;
        private Button btSynchro;
    }
}