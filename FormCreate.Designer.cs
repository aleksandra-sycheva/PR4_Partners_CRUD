namespace PR4_Partners_CRUD
{
    partial class FormCreate
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
            label1 = new Label();
            textBoxType = new TextBox();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(168, 31);
            label1.TabIndex = 0;
            label1.Text = "Тип партнера: ";
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(22, 74);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(457, 27);
            textBoxType.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(320, 123);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(146, 40);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Подтвердить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 175);
            Controls.Add(buttonSave);
            Controls.Add(textBoxType);
            Controls.Add(label1);
            Name = "FormCreate";
            Text = "Добавить/Обновить";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxType;
        private Button buttonSave;
    }
}