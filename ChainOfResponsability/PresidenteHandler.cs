namespace ChainOfResponsability;
public class PresidenteHandler : AprobadorHandler
{
    public override void ProcesarSolicitud(Compra compra)
    {
        //La lógica de negocio
        if (compra.Monto <= 80000)
        {
            MessageBox.Show($"{this.GetType().Name} Solicitud Nro {compra.Numero} aprobada.");
        }
        else
        {
            MessageBox.Show($"Para la Solicitud Nro {compra.Numero} se requiere una reunión corporativa.");
        }
    }
}
