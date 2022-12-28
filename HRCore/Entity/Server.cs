using System;
using System.Data.Common;
using Newtonsoft.Json;
//using Npgsql;

using HRCore.Util;

namespace HRCore.Entity
{
    [Serializable]
    public class Server : IDisposable
    {
        public bool Online { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string DatabaseName { get; set; }
        public string DatabaseUserID { get; set; }
        public string DatabasePassword { get; set; }

        [JsonIgnore]
        public string ApplicationName { get; set; }

        [JsonIgnore]
        public string Provider { get
            {
                return "Npgsql";
            }
            private set
            {
            }
        } 

        [JsonIgnore]
        public string ConnectionString { 
            get
            {
                //return $"HOST=localhost;PORT=5432;DATABASE=ATE2020;PASSWORD=123456;USER ID=postgres;";
                string password = GetPassword();
                //return $"HOST={Host};PORT={Port};DATABASE={DatabaseName};USER ID={DatabaseUserID};PASSWORD={password};";
                return $"HOST={Host};PORT={Port};DATABASE={DatabaseName};USER ID={DatabaseUserID};PASSWORD={password};APPLICATIONNAME={ApplicationName};";
            }
        }

        public string DefaultUserNO { get; set; }

        public Server()
        {
        }

        public Server(DbConnection connection)
        {
        }

        ~Server()
        {
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                //执行基本的清理代码
            }
        }

        public void Open()
        {
            //using (NpgsqlConnection cn = new NpgsqlConnection(ConnectionString))
            //{
            //    try
            //    {
            //        cn.Open();
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }
            //}
        }

        public bool ConnectionTesting()
        {
            bool connected = false;

            //using (NpgsqlConnection cn = new NpgsqlConnection(ConnectionString))
            //{
            //    try
            //    {
            //        cn.Open();
            //        connected = true;
            //    }
            //    catch
            //    {
            //        connected = false;
            //    }
            //}
            return connected;
        }
    
        public void SetPassword(string password)
        {
            DatabasePassword = CryptoHelper.Md5Encrypt(password);
        }

        public string GetPassword()
        {
            if (string.IsNullOrEmpty(DatabasePassword)) return string.Empty;
            return CryptoHelper.Md5Decrypt(DatabasePassword);
        }
    }
}
