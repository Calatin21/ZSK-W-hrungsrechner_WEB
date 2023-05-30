using System.ComponentModel.DataAnnotations;

namespace ZSK_Währungsrechner_WEB.Models {
	public class DAHRS {
		[Required(ErrorMessage = "Bitte einen Dorsch Betrag eingeben!")]
		public double? Dorsch { get; set; }
		[Required(ErrorMessage = "Bitte einen Aal Betrag eingeben!")]
		public double? Aal { get; set; }
		[Required(ErrorMessage = "Bitte einen Hering Betrag eingeben!")]
		public double? Hering { get; set; }
		[Required(ErrorMessage = "Bitte einen Rochen Betrag eingeben!")]
		public double? Rochen { get; set; }
		[Required(ErrorMessage = "Bitte einen Sprotten Betrag eingeben!")]
		public double? Sprotten { get; set; }
	}
}
