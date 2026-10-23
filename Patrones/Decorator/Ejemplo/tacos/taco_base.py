from taco import Taco

class TacoBase(Taco):
    """"Componente concreto base"""

    NOMBRE = ""
    PRECIO = 0.0
    CALORIAS = 0

    def descripcion(self) -> str:
        return self.NOMBRE

    def precio(self) -> float:
        return self.PRECIO

    def calorias(self) -> int:
        return self.CALORIAS