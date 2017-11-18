﻿using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.View.Cliente;
using PagoAgil.Aplicacion.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View
{

    class FormABMCliente : Form
    {
        ClientesVM clientesVM = new ClientesVM();
        private Button limpiarButton;
        private Button buscarButton;
        private ComboBox CondicionComboBox;
        private TextBox condicionTextBox;
        private Label label1;
        private Label label2;
        private Button nuevoClienteButton;
        private DataGridView dataGridView2;
        private ComboBox tipoFiltroComboBox;
        private Label label3;
        private DataGridViewButtonColumn Modificar;
        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            this.limpiarButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.CondicionComboBox = new System.Windows.Forms.ComboBox();
            this.condicionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nuevoClienteButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tipoFiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(321, 296);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(199, 42);
            this.limpiarButton.TabIndex = 1;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(555, 296);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(199, 42);
            this.buscarButton.TabIndex = 2;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // CondicionComboBox
            // 
            this.CondicionComboBox.FormattingEnabled = true;
            this.CondicionComboBox.Location = new System.Drawing.Point(429, 106);
            this.CondicionComboBox.Name = "CondicionComboBox";
            this.CondicionComboBox.Size = new System.Drawing.Size(216, 28);
            this.CondicionComboBox.TabIndex = 3;
            this.CondicionComboBox.SelectedIndexChanged += new System.EventHandler(this.CondicionComboBox_SelectedIndexChanged);
            // 
            // condicionTextBox
            // 
            this.condicionTextBox.Location = new System.Drawing.Point(452, 238);
            this.condicionTextBox.Name = "condicionTextBox";
            this.condicionTextBox.Size = new System.Drawing.Size(170, 26);
            this.condicionTextBox.TabIndex = 4;
            this.condicionTextBox.TextChanged += new System.EventHandler(this.condicionTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Condicion de filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor de filtro";
            // 
            // nuevoClienteButton
            // 
            this.nuevoClienteButton.Location = new System.Drawing.Point(824, 30);
            this.nuevoClienteButton.Name = "nuevoClienteButton";
            this.nuevoClienteButton.Size = new System.Drawing.Size(199, 69);
            this.nuevoClienteButton.TabIndex = 7;
            this.nuevoClienteButton.Text = "NUEVO CLIENTE";
            this.nuevoClienteButton.UseVisualStyleBackColor = true;
            this.nuevoClienteButton.Click += new System.EventHandler(this.nuevoClienteButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar});
            this.dataGridView2.Location = new System.Drawing.Point(12, 397);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1031, 273);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            // 
            // tipoFiltroComboBox
            // 
            this.tipoFiltroComboBox.FormattingEnabled = true;
            this.tipoFiltroComboBox.Location = new System.Drawing.Point(474, 173);
            this.tipoFiltroComboBox.Name = "tipoFiltroComboBox";
            this.tipoFiltroComboBox.Size = new System.Drawing.Size(121, 28);
            this.tipoFiltroComboBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo filtro";
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            // 
            // FormABMCliente
            // 
            this.ClientSize = new System.Drawing.Size(1055, 696);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tipoFiltroComboBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.nuevoClienteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.condicionTextBox);
            this.Controls.Add(this.CondicionComboBox);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.limpiarButton);
            this.Name = "FormABMCliente";
            this.Load += new System.EventHandler(this.FormABMCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public FormABMCliente()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void nuevoClienteButton_Click(object sender, EventArgs e)
        {
            Form altaClinte = new FormAltaCliente();
            altaClinte.Show();

        }

        private void FormABMCliente_Load(object sender, EventArgs e)
        {
            var clientes = clientesVM.obtenerClientes();
            var bindingList = new BindingList<ClienteDB>(clientes);
            var source = new BindingSource(bindingList, null);
            dataGridView2.DataSource = source;


            CondicionComboBox.DataSource = clientesVM.obtenerCondicionesDeFiltro();

            List<string> filtros = new List<string>(); //TODO:Armar clase para esto
            filtros.Add("=");
            filtros.Add(">=");
            filtros.Add("<=");
            filtros.Add(">");
            filtros.Add("<");
            filtros.Add("!=");

            tipoFiltroComboBox.DataSource = filtros;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClienteDB cliente = clientesVM.obtenerClientes().ElementAt(e.RowIndex);

            Form mc = new FormModificarCliente(cliente);
            mc.Show();
        }

        private void CondicionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            condicionTextBox.Enabled = false;







            condicionTextBox.Enabled = true;

        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            string condicionSeleccionada = CondicionComboBox.SelectedItem as string;
            string filtroCondicion = tipoFiltroComboBox.SelectedItem as string;
            string valorCondicion = condicionTextBox.Text as string;



            dataGridView2.DataSource = clientesVM.obtenerClientesFiltradosPor(condicionSeleccionada, filtroCondicion, valorCondicion);
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = clientesVM.obtenerClientes();
        }

        private void condicionTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            ClienteDB cliente = clientesVM.obtenerClientes().ElementAt(e.RowIndex);



            //MessageBox.Show(cliente.Nombre);
        }
    }
}
