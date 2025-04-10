using PR4_Partners_CRUD.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PR4_Partners_CRUD
{
    public partial class FormCreate : Form
    {
        private Models.AppContext db;
        private TypesOfPartner _type;
        private bool _isEditMode;

        public FormCreate()
        {
            InitializeComponent();
            db = new Models.AppContext();
            _isEditMode = false;
        }

        public FormCreate(TypesOfPartner type)
        {
            InitializeComponent();
            db = new Models.AppContext();
            _type = type;
            _isEditMode = true;
            LoadTypeData();
        }

        private void LoadTypeData()
        {  
            textBoxType.Text = _type.TypeOfPartner; 
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    if (_isEditMode)
                    {
                        UpdateType();
                    }
                    else
                    {
                        AddNewType();
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(textBoxType.Text))
            {
                MessageBox.Show("Пожалуйста, заполните название типа партнера.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxType.Focus();
                return false;
            }

            if (textBoxType.Text.Length > 100)
            {
                MessageBox.Show("Название типа партнера не должно превышать 100 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxType.Focus();
                return false;
            }

            return true;
        }

        private void AddNewType()
        {
            var newType = new TypesOfPartner
            {
                TypeOfPartner = textBoxType.Text
            };

            db.TypesOfPartners.Add(newType);
            db.SaveChanges();
            MessageBox.Show("Новый тип партнера успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateType()
        {
            _type.TypeOfPartner = textBoxType.Text;
            db.SaveChanges();
            MessageBox.Show("Тип партнера успешно обновлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
