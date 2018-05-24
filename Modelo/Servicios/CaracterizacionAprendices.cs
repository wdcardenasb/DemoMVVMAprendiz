namespace DemoMVVMAprendiz.Modelo.Servicios
{
    using System;
    using System.Collections.ObjectModel;
   
    public class CaracterizacionAprendices
    {
        public static Data CargarAprendices()
        {
            ObservableCollection<Aprendiz> aprendices = new ObservableCollection<Aprendiz>();
            Data carAprendices = new Data();

            string[] nombres = { "Carlos", "Daniel", "Alejandro", "Angela", "Diana", "Diego", "Arnul" };
            string[] apellidos = { "Sanchez", "Segura", "Barrera", "Vargas", "Gomez", "Cabezas", "Gomez" };
            string[] programas = { "Contabilidad", "Mecatrónica", "ADSI", "Diseño 3D", "Hoteleria", "Salud Ocupacional", "Gestión Documental" };
            Random rdn = new Random(DateTime.Now.Millisecond);
            aprendices = new ObservableCollection<Aprendiz>();

            for (int i=0;i<20;i++)
            {
                Aprendiz aprendiz = new Aprendiz();
                aprendiz.Nombre = nombres[rdn.Next(0, 6)];
                aprendiz.Apellido = $"{apellidos [rdn.Next(0, 6)]} {apellidos[rdn.Next(0, 7)]}";
                double ficha = rdn.Next(1618618,2000000);
                aprendiz.Ficha = ficha;
                aprendiz.Programa = programas[rdn.Next(0, 6)];
                aprendiz.Promedio = rdn.Next(100, 1000);
                aprendices.Add(aprendiz);
            }
            carAprendices.Aprendices = aprendices;
            return carAprendices;

        }
    }
}
