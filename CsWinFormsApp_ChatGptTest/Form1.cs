using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace CsWinFormsApp_ChatGptTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
        }

        public static readonly string apiKey = "<Change to your api key.>";
        public static readonly string ApiUrl = "https://api.openai.com/v1/";

        private readonly HttpClient _client;

        public async Task<string> GetResponseFromChatCPT(string prompt, string model, int maxTokens)
        {
            ChatGPT_ChatRequest request = new ChatGPT_ChatRequest
            {
                model = model,
                messages = new List<ChatGPT_ChatRequest_message>
                {
                    new ChatGPT_ChatRequest_message { role = "user", content = prompt }
                },
                max_tokens = maxTokens
            };
            string json = JsonConvert.SerializeObject(request);
            StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync($"{ApiUrl}chat/completions", content);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            dynamic jsonResult = JsonConvert.DeserializeObject(responseBody);
            return jsonResult.choices[0].message.content;
        }

        private struct ChatGPT_ChatRequest_message
        {
            public string role { get; set; }
            public string content { get; set; }
        }

        private struct ChatGPT_ChatRequest
        {
            public string model { get; set; }
            public List<ChatGPT_ChatRequest_message> messages { get; set; }

            public int max_tokens; // OpenAI document does not mention this field, but it seems make sense.
        }

        private async void button_submit_Click(object sender, EventArgs e)
        {
            // Question to ask.
            string prompt = textBox_input.Text == "" ? "Hello." : textBox_input.Text;

            // Get response from ChatGTP.
            string response;
            try
            {
                response = await GetResponseFromChatCPT(prompt, "gpt-3.5-turbo", 200);
            }
            catch (Exception ex)
            {
                richTextBox_result.Text = ex.Message;
                return;
            }

            // Show the answer.
            richTextBox_result.Text = response.Trim();
        }
    }
}