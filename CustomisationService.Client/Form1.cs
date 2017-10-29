using System;
using System.ServiceModel.Channels;
using System.Windows.Forms;

namespace CustomisationService.Client
{
    public partial class Form1 : Form
    {
        private Proxy.Client client;

        public Form1()
        {
            InitializeComponent();
            client = new Proxy.Client();
            SetHeaders("initialvalue", false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var result = client.GetData(3);
                tssAccessResult.Text = $"Permitted {result}";
            }
            catch (Exception ex)
            {
                tssAccessResult.Text = ex.Message;
            }

        }

        private void btnSetHeader_Click(object sender, EventArgs e)
        {
            SetHeaders(textBox1.Text, true);
        }

        private void SetHeaders(string headerValue, bool closeExisting)
        {
            if (closeExisting)
            {
                client.Close();
                client = new Proxy.Client();
            }

            var headers = new AddressHeader[]
            {
            AddressHeader.CreateAddressHeader("x-accesstoken", "", headerValue)
            };

            client.Endpoint.Address = new System.ServiceModel.EndpointAddress(client.Endpoint.Address.Uri, headers);

        }
    }
}
