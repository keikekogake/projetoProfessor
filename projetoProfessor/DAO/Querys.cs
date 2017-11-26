using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace projetoProfessor.DAO
{
    public class Querys : AcessoDB
    {
        public int rs = 0;

        MySqlCommand cmd = new MySqlCommand();
        public void Insert(string query)
        {

            //open connection
            if (AbrirConexao() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    //close connection
                    FecharConexao();
                }
            }
        }

        public void Update(string query)
        {

            //open connection
            if (AbrirConexao() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }
                finally
                {
                    //close connection
                    AbrirConexao();
                }
            }
        }

        public void Delete(string query)
        {

            if (AbrirConexao() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }
                finally
                {
                    //close connection
                    AbrirConexao();
                }

            }
        }

        public bool Login(string email, string senha)
        {
            MySqlDataReader dtr;
            bool retorno = false;
            string query = "select count(codigo) from usuario where email = '" + email + "' and senha = '" + senha + "'";
            //open connection
            if (AbrirConexao() == true)
            {
                //Cria o comando recebendo a query e a conexão do banco.
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Executa a query
                try
                {
                    dtr = cmd.ExecuteReader();
                    while (dtr.Read())
                    {
                        int val = Int16.Parse(dtr[0].ToString());
                        if (val == 1)
                        {
                            retorno = true;
                        }
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    FecharConexao();
                }
            }
            return retorno;
        }

        public List<Professor> ConsultaProfessores()
        {
            List<Professor> list = new List<Professor>();
            string query = "select codigo, nome, email, senha, telefone, ativo from professor";
            //open connection
            if (AbrirConexao() == true)
            {
                //Cria o comando recebendo a query e a conexão do banco.
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Executa a query
                try
                {
                    Professor prof = new Professor();
                    var dtr = cmd.ExecuteReader();
                    while(dtr.Read())
                    {
                        
                        prof.Codigo = Int16.Parse(dtr.GetValue(0).ToString());
                        prof.Nome = dtr.GetValue(1).ToString();
                        prof.Email = dtr.GetValue(2).ToString();
                        prof.Senha = dtr.GetValue(3).ToString();
                        prof.Telefone = dtr.GetValue(4).ToString();
                        prof.Ativo = bool.Parse(dtr.GetValue(5).ToString());

                        list.Add(prof);
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    FecharConexao();
                }
            }
            return list;
        }
    }
}