using System.ComponentModel.DataAnnotations;

namespace ZSK_Währungsrechner_WEB.Models {
	public class ZSK {		
		[Required(ErrorMessage = "Bitte einen Schaf Betrag eingeben!")]
		public double? Schaf { get; set; }
		[Required(ErrorMessage = "Bitte einen Ziege Betrag eingeben!")]
		public double? Ziege { get; set; }
		[Required(ErrorMessage = "Bitte einen Kuh Betrag eingeben!")]
		public double? Kuh { get; set; }
		[Required(ErrorMessage = "Bitte einen kleine Ziege Betrag eingeben!")]
		public double? KleineZiege { get; set; }		
	}
}
