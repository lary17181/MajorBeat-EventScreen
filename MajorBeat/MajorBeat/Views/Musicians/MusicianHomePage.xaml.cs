using MajorBeat.Enums;
using MajorBeat.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
namespace MajorBeat.Views.Musicians;


public partial class MusicianHomePage : ContentPage
{
	public MusicianHomePage()
	{
		InitializeComponent();
	}

    private async void search_page_btn_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MusicianSearchPage());
    }

    //private async Task home_page_btn_Clicked(object sender, EventArgs e)
    //{
        
    //}

    private async void profile_page_btn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MusicianProfilePage());
    }

    private async void OnEventTapped(object sender, EventArgs e)
    {
        var evento = new Evento
        {
            Titulo = "Panelão do Norte",
            Descricao = "Uma noite especial com artistas locais...",
            Endereco = "Av. Norte, 123 - São Paulo, SP",
            Data = new DateTime(2025, 11, 20),
            HoraInicio = new TimeSpan(20, 0, 0),
            HoraFim = new TimeSpan(23, 30, 0),
            NomeGenero = new ObservableCollection<GeneroEnum> { GeneroEnum.Sertanejo },
            NomeInstrumento = new ObservableCollection<InstrumentoEnum> { InstrumentoEnum.Violão, InstrumentoEnum.Bateria },
            ImagemLocalEvento = new ObservableCollection<byte[]>(),
            Contratante = new Contratante
            {
                Nome = "Panelão do Norte Produções"
            }
        };
        await Navigation.PushAsync(new MusicianEventView(evento));
    }

}