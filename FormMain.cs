namespace PR4_Partners_CRUD
{
    public partial class FormMain : Form
    {
        private Models.AppContext db;
        public FormMain()
        {
            InitializeComponent();
            db = new Models.AppContext();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadData();
        }

        private void LoadData()
        {
            dataGridViewTypesPartners.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0x67, 0xBA, 0x80);
            dataGridViewTypesPartners.DefaultCellStyle.SelectionForeColor = Color.White;

            using (var tempContext = new Models.AppContext())
            {
                var typeOfPartners = tempContext.TypesOfPartners
                    .Select(tp => new
                    {
                        tp.Id,
                        tp.TypeOfPartner
                    })
                    .OrderBy(o => o.Id)
                    .ToList();

                dataGridViewTypesPartners.DataSource = typeOfPartners;
                dataGridViewTypesPartners.Columns["Id"].Visible = false;
                dataGridViewTypesPartners.Columns["TypeOfPartner"].HeaderText = "Тип партнера";
                dataGridViewTypesPartners.Columns["TypeOfPartner"].ReadOnly = true;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            using (FormCreate formCreate = new FormCreate())
            {
                if (formCreate.ShowDialog() == DialogResult.OK)
                {
                    db = new Models.AppContext();
                    LoadData();
                }
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypesPartners.SelectedRows.Count == 0)
            {
                MessageBox.Show("Тип партнера не выбран",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            using (var tempContext = new Models.AppContext())
            {
                var type = tempContext.TypesOfPartners.Find((short)dataGridViewTypesPartners.SelectedRows[0].Cells["Id"].Value);
                
                using (FormCreate formCreate = new FormCreate(type))
                {
                    if (formCreate.ShowDialog() == DialogResult.OK)
                    {
                        tempContext.SaveChanges();
                        LoadData();
                    }
                }
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypesPartners.SelectedRows.Count == 0)
            {
                MessageBox.Show("Тип партнера не выбран",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранный тип партнера?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var type = db.TypesOfPartners.Find((short)dataGridViewTypesPartners.SelectedRows[0].Cells["Id"].Value);
                    db.TypesOfPartners.Remove(type);
                    db.SaveChanges();
                    LoadData();
                
            }
        }
    }
}