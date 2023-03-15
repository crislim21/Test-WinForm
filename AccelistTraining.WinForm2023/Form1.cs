using AccelistTraining.WinForm2023.Models;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Text.Json;

namespace AccelistTraining.WinForm2023
{
    public partial class Form1 : Form
    {
        private const string IncorrectInputTitle = "Incorrect Input";

        public Form1()
        {
            InitializeComponent();
        }

        private void inputNameButton_Click(object sender, EventArgs e)
        {
            var isValidName = SetYourName();

            if (!isValidName)
            {
                return;
            }
            UpdateSubmissionProgressBar(25);

            var isValidGender = SetYourGender();
            if (!isValidGender)
            {
                return;
            }
            UpdateSubmissionProgressBar(50);

            var luckyNumber = luckyNumberInput.Value;
            yourLuckyNumberValueLabel.Text = luckyNumber.ToString();
            UpdateSubmissionProgressBar(75);

            var isValidAddress = SetYourAddress();
            if (!isValidAddress)
            {
                return;
            }
            UpdateSubmissionProgressBar(100);

            MessageBox.Show("Your data has been successfully submitted. Please check your data at the right-side panel",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Update the submission progress bar's and text indicator's value.
        /// </summary>
        /// <param name="currentValue"></param>
        private void UpdateSubmissionProgressBar(int currentValue)
        {
            submissionProgressBar.Value = currentValue;
            currentProgressLabel.Text = currentValue.ToString();
        }

        /// <summary>
        /// Validate and set the Your Name label based on the user's input.
        /// </summary>
        /// <returns></returns>
        private bool SetYourName()
        {
            var inputName = inputNameTextBox.Text;

            if (string.IsNullOrEmpty(inputName))
            {
                MessageBox.Show("Please input your name.",
                    IncorrectInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            UpdateSubmissionProgressBar(10);

            if (inputName.Length < 3 || inputName.Length > 50)
            {
                MessageBox.Show("Name length can only be between 3 to 50 characters.",
                    IncorrectInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            UpdateSubmissionProgressBar(15);

            yourNameValueLabel.Text = inputName;

            return true;
        }

        /// <summary>
        /// Validate and set the Your Gender label based on the user's input.
        /// </summary>
        /// <returns></returns>
        private bool SetYourGender()
        {
            string gender;
            if (maleRadioButton.Checked)
            {
                gender = maleRadioButton.Text;
            }
            else if (femaleRadioButton.Checked)
            {
                gender = femaleRadioButton.Text;
            }
            else
            {
                MessageBox.Show("Please choose your gender.",
                   IncorrectInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            yourGenderValueLabel.Text = gender;

            return true;
        }


        /// <summary>
        /// Validate and set the Your Address label based on the user's input.
        /// </summary>
        /// <returns></returns>
        private bool SetYourAddress()
        {
            var inputAddress = addressRichTextBox.Text;

            if (string.IsNullOrEmpty(inputAddress))
            {
                MessageBox.Show("Please input your address.",
                    IncorrectInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            UpdateSubmissionProgressBar(85);

            if (inputAddress.Length < 3 || inputAddress.Length > 100)
            {
                MessageBox.Show("Address length can only be between 3 to 100 characters.",
                    IncorrectInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            UpdateSubmissionProgressBar(95);

            yourAddressValueLabel.Text = inputAddress;

            return true;
        }

        // ONLY USE async void IN DESKTOP!
        // DO NOT USE async void IN ASP.NET CORE! USE async Task INSTEAD!
        // The reason is in ASP.NET Core, it will block your thread, which will cause a bug or performance issue.
        /// <summary>
        /// On click Fetch API button event handler. Using asynchronous codes to make the app still responsive while waiting until the HTTP request transaction is done.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void fetchApiButton_Click(object sender, EventArgs e)
        {
            // Use using statement to dispose the HttpClient object on the closing statement.
            // At the end of using statement, Garbage Collector (GC) will get triggered and will flush the HttpClient object.
            // To trigger GC normally, use using statement on an object that inherit IDisposable interface.
            using (var httpClient = new HttpClient())
            {
                // Use await keyword to invoke the async method, such as GetAsync().
                // This will invoke an HTTP request using GET method / verb.
                var response = await httpClient.GetAsync("https://swapi.dev/api/people/");

                // Mock delay for 2 seconds to see how the app is still responsive while waiting for the fetch process to be done.
                await Task.Delay(2_000);

                // Ensure the response's HTTP status code is 200, which is OK and should not be return an error.
                // If not 200, this code will throw an exception.
                response.EnsureSuccessStatusCode();

                var result = await response.Content.ReadAsStreamAsync();

                // Deserialize will parse the JSON string / data as a C# object.
                PeopleResult? resultData = await JsonSerializer.DeserializeAsync<PeopleResult>(result);

                // If the JSON parser cannot parse the JSON string, it should return null.
                if (resultData == null)
                {
                    MessageBox.Show("JSON conversion failed.", "Fetch API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a data source for ListBox component.
                var peopleSource = new BindingSource
                {
                    DataSource = resultData.PeopleData
                };

                // Set the ListBox's data source.
                peopleBox.DataSource = peopleSource;

                // Display the column by using the property name in the source.
                // In this case, we want to display the "Name" data from PeopleData.Name property's value.
                peopleBox.DisplayMember = "Name";
            }
        }

        private async void submitUserRequestButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userRequestNameInput.Text))
            {
                MessageBox.Show("Please input your user's name.", IncorrectInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(userRequrestJobInput.Text))
            {
                MessageBox.Show("Please input your user's job.", IncorrectInputTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await PostJson();
            //await PostJsonUsingStream();
        }

        /// <summary>
        /// POST the data to the server.
        /// </summary>
        /// <returns></returns>
        private async Task PostJson()
        {
            var createUserUri = "https://reqres.in/api/users";

            var userRequest = new UserRequest
            {
                Name = userRequestNameInput.Text,
                Job = userRequrestJobInput.Text
            };

            // Serialize will convert the C# object as JSON string.
            var jsonString = JsonSerializer.Serialize(userRequest);

            using (var content = new StringContent(jsonString))
            {
                // Set the Content-Type of HTTP request header to tell the server that we will send a JSON data.
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.PostAsync(createUserUri, content);

                    response.EnsureSuccessStatusCode();

                    var jsonResponseString = await response.Content.ReadAsStringAsync();

                    var userResponse = JsonSerializer.Deserialize<UserResponse>(jsonResponseString);

                    if (userResponse == null)
                    {
                        MessageBox.Show("Return result is null from the server or cannot parse the response.", "POST API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show($@"Data has been successfully submitted to the server
ID: {userResponse.Id}
Created At: {userResponse.CreatedAt}");
                }
            }
        }

        /// <summary>
        /// POST the data to the server using Stream.
        /// </summary>
        /// <returns></returns>
        private async Task PostJsonUsingStream()
        {
            var createUserUri = "https://reqres.in/api/users";

            var userRequest = new UserRequest
            {
                Name = userRequestNameInput.Text,
                Job = userRequrestJobInput.Text
            };

            // We will use Stream object to send it to the server.
            // DO NOT USE MemoryStream WITHOUT CAUTION, OR YOUR APP WILL HAVE A MEMORY LEAK ISSUE!
            // THIS IS JUST AN EXAMPLE OF HOW USING MemoryStream, DO NOT USE THIS IN MOST OF COMMERCIAL PRODUCTION APP!
            using (var userRequestJsonStream = new MemoryStream())
            {
                // Serialize will convert the C# object into another type of data, either a stream data, or JSON string.
                await JsonSerializer.SerializeAsync(userRequestJsonStream, userRequest);

                // This is why we use Stream object such as MemoryStream, because we want to put the body request as StreamContent object.

                using (var content = new StreamContent(userRequestJsonStream))
                {
                    // Set the Content-Type of HTTP request header to tell the server that we will send a JSON data.
                    content.Headers.Add("Content-Type", "application/json");

                    using (var httpClient = new HttpClient())
                    {
                        var response = await httpClient.PostAsync(createUserUri, content);

                        response.EnsureSuccessStatusCode();

                        using (var result = await response.Content.ReadAsStreamAsync())
                        {
                            var userResponse = await JsonSerializer.DeserializeAsync<UserResponse>(result);

                            if (userResponse == null)
                            {
                                MessageBox.Show("Return result is null from the server or cannot parse the response.", "POST API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            MessageBox.Show($@"Data has been successfully submitted to the server
ID: {userResponse.Id}
Created At: {userResponse.CreatedAt}");
                        }
                    }
                }
            }
        }

        private async void readTxtFileButton_Click(object sender, EventArgs e)
        {
            var filePath = readTxtFilePathInput.Text;
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please write your file path.", IncorrectInputTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Validate whether the file is exists or not.
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File does not exist, please input the correct path.", IncorrectInputTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Simple validation to check whether it is a .txt file or not.
            if (Path.GetExtension(filePath) != ".txt")
            {
                MessageBox.Show("File is not a .txt file, please choose the correct .txt file.", IncorrectInputTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Use FileMode.Open to tell the OS's file system that the file is currently opened by our app.
            using (var fs = new FileStream(filePath, FileMode.Open))
            {
                // Use StreamReader to read the stream data.
                using (var streamReader = new StreamReader(fs))
                {
                    // Use ReadToEndAsync() to tell the stream reader to read the whole file content
                    // from the beginning to the end of the file content.
                    var fileContent = await streamReader.ReadToEndAsync();

                    txtFileTextBox.Text = fileContent;

                    // Release the stream reader.
                    // Should not needed since we are using the using statement.
                    //streamReader.Close();
                }
            }
        }

        private async void writeTxtButton_Click(object sender, EventArgs e)
        {
            var filePath = writeTxtFilePathInput.Text;
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please write your file path.", IncorrectInputTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Simple validation to check whether it is a .txt file or not.
            if (Path.GetExtension(filePath) != ".txt")
            {
                MessageBox.Show("File is not a .txt file, please choose the correct .txt file.", IncorrectInputTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Set the message to tell whether the app made a new file or did overwrite an existing file.
            var message = "Your file has been successfully created.";
            if (File.Exists(filePath))
            {
                message = "Your file has been successfully overwritten.";
            }

            // FileMode.Create will automatically create the file if not exists or overwrite the file if exists.
            using (var fs = new FileStream(filePath, FileMode.Create))
            {
                await WriteToStream(fs);
            }
            
            MessageBox.Show(message, "Write Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Write the <see cref="inputTxtFileTextBox"/> text value into the stream.
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        private async Task WriteToStream(Stream stream)
        {
            // Use StreamWriter to write data to the opened file stream.
            using (var streamWriter = new StreamWriter(stream))
            {
                // WriteLineAsync will write the stream using the provided string value in the parameter
                // and add a new line separator at the of the file.
                await streamWriter.WriteLineAsync(inputTxtFileTextBox.Text);
            }
        }

        // Synchronous example for comparison.
        //private void fetchApiButton_Click(object sender, EventArgs e)
        //{
        //    // Use using statement to dispose the HttpClient object on the closing statement.
        //    // At the end of using statement, Garbage Collector (GC) will get triggered and will flush the HttpClient object.
        //    // To trigger GC normally, use using statement on an object that inherit IDisposable interface.
        //    using (var httpClient = new HttpClient())
        //    {
        //        // Use GetAwaiter().GetResult() methods to run Task method synchronously.
        //        var response = httpClient.GetAsync("https://swapi.dev/api/people/").GetAwaiter().GetResult();

        //        // Mock delay for 2 seconds to see how the app will become unresponsive while waiting for the fetch process to be done.
        //        Task.Delay(2_000).GetAwaiter().GetResult();

        //        // Ensure the response's HTTP status code is 200, which is OK and should not be return an error.
        //        // If not 200, this code will throw an exception.
        //        response.EnsureSuccessStatusCode();

        //        var result = response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();

        //        PeopleResult? resultData = JsonSerializer.DeserializeAsync<PeopleResult>(result).GetAwaiter().GetResult();

        //        // If the JSON parser cannot parse the JSON string, it should return null.
        //        if (resultData == null)
        //        {
        //            MessageBox.Show("JSON conversion failed.", "Fetch API", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        // Create a data source for ListBox component.
        //        var peopleSource = new BindingSource
        //        {
        //            DataSource = resultData.PeopleData
        //        };

        //        // Set the ListBox's data source.
        //        peopleBox.DataSource = peopleSource;

        //        // Display the column by using the property name in the source.
        //        // In this case, we want to display the "Name" data from PeopleData.Name property's value.
        //        peopleBox.DisplayMember = "Name";
        //    }
        //}
    }
}