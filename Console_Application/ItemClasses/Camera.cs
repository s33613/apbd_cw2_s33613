namespace Console_Application.Properties
{
    public class Camera : Item
    {
        private int photos { get; set; }
        public Camera(string desc) : base("Camera",desc){ }

        public void TakePhoto()
        {
            photos++;
        }

        public void ClearPhotos()
        {
            photos = 0;
        }
    }
}