using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsApplication2
{
    public partial class Tiempo : Form
    {
        //definimos variables a utilizar
        private WSclima.GlobalWeather webServiceTiempo;
        private WSpaises.country webServicePais;
        private DataTable tablaTiempo;
        private DataRow renglonTiempo;
        private DataSet dataSetPais, dataSetCiudad;
        private SortedList sortedListPais, sortedListCiudad;
        private String pais, ciudad, tiempo;

        public Tiempo()
        {
            InitializeComponent();
            try
            {
                //variable local
                String country;
                //mostramos los pasises obtenidos del WebService de Country
                webServicePais = new WSpaises.country();
                dataSetPais = new DataSet();
                sortedListPais = new SortedList();
                pais = webServicePais.GetCountries();
                dataSetPais.ReadXml(new System.IO.StringReader(pais));
                for (int i = 0; i < dataSetPais.Tables[0].Rows.Count; i++)
                {
                    country = dataSetPais.Tables[0].Rows[i][0].ToString();
                    sortedListPais.Add(country, country);
                }
                ComboPaises.DataSource = sortedListPais.GetValueList();
                ComboPaises.Show();
                //creamos una tabla que guardara los datos de la temperatura
                tablaTiempo = new DataTable();
                tablaTiempo.Columns.Add(new DataColumn("Temperatura"));
                tablaTiempo.Columns.Add(new DataColumn("Presion"));
                tablaTiempo.Columns.Add(new DataColumn("Viento"));
                tablaTiempo.Columns.Add(new DataColumn("Visibilidad"));
                tablaTiempo.Columns.Add(new DataColumn("Humedad Relativa"));
                tablaTiempo.Columns.Add(new DataColumn("Fecha/Hora"));               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void ComboPaises_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //variable local
                String city;
                //mostramos las ciudades obtenidos del WebService de GlobalWeather
                webServiceTiempo = new WSclima.GlobalWeather();
                dataSetCiudad = new DataSet();
                sortedListCiudad = new SortedList();
                pais = ComboPaises.SelectedItem.ToString();
                ciudad = webServiceTiempo.GetCitiesByCountry(pais);
                dataSetCiudad.ReadXml(new System.IO.StringReader(ciudad));
                for (int i = 0; i < dataSetCiudad.Tables[0].Rows.Count; i++)
                {
                    city = dataSetCiudad.Tables[0].Rows[i][1].ToString();
                    sortedListCiudad.Add(city, city);
                }
                ComboCiudades.DataSource = sortedListCiudad.GetValueList();
                ComboCiudades.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //obtenemos los datos del Tiempo, segun el pais y ciudad que le pasamos al WebService de GlobalWeather
                webServiceTiempo = new WSclima.GlobalWeather();
                ciudad = ComboCiudades.SelectedItem.ToString();
                pais = ComboPaises.SelectedItem.ToString();
                tiempo = webServiceTiempo.GetWeather(ciudad, pais);
                if (tiempo != "Data Not Found")
                {
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.LoadXml(tiempo);
                    renglonTiempo = tablaTiempo.NewRow();
                    renglonTiempo[0] = xdoc.SelectSingleNode("//CurrentWeather/Temperature").InnerText;
                    renglonTiempo[1] = xdoc.SelectSingleNode("//CurrentWeather/Pressure").InnerText;
                    renglonTiempo[2] = xdoc.SelectSingleNode("//CurrentWeather/Wind").InnerText;
                    renglonTiempo[3] = xdoc.SelectSingleNode("//CurrentWeather/Visibility").InnerText;
                    renglonTiempo[4] = xdoc.SelectSingleNode("//CurrentWeather/RelativeHumidity").InnerText;
                    renglonTiempo[5] = DateTime.Now.ToString();
                    tablaTiempo.Rows.Add(renglonTiempo);
                    tablaTiempo.DefaultView.Sort = "Fecha/Hora desc";
                    DataGridResultado.DataSource = tablaTiempo;
                }
                else
                {
                    MessageBox.Show("Datos del clima no disponibles");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //sin acciones
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //sin acciones
        }

        private void Tiempo_Load(object sender, EventArgs e)
        {
            //sin acciones
        }

        private void ComboPaises_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}