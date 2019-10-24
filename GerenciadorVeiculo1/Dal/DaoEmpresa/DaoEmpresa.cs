using dllDao;
using GerenciadorVeiculo1.Entitys;
using GerenciadorVeiculo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculo1.Dal.DaoEmpresa
{
    class DaoEmpresa
    {
        public Empresa empresa { get; set; }
        public Telefone telefone { get; set; }

        Conexao conexao = new Conexao();

        //consulta inicial das empresas
        public DataTable ConsultaEmpresa(string status)
        {
            string query="";
            //traz as empresas que tem como status = ativo
            if (status == "ATIVO")
            {
                query = "SELECT EP.EMP_INT_ID AS ID, EP.EMP_STR_NOME AS NOME, EMP_STR_CNPJ AS CNPJ, T.TEL_INT_CELULAR AS CELULAR, T.TEL_INT_FIXO AS FIXO"
                + " FROM TBL_EMPRESA AS EP INNER JOIN TBL_TELEFONE AS T ON T.TEL_INT_ID = EP.TEL_INT_ID WHERE EP.EMP_STR_STATUS = 'ATIVO'";
            }
            //traz todas as empresas
            else
            {
                query = "SELECT EP.EMP_INT_ID AS ID, EP.EMP_STR_NOME AS NOME, EMP_STR_CNPJ AS CNPJ, T.TEL_INT_CELULAR AS CELULAR, T.TEL_INT_FIXO AS FIXO"
               + " FROM TBL_EMPRESA AS EP INNER JOIN TBL_TELEFONE AS T ON T.TEL_INT_ID = EP.TEL_INT_ID";
            }

            DataTable dt = conexao.CarregarDados(query);
            return dt;
        }
        //traz todos os ID
        public SqlDataReader TrazTodosId()
        {
            string query = "SELECT EP.EMP_INT_ID, T.TEL_INT_ID, EDP.EMP_INT_ID, E.END_INT_ID FROM TBL_EMPRESA AS EP"
            +" INNER JOIN TBL_TELEFONE AS T ON T.TEL_INT_ID = EP.TEL_INT_ID"
            +" INNER JOIN TBL_ENDERECO_EMPRESA AS EDP ON EDP.EMP_INT_ID = EP.EMP_INT_ID"
            +" INNER JOIN TBL_ENDERECO AS E ON E.END_INT_ID = EDP.END_INT_ID WHERE EP.EMP_INT_ID = " + empresa.EmpId.ToString();

            SqlDataReader dr = conexao.CarregarVariosDados(query);
            return dr;
        }
        public void DeleteEmpresa()
        {
            string idTel,idEndEmp,idEnd;

            SqlDataReader dr;
            dr= TrazTodosId();

            //Passando os ID para as Variaveis
            idTel = dr["TEL_INT_ID"].ToString();
            idEndEmp = dr["EMP_INT_ID"].ToString();
            idEnd = dr["END_INT_ID"].ToString();

            SqlConnection con = new SqlConnection(conexao.StrConexao());

            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand cmd3 = con.CreateCommand();
            SqlCommand cmd4 = con.CreateCommand();

            cmd1.CommandText = "DELETE TBL_ENDERECO_EMPRESA WHERE EMP_INT_ID = " + empresa.EmpId;
            cmd2.CommandText = "DELETE TBL_ENDERECO WHERE END_INT_ID = " + idEnd;
            cmd3.CommandText = "DELETE TBL_EMPRESA WHERE EMP_INT_ID = " + empresa.EmpId;
            cmd4.CommandText = "DELETE TBL_TELEFONE WHERE TEL_INT_ID = " + idTel;

            con.Open();

            SqlTransaction tran = con.BeginTransaction();

            try
            {
                cmd1.Transaction = tran;
                cmd1.ExecuteNonQuery();
                cmd2.Transaction = tran;
                cmd2.ExecuteNonQuery();
                cmd3.Transaction = tran;
                cmd3.ExecuteNonQuery();
                cmd4.Transaction = tran;
                cmd4.ExecuteNonQuery();

                tran.Commit();
            }
            catch (Exception)
            {
                tran.Rollback();

                throw new DomainExceptions("Erro, ao excluir a empresa, verifique se não á motoristas cadastrados que ainda estão vinculados a essa empresa.");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
