﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Encuesta_Colquehuanca
{
    public partial class Encuesta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rbtnListCursos.Items.Clear();
                rbtnListCursos.Items.Add("Redes II");
                rbtnListCursos.Items.Add("Web II");
                rbtnListCursos.Items.Add("Base de Datos II");
                rbtnListCursos.Items.Add("Ingles Técnico");
                txtVotosRedes.Text = "0";
                txtVotosWeb.Text = "0";
                txtVotosBaseDatos.Text = "0";
                txtVotosIngles.Text = "0";
            }
            
        }
        
        
        protected void btnVotar_Click(object sender, EventArgs e)
        {
            if (rbtnListCursos.Items[0].Selected == true)
            {
                txtVotosRedes.Text = (Int32.Parse(txtVotosRedes.Text) + 1).ToString();
            }
            if (rbtnListCursos.Items[1].Selected == true)
            {
                txtVotosWeb.Text = (Int32.Parse(txtVotosWeb.Text) + 1).ToString();
            }      
            if (rbtnListCursos.Items[2].Selected == true)
            {
                txtVotosBaseDatos.Text = (Int32.Parse(txtVotosBaseDatos.Text) + 1).ToString();
            }
            if (rbtnListCursos.Items[3].Selected == true)
            {
                txtVotosIngles.Text = (Int32.Parse(txtVotosIngles.Text) + 1).ToString();
            }
            txtTotalVotos.Text = (Int32.Parse(txtVotosRedes.Text) + Int32.Parse(txtVotosWeb.Text) + Int32.Parse(txtVotosBaseDatos.Text) + Int32.Parse(txtVotosIngles.Text)).ToString();

            txtPorcentajeRedes.Text = ((float.Parse(txtVotosRedes.Text) * 100f) / float.Parse(txtTotalVotos.Text)).ToString();
            txtPorcentajeWeb.Text = ((float.Parse(txtVotosWeb.Text) * 100f) / float.Parse(txtTotalVotos.Text)).ToString();
            txtPorcentajeBaseDatos.Text = ((float.Parse(txtVotosBaseDatos.Text) * 100f) / float.Parse(txtTotalVotos.Text)).ToString();
            txtPorcentajeIngles.Text = ((float.Parse(txtVotosIngles.Text) * 100f) / float.Parse(txtTotalVotos.Text)).ToString();
            
            txtPorcentajeTotal.Text = (Int32.Parse(txtPorcentajeRedes.Text) + Int32.Parse(txtPorcentajeWeb.Text) + Int32.Parse(txtPorcentajeBaseDatos.Text) + Int32.Parse(txtPorcentajeIngles.Text)).ToString();
        }
    }
}