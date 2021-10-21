using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaExemplo.Uteis;
using System.Data;

namespace SistemaExemplo.Models
{
    public class MenuModel
    {
        public string IdEmpresa { get; set; }
        public string NomeEmpresa { get; set; }
        public string Cnpj { get; set; }

        public List<MenuModel> ListarTodasEmpresas()
        {
            List<MenuModel> lista = new List<MenuModel>();
            MenuModel item;
            DAL objDAL = new DAL();
            String sql = "SELECT idempresa, NomeEmpresa, Cnpj from empresa order by NomeEmpresa asc";
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new MenuModel
                {
                    IdEmpresa = dt.Rows[i]["idempresa"].ToString(),
                    NomeEmpresa = dt.Rows[i]["NomeEmpresa"].ToString(),
                    Cnpj = dt.Rows[i]["Cnpj"].ToString()
                };
                lista.Add(item);
            }

            return lista;
        }

        public MenuModel RetornarEmpresa(int id)
        {
            MenuModel item;
            DAL objDAL = new DAL();
            String sql = $"SELECT idempresa, NomeEmpresa, Cnpj from empresa where idempresa = '{id}' ";
            DataTable dt = objDAL.RetDataTable(sql);
            item = new MenuModel
            {
                IdEmpresa = dt.Rows[0]["idempresa"].ToString(),
                NomeEmpresa = dt.Rows[0]["NomeEmpresa"].ToString(),
                Cnpj = dt.Rows[0]["Cnpj"].ToString()
            };
            return item;
        }

        public void Inserir() {
            DAL objDAL = new DAL();
            string sql = $"update empresa set NomeEmpresa='{NomeEmpresa}', Cnpj='{Cnpj}' where idempresa = '{IdEmpresa}'";
            objDAL.ExecutarComandoSQL(sql);
        }

    }
}
