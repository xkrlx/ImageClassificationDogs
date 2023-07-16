
namespace ImageClassifiationDogs
{
    public partial class DogsImageClassification : Form
    {
        public DogsImageClassification()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files|*.jpg;*.png";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = fileDialog.FileName;
            }
        }

        private void btnClassify_Click(object sender, EventArgs e)
        {
            //Load sample data
            //var imageBytes = File.ReadAllBytes(@"C:\Users\karol\Documents\DOGS_DATASET\n02099601-golden_retriever\n02099601_10.jpg");


            var imageLocation = pictureBox.ImageLocation;
            var imageBytes = File.ReadAllBytes(imageLocation);
            MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
            {
                ImageSource = imageBytes,
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);


            if(result.Score.Max() < 60) {
                MessageBox.Show("Dog breed recognition problem");
            }
            else
            {
                MessageBox.Show(result.PredictedLabel);
            }

           
        }
    }
}