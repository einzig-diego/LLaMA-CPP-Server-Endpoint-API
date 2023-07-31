var request = require('request');
var options = {
  'method': 'POST',
  'url': 'http://127.0.0.1:8080/completion',
  'headers': {
    'Content-Type': 'application/json'
  },
  body: JSON.stringify({
    "stream": false,
    "n_predict": -1,
    "temperature": 0.7,
    "stop": [
      "</s>",
      "llama:",
      "User:"
    ],
    "repeat_last_n": 256,
    "repeat_penalty": 1.18,
    "top_k": 40,
    "top_p": 0.5,
    "tfs_z": 1,
    "typical_p": 1,
    "presence_penalty": 0,
    "frequency_penalty": 0,
    "mirostat": 0,
    "mirostat_tau": 5,
    "mirostat_eta": 0.1,
    "prompt": "This is a conversation between user and llama, a friendly chatbot. respond in simple markdown.\n\nUser: {prompt}\nllama:"
  })

};
request(options, function (error, response) {
  if (error) throw new Error(error);
  console.log(response.body);
});
