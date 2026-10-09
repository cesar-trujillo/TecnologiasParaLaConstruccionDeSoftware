package main

import "fmt"

func main() {
	fmt.Println("====== Entorno real =======")
	pasarelaReal := &AdaptadorMercadoPago{TokenAccess: "1234!#$"}
	emisorReal := &AdaptadorTwilio{IdentificadorCuenta: "54321&%$#"}

	servicioReal := NuevoServicioPago(pasarelaReal, emisorReal)
	_ = servicioReal.ProecesarPago("changotremendo@gmail.com", 1500.00)

	fmt.Println("====== Entorno Prueba =======")
	pasarelaMock := &SimuladorPasarela{DebeFallar: false}
	emisorMock := &SimuladorEmisor{}

	servicioMock := NuevoServicioPago(pasarelaMock, emisorMock)
	_ = servicioMock.ProecesarPago("tilintravieso@gmail.com", 3000)
}
