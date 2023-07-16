Dogs Image Classification

This application utilizes ML.NET to classify dog breeds based on the provided image. It is a Windows Forms application built using C# and .NET 6.

Prerequisites
Before running the application, ensure you have the following:

.NET 6 SDK installed. You can download it from the official .NET website.

Training Data
To train the ML.NET model for dog breed classification, you will need a dataset of labeled dog images. The dataset should be organized into subdirectories, where each subdirectory represents a different dog breed and contains images of that breed.

Getting Started

Clone or download the source code from the GitHub repository.
Open the solution in Visual Studio.
Build the solution to restore NuGet packages and compile the application.

Usage

Launch the DogsImageClassification application.
Click the "Browse" button to select an image file from your local machine. Only .jpg and .png files are supported.
Once an image is selected, it will be displayed in the picture box.
Click the "Classify" button to initiate the dog breed classification.
The application will read the image file, convert it to bytes, and create an MLModel1.ModelInput instance with the image data.
ML.NET will load the trained model and predict the dog breed based on the input image.
A message box will appear displaying the predicted dog breed.

Notes

The application assumes that you have a trained ML.NET model named "MLModel1" capable of classifying dog breeds. Please ensure that the model is available and properly configured within the project.
You may need to update the file path in the btnClassify_Click method to match the location of your trained model if necessary.
Make sure to provide high-quality images of dogs for accurate breed classification results.

Contributing

Contributions to the Dogs Image Classification application are welcome. If you find any issues or have suggestions for improvements, please submit them via GitHub issues.

License

This project is licensed under the MIT License. Feel free to modify and distribute the code as needed.
