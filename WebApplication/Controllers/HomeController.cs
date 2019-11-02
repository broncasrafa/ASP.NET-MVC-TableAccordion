using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {            
            return View();
        }

        public JsonResult GetData()
        {
            try
            {
                List<Parcela> Parcelas = Parcela.GetParcelas();

                return Json(new { data = Parcelas, status = "OK" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { mensagem = $"Ocorreu um erro: {ex.Message}", status = "ERROR" }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult SalvarParcela(Parcela parcela, int idPagamento, int idProjeto)
        {
            try
            {
                if (idPagamento > 0)
                {                                        
                    return Json(new { data = parcela, status = "OK" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    // cria o pagamento no projeto
                    // pega o id do pagamento criado e salva a parcela
                    return Json(new { data = parcela, status = "OK" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { mensagem = $"Ocorreu um erro: {ex.Message}", status = "ERROR" }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult EditarParcela(Parcela parcela, int idPagamento, int idProjeto)
        {
            try
            {
                if (idPagamento > 0)
                {                    
                    return Json(new { data = parcela, status = "OK" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    // cria o pagamento no projeto
                    // pega o id do pagamento criado e salva a parcela
                    return Json(new { data = parcela, status = "OK" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { mensagem = $"Ocorreu um erro: {ex.Message}", status = "ERROR" }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult DeletarParcela(int idParcela)
        {
            try
            {
                return Json(new { mensagem = "Parcela removida com sucesso", status = "OK" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { mensagem = $"Ocorreu um erro: {ex.Message}", status = "ERROR" }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}