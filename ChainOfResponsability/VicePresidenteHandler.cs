namespace ChainOfResponsability;
public class VicePresidenteHandler : AprobadorHandler
{
    public override void ProcesarSolicitud(Compra compra)
    {
        //La lógica de negocio
        if (compra.Monto <= 25000)
        {
            MessageBox.Show($"{this.GetType().Name} Solicitud Nro {compra.Numero} aprobada.");
        }
        else if (_sucesor != null)
        {
            _sucesor.ProcesarSolicitud(compra);
        }
    }
}
