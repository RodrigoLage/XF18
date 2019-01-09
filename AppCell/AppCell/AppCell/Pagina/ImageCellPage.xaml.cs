using AppCell.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AppCell.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageCellPage : ContentPage
	{
		public ImageCellPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Foto = "http://creaes.org.br/creaes/portals/1/Images/presidente_helder_perfil.jpg",  Nome = "José", Cargo = "Presidente da Empresa"});
            Lista.Add(new Funcionario() { Foto = "http://graziellanicolai.com.br/wp-content/uploads/2018/03/Graziella-perfil.jpg",  Nome = "Maria", Cargo = "Gerente de Vendas" });
            Lista.Add(new Funcionario() { Foto = "http://www.lorearquitetura.com.br/cms/wp-content/uploads/2012/12/Foto-Perfil.gif", Nome = "Elaine", Cargo = "Gerente de Marketing" });
            Lista.Add(new Funcionario() { Foto = "https://oba.portal5g-media.com/contentFiles/system/pictures/2014/10/286493/cropped/crianca-4.jpg", Nome = "Felipe", Cargo = "Entregador" });
            Lista.Add(new Funcionario() { Foto = "https://assets4.domestika.org/project-items/001/228/844/sesion-estudio-barcelona-10-big.jpg?1425034585", Nome = "João", Cargo = "Vendedor" });

            ListaFuncionario.ItemsSource = Lista;

        }
	}
}