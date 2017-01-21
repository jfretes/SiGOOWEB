using Opticx.Productos.Business;
using Opticx.Productos.Bussiness.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Principal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TopTresPromociones();
    }
    private void TopTresPromociones()
    {
        List<EntPromociones> lst = new BusPromociones().TopCincoPromociones();
        LiteralControl literal = new LiteralControl();
        literal.Text = "";
        int contador = 0;
        foreach (EntPromociones ent in lst)
        {
            literal = new LiteralControl();
            if (contador == 0)
                literal.Text += "<li data-target=\"#myCarousel\" data-slide-to=\"" + contador + "\" class=\"active\"></li>";
            else
                literal.Text += "<li data-target=\"#myCarousel\" data-slide-to=\"" + contador + "\"></li>";
            phIndiceUno.Controls.Add(literal);

            literal = new LiteralControl();
            if (contador == 0)
                literal.Text += "<div class=\"item active\">";
            else
                literal.Text += "<div class=\"item\">";
            literal.Text += " <img src=\"" + ent.Foto + "\" alt=\"Chania\" style=\"margin: auto;\">";
            literal.Text += " <div class=\"carousel-caption\">";
            literal.Text += "     <h3>" + ent.Nombre + "</h3>";
            literal.Text += "     <p>" + ent.Descripcion + "</p>";
            literal.Text += " </div>";
            literal.Text += "</div>";
            phFotosUno.Controls.Add(literal);
            contador++;

        }
    }
}