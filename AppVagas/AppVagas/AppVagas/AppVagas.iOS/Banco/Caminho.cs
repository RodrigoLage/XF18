using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using AppVagas.iOS.Banco;
using AppVagas.Banco;

[assembly: Dependency(typeof(Caminho))]
namespace AppVagas.iOS.Banco
{
    class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            string caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string caminhoDaBiblioteca = Path.Combine(caminhoDaPasta, "..", "Library");

            string caminhoBanco = Path.Combine(caminhoDaBiblioteca, NomeArquivoBanco);

            return caminhoBanco;
        }
    }
}