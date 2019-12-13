using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCafeteria
{
    class Estoque
    {
        public int CapsulaId { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime Validade { get; set; }
        public int Quantidade { get; set; }

        public Estoque() { }

        public string IncluirCapsulasNoEstoque(Estoque estoque)
        {
            string result = "ok";
            int iterator = 0;

            for (iterator = 0; iterator < estoque.Quantidade; iterator++)
            {
                try
                {
                    Conexao conexao = new Conexao();
                    using (NpgsqlConnection conn = new NpgsqlConnection(conexao.ConnString))
                    {
                        conn.Open();
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "Insert into cafeteria.\"estoque\" (validade,data_entrada,capsula_id) values(@validade,@dataEntrada,@capsulasID)";
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new NpgsqlParameter("@validade", estoque.Validade));
                        cmd.Parameters.Add(new NpgsqlParameter("@dataEntrada", estoque.DataEntrada));
                        cmd.Parameters.Add(new NpgsqlParameter("@capsulasID", estoque.CapsulaId));
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    return "ERROR : " + ex.ToString();
                }
            }
            return result;
        }
    }
}
