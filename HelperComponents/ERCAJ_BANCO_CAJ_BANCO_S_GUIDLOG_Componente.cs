
namespace ERCAJ_BANCO_proj.HelperComponents
{
	public class ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_Componente
	{
		private static readonly ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_Componente _Instance_ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_Componente = new ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_Componente();
		
		public ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_Componente()
		{
		}

		public static ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_Componente GetInstance()
		{
			return _Instance_ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_Componente;
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

