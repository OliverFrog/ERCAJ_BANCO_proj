
namespace ERCAJ_BANCO_proj.HelperComponents
{
	public class ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_Componente
	{
		private static readonly ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_Componente _Instance_ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_Componente = new ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_Componente();
		
		public ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_Componente()
		{
		}

		public static ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_Componente GetInstance()
		{
			return _Instance_ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_Componente;
		}

		
public bool IsEnabled { get; set; } = true;
public string Text { get; set; } = "prueba";

	}
}

