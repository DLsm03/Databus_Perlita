
namespace Interfaces
{
    partial class frmUsuarios
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCamion = new FontAwesome.Sharp.IconButton();
            this.btnPrecio = new FontAwesome.Sharp.IconButton();
            this.btnHorario = new FontAwesome.Sharp.IconButton();
            this.btnParadas = new FontAwesome.Sharp.IconButton();
            this.btnRuta = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.ptcbxInicio = new System.Windows.Forms.PictureBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.iconCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.iconMaximizar = new FontAwesome.Sharp.IconPictureBox();
            this.iconMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.lblActual = new System.Windows.Forms.Label();
            this.iconInicioActual = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcbxInicio)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconInicioActual)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.pnlMenu.Controls.Add(this.btnCamion);
            this.pnlMenu.Controls.Add(this.btnPrecio);
            this.pnlMenu.Controls.Add(this.btnHorario);
            this.pnlMenu.Controls.Add(this.btnParadas);
            this.pnlMenu.Controls.Add(this.btnRuta);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(291, 703);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnCamion
            // 
            this.btnCamion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCamion.FlatAppearance.BorderSize = 0;
            this.btnCamion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCamion.ForeColor = System.Drawing.Color.White;
            this.btnCamion.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnCamion.IconColor = System.Drawing.Color.White;
            this.btnCamion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCamion.IconSize = 50;
            this.btnCamion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCamion.Location = new System.Drawing.Point(0, 525);
            this.btnCamion.Name = "btnCamion";
            this.btnCamion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCamion.Size = new System.Drawing.Size(291, 90);
            this.btnCamion.TabIndex = 5;
            this.btnCamion.Text = "Camión";
            this.btnCamion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCamion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCamion.UseVisualStyleBackColor = true;
            this.btnCamion.Click += new System.EventHandler(this.btnCamion_Click);
            // 
            // btnPrecio
            // 
            this.btnPrecio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrecio.FlatAppearance.BorderSize = 0;
            this.btnPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnPrecio.ForeColor = System.Drawing.Color.White;
            this.btnPrecio.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btnPrecio.IconColor = System.Drawing.Color.White;
            this.btnPrecio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrecio.IconSize = 50;
            this.btnPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrecio.Location = new System.Drawing.Point(0, 435);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPrecio.Size = new System.Drawing.Size(291, 90);
            this.btnPrecio.TabIndex = 4;
            this.btnPrecio.Text = "Precio";
            this.btnPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrecio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrecio.UseVisualStyleBackColor = true;
            this.btnPrecio.Click += new System.EventHandler(this.btnPrecio_Click);
            // 
            // btnHorario
            // 
            this.btnHorario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHorario.FlatAppearance.BorderSize = 0;
            this.btnHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnHorario.ForeColor = System.Drawing.Color.White;
            this.btnHorario.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.btnHorario.IconColor = System.Drawing.Color.White;
            this.btnHorario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHorario.IconSize = 50;
            this.btnHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorario.Location = new System.Drawing.Point(0, 345);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHorario.Size = new System.Drawing.Size(291, 90);
            this.btnHorario.TabIndex = 3;
            this.btnHorario.Text = "Horario";
            this.btnHorario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHorario.UseVisualStyleBackColor = true;
            this.btnHorario.Click += new System.EventHandler(this.btnHorario_Click);
            // 
            // btnParadas
            // 
            this.btnParadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParadas.FlatAppearance.BorderSize = 0;
            this.btnParadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnParadas.ForeColor = System.Drawing.Color.White;
            this.btnParadas.IconChar = FontAwesome.Sharp.IconChar.OilCan;
            this.btnParadas.IconColor = System.Drawing.Color.White;
            this.btnParadas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnParadas.IconSize = 50;
            this.btnParadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParadas.Location = new System.Drawing.Point(0, 255);
            this.btnParadas.Name = "btnParadas";
            this.btnParadas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnParadas.Size = new System.Drawing.Size(291, 90);
            this.btnParadas.TabIndex = 2;
            this.btnParadas.Text = "Paradas";
            this.btnParadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParadas.UseVisualStyleBackColor = true;
            this.btnParadas.Click += new System.EventHandler(this.btnParadas_Click);
            // 
            // btnRuta
            // 
            this.btnRuta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRuta.FlatAppearance.BorderSize = 0;
            this.btnRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnRuta.ForeColor = System.Drawing.Color.White;
            this.btnRuta.IconChar = FontAwesome.Sharp.IconChar.Route;
            this.btnRuta.IconColor = System.Drawing.Color.White;
            this.btnRuta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRuta.IconSize = 50;
            this.btnRuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuta.Location = new System.Drawing.Point(0, 165);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRuta.Size = new System.Drawing.Size(291, 90);
            this.btnRuta.TabIndex = 1;
            this.btnRuta.Text = "Ruta";
            this.btnRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.ptcbxInicio);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(291, 165);
            this.pnlLogo.TabIndex = 0;
            // 
            // ptcbxInicio
            // 
            this.ptcbxInicio.Dock = System.Windows.Forms.DockStyle.Fill;
           // this.ptcbxInicio.Image = global::Interfaces.Properties.Resources.wd_removebg_preview__1_;
            this.ptcbxInicio.Location = new System.Drawing.Point(0, 0);
            this.ptcbxInicio.Name = "ptcbxInicio";
            this.ptcbxInicio.Size = new System.Drawing.Size(291, 165);
            this.ptcbxInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcbxInicio.TabIndex = 0;
            this.ptcbxInicio.TabStop = false;
            this.ptcbxInicio.Click += new System.EventHandler(this.ptcbxInicio_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(68)))), ((int)(((byte)(142)))));
            this.pnlTitulo.Controls.Add(this.iconCerrar);
            this.pnlTitulo.Controls.Add(this.iconMaximizar);
            this.pnlTitulo.Controls.Add(this.iconMinimizar);
            this.pnlTitulo.Controls.Add(this.lblActual);
            this.pnlTitulo.Controls.Add(this.iconInicioActual);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(291, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(824, 98);
            this.pnlTitulo.TabIndex = 1;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // iconCerrar
            // 
            this.iconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(68)))), ((int)(((byte)(142)))));
            this.iconCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconCerrar.IconColor = System.Drawing.Color.White;
            this.iconCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCerrar.IconSize = 29;
            this.iconCerrar.Location = new System.Drawing.Point(780, 12);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(32, 29);
            this.iconCerrar.TabIndex = 5;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // iconMaximizar
            // 
            this.iconMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(68)))), ((int)(((byte)(142)))));
            this.iconMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconMaximizar.IconColor = System.Drawing.Color.White;
            this.iconMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMaximizar.IconSize = 29;
            this.iconMaximizar.Location = new System.Drawing.Point(742, 12);
            this.iconMaximizar.Name = "iconMaximizar";
            this.iconMaximizar.Size = new System.Drawing.Size(32, 29);
            this.iconMaximizar.TabIndex = 4;
            this.iconMaximizar.TabStop = false;
            this.iconMaximizar.Click += new System.EventHandler(this.iconMaximizar_Click);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(68)))), ((int)(((byte)(142)))));
            this.iconMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimizar.IconColor = System.Drawing.Color.White;
            this.iconMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimizar.IconSize = 29;
            this.iconMinimizar.Location = new System.Drawing.Point(704, 12);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(32, 29);
            this.iconMinimizar.TabIndex = 3;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // lblActual
            // 
            this.lblActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblActual.ForeColor = System.Drawing.Color.White;
            this.lblActual.Location = new System.Drawing.Point(83, 0);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(151, 103);
            this.lblActual.TabIndex = 1;
            this.lblActual.Text = "Inicio";
            this.lblActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconInicioActual
            // 
            this.iconInicioActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(68)))), ((int)(((byte)(142)))));
            this.iconInicioActual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconInicioActual.IconColor = System.Drawing.Color.White;
            this.iconInicioActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconInicioActual.IconSize = 58;
            this.iconInicioActual.Location = new System.Drawing.Point(19, 22);
            this.iconInicioActual.Name = "iconInicioActual";
            this.iconInicioActual.Size = new System.Drawing.Size(58, 61);
            this.iconInicioActual.TabIndex = 0;
            this.iconInicioActual.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(45)))), ((int)(((byte)(94)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(291, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 5);
            this.panel1.TabIndex = 2;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(102)))), ((int)(((byte)(160)))));
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(291, 103);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(824, 600);
            this.pnlContenedor.TabIndex = 3;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 703);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptcbxInicio)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconInicioActual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnRuta;
        private System.Windows.Forms.Panel pnlLogo;
        private FontAwesome.Sharp.IconButton btnCamion;
        private FontAwesome.Sharp.IconButton btnPrecio;
        private FontAwesome.Sharp.IconButton btnHorario;
        private FontAwesome.Sharp.IconButton btnParadas;
        private System.Windows.Forms.PictureBox ptcbxInicio;
        private System.Windows.Forms.Panel pnlTitulo;
        private FontAwesome.Sharp.IconPictureBox iconInicioActual;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlContenedor;
        private FontAwesome.Sharp.IconPictureBox iconMinimizar;
        private FontAwesome.Sharp.IconPictureBox iconCerrar;
        private FontAwesome.Sharp.IconPictureBox iconMaximizar;
    }
}