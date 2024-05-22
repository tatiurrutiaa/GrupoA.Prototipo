﻿using GrupoA.Prototipo.Empaquetado;
using GrupoA.Prototipo.OrdenPreparacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoA.Prototipo
{
    public partial class OrdenPreparacionForms : Form
    {
        OrdenPreparacionModel modelo;
        public OrdenPreparacionForms()
        {
            InitializeComponent();
        }

        private void groupBoxCliente_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.MenuForms menu = new();
            this.Hide();
            menu.Show();
        }

        private void OrdenPreparaciónForms_Load(object sender, EventArgs e)
        {
            modelo = new();
        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            string cuit = this.textBoxCUITCliente.Text;
            var cliente = modelo.BuscarCliente(cuit);

            if (cliente == null)
            {
                MessageBox.Show("Cliente no encontrado");
                return;
            }

            this.textBoxRazonSocialCliente.Text = cliente.RazonSocial;
            // oculto o deshabilito la busqueda... etc. 
        }
    }
}