namespace BugTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validamos que se haya ingresado un usuario
            if ((txtUsuario.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario");
                return;
            }

            //Validamos que se haya ingresado una contraseña
            if ((txtContraseña.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña");
                return;
            }

            MessageBox.Show("Usted ha ingresado al sistema");
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}