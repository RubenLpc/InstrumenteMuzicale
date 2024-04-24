using System;

namespace LibrarieModele
{ }
public class CumparareInstrumentMuzical
{
    //constante
    private const char SEPARATOR_PRINCIPAL_FISIER = ';';

    private const int NUME_CLIENT = 0;
    private const int NUME_INSTRUMENT = 1;
    private const int TIP_INSTRUMENT = 2;
    private const int PRET = 3;
    private const int DATA_CUMPARARE = 4;

    //proprietati auto-implemented
    public string NumeClient { get; set; }
    public string NumeInstrument { get; set; }
    public string TipInstrument { get; set; }
    public decimal Pret { get; set; }
    public DateTime DataCumparare { get; set; }

    //constructor implicit
    public CumparareInstrumentMuzical()
    {
        NumeClient = NumeInstrument = TipInstrument = string.Empty;
        Pret = 0;
        DataCumparare = DateTime.Now;
    }

    //constructor cu parametri
    public CumparareInstrumentMuzical(string numeClient, string numeInstrument, string tipInstrument, decimal pret, DateTime dataCumparare)
    {
        this.NumeClient = numeClient;
        this.NumeInstrument = numeInstrument;
        this.TipInstrument = tipInstrument;
        this.Pret = pret;
        this.DataCumparare = dataCumparare;
    }

    //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
    public CumparareInstrumentMuzical(string linieFisier)
    {
        string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

        this.NumeClient = dateFisier[NUME_CLIENT];
        this.NumeInstrument = dateFisier[NUME_INSTRUMENT];
        this.TipInstrument = dateFisier[TIP_INSTRUMENT];
        this.Pret = Convert.ToDecimal(dateFisier[PRET]);
        this.DataCumparare = DateTime.Parse(dateFisier[DATA_CUMPARARE]);
    }

    public string Info()
    {
        string info = $"Client:{NumeClient} Instrument:{NumeInstrument} Tip: {TipInstrument} Pret: {Pret} Data cumparare: {DataCumparare}";

        return info;
    }

    public string ConversieLaSir_PentruFisier()
    {
        string obiectCumparareInstrumentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5:dd.MM.yyyy}",
            SEPARATOR_PRINCIPAL_FISIER,
            NumeClient,
            NumeInstrument,
            TipInstrument,
            Pret.ToString(),
            DataCumparare);

        return obiectCumparareInstrumentPentruFisier;
    }
}
