using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Converter_with_api
{
    public partial class Form1 : Form
    {
        // Declare variables for the API URL and my access key
        private static readonly string apiUrl = "https://api.exchangerate-api.com/v4/latest/";

        public Form1()
        {
            InitializeComponent();
        }

        // Form Load event to populate ComboBoxes with currency options
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] currencies = { "EUR", "USD", "GBP", "CNY", "JPY" };

            comboBoxFromCurrency.Items.AddRange(currencies);
            comboBoxToCurrency.Items.AddRange(currencies);

            comboBoxFromCurrency.SelectedIndex = 0; // Default to EUR
            comboBoxToCurrency.SelectedIndex = 1; // Default to USD
        }

        // conversion logic when the Convert button is clicked
        private async void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(txtInput.Text, out decimal inputAmount))
                {
                    // Get the conversion rate from the API
                    decimal conversionRate = await GetExchangeRateAsync(comboBoxFromCurrency.SelectedItem.ToString(), comboBoxToCurrency.SelectedItem.ToString());

                    // Calculate the converted value
                    decimal result = inputAmount * conversionRate;

                    // Show the result in the output textbox
                    txtOutput.Text = result.ToString("0.##");

                    // Display an appropriate image based on the conversion result
                    DisplayFinancialImage(result);
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Call the API and get the conversion rate for the selected currencies
        private async Task<decimal> GetExchangeRateAsync(string fromCurrency, string toCurrency)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = apiUrl + fromCurrency;
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    var json = JObject.Parse(responseData);

                    // Log the entire response for debugging
                    Console.WriteLine(json.ToString());

                    if (json["rates"] != null && json["rates"][toCurrency] != null)
                    {
                        return json["rates"][toCurrency].Value<decimal>();
                    }
                    else
                    {
                        throw new Exception($"Rate for {toCurrency} not found.");
                    }
                }
                else
                {
                    throw new Exception("Failed to fetch exchange rates from the API.");
                }
            }
        }

        // Display the appropriate financial image based on the converted value
        private void DisplayFinancialImage(decimal amount)
        {
            if (amount < 30000)
            {
                pictureBox1.Visible = true; // Struggling
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            else if (amount >= 30000 && amount < 75000)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true; // Comfortable
                pictureBox3.Visible = false;
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true; // Lavish
            }
        }

        // Handle the Clear button click to reset the form
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
            comboBoxFromCurrency.SelectedIndex = 0;
            comboBoxToCurrency.SelectedIndex = 1;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
    }
}
