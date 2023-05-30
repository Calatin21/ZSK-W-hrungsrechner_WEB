namespace ZSK_Währungsrechner_WEB.Models {
	public class Ablage {
		public static ZSK LandTiere { get; set; } = new();
		public static Euro Betrag { get; set; } = new();
		public static DAHRS Fische { get; set; } = new();
		public static double? PreisKuh { get; set; } = 2800;
		public static double? PreisSchaf { get; set; } = 650;
		public static double? PreisZiege { get; set; } = 500;
		public static double? PreisKleineZiege { get; set; } = 50;

		public static double? PreisDorsch { get; set; } = 8;
		public static double? PreisRochen { get; set; } = (double)Math.Round((decimal)((9d * 8d / 11d / 5d) + (7d * 8d / 11d)), 2);
		public static double? PreisAal { get; set; } = ((double)Math.Round((decimal)(8d / 11d), 2));
		public static double? PreisHering { get; set; } = ((double)Math.Round((decimal)(8d / 11d / 5d), 2));
		public static double? PreisSprotte { get; set; } = ((double) Math.Round((decimal)(8d / 11d / 5d / 11d), 2));

		public static void EuroInZSK(Euro euro) {
			Betrag.Betrag = euro.Betrag;
			LandTiere.Kuh = (int)(Betrag.Betrag / PreisKuh);
			Betrag.Betrag = (int)(Betrag.Betrag % PreisKuh);
			LandTiere.Schaf = (int)(Betrag.Betrag / PreisSchaf);
			Betrag.Betrag = (int)(Betrag.Betrag % PreisSchaf);
			LandTiere.Ziege = (int)(Betrag.Betrag / PreisZiege);
			Betrag.Betrag = (int)(Betrag.Betrag % PreisZiege);
			LandTiere.KleineZiege = (int)(Betrag.Betrag / PreisKleineZiege);		
		}
		public static void ZSKInEuro(ZSK zsk) {
			LandTiere.Kuh = zsk.Kuh;
			LandTiere.Schaf = zsk.Schaf;
			LandTiere.Ziege = zsk.Ziege;
			LandTiere.KleineZiege = zsk.KleineZiege;
			Betrag.Betrag = (int)(zsk.Kuh * PreisKuh + zsk.Schaf * PreisSchaf + zsk.Ziege * PreisZiege + zsk.KleineZiege * PreisKleineZiege);
		}
		public static void EuroInDAHRS(Euro euro) {
			int? rest = euro.Betrag;
			Fische.Dorsch = (int)(rest / PreisDorsch);
			rest = (int)((double)rest % PreisDorsch);
			Fische.Rochen = (int)(rest / PreisRochen);
			rest = (int)((double)rest % PreisRochen);
			Fische.Aal = (int)(rest / PreisAal);
			rest = (int)((double)rest % PreisAal);
			Fische.Hering = (int)(rest / PreisHering);
			rest = (int)((double)rest % PreisHering);
			Fische.Sprotten = (int)(rest / PreisSprotte);
		}
		public static void DAHRSInEuro(DAHRS dahrs) {			
			double? ergebnis = dahrs.Dorsch * PreisDorsch + dahrs.Rochen * PreisRochen + dahrs.Aal * PreisAal + dahrs.Hering * PreisHering + dahrs.Sprotten * PreisSprotte;
			Betrag.Betrag = (int)Math.Round((decimal)ergebnis, 2);
		}
		public static ZSK GetZSK() {
			return LandTiere;
		}
		public static Euro GetEuro() {
			return Betrag;
		}
		public static DAHRS GetDAHRS() {
			return Fische;
		}
		public static void SetZSK(ZSK zsk) {
			PreisKuh = zsk.Kuh;
			PreisSchaf = zsk.Schaf;
			PreisZiege = zsk.Ziege;
			PreisKleineZiege = zsk.KleineZiege;
		}
		public static void SetDAHRS(DAHRS d) {
			PreisDorsch = d.Dorsch;
			PreisAal = d.Aal;
			PreisRochen = d.Rochen;
			PreisHering = d.Hering;
			PreisSprotte = d.Sprotten;
		}
		public static List<double?> GetWechselKurs() {
			List<double?> ergebnis = new();
			ergebnis.Add(PreisKuh);
			ergebnis.Add(PreisSchaf);
			ergebnis.Add(PreisZiege);
			ergebnis.Add(PreisKleineZiege);
			ergebnis.Add(PreisDorsch);
			ergebnis.Add(PreisRochen);
			ergebnis.Add(PreisAal);
			ergebnis.Add(PreisHering);					
			ergebnis.Add(PreisSprotte);
			return ergebnis;
		}
	}
}
