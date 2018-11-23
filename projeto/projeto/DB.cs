using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading.Tasks;

namespace projeto
{
    class DB
    {
        #region Atributos
        
        private MySqlConnection _conexao;
        private MySqlCommand _comandoDB;
        private MySqlDataAdapter _adaptador;
        private DataSet _dados;
        #endregion


        #region Propriedades
        public string Host { get; set; } = "localhost";
        public string DBName { get; set; } = "";
        public string Usuario { get; set; } = "root";
        public string Senha { get; set; } = "";

        #endregion

        #region Construtor

        public DB()
        { }
        #endregion


        #region Métodos
        public void Conectar()
        {



            string strConexao = "Server=" + Host;
            strConexao += ";Database =" + DBName;
            strConexao += ";Uid=" + Usuario;
            strConexao += ";Pwd=" + Senha;
            strConexao += ";SSL Mode = None";


            try
            {
                //bloco de comandos sujeitos a erro
                _conexao = new MySqlConnection(strConexao);
                if (_conexao.State.Equals(ConnectionState.Closed))
                {
                    _conexao.Open();
                }

            }
            catch (MySqlException erro)
            {
                // capturar o erro,caso ocorra
                throw new Exception(erro.Message);

            }
            finally
            {
                // libera o recurso, caso necessário, mesmo no erro
                _conexao.Dispose();
            }




        }
        public void Inserir(string strSQL)
        {


            try
            {
                if (_conexao.State.Equals(ConnectionState.Closed))
                {
                    _conexao.Open();

                }

                _comandoDB = _conexao.CreateCommand();
                _comandoDB.CommandText = strSQL;

                if (_comandoDB.ExecuteNonQuery() != 1)
                {
                    throw new Exception("Falha ao inserir");
                }
            }

            catch (MySqlException erro)
            {
                throw new Exception("Erro ao Inserir: " + erro.Message);
            }




        }
        public DataSet Buscar(string strSQL)
        {
            if (_conexao.State.Equals(ConnectionState.Closed))
            {
                _conexao.Open();

            }
            try
            {
                _dados = new DataSet();

                //Cria um adaptador para receber
                // o retorno  da consulta

                _adaptador = new MySqlDataAdapter(strSQL, _conexao);
                _adaptador.Fill(_dados, "tbl_resultado");

                return _dados;
            }
            catch (MySqlException erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {

            }
        }
        public void Atualizar() { }
        public void Excluir() { }
        #endregion
    }
}
