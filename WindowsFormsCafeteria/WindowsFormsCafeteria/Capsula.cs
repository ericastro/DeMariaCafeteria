using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCafeteria
{
    public class Capsula
    {
        public Capsula()
        {

        }

        public int CapsulasId { get; set; }
        public string Descricao { get; set; }
        public int Forca { get; set; }

        public string IncluirCapsula(Capsula capsula)
        {
            string result = "ok";
            try
            {
                Conexao conexao = new Conexao();
                using (NpgsqlConnection conn = new NpgsqlConnection(conexao.ConnString))
                {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Insert into cafeteria.\"capsulas\" (descricao,forca) values (@descricao,@forca)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@descricao", capsula.Descricao));
                    cmd.Parameters.Add(new NpgsqlParameter("@forca", capsula.Forca));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                return "ERROR : " + ex.ToString();
            }
            return result;
        }

        public DataTable ListarCapsulas()
        {
            DataTable dtCapsula = new DataTable();
            Conexao conexao = new Conexao();
            NpgsqlConnection conn = new NpgsqlConnection(conexao.ConnString);

            string sql = "SELECT * FROM cafeteria.\"capsulas\"";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            conn.Open();
            NpgsqlDataReader reader = cmd.ExecuteReader();

            dtCapsula.Load(reader);
            conn.Close();
            return dtCapsula;
        }


        public void EditarCapsulas(Capsula capsula)
        {

        }

        public void ExcluirCapsulas(int capusla_id)
        {

        }
    }



}
