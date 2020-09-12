using POO_3D2_02_21.DAL;
using POO_3D2_02_21.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace POO_3D2_02_21.BLL
{
    public class tbLivrosBLL
    {
        private DALMysql daoBanco = new DALMysql();

        // Metodo para Consultar os dados dos Livros
        public DataTable ListarLivros(string idLivro)
        {
            string sql = string.Format($@"select * from TBL_Livro where id = '{idLivro}';");
            return daoBanco.executarConsulta(sql);
        }

        public DataTable ListarLivros()
        {
            string sql = string.Format($@"select * from TBL_Livro");
            return daoBanco.executarConsulta(sql);
        }

        // Metodo utilizado para Update na tabela Livro
        public void AlterarLivro(tblLivrosDTO dtoLivros)
        {
            string sql = string.Format($@"UPDATE TBL_Livro set nome_cliente = '{dtoLivros.IdAutor}',
                                                                 sobrenome_cliente = '{dtoLivros.IdEditora}',
                                                                 cpf_cliente = '{dtoLivros.Titulo}',
                                                                 senha_cliente = '{dtoLivros.DataCadastro}'
                                                                 senha_cliente = '{dtoLivros.num_Paginas}'
                                                                 senha_cliente = '{dtoLivros.Valor}'
                                                where idLivro = '{dtoLivros.IdLivro}';");
            daoBanco.executarComando(sql);

        }

        // Metodo para Inserir Livros
        public void InserirLivro(tblLivrosDTO dtoLivros)
        {
            string sql = string.Format($@"INSERT INTO TBL_Livro VALUES (NULL,'{dtoLivros.IdAutor}',
                                                                               '{dtoLivros.IdEditora}',   
                                                                               '{dtoLivros.Titulo}',
                                                                               '{dtoLivros.DataCadastro}',
                                                                               '{dtoLivros.num_Paginas}',
                                                                               '{dtoLivros.Valor}');");
            daoBanco.executarComando(sql);

        }

        // Metodo para Excluir Livro
        public void ExcluirLivro(tblLivrosDTO dtoLivros)
        {
            string sql = string.Format($@"DELETE FROM TBL_Livro where idLivro = {dtoLivros.IdLivro};");
            daoBanco.executarComando(sql);
        }
    }
}