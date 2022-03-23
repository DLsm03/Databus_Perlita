using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace Interfaces
{
    public partial class frmUsuarios : Form
    {
        //Atributos
        private IconButton btnActual;
        private Panel bordeBtn;
        private Form formularioChiquillo;
        //constructor
        public frmUsuarios()
        {
            InitializeComponent();
            bordeBtn = new Panel();
            bordeBtn.Size = new Size(7, 90);
            pnlMenu.Controls.Add(bordeBtn);
            //Barra formulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Metodos
        private void ActivarBoton(object recibirBtn, Color color)
        {
            if (recibirBtn != null)
            {
                DesactivarBoton();
                btnActual = (IconButton)recibirBtn;
                btnActual.BackColor = Color.FromArgb(37, 36, 81);
                btnActual.ForeColor = color;
                btnActual.TextAlign = ContentAlignment.MiddleCenter;
                btnActual.IconColor = color;
                btnActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnActual.ImageAlign = ContentAlignment.MiddleRight;
                //Borde derecho del boton
                bordeBtn.BackColor = color;
                bordeBtn.Location = new Point(0, btnActual.Location.Y);
                bordeBtn.Visible = true;
                bordeBtn.BringToFront();
                //Icono formulario
                iconInicioActual.IconChar = btnActual.IconChar;
                iconInicioActual.IconColor = Color.White;
                lblActual.Text = btnActual.Text;
            }
        }
        private void DesactivarBoton()
        {
            if (btnActual != null)
            {
                btnActual.BackColor = Color.FromArgb(35, 137, 137);
                btnActual.ForeColor = Color.White;
                btnActual.TextAlign = ContentAlignment.MiddleLeft;
                btnActual.IconColor = Color.White;
                btnActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private struct Colors
        {
            public static Color color1 = Color.FromArgb(92, 192, 192);
        }
        private void Reiniciar()
        {
            DesactivarBoton();
            bordeBtn.Visible = false;
            //Icono formulario
            iconInicioActual.IconChar = IconChar.Home;
            iconInicioActual.IconColor = Color.White;
            lblActual.Text = "Inicio";
        }
        private void AbrirFormularioHijo(Form formularioHijo)
        {
            if (formularioChiquillo != null)
            {
                formularioChiquillo.Close();
            }
            formularioChiquillo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formularioHijo);
            pnlContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
            //lblActual.Text = formularioHijo.Text;
        }
        //Eventos
        private void btnRuta_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colors.color1);
            AbrirFormularioHijo(new Forms.frmRutas());
        }

        private void btnParadas_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colors.color1);
            AbrirFormularioHijo(new Forms.frmParadas());
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colors.color1);
            AbrirFormularioHijo(new Forms.frmHorarios());
        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colors.color1);
            AbrirFormularioHijo(new Forms.frmPrecios());
        }

        private void btnCamion_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colors.color1);
            AbrirFormularioHijo(new Forms.frmCamion());
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Forms.frmInicio());
        }

        private void ptcbxInicio_Click(object sender, EventArgs e)
        {
            formularioChiquillo.Close();
            Reiniciar();
            AbrirFormularioHijo(new Forms.frmInicio());
        }
        //Apariencia formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
