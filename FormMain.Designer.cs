namespace PR4_Partners_CRUD
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop = new Panel();
            pictureBox1 = new PictureBox();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonCreate = new Button();
            panel1 = new Panel();
            dataGridViewTypesPartners = new DataGridView();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypesPartners).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(pictureBox1);
            panelTop.Controls.Add(buttonDelete);
            panelTop.Controls.Add(buttonUpdate);
            panelTop.Controls.Add(buttonCreate);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(675, 115);
            panelTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelete.Location = new Point(485, 23);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(181, 69);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += this.buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonUpdate.Location = new Point(280, 23);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(181, 69);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Редактировать";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += this.buttonUpdate_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCreate.Location = new Point(123, 23);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(137, 69);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Добавить";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += this.buttonCreate_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewTypesPartners);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(675, 335);
            panel1.TabIndex = 1;
            // 
            // dataGridViewTypesPartners
            // 
            dataGridViewTypesPartners.BackgroundColor = Color.PapayaWhip;
            dataGridViewTypesPartners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypesPartners.Dock = DockStyle.Fill;
            dataGridViewTypesPartners.Location = new Point(0, 0);
            dataGridViewTypesPartners.Name = "dataGridViewTypesPartners";
            dataGridViewTypesPartners.RowHeadersWidth = 51;
            dataGridViewTypesPartners.Size = new Size(675, 335);
            dataGridViewTypesPartners.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 450);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Name = "FormMain";
            Text = "Типы партнеров";
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypesPartners).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button buttonUpdate;
        private Button buttonCreate;
        private Button buttonDelete;
        private Panel panel1;
        private DataGridView dataGridViewTypesPartners;
        private PictureBox pictureBox1;
    }
}
