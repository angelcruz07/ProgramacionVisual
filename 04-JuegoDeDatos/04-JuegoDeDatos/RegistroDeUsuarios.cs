using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_JuegoDeDatos
{
    public partial class RegistroDeUsuarios : Form
    {
        public RegistroDeUsuarios()
        {
            InitializeComponent();
        }

        private void BtnRegistrar(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string firstLastname = TxtFirstLastName.Text;
            string secondLastname = TxtSecondLastName.Text;
            string state = CboState.SelectedItem.ToString();
            string colony = TxtColony.Text;
            string street = TxtStreet.Text;
            string dateRegister = DateRegister.Value.ToShortDateString();
            string urlPthoto = TxtUrl.Text;


            LstUsers.Items.Add("-------------------- Nuevo Usuario --------------------");

            // Add each detail as a separate item
            LstUsers.Items.Add($"Nombre Completo: {name} {firstLastname} {secondLastname}");
            LstUsers.Items.Add($"Estado: {state}");
            LstUsers.Items.Add($"Colonia: {colony}");
            LstUsers.Items.Add($"Calle: {street}");
            LstUsers.Items.Add($"Fecha de Registro: {dateRegister}");
            LstUsers.Items.Add($"URL de la Foto: {urlPthoto}");

            // Optional: Add an empty line for better separation
            LstUsers.Items.Add("");


            TxtName.Clear();
            TxtFirstLastName.Clear();
            TxtSecondLastName.Clear();
            CboState.SelectedIndex = -1;
            TxtColony.Clear();
            TxtStreet.Clear();
            DateRegister.Value = DateTime.Now;
            TxtUrl.Clear();
            Photo.ImageLocation = "";
            TxtName.Focus();
        }

        private void SaveImage(OpenFileDialog file)
        {
            file.FileName = "";
            file.Title = "Elerge una imagen";
            file.InitialDirectory = "C:\\Users\\Angel\\OneDrive\\Documentos\\Programación Visual\\assets";
            file.FileName = TxtUrl.Text;

            if (file.ShowDialog() == DialogResult.OK)
            {
                TxtUrl.Text = file.FileName;
                Photo.ImageLocation = file.FileName;
            }
        }

        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            SaveImage(openFileDialog1);
        }
    }
}
