using POO_3D2_02_21.BLL;
using POO_3D2_02_21.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace POO_3D2_02_21
{
    public partial class FrmLivros : System.Web.UI.Page
    {
        // Instanciar Blls e DTOs
        tbLivrosBLL bllLivros = new tbLivrosBLL();
        tblLivrosDTO dtoLivros = new tblLivrosDTO();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {

            try
            {
                // inserir os dados da UI no DTO
                dtoLivros.IdAutor = int.Parse(txtAutor.Text);
                dtoLivros.IdEditora = int.Parse(txtEditora.Text);
                dtoLivros.Titulo = txtData.Text;
                dtoLivros.num_Paginas = txtPaginas.Text;
                dtoLivros.Valor = double.Parse(txtPreco.Text);

                // Inserir na tabela de clientes
                bllLivros.InserirLivro(dtoLivros);
                msgerro.Visible = true;
                msgerro.Text = "Livro Cadastrado com Sucesso";
                this.LimparCampos();
                this.ExibirGridLivros();


            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }

        }

        // Metodo para Exibir Dados no Grid
        public void ExibirGridLivros()
        {
            GridLivros.DataSource = bllLivros.ListarLivros();
            GridLivros.DataBind();
        }

        protected void GridLivros_RowDeleting(object sender, GridViewDeleteEventArgs Registro)
        {
            try
            {
                dtoLivros.IdLivro = Convert.ToInt32(Registro.Values[0]);
                bllLivros.ExcluirLivro(dtoLivros);
                this.ExibirGridLivros();
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }
        public void LimparCampos()
        {
            txtAutor.Text = "";
            txtEditora.Text = "";
            txtTitulo.Text = "";
            txtPaginas.Text = "";
            txtPreco.Text = "";
            txtData.Text = "";
        }

        // Metodo para Edição de Dados no Grid
        protected void GridLivros_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridLivros.EditIndex = e.NewEditIndex;
            this.ExibirGridLivros();
        }
        // Metodo Utilizado para Salvar a Edição dos dados do grid
        protected void GridLivros_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                dtoLivros.Titulo = e.NewValues[3].ToString();
                dtoLivros.num_Paginas = e.NewValues[4].ToString();
                dtoLivros.Valor = Double.Parse(e.NewValues[5].ToString());
                bllLivros.AlterarLivro(dtoLivros);
                GridLivros.EditIndex = -1;
                this.ExibirGridLivros();
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }
        // Metodo para Cancelar Edição no Grid
        protected void GridLivros_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridLivros.EditIndex = -1;
            this.ExibirGridLivros();
        }

        protected void GridLivros_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridLivros.PageIndex = e.NewPageIndex;
            this.ExibirGridLivros();
        }
    }
}