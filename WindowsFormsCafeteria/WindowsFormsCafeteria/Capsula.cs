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

        public int Capsulas_id { get; set; }
        public string Descricao { get; set; }
        public int Forca
        {
            get
            {
                return forca;
            }
            set
            {
                if( (this.forca > 0) && (this.forca < 11) )
                {
                    forca = Forca;
                }
                else
                {
                    forca = 0;
                }
            }
        }

        public string IncluirCapsula(Capsula capsula)
        {
            string result = "ok";
            try
            {
                Conexao conexao = new Conexao();
                /* Insertion After Validations*/
                using (NpgsqlConnection conn = new NpgsqlConnection(conexao.ConnString))
                {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Insert into public.\"capsulas\" (descricao,forca) values (@descricao,@forca)";
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

        public void LitarCapsulas()
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
