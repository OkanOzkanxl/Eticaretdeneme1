namespace Eticaret.WebUI.Utils
{
    public class FileHelper
    {
        public static async Task<string> FileLoaderAsync(IFormFile formFile,
            string filePath = "/Img/")
        {
            string fileName = "";
            if (formFile != null && formFile.Length > 0) 
            {
                fileName = formFile.Name.ToLower();
                string directory = Directory.GetCurrentDirectory() +
                    "/wwwroot" + filePath + fileName;
                using var stream = new FileStream(directory, FileMode.Create);
                await stream.CopyToAsync(stream);
            }
            return fileName;


        }
    }
}
