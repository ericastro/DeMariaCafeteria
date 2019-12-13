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
        private int forca;

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

        public void ListarCapsulas()
        {

        }

        public void EditarCapsulas(Capsula capsula)
        {

        }

        public void ExcluirCapsulas(int capusla_id)
        {

        }
    }



}
