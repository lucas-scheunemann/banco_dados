using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banco_Dados
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnConectar_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection();
			con.ConnectionString = Properties.Settings.Default.CST;

			//criando conexão nome con,
			//Recuperando junto às propriedades, apos digitar o Default observe que aparece uma lista de opções e
			//nesta lista deve aparecer o nome que escolhemos em Propriedades/Settings do Projeto anteriormente, no caso CS*

			try
			{
				con.Open();
				con.Close();

				MessageBox.Show("A conexao foi realizada com sucesso");
			}
			catch (Exception exc) 
			{
				MessageBox.Show(String.Format("Falha ao tentar conectar ao banco de dados", exc.Message));

				//abriu e fechou a conexao
				//exibe mensagem se a conexao foi realizada com sucesso ou não
			}
		}
	}
}
