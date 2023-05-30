using System.ComponentModel.DataAnnotations;

namespace ZSK_Währungsrechner_WEB.Models {
	public class Euro {
		[Required(ErrorMessage = "Bitte einen Euro Betrag eingeben!")]
		public int? Betrag { get; set; }
	}
}
