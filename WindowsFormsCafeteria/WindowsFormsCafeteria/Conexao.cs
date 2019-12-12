using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsCafeteria
{
    class Conexao
    {
        private string serverName;
        private string port;
        private string userName;
        private string password;
        private string dataBaseName;
        private string connString;
        private NpgsqlConnection conn;

        //TODO
        //CRIAR UM ARMAZENAMENTO PARA CONFIGURAÇÕES 
        //EM UM ARQUIVO TXT JSON OU XML
        //E METODOS PARA RECUPERA-LOS

        public Conexao()
        {
            ServerName = ServerNameFromJson();
            Port = ServerPortFromJson();
            UserName = UserNameFromJson();
            Password = PasswordFromJson();
            DatabaseName = DataBaseFromJson();
        }

        public string ServerName
        {
            get
            {
                if (String.IsNullOrEmpty(serverName))
                    serverName = "127.0.0.1";
                return serverName;
            }
            set => serverName = value;
        }

        public string Port
        {
            get
            {
                if (String.IsNullOrEmpty(port))
                    port = "5432";
                return port;
            }
            set => port = value;
        }

        public string UserName
        {
            get
            {
                if (String.IsNullOrEmpty(userName))
                    userName = "postgres";
                return userName;
            }
            set => userName = value;
        }

        public string Password
        {
            get
            {
                if (String.IsNullOrEmpty(password))
                    password = "123";
                return password;
            }
            set => password = value;
        }

        public string DatabaseName
        {
            get
            {
                if (String.IsNullOrEmpty(dataBaseName))
                    dataBaseName = "DeMariaEric";
                return dataBaseName;
            }
            set => dataBaseName = value;
        }

        public string ConnString
        {
            get
            {
                if (String.IsNullOrEmpty(connString))
                {
                    connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4}", ServerName, port, userName, password, dataBaseName);
                }
                return connString;
            }
            set => connString = value;
        }

        public NpgsqlConnection Conn
        {
            get => conn;
            set
            {
                try
                {
                    conn = new NpgsqlConnection(ConnString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection ERROR = " + ex.ToString());
                    throw;
                }
            }
        }

        private string ServerNameFromJson()
        {
            return "127.0.0.1";
        }

        private string ServerPortFromJson()
        {
            return "5432";
        }

        private string UserNameFromJson()
        {
            return "postgres";
        }

        private string PasswordFromJson()
        {
            return "123";
        }

        private string DataBaseFromJson()
        {
            return "Cafeteria";
        }
    }
}
