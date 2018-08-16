using System.IO;
using System.Web;

/// <summary>
/// If image upoad stops working re-set the file directory permissions. https://www.godaddy.com/help/set-directory-permissions-windows-6481?locale=en
/// </summary>

namespace DutchmanSite.Helper
{
    public class ImgUpload
    {
        public string Upload(HttpPostedFileBase file)
        {
            if ((file != null) && (file.ContentLength > 0) && (file.ContentLength <= 15000000))//max 15MB
            {
                string ext = Path.GetExtension(file.FileName);
                string Filename = Path.GetFileNameWithoutExtension(file.FileName);
                int FileNameFix = 1;

                try
                {
                    string NewFilename = Filename + ext;
                    string path = Path.Combine(HttpContext.Current.Server.MapPath("~/Content/img"), NewFilename);

                    while (File.Exists(path))
                    {
                        NewFilename = Filename + FileNameFix.ToString() + ext;
                        path = Path.Combine(HttpContext.Current.Server.MapPath("~/Content/img"), NewFilename);
                        FileNameFix++;
                    }

                    if (FileTypeIsImage(ext))
                    {
                        file.SaveAs(path);
                        return("Uploaded as " + NewFilename);
                    }
                    else
                    {
                        return("Invalid File Type");
                    }
                }
                catch
                {
                    return ("Page Error: Unable to Upload");
                }
            }
            else
            {
                return("Invalid image size");
            }
        }

        private bool FileTypeIsImage(string ext)
        {
            string type = ext.ToLower();
            if ((type == ".png") || (type == ".jpeg") || (type == ".jpg") || (type == ".bmp") || (type == ".gif") || (type == ".tif") || (type == ".tiff"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}