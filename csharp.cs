var client = new HttpClient();
var request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:8080/completion");
var content = new StringContent("{\"stream\":false,\"n_predict\":-1,\"temperature\":0.7,\"stop\":[\"</s>\",\"llama:\",\"User:\"],\"repeat_last_n\":256,\"repeat_penalty\":1.18,\"top_k\":40,\"top_p\":0.5,\"tfs_z\":1,\"typical_p\":1,\"presence_penalty\":0,\"frequency_penalty\":0,\"mirostat\":0,\"mirostat_tau\":5,\"mirostat_eta\":0.1,\"prompt\":\"This is a conversation between user and llama, a friendly chatbot. respond in simple markdown.\\n\\nUser: {prompt}\\nllama:\"}", null, "application/json");
request.Content = content;
var response = await client.SendAsync(request);
response.EnsureSuccessStatusCode();
Console.WriteLine(await response.Content.ReadAsStringAsync());
