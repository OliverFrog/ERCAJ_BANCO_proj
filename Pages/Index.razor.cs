
using BlazeMaxControls.Helpers;
using ERCAJ_BANCO_proj.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using veXMAX.Lib.Extension;
using veXMAX.Resources;
using veXMAX.Shared.Attributes;
using veXMAX.Shared.Models.Transactions;
using ERCAJ_BANCO_proj.HelperComponents;

namespace ERCAJ_BANCO_proj.Pages
{
    public partial class Index
    {
		[Inject]
        IStringLocalizer<VXModelLabels> L { get; set; }
        [Inject]
        SimpleTransactionService service { get; set; }

		ERCAJ_BANCO _ERCAJ_BANCO { get; set; }
		List<VXLayOutFieldAttribute> _LayoutL = new List<VXLayOutFieldAttribute>();

		protected override async Task OnInitializedAsync()
		{	
			
    ERCAJ_BANCO_CAJ_BANCO_SYSUDN_CODIGO_K_Componente = ERCAJ_BANCO_CAJ_BANCO_SYSUDN_CODIGO_K_Componente.GetInstance();
    ERCAJ_BANCO_CAJ_BANCO_SYSUDN_CODIGO_K_Componente.EventBind += ERCAJ_BANCO_CAJ_BANCO_SYSUDN_CODIGO_K_Cambio;

    ERCAJ_BANCO_CAJ_BANCO_SYSTRA_CODIGO_K_Componente = ERCAJ_BANCO_CAJ_BANCO_SYSTRA_CODIGO_K_Componente.GetInstance();
    ERCAJ_BANCO_CAJ_BANCO_SYSTRA_CODIGO_K_Componente.EventBind += ERCAJ_BANCO_CAJ_BANCO_SYSTRA_CODIGO_K_Cambio;

    ERCAJ_BANCO_CAJ_BANCO_CAJBAN_SERIE_K_Componente = ERCAJ_BANCO_CAJ_BANCO_CAJBAN_SERIE_K_Componente.GetInstance();
    ERCAJ_BANCO_CAJ_BANCO_CAJBAN_SERIE_K_Componente.EventBind += ERCAJ_BANCO_CAJ_BANCO_CAJBAN_SERIE_K_Cambio;

    ERCAJ_BANCO_CAJ_BANCO_CAJBAN_REFERENCIA_Componente = ERCAJ_BANCO_CAJ_BANCO_CAJBAN_REFERENCIA_Componente.GetInstance();
    ERCAJ_BANCO_CAJ_BANCO_CAJBAN_REFERENCIA_Componente.EventBind += ERCAJ_BANCO_CAJ_BANCO_CAJBAN_REFERENCIA_Cambio;

    ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_Componente = ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_Componente.GetInstance();
    ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_Componente.EventBind += ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_Cambio;

    ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_Componente = ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_Componente.GetInstance();
    ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_Componente.EventBind += ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_Cambio;

    ERCAJ_BANCO_CAJ_BANCO_SYSTTP_CODIGO_K_Componente = ERCAJ_BANCO_CAJ_BANCO_SYSTTP_CODIGO_K_Componente.GetInstance();
    ERCAJ_BANCO_CAJ_BANCO_SYSTTP_CODIGO_K_Componente.EventBind += ERCAJ_BANCO_CAJ_BANCO_SYSTTP_CODIGO_K_Cambio;

    ERCAJ_BANCO_CAJ_BANCO_SYSTTS_CODIGO_K_Componente = ERCAJ_BANCO_CAJ_BANCO_SYSTTS_CODIGO_K_Componente.GetInstance();
    ERCAJ_BANCO_CAJ_BANCO_SYSTTS_CODIGO_K_Componente.EventBind += ERCAJ_BANCO_CAJ_BANCO_SYSTTS_CODIGO_K_Cambio;

    ERCAJ_BANCO_CAJ_BANCO_S_FI_Componente = ERCAJ_BANCO_CAJ_BANCO_S_FI_Componente.GetInstance();
    ERCAJ_BANCO_CAJ_BANCO_S_FI_Componente.EventBind += ERCAJ_BANCO_CAJ_BANCO_S_FI_Cambio;

    ERCAJ_BANCO_CAJ_BANCO_S_GUID_Componente = ERCAJ_BANCO_CAJ_BANCO_S_GUID_Componente.GetInstance();
    ERCAJ_BANCO_CAJ_BANCO_S_GUID_Componente.EventBind += ERCAJ_BANCO_CAJ_BANCO_S_GUID_Cambio;

    ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_Componente = ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_Componente.GetInstance();
    ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_Componente.EventBind += ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_Cambio;

    ERCAJ_BANCO_CAJ_BANCO_S_USUARIO_Componente = ERCAJ_BANCO_CAJ_BANCO_S_USUARIO_Componente.GetInstance();
    ERCAJ_BANCO_CAJ_BANCO_S_USUARIO_Componente.EventBind += ERCAJ_BANCO_CAJ_BANCO_S_USUARIO_Cambio;

    ERCAJ_BANCO_CAJ_BANCO_S_USUARIODB_Componente = ERCAJ_BANCO_CAJ_BANCO_S_USUARIODB_Componente.GetInstance();
    ERCAJ_BANCO_CAJ_BANCO_S_USUARIODB_Componente.EventBind += ERCAJ_BANCO_CAJ_BANCO_S_USUARIODB_Cambio;

    ERCAJ_BANCO_CAJ_BANCO_S_USUARIONOT_Componente = ERCAJ_BANCO_CAJ_BANCO_S_USUARIONOT_Componente.GetInstance();
    ERCAJ_BANCO_CAJ_BANCO_S_USUARIONOT_Componente.EventBind += ERCAJ_BANCO_CAJ_BANCO_S_USUARIONOT_Cambio;

    ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_Componente = ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_Componente.GetInstance();
    ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_Componente.EventBind += ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_Cambio;

			TemplateHelper Template = new TemplateHelper();		
			_ERCAJ_BANCO = new ERCAJ_BANCO();
			_ERCAJ_BANCO = await service.GetFirst<ERCAJ_BANCO>();
			await base.OnInitializedAsync();
		}

		private List<ComboEnumWrapper> EnumOptionsList(string Field)
		{
			return Enum.GetValues(Field.GetType()).OfType<Enum>().Select(t => new ComboEnumWrapper { Type = t, DisplayText = t.ToSafeString() }).ToList();
		}
		private string sEnumCaption(string Field)
		{
			return $"{Field.ToInt16()} - {Field.ToString()}";
		}
		private string sMaqEdoDesc
		{
			get => $"{_ERCAJ_BANCO.CAJ_BANCO.S_MAQEDO.ToInt16()} - {_ERCAJ_BANCO.CAJ_BANCO.S_MAQEDO.ToString()}"; set { }
		}

		
private ERCAJ_BANCO_Funciones funciones = new ERCAJ_BANCO_Funciones();
//Metodos y atributos de _ERCAJ_BANCO.CAJ_BANCO.SYSUDN_CODIGO_K
public ERCAJ_BANCO_CAJ_BANCO_SYSUDN_CODIGO_K_Componente ERCAJ_BANCO_CAJ_BANCO_SYSUDN_CODIGO_K_Componente;
private void ERCAJ_BANCO_CAJ_BANCO_SYSUDN_CODIGO_K_OnChange(ChangeEventArgs args)
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_SYSUDN_CODIGO_K_Componente.Text = args.Value.ToString();
    funciones.ERCAJ_BANCO_CAJ_BANCO_SYSUDN_CODIGO_K_OnChange();
}
private void ERCAJ_BANCO_CAJ_BANCO_SYSUDN_CODIGO_K_Cambio(object sender, string data)
{
    _ERCAJ_BANCO.CAJ_BANCO.SYSUDN_CODIGO_K = data;
}
private void ERCAJ_BANCO_CAJ_BANCO_SYSUDN_CODIGO_K_OnFocus()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_SYSUDN_CODIGO_K_OnFocus();
}
private void ERCAJ_BANCO_CAJ_BANCO_SYSUDN_CODIGO_K_OnBlur()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_SYSUDN_CODIGO_K_OnBlur();
}
//Metodos y atributos de _ERCAJ_BANCO.CAJ_BANCO.SYSTRA_CODIGO_K
public ERCAJ_BANCO_CAJ_BANCO_SYSTRA_CODIGO_K_Componente ERCAJ_BANCO_CAJ_BANCO_SYSTRA_CODIGO_K_Componente;
private void ERCAJ_BANCO_CAJ_BANCO_SYSTRA_CODIGO_K_OnChange(ChangeEventArgs args)
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_SYSTRA_CODIGO_K_Componente.Text = args.Value.ToString();
    funciones.ERCAJ_BANCO_CAJ_BANCO_SYSTRA_CODIGO_K_OnChange();
}
private void ERCAJ_BANCO_CAJ_BANCO_SYSTRA_CODIGO_K_Cambio(object sender, string data)
{
    _ERCAJ_BANCO.CAJ_BANCO.SYSTRA_CODIGO_K = data;
}
private void ERCAJ_BANCO_CAJ_BANCO_SYSTRA_CODIGO_K_OnFocus()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_SYSTRA_CODIGO_K_OnFocus();
}
private void ERCAJ_BANCO_CAJ_BANCO_SYSTRA_CODIGO_K_OnBlur()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_SYSTRA_CODIGO_K_OnBlur();
}
//Metodos y atributos de _ERCAJ_BANCO.CAJ_BANCO.CAJBAN_SERIE_K
public ERCAJ_BANCO_CAJ_BANCO_CAJBAN_SERIE_K_Componente ERCAJ_BANCO_CAJ_BANCO_CAJBAN_SERIE_K_Componente;
private void ERCAJ_BANCO_CAJ_BANCO_CAJBAN_SERIE_K_OnChange(ChangeEventArgs args)
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_CAJBAN_SERIE_K_Componente.Text = args.Value.ToString();
    funciones.ERCAJ_BANCO_CAJ_BANCO_CAJBAN_SERIE_K_OnChange();
}
private void ERCAJ_BANCO_CAJ_BANCO_CAJBAN_SERIE_K_Cambio(object sender, string data)
{
    _ERCAJ_BANCO.CAJ_BANCO.CAJBAN_SERIE_K = data;
}
private void ERCAJ_BANCO_CAJ_BANCO_CAJBAN_SERIE_K_OnFocus()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_CAJBAN_SERIE_K_OnFocus();
}
private void ERCAJ_BANCO_CAJ_BANCO_CAJBAN_SERIE_K_OnBlur()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_CAJBAN_SERIE_K_OnBlur();
}
//Metodos y atributos de _ERCAJ_BANCO.CAJ_BANCO.CAJBAN_REFERENCIA
public ERCAJ_BANCO_CAJ_BANCO_CAJBAN_REFERENCIA_Componente ERCAJ_BANCO_CAJ_BANCO_CAJBAN_REFERENCIA_Componente;
private void ERCAJ_BANCO_CAJ_BANCO_CAJBAN_REFERENCIA_OnChange(ChangeEventArgs args)
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_CAJBAN_REFERENCIA_Componente.Text = args.Value.ToString();
    funciones.ERCAJ_BANCO_CAJ_BANCO_CAJBAN_REFERENCIA_OnChange();
}
private void ERCAJ_BANCO_CAJ_BANCO_CAJBAN_REFERENCIA_Cambio(object sender, string data)
{
    _ERCAJ_BANCO.CAJ_BANCO.CAJBAN_REFERENCIA = data;
}
private void ERCAJ_BANCO_CAJ_BANCO_CAJBAN_REFERENCIA_OnFocus()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_CAJBAN_REFERENCIA_OnFocus();
}
private void ERCAJ_BANCO_CAJ_BANCO_CAJBAN_REFERENCIA_OnBlur()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_CAJBAN_REFERENCIA_OnBlur();
}
//Metodos y atributos de _ERCAJ_BANCO.CAJ_BANCO.CAJBAN_FECHA
private bool ERCAJ_BANCO_CAJ_BANCO_CAJBAN_FECHA_IsEnabled = true;
private void ERCAJ_BANCO_CAJ_BANCO_CAJBAN_FECHA_OnChange(DateTime data)
{
    _ERCAJ_BANCO.CAJ_BANCO.CAJBAN_FECHA = data;
}
private void ERCAJ_BANCO_CAJ_BANCO_CAJBAN_FECHA_OnFocus()
{
}
private void ERCAJ_BANCO_CAJ_BANCO_CAJBAN_FECHA_OnBlur()
{
}
//Metodos y atributos de _ERCAJ_BANCO.CAJ_BANCO.CAJBAN_BANCOREF
public ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_Componente ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_Componente;
private void ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_OnChange(ChangeEventArgs args)
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_Componente.Text = args.Value.ToString();
    funciones.ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_OnChange();
}
private void ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_Cambio(object sender, string data)
{
    _ERCAJ_BANCO.CAJ_BANCO.CAJBAN_BANCOREF = data;
}
private void ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_OnFocus()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_OnFocus();
}
private void ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_OnBlur()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_CAJBAN_BANCOREF_OnBlur();
}
//Metodos y atributos de _ERCAJ_BANCO.CAJ_BANCO.CONPOL_REFERENCIA
public ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_Componente ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_Componente;
private void ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_OnChange(ChangeEventArgs args)
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_Componente.Text = args.Value.ToString();
    funciones.ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_OnChange();
}
private void ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_Cambio(object sender, string data)
{
    _ERCAJ_BANCO.CAJ_BANCO.CONPOL_REFERENCIA = data;
}
private void ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_OnFocus()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_OnFocus();
}
private void ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_OnBlur()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_CONPOL_REFERENCIA_OnBlur();
}
//Metodos y atributos de _ERCAJ_BANCO.CAJ_BANCO.SYSTTP_CODIGO_K
public ERCAJ_BANCO_CAJ_BANCO_SYSTTP_CODIGO_K_Componente ERCAJ_BANCO_CAJ_BANCO_SYSTTP_CODIGO_K_Componente;
private void ERCAJ_BANCO_CAJ_BANCO_SYSTTP_CODIGO_K_OnChange(ChangeEventArgs args)
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_SYSTTP_CODIGO_K_Componente.Text = args.Value.ToString();
    funciones.ERCAJ_BANCO_CAJ_BANCO_SYSTTP_CODIGO_K_OnChange();
}
private void ERCAJ_BANCO_CAJ_BANCO_SYSTTP_CODIGO_K_Cambio(object sender, string data)
{
    _ERCAJ_BANCO.CAJ_BANCO.SYSTTP_CODIGO_K = data;
}
private void ERCAJ_BANCO_CAJ_BANCO_SYSTTP_CODIGO_K_OnFocus()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_SYSTTP_CODIGO_K_OnFocus();
}
private void ERCAJ_BANCO_CAJ_BANCO_SYSTTP_CODIGO_K_OnBlur()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_SYSTTP_CODIGO_K_OnBlur();
}
//Metodos y atributos de _ERCAJ_BANCO.CAJ_BANCO.SYSTTS_CODIGO_K
public ERCAJ_BANCO_CAJ_BANCO_SYSTTS_CODIGO_K_Componente ERCAJ_BANCO_CAJ_BANCO_SYSTTS_CODIGO_K_Componente;
private void ERCAJ_BANCO_CAJ_BANCO_SYSTTS_CODIGO_K_OnChange(ChangeEventArgs args)
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_SYSTTS_CODIGO_K_Componente.Text = args.Value.ToString();
    funciones.ERCAJ_BANCO_CAJ_BANCO_SYSTTS_CODIGO_K_OnChange();
}
private void ERCAJ_BANCO_CAJ_BANCO_SYSTTS_CODIGO_K_Cambio(object sender, string data)
{
    _ERCAJ_BANCO.CAJ_BANCO.SYSTTS_CODIGO_K = data;
}
private void ERCAJ_BANCO_CAJ_BANCO_SYSTTS_CODIGO_K_OnFocus()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_SYSTTS_CODIGO_K_OnFocus();
}
private void ERCAJ_BANCO_CAJ_BANCO_SYSTTS_CODIGO_K_OnBlur()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_SYSTTS_CODIGO_K_OnBlur();
}
//Metodos y atributos de _ERCAJ_BANCO.CAJ_BANCO.S_FECHA
private bool ERCAJ_BANCO_CAJ_BANCO_S_FECHA_IsEnabled = true;
private void ERCAJ_BANCO_CAJ_BANCO_S_FECHA_OnChange(DateTime data)
{
    _ERCAJ_BANCO.CAJ_BANCO.S_FECHA = data;
}
private void ERCAJ_BANCO_CAJ_BANCO_S_FECHA_OnFocus()
{
}
private void ERCAJ_BANCO_CAJ_BANCO_S_FECHA_OnBlur()
{
}
//Metodos y atributos de _ERCAJ_BANCO.CAJ_BANCO.S_FI
public ERCAJ_BANCO_CAJ_BANCO_S_FI_Componente ERCAJ_BANCO_CAJ_BANCO_S_FI_Componente;
private void ERCAJ_BANCO_CAJ_BANCO_S_FI_OnChange(ChangeEventArgs args)
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_FI_Componente.Text = args.Value.ToString();
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_FI_OnChange();
}
private void ERCAJ_BANCO_CAJ_BANCO_S_FI_Cambio(object sender, string data)
{
    _ERCAJ_BANCO.CAJ_BANCO.S_FI = data;
}
private void ERCAJ_BANCO_CAJ_BANCO_S_FI_OnFocus()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_FI_OnFocus();
}
private void ERCAJ_BANCO_CAJ_BANCO_S_FI_OnBlur()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_FI_OnBlur();
}
//Metodos y atributos de _ERCAJ_BANCO.CAJ_BANCO.S_GUID
public ERCAJ_BANCO_CAJ_BANCO_S_GUID_Componente ERCAJ_BANCO_CAJ_BANCO_S_GUID_Componente;
private void ERCAJ_BANCO_CAJ_BANCO_S_GUID_OnChange(ChangeEventArgs args)
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_GUID_Componente.Text = args.Value.ToString();
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_GUID_OnChange();
}
private void ERCAJ_BANCO_CAJ_BANCO_S_GUID_Cambio(object sender, string data)
{
    _ERCAJ_BANCO.CAJ_BANCO.S_GUID = data;
}
private void ERCAJ_BANCO_CAJ_BANCO_S_GUID_OnFocus()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_GUID_OnFocus();
}
private void ERCAJ_BANCO_CAJ_BANCO_S_GUID_OnBlur()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_GUID_OnBlur();
}
//Metodos y atributos de _ERCAJ_BANCO.CAJ_BANCO.S_GUIDLOG
public ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_Componente ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_Componente;
private void ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_OnChange(ChangeEventArgs args)
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_Componente.Text = args.Value.ToString();
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_OnChange();
}
private void ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_Cambio(object sender, string data)
{
    _ERCAJ_BANCO.CAJ_BANCO.S_GUIDLOG = data;
}
private void ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_OnFocus()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_OnFocus();
}
private void ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_OnBlur()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_GUIDLOG_OnBlur();
}
//Metodos y atributos de _ERCAJ_BANCO.CAJ_BANCO.S_USUARIO
public ERCAJ_BANCO_CAJ_BANCO_S_USUARIO_Componente ERCAJ_BANCO_CAJ_BANCO_S_USUARIO_Componente;
private void ERCAJ_BANCO_CAJ_BANCO_S_USUARIO_OnChange(ChangeEventArgs args)
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_USUARIO_Componente.Text = args.Value.ToString();
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_USUARIO_OnChange();
}
private void ERCAJ_BANCO_CAJ_BANCO_S_USUARIO_Cambio(object sender, string data)
{
    _ERCAJ_BANCO.CAJ_BANCO.S_USUARIO = data;
}
private void ERCAJ_BANCO_CAJ_BANCO_S_USUARIO_OnFocus()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_USUARIO_OnFocus();
}
private void ERCAJ_BANCO_CAJ_BANCO_S_USUARIO_OnBlur()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_USUARIO_OnBlur();
}
//Metodos y atributos de _ERCAJ_BANCO.CAJ_BANCO.S_USUARIODB
public ERCAJ_BANCO_CAJ_BANCO_S_USUARIODB_Componente ERCAJ_BANCO_CAJ_BANCO_S_USUARIODB_Componente;
private void ERCAJ_BANCO_CAJ_BANCO_S_USUARIODB_OnChange(ChangeEventArgs args)
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_USUARIODB_Componente.Text = args.Value.ToString();
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_USUARIODB_OnChange();
}
private void ERCAJ_BANCO_CAJ_BANCO_S_USUARIODB_Cambio(object sender, string data)
{
    _ERCAJ_BANCO.CAJ_BANCO.S_USUARIODB = data;
}
private void ERCAJ_BANCO_CAJ_BANCO_S_USUARIODB_OnFocus()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_USUARIODB_OnFocus();
}
private void ERCAJ_BANCO_CAJ_BANCO_S_USUARIODB_OnBlur()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_USUARIODB_OnBlur();
}
//Metodos y atributos de _ERCAJ_BANCO.CAJ_BANCO.S_USUARIONOT
public ERCAJ_BANCO_CAJ_BANCO_S_USUARIONOT_Componente ERCAJ_BANCO_CAJ_BANCO_S_USUARIONOT_Componente;
private void ERCAJ_BANCO_CAJ_BANCO_S_USUARIONOT_OnChange(ChangeEventArgs args)
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_USUARIONOT_Componente.Text = args.Value.ToString();
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_USUARIONOT_OnChange();
}
private void ERCAJ_BANCO_CAJ_BANCO_S_USUARIONOT_Cambio(object sender, string data)
{
    _ERCAJ_BANCO.CAJ_BANCO.S_USUARIONOT = data;
}
private void ERCAJ_BANCO_CAJ_BANCO_S_USUARIONOT_OnFocus()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_USUARIONOT_OnFocus();
}
private void ERCAJ_BANCO_CAJ_BANCO_S_USUARIONOT_OnBlur()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_USUARIONOT_OnBlur();
}
//Metodos y atributos de _ERCAJ_BANCO.CAJ_BANCO.S_GUIDNOT
public ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_Componente ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_Componente;
private void ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_OnChange(ChangeEventArgs args)
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_Componente.Text = args.Value.ToString();
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_OnChange();
}
private void ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_Cambio(object sender, string data)
{
    _ERCAJ_BANCO.CAJ_BANCO.S_GUIDNOT = data;
}
private void ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_OnFocus()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_OnFocus();
}
private void ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_OnBlur()
{
    funciones.ERCAJ_BANCO_CAJ_BANCO_S_GUIDNOT_OnBlur();
}


    }
}

