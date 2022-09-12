
namespace ERCAJ_BANCO_proj.HelperComponents
{
	public class ERCAJ_BANCO_CAJ_BANCO_S_FI_Componente
	{
		private static readonly ERCAJ_BANCO_CAJ_BANCO_S_FI_Componente _Instance_ERCAJ_BANCO_CAJ_BANCO_S_FI_Componente = new ERCAJ_BANCO_CAJ_BANCO_S_FI_Componente();
		
		public ERCAJ_BANCO_CAJ_BANCO_S_FI_Componente()
		{
		}

		public static ERCAJ_BANCO_CAJ_BANCO_S_FI_Componente GetInstance()
		{
			return _Instance_ERCAJ_BANCO_CAJ_BANCO_S_FI_Componente;
		}

		
public event EventHandler<string> EventBind;
public bool IsEnabled { get; set; } = true;
public string Text { 
    get
    {
        return Text;
    }
    set
    {
        EventBind.Invoke(this, value);
    }
}

	}
}

