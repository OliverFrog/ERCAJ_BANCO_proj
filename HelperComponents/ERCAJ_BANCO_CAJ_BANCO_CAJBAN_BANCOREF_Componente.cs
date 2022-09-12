
namespace ERCAJ_BANCO_proj.HelperComponents
{
	public class ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_Componente
	{
		private static readonly ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_Componente _Instance_ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_Componente = new ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_Componente();
		
		public ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_Componente()
		{
		}

		public static ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_Componente GetInstance()
		{
			return _Instance_ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_Componente;
		}

		
public bool IsEnabled { get; set; } = true;
public string Text { get; set; } = "prueba";

	}
}

