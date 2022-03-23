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
    public partial class Frm_Administradores : Form
    {
        //----------------Atributos--------------------------
        private IconButton btnActual;
        private Panel bordeBtn;
        private Form frm_hijo;
        private bool statusE = false, statusEdit = false; 
        //---------------Constructor-------------------------
        public Frm_Administradores()
        {
            InitializeComponent();
            bordeBtn = new Panel();
            bordeBtn.Size = new Size(7, 70);
            pnl_menu.Controls.Add(bordeBtn);
            //-----Barra formulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //----------------Metodos----------------------------
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
                //----Borde derecho del boton
                bordeBtn.BackColor = color;
                bordeBtn.Location = new Point(0, btnActual.Location.Y);
                bordeBtn.Visible = true;
                bordeBtn.BringToFront();
                //----Cambiar el icono y el texto al actual
                ico_actual.IconChar = btnActual.IconChar;
                lbl_actual.Text = btnActual.Text;
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
            ico_actual.IconChar = IconChar.Home;
            ico_actual.IconColor = Color.White;
            lbl_actual.Text = "Inicio";
        }
        private void abrir_FrmHijo(Form frmHijo)
        {
            if (frm_hijo != null)
            {
                frm_hijo.Close();
            }
            frm_hijo = frmHijo;
            frmHijo.TopLevel = false;
            frmHijo.FormBorderStyle = FormBorderStyle.None;
            frmHijo.Dock = DockStyle.Fill;
            pnl_hijos.Controls.Add(frmHijo);
            pnl_hijos.Tag = frmHijo;
            frmHijo.BringToFront();
            frmHijo.Show();
            //lblActual.Text = formularioHijo.Text;
        }
        private void Mostrar(bool estadoE, int tipo, bool estadoEdicion)
        {
            statusE = estadoE;
            statusEdit = estadoEdicion;
            if (tipo == 1 && estadoE == false)// 1 - Boton Empleados 
            {
                btn_Choferes.Visible = true;
                btn_Choferes.Visible = true;
                btn_Choferes.Visible = true;
                btn_Choferes.Visible = true;
                statusE = true;
            }
            if (tipo == 2 && estadoEdicion == false)// 2 - Boton Empleados 
            {
                btn_Choferes.Visible = true;
                btn_Choferes.Visible = true;
                btn_Choferes.Visible = true;
                btn_Choferes.Visible = true;
                statusE = true;
            }
        }
        private void Ocultar(string estadoE, int tipo, string estadoEdicion)
        {
            if(tipo == 1)
            {

            }
        }
        //----------------Otros------------------------------
        private void Frm_Administradores_Load(object sender, EventArgs e)
        {

        }
        //--------------Eventos------------------------------
        private void Btn_Empleados_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colors.color1);
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colors.color1);
            abrir_FrmHijo(new Formularios.Frm_Insertar());
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colors.color1);
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colors.color1);
            abrir_FrmHijo(new Formularios.Frm_Eliminar());
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colors.color1);
            abrir_FrmHijo(new Formularios.Frm_Modificar());
        }

        private void btn_Choferes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colors.color1);
            abrir_FrmHijo(new Formularios.Frm_Choferes());
        }

        private void btn_Taquiller_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colors.color1);
            abrir_FrmHijo(new Formularios.Frm_Taquiller());
        }

        private void btn_Limpieza_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colors.color1);
            abrir_FrmHijo(new Formularios.Frm_Limpieza());
        }

        private void btn_Mecanico_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colors.color1);
            abrir_FrmHijo(new Formularios.Frm_Mecanico());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reiniciar();
            frm_hijo.Close();
        }

        private void pnl_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //---------Apariencia formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}
