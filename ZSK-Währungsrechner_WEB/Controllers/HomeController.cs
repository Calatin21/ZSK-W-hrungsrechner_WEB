using Microsoft.AspNetCore.Mvc;
using ZSK_Währungsrechner_WEB.Models;

namespace ZSK_Währungsrechner_WEB.Controllers {
	public class HomeController : Controller {
		public IActionResult Index() {
			return View();
		}
		[HttpGet]
		public IActionResult EuroInZSK() {
			return View();
		}
		[HttpPost]
		public ViewResult EuroInZSK(Euro daten) {
			if (ModelState.IsValid) {
				Ablage.EuroInZSK(daten);
				ZSK tiere = Ablage.GetZSK();
				return View("ErgebnisZSK", tiere);
			}
			else {
				return View();
			}
		}
		[HttpGet]
		public IActionResult ZSKInEuro() {
			return View();
		}
		[HttpPost]
		public ViewResult ZSKInEuro(ZSK daten) {
			if (ModelState.IsValid) {
				Ablage.ZSKInEuro(daten);
				Euro geld = Ablage.GetEuro();
				return View("ErgebnisEuro", geld);
			}
			else {
				return View();
			}
		}
		public ViewResult ErgebnisEuro() {
			return View(Ablage.LandTiere);
		}
		public ViewResult ErgebnisZSK() {
			return View(Ablage.LandTiere);
		}
		[HttpGet]
		public IActionResult EuroInDAHRS() {
			return View();
		}
		[HttpPost]
		public ViewResult EuroInDAHRS(Euro daten) {
			if (ModelState.IsValid) {
				Ablage.EuroInDAHRS(daten);
				DAHRS tiere = Ablage.GetDAHRS();
				return View("ErgebnisDAHRS", tiere);
			}
			else {
				return View();
			}
		}
		[HttpGet]
		public IActionResult DAHRSInEuro() {
			return View();
		}
		[HttpPost]
		public ViewResult DAHRSInEuro(DAHRS daten) {
			if (ModelState.IsValid) {
				Ablage.DAHRSInEuro(daten);				
				return View("ErgebnisEuro", Ablage.GetEuro());
			}
			else {
				return View();
			}
		}
		public IActionResult ZSKInDAHRS() {
			return View();
		}
		[HttpPost]
		public ViewResult ZSKInDAHRS(ZSK zsk) {
			if (ModelState.IsValid) {
				Ablage.ZSKInEuro(zsk);
				Euro euro = Ablage.GetEuro();
				if (euro.Betrag > 10000) {
					return View("Limit");
				}
				Ablage.EuroInDAHRS(euro);
				DAHRS dahrs = Ablage.GetDAHRS();
				return View("ErgebnisDAHRS", dahrs);
			}
			else {
				return View();
			}
		}
		public IActionResult DAHRSInZSK() {
			return View();
		}
		[HttpPost]
		public ViewResult DAHRSInZSK(DAHRS dahrs) {
			if (ModelState.IsValid) {
				Ablage.DAHRSInEuro(dahrs);
				Euro euro = Ablage.GetEuro();
				if (euro.Betrag > 10000) {
					return View("Limit");
				}
				Ablage.EuroInZSK(euro);
				ZSK zsk = Ablage.GetZSK();
				return View("ErgebnisZSK", zsk);
			}
			else {
				return View();
			}
		}
		[HttpGet]
		public IActionResult WechselkursZSK() {
			return View();
		}
		[HttpPost]
		public ViewResult WechselkursZSK(ZSK zsk) {
			if (ModelState.IsValid) {
				Ablage.SetZSK(zsk);
				return View("WechselKurs", Ablage.GetWechselKurs());
			}
			else {
				return View();
			}
		}
		[HttpGet]
		public IActionResult WechselkursDAHRS() {
			return View();
		}
		[HttpPost]
		public ViewResult WechselkursDAHRS(DAHRS dahrs) {
			if (ModelState.IsValid) {
				Ablage.SetDAHRS(dahrs);
				return View("WechselKurs", Ablage.GetWechselKurs());
			}
			else {
				return View();
			}
		}
		public ViewResult WechselKurs() {
			return View("WechselKurs", Ablage.GetWechselKurs());
		}
	}
}