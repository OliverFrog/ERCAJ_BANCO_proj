
namespace ERCAJ_BANCO_proj.HelperComponents
{
	public class ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_Componente
	{
		private static readonly ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_Componente _Instance_ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_Componente = new ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_Componente();
		
		public ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_Componente()
		{
		}

		public static ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_Componente GetInstance()
		{
			return _Instance_ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_Componente;
		}

		
public bool IsEnabled { get; set; } = true;
public string Text { get; set; } = "prueba";

	}
}
