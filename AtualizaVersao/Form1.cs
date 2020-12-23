using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AtualizaVersao
{
    public partial class frmAtualizaVersao : Form
    {
        public frmAtualizaVersao()
        {
            InitializeComponent();
            OpenSqlConnection("suporte-ti", "SQLEXPRESS", "DeltaDELTA", "sa", "857142");
        }

       
        public SqlConnection OpenSqlConnection(String server, String instance, String dbName, String user, String passwrd)
        {
            SqlConnection sqlConn;
            sqlConn = new SqlConnection("Server="+server+"\\"+instance+";Database="+dbName+";User Id="+user+";Password="+passwrd+";");
            //do something here
            StringBuilder errorMessages = new StringBuilder();
            try {
                sqlConn.Open();
                
                if (sqlConn.State.ToString() == "Open") {
                    StatusBarConnetion.Text += "Aberta em " + dbName; 
                    return sqlConn; 
                } 
            }
            catch (SqlException ex) {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                    StatusBarConnetion.Text = "Conexão: Erro ao abrir conexão, entre em contato com o suporte";
                }
                Console.WriteLine(errorMessages.ToString());
            }
            return sqlConn;
        }
        

        }


    }

