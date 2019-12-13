using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public bool VerificarCapulasNoEstoque(int capsulaId, int quantidadeXicaras)
        {
            bool result = true;
            DataTable dtCapsula = new DataTable();
            try
            {
                Conexao conexao = new Conexao();
                using (NpgsqlConnection conn = new NpgsqlConnection(conexao.ConnString))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    string dataDeHoje = DateTime.Now.ToString("yyyy-MM-dd");

                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "select count(*) as quantidade_capsulas from cafeteria.\"estoque\" where \"capsula_id\" = @CapsulaId and \"data_saida\" ISNULL and \"validade\" > @DataDeHoje";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@capsulaId", capsulaId));
                    cmd.Parameters.Add(new NpgsqlParameter("@DataDeHoje", Convert.ToDateTime(dataDeHoje)));

                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    dtCapsula.Load(reader);
                    cmd.Dispose();
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }

            int quantidadeCapsulas = Convert.ToInt32(dtCapsula.Rows[0]["quantidade_capsulas"]);

            if(quantidadeCapsulas < quantidadeXicaras)
            {
                result = false;
            }

            return result;
        }

        public bool ExcluirCapsulasDoEstoque(int capsulaId, int quantidadeCapsulas)
        {
            bool result = true;

            Conexao conexao = new Conexao();
            string quantidade = quantidadeCapsulas.ToString();
            string capsula = capsulaId.ToString();

            using (NpgsqlConnection conn = new NpgsqlConnection(conexao.ConnString))
            {
                DataTable dtCapsula = new DataTable();
                string sql = "select * from cafeteria.\"estoque\" where \"capsula_id\" = " + capsula + " and \"data_saida\" ISNULL LIMIT " + quantidade;
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                conn.Open();
                NpgsqlDataReader reader = cmd.ExecuteReader();
                dtCapsula.Load(reader);

                foreach (DataRow linha in dtCapsula.Rows)
                {
                    string indice = linha["estoque_id"].ToString();
                    string data = DateTime.Now.ToString("yyyy-MM-dd");

                    sql = "UPDATE cafeteria.\"estoque\" SET \"data_saida\" = '" + data + "' WHERE \"estoque_id\" = " + indice + ";";
                    NpgsqlCommand cmdUpdateCapsulas = new NpgsqlCommand(sql, conn);
                    cmdUpdateCapsulas.ExecuteNonQuery();
                }
                conn.Close();
            }
            return result;
        }
    }
}
