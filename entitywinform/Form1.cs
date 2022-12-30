using entitywinform.modelos;

namespace entitywinform
{
    public partial class Form1 : Form
    {
        CrudemaContext contextoxd;
        public Form1()
        {
            InitializeComponent();
            contextoxd = new CrudemaContext();
            contextoxd.Database.EnsureCreated();
            dataGridView1.DataSource= contextoxd.Usuario.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(usuarioxd.Text) && !String.IsNullOrEmpty(passwordxd.Text))
            {
                Usuario userxd = new Usuario();
                userxd.Usuario1 = usuarioxd.Text;
                userxd.Password = passwordxd.Text;
                contextoxd.Usuario.Add(userxd);
                contextoxd.SaveChanges();
                dataGridView1.DataSource = contextoxd.Usuario.ToList();
            } else
            {
                MessageBox.Show("Verifica que los campos no esten en blanco");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


                if (dataGridView1.CurrentRow != null)
                {
                Usuario userxd = (Usuario)dataGridView1.CurrentRow.DataBoundItem;
                contextoxd.Usuario.Remove(userxd);
                    contextoxd.SaveChanges();
                    dataGridView1.DataSource = contextoxd.Usuario.ToList();
                }
                else
                {
                    MessageBox.Show("Selecciona un dato antes de intentar eliminar");
                return;
                }
           
                



        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                Usuario userxd = (Usuario)dataGridView1.CurrentRow.DataBoundItem;
                userxd.Usuario1 = usuarioxd.Text;
                userxd.Password = passwordxd.Text;
                contextoxd.Usuario.Update(userxd);
                dataGridView1.DataSource = contextoxd.Usuario.ToList();
                contextoxd.SaveChanges();
            } else 
            {
                MessageBox.Show("Selecciona un dato antes de intentar modificar");
                return;
            }
        }
    }
}