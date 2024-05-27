﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryInicioSesion
{
    public partial class frmCrearUsuario : Form
    {
        clsUsuario objUsuario;
        public frmCrearUsuario()
        {
            InitializeComponent();
            objUsuario = new clsUsuario();

            txtContraseña.PasswordChar = '*';
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objUsuario.registrarUsuario(txtUsuario.Text,txtContraseña.Text, cmbPerfil.SelectedItem.ToString());
        }
    }
}
