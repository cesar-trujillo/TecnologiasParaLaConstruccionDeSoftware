abstract class IReporte {
  void mostrar();
}

//ReperteVentas
class ReporteVentas implements IReporte {
  @override
  void mostrar() {
    print(r'Ventas del día: $2,500');
  }
}

//Proxy
class ProxyReporte implements IReporte {
  final ReporteVentas _reporte = ReporteVentas();
  final bool esAdministrador;

  ProxyReporte(this.esAdministrador);

  @override
  void mostrar() {
    if (esAdministrador) {
      _reporte.mostrar();
    } else {
      print('Acceso denegado por falta de permisos.');
    }
  }
}

void main() {
  print('Acceso al administrador');
  IReporte accesoAdmin = new ProxyReporte(true);
  accesoAdmin.mostrar();

  print('Acceso al administrador');
  IReporte accesoCajero = new ProxyReporte(false);
  accesoCajero.mostrar();
}
