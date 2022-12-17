namespace Practical
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.orderPanel = new System.Windows.Forms.Panel();
            this.orderNumber = new System.Windows.Forms.NumericUpDown();
            this.orderLabel = new System.Windows.Forms.Label();
            this.datePanel = new System.Windows.Forms.Panel();
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.servicePanel = new System.Windows.Forms.Panel();
            this.serviceInput = new System.Windows.Forms.TextBox();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serviceTypeInput = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.timePanel = new System.Windows.Forms.Panel();
            this.timeInput = new System.Windows.Forms.MaskedTextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.discountPanel = new System.Windows.Forms.Panel();
            this.discountInput = new System.Windows.Forms.NumericUpDown();
            this.discountLabel = new System.Windows.Forms.Label();
            this.costPanel = new System.Windows.Forms.Panel();
            this.costInput = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.donePanel = new System.Windows.Forms.CheckBox();
            this.statusBarText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.done = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saveTableToFile = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.orderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumber)).BeginInit();
            this.datePanel.SuspendLayout();
            this.namePanel.SuspendLayout();
            this.servicePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.timePanel.SuspendLayout();
            this.discountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountInput)).BeginInit();
            this.costPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusBarText, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.saveTableToFile, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(958, 496);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.orderPanel);
            this.flowLayoutPanel1.Controls.Add(this.datePanel);
            this.flowLayoutPanel1.Controls.Add(this.namePanel);
            this.flowLayoutPanel1.Controls.Add(this.servicePanel);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.timePanel);
            this.flowLayoutPanel1.Controls.Add(this.discountPanel);
            this.flowLayoutPanel1.Controls.Add(this.costPanel);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(952, 187);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // orderPanel
            // 
            this.orderPanel.Controls.Add(this.orderNumber);
            this.orderPanel.Controls.Add(this.orderLabel);
            this.orderPanel.Location = new System.Drawing.Point(3, 3);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(80, 40);
            this.orderPanel.TabIndex = 0;
            // 
            // orderNumber
            // 
            this.orderNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orderNumber.Location = new System.Drawing.Point(0, 20);
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.Size = new System.Drawing.Size(80, 20);
            this.orderNumber.TabIndex = 1;
            this.orderNumber.Leave += new System.EventHandler(this.orderNumber_Leave);
            // 
            // orderLabel
            // 
            this.orderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderLabel.Location = new System.Drawing.Point(0, 0);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(80, 13);
            this.orderLabel.TabIndex = 0;
            this.orderLabel.Text = "№ Заказа:";
            this.orderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // datePanel
            // 
            this.datePanel.Controls.Add(this.dateInput);
            this.datePanel.Controls.Add(this.dateLabel);
            this.datePanel.Location = new System.Drawing.Point(89, 3);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(80, 40);
            this.datePanel.TabIndex = 2;
            // 
            // dateInput
            // 
            this.dateInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dateInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInput.Location = new System.Drawing.Point(0, 20);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(80, 20);
            this.dateInput.TabIndex = 1;
            this.dateInput.Leave += new System.EventHandler(this.dateInput_Leave);
            // 
            // dateLabel
            // 
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateLabel.Location = new System.Drawing.Point(0, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(80, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Дата заказа:";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // namePanel
            // 
            this.namePanel.Controls.Add(this.nameInput);
            this.namePanel.Controls.Add(this.nameLabel);
            this.namePanel.Location = new System.Drawing.Point(175, 3);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(160, 40);
            this.namePanel.TabIndex = 3;
            // 
            // nameInput
            // 
            this.nameInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameInput.Location = new System.Drawing.Point(0, 20);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(160, 20);
            this.nameInput.TabIndex = 1;
            this.nameInput.Leave += new System.EventHandler(this.nameInput_Leave);
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(160, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "ФИО/Название:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // servicePanel
            // 
            this.servicePanel.Controls.Add(this.serviceInput);
            this.servicePanel.Controls.Add(this.serviceLabel);
            this.servicePanel.Location = new System.Drawing.Point(341, 3);
            this.servicePanel.Name = "servicePanel";
            this.servicePanel.Size = new System.Drawing.Size(160, 40);
            this.servicePanel.TabIndex = 4;
            // 
            // serviceInput
            // 
            this.serviceInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.serviceInput.Location = new System.Drawing.Point(0, 20);
            this.serviceInput.Name = "serviceInput";
            this.serviceInput.Size = new System.Drawing.Size(160, 20);
            this.serviceInput.TabIndex = 1;
            this.serviceInput.Leave += new System.EventHandler(this.serviceInput_Leave);
            // 
            // serviceLabel
            // 
            this.serviceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.serviceLabel.Location = new System.Drawing.Point(0, 0);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(160, 13);
            this.serviceLabel.TabIndex = 0;
            this.serviceLabel.Text = "Наименование услуги:";
            this.serviceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.serviceTypeInput);
            this.panel2.Controls.Add(this.typeLabel);
            this.panel2.Location = new System.Drawing.Point(507, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 40);
            this.panel2.TabIndex = 5;
            // 
            // serviceTypeInput
            // 
            this.serviceTypeInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.serviceTypeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceTypeInput.FormattingEnabled = true;
            this.serviceTypeInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.serviceTypeInput.Location = new System.Drawing.Point(0, 19);
            this.serviceTypeInput.Name = "serviceTypeInput";
            this.serviceTypeInput.Size = new System.Drawing.Size(160, 21);
            this.serviceTypeInput.TabIndex = 1;
            this.serviceTypeInput.Leave += new System.EventHandler(this.serviceTypeInput_Leave);
            // 
            // typeLabel
            // 
            this.typeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.typeLabel.Location = new System.Drawing.Point(0, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(160, 13);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Вид услуги:";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timePanel
            // 
            this.timePanel.Controls.Add(this.timeInput);
            this.timePanel.Controls.Add(this.timeLabel);
            this.timePanel.Location = new System.Drawing.Point(673, 3);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(160, 40);
            this.timePanel.TabIndex = 6;
            // 
            // timeInput
            // 
            this.timeInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timeInput.Location = new System.Drawing.Point(0, 20);
            this.timeInput.Mask = "Дней:00\\,Часов:00\\,Минут:00\\.";
            this.timeInput.Name = "timeInput";
            this.timeInput.Size = new System.Drawing.Size(160, 20);
            this.timeInput.TabIndex = 1;
            this.timeInput.ValidatingType = typeof(System.DateTime);
            this.timeInput.Leave += new System.EventHandler(this.timeInput_Leave);
            // 
            // timeLabel
            // 
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.timeLabel.Location = new System.Drawing.Point(0, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(160, 13);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Объём услуги:";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // discountPanel
            // 
            this.discountPanel.Controls.Add(this.discountInput);
            this.discountPanel.Controls.Add(this.discountLabel);
            this.discountPanel.Location = new System.Drawing.Point(839, 3);
            this.discountPanel.Name = "discountPanel";
            this.discountPanel.Size = new System.Drawing.Size(55, 40);
            this.discountPanel.TabIndex = 7;
            // 
            // discountInput
            // 
            this.discountInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.discountInput.Location = new System.Drawing.Point(0, 20);
            this.discountInput.Name = "discountInput";
            this.discountInput.Size = new System.Drawing.Size(55, 20);
            this.discountInput.TabIndex = 1;
            this.discountInput.Leave += new System.EventHandler(this.discountInput_Leave);
            // 
            // discountLabel
            // 
            this.discountLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.discountLabel.Location = new System.Drawing.Point(0, 0);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(55, 13);
            this.discountLabel.TabIndex = 0;
            this.discountLabel.Text = "Скидка:";
            this.discountLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // costPanel
            // 
            this.costPanel.Controls.Add(this.costInput);
            this.costPanel.Controls.Add(this.costLabel);
            this.costPanel.Location = new System.Drawing.Point(3, 49);
            this.costPanel.Name = "costPanel";
            this.costPanel.Size = new System.Drawing.Size(105, 40);
            this.costPanel.TabIndex = 7;
            // 
            // costInput
            // 
            this.costInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.costInput.Location = new System.Drawing.Point(0, 20);
            this.costInput.Name = "costInput";
            this.costInput.Size = new System.Drawing.Size(105, 20);
            this.costInput.TabIndex = 1;
            this.costInput.Leave += new System.EventHandler(this.costInput_Leave);
            // 
            // costLabel
            // 
            this.costLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.costLabel.Location = new System.Drawing.Point(0, 0);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(105, 13);
            this.costLabel.TabIndex = 0;
            this.costLabel.Text = "Стоимость услуги:";
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.donePanel);
            this.panel1.Location = new System.Drawing.Point(114, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 40);
            this.panel1.TabIndex = 8;
            // 
            // donePanel
            // 
            this.donePanel.AutoSize = true;
            this.donePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donePanel.Location = new System.Drawing.Point(0, 0);
            this.donePanel.Name = "donePanel";
            this.donePanel.Size = new System.Drawing.Size(105, 40);
            this.donePanel.TabIndex = 0;
            this.donePanel.Text = "Услуга оказана";
            this.donePanel.UseVisualStyleBackColor = true;
            this.donePanel.CheckedChanged += new System.EventHandler(this.donePanel_CheckedChanged);
            // 
            // statusBarText
            // 
            this.statusBarText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusBarText.Location = new System.Drawing.Point(3, 469);
            this.statusBarText.Name = "statusBarText";
            this.statusBarText.Size = new System.Drawing.Size(952, 24);
            this.statusBarText.TabIndex = 1;
            this.statusBarText.Text = "";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(952, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить в список";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order,
            this.date,
            this.name,
            this.service,
            this.type,
            this.time,
            this.discount,
            this.cost,
            this.done});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(952, 172);
            this.dataGridView1.TabIndex = 3;
            // 
            // order
            // 
            this.order.HeaderText = "№";
            this.order.Name = "order";
            this.order.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "ФИО/Название";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // service
            // 
            this.service.HeaderText = "Наименование";
            this.service.Name = "service";
            this.service.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "Вид";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "Объём";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // discount
            // 
            this.discount.HeaderText = "Скидка";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.HeaderText = "Стоимость";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // done
            // 
            this.done.HeaderText = "Оказана";
            this.done.Name = "done";
            this.done.ReadOnly = true;
            // 
            // saveTableToFile
            // 
            this.saveTableToFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveTableToFile.Location = new System.Drawing.Point(3, 429);
            this.saveTableToFile.Name = "saveTableToFile";
            this.saveTableToFile.Size = new System.Drawing.Size(952, 34);
            this.saveTableToFile.TabIndex = 4;
            this.saveTableToFile.Text = "Выгрузить таблицу в файл";
            this.saveTableToFile.UseVisualStyleBackColor = true;
            this.saveTableToFile.Click += new System.EventHandler(this.saveTableToFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 496);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.orderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderNumber)).EndInit();
            this.datePanel.ResumeLayout(false);
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.servicePanel.ResumeLayout(false);
            this.servicePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.discountPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.discountInput)).EndInit();
            this.costPanel.ResumeLayout(false);
            this.costPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel orderPanel;
        private System.Windows.Forms.NumericUpDown orderNumber;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Panel datePanel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel servicePanel;
        private System.Windows.Forms.TextBox serviceInput;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox serviceTypeInput;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Panel discountPanel;
        private System.Windows.Forms.NumericUpDown discountInput;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Panel costPanel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox donePanel;
        public System.Windows.Forms.RichTextBox statusBarText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn service;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewCheckBoxColumn done;
        private System.Windows.Forms.MaskedTextBox timeInput;
        private System.Windows.Forms.TextBox costInput;
        private System.Windows.Forms.DateTimePicker dateInput;
        private System.Windows.Forms.Button saveTableToFile;
    }
}

