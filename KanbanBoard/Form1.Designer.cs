namespace KanbanBoard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTool = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTool = new System.Windows.Forms.ToolStripMenuItem();
            this.changeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Planned = new System.Windows.Forms.ListBox();
            this.contextMenuPlan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolInProc1 = new System.Windows.Forms.ToolStripMenuItem();
            this.InProcess = new System.Windows.Forms.ListBox();
            this.Delayed = new System.Windows.Forms.ListBox();
            this.Done = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Запланировано";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(188, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "В процессе выполнения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(432, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отложено";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(612, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Выполнено";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileItem,
            this.changeItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileItem
            // 
            this.fileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTool,
            this.clearTool});
            this.fileItem.Name = "fileItem";
            this.fileItem.Size = new System.Drawing.Size(48, 20);
            this.fileItem.Text = "Файл";
            // 
            // saveTool
            // 
            this.saveTool.Name = "saveTool";
            this.saveTool.Size = new System.Drawing.Size(180, 22);
            this.saveTool.Text = "Сохранить";
            // 
            // clearTool
            // 
            this.clearTool.Name = "clearTool";
            this.clearTool.Size = new System.Drawing.Size(180, 22);
            this.clearTool.Text = "Очистить";
            this.clearTool.Click += new System.EventHandler(this.clearTool_Click);
            // 
            // changeItem
            // 
            this.changeItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoItem,
            this.redoItem});
            this.changeItem.Name = "changeItem";
            this.changeItem.Size = new System.Drawing.Size(73, 20);
            this.changeItem.Text = "Изменить";
            // 
            // undoItem
            // 
            this.undoItem.Name = "undoItem";
            this.undoItem.Size = new System.Drawing.Size(128, 22);
            this.undoItem.Text = "Отменить";
            // 
            // redoItem
            // 
            this.redoItem.Name = "redoItem";
            this.redoItem.Size = new System.Drawing.Size(128, 22);
            this.redoItem.Text = "Вернуть";
            // 
            // Planned
            // 
            this.Planned.ContextMenuStrip = this.contextMenuPlan;
            this.Planned.FormattingEnabled = true;
            this.Planned.Location = new System.Drawing.Point(16, 119);
            this.Planned.Name = "Planned";
            this.Planned.Size = new System.Drawing.Size(150, 303);
            this.Planned.TabIndex = 6;
            // 
            // contextMenuPlan
            // 
            this.contextMenuPlan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolInProc1});
            this.contextMenuPlan.Name = "contextMenuPlan";
            this.contextMenuPlan.Size = new System.Drawing.Size(148, 26);
            // 
            // toolInProc1
            // 
            this.toolInProc1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolInProc1.Name = "toolInProc1";
            this.toolInProc1.Size = new System.Drawing.Size(147, 22);
            this.toolInProc1.Text = "Выполняется";
            // 
            // InProcess
            // 
            this.InProcess.FormattingEnabled = true;
            this.InProcess.Location = new System.Drawing.Point(211, 119);
            this.InProcess.Name = "InProcess";
            this.InProcess.Size = new System.Drawing.Size(150, 303);
            this.InProcess.TabIndex = 7;
            // 
            // Delayed
            // 
            this.Delayed.FormattingEnabled = true;
            this.Delayed.Location = new System.Drawing.Point(403, 119);
            this.Delayed.Name = "Delayed";
            this.Delayed.Size = new System.Drawing.Size(150, 303);
            this.Delayed.TabIndex = 9;
            // 
            // Done
            // 
            this.Done.FormattingEnabled = true;
            this.Done.Location = new System.Drawing.Point(588, 119);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(150, 303);
            this.Done.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.label5.Location = new System.Drawing.Point(307, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "KANBAN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Delayed);
            this.Controls.Add(this.InProcess);
            this.Controls.Add(this.Planned);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuPlan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileItem;
        private System.Windows.Forms.ToolStripMenuItem saveTool;
        private System.Windows.Forms.ToolStripMenuItem clearTool;
        private System.Windows.Forms.ToolStripMenuItem changeItem;
        private System.Windows.Forms.ToolStripMenuItem undoItem;
        private System.Windows.Forms.ToolStripMenuItem redoItem;
        private System.Windows.Forms.ListBox Planned;
        private System.Windows.Forms.ListBox InProcess;
        private System.Windows.Forms.ListBox Delayed;
        private System.Windows.Forms.ListBox Done;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuPlan;
        private System.Windows.Forms.ToolStripMenuItem toolInProc1;
    }
}

