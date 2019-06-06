using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomLibrary.Extensions.Collections;

namespace Tests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Datos> datos = new List<Datos>();
            datos.Add(new Datos
            {
                ID = 1,
                Descripción = "Lorem ipsum dolor sit amet",
                Fecha = RandomDay(),
                Importe = RandomImporte(),
                Válido = true
            });
            datos.Add(new Datos
            {
                ID = 2,
                Descripción = "Consectetuer adipiscing elit",
                Fecha = RandomDay(),
                Importe = RandomImporte(),
                Válido = true
            });
            datos.Add(new Datos
            {
                ID = 3,
                Descripción = "Maecenas porttitor congue massa",
                Fecha = RandomDay(),
                Importe = RandomImporte(),
                Válido = true
            });
            datos.Add(new Datos
            {
                ID = 4,
                Descripción = "Fusce posuere",
                Fecha = RandomDay(),
                Importe = RandomImporte(),
                Válido = true
            });
            datos.Add(new Datos
            {
                ID = 5,
                Descripción = "Magna sed pulvinar ultricies",
                Fecha = RandomDay(),
                Importe = RandomImporte(),
                Válido = true
            });
            datos.Add(new Datos
            {
                ID = 6,
                Descripción = "Purus lectus malesuada libero",
                Fecha = RandomDay(),
                Importe = RandomImporte(),
                Válido = false
            });

            customDataGridView1.SetDataSource(datos, 0, ListSortDirection.Ascending);
        }

        private Random gen = new Random();
        DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        private decimal RandomImporte()
        {
            return gen.Next();
        }
    }
}
