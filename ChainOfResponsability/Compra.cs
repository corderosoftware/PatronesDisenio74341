namespace ChainOfResponsability;

/// <summary>
/// Detalles de la solicitud
/// </summary>
public class Compra
{
    int _numero;
    double _monto;
    string _objetivo;

    public Compra(int numero, double monto, string objetivo)
    {
        this._numero = numero;
        this._monto = monto;
        this._objetivo = objetivo;
    }

    public int Numero //Propiedad Implementada (Getters/Setters)
    {
        get { return _numero; }
        set { _numero = value; }
    }

    public double Monto
    {
        get { return _monto; }
        set { _monto = value; }
    }

    public string Objetivo
    {
        get { return _objetivo; }
        set { _objetivo = value; }
    }
}
