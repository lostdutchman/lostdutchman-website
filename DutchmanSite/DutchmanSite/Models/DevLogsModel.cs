using DutchmanSite.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace DutchmanSite.Models
{
    public class DevLogsModel
    {
        public string Site { get; set; }
        public Boolean IsPublished { get; set; }
        public string Icon { get; set; }
        public string IconText { get; set; }
        public string Title { get; set; }
        public string Summery { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public long PKEY { get; set; }

        public void CreateNew(string site, string icon, string iconText, string title, string summery, string description, int isPublished)
        {
            DevLogDBHelper DBHelp = new DevLogDBHelper();

            //sanitizing this value so that if its null or somehow an int other than 0/1 it will be saved as a draft.
            if (isPublished != 1) { isPublished = 0; }

            //Sanitize all strings to not include "
            site.Replace("\"", "'");
            icon.Replace("\"", "'");
            iconText.Replace("\"", "'");
            title.Replace("\"", "'");
            summery.Replace("\"", "'");
            description.Replace("\"", "'");

            DBHelp.NewLog(site, icon, iconText, title, summery, description, isPublished);
        }

        public string LogEditList(string SortBy)
        {
            DevLogDBHelper DB = new DevLogDBHelper();
            var Temp = DB.ListAll();
            List<DevLogsModel> List = new List<DevLogsModel>();
            switch (SortBy)
            {
                case "OldToNew":
                    List = Temp.OrderBy(o => o.Date).ToList();
                    break;

                case "NewToOld":
                    List = Temp.OrderByDescending(o => o.Date).ToList();
                    break;

                case "HomeOldToNew":
                    foreach(DevLogsModel log in Temp)
                    {
                        if(log.Site == "Index")
                        {
                            List.Add(log);
                        }
                    }
                    List = List.OrderBy(o => o.Date).ToList();
                    break;

                case "HomeNewToOld":
                    foreach (DevLogsModel log in Temp)
                    {
                        if (log.Site == "Index")
                        {
                            List.Add(log);
                        }
                    }
                    List = List.OrderByDescending(o => o.Date).ToList();
                    break;

                case "NBOldToNew":
                    foreach (DevLogsModel log in Temp)
                    {
                        if (log.Site == "NiceBowling")
                        {
                            List.Add(log);
                        }
                    }
                    List = List.OrderBy(o => o.Date).ToList();
                    break;

                case "NBNewToOld":
                    foreach (DevLogsModel log in Temp)
                    {
                        if (log.Site == "NiceBowling")
                        {
                            List.Add(log);
                        }
                    }
                    List = List.OrderByDescending(o => o.Date).ToList();
                    break;

                case "WoSOldToNew":
                    foreach (DevLogsModel log in Temp)
                    {
                        if (log.Site == "WyrdOfStromgard")
                        {
                            List.Add(log);
                        }
                    }
                    List = List.OrderBy(o => o.Date).ToList();
                    break;

                case "WoSNewToOld":
                    foreach (DevLogsModel log in Temp)
                    {
                        if (log.Site == "WyrdOfStromgard")
                        {
                            List.Add(log);
                        }
                    }
                    List = List.OrderBy(o => o.Date).ToList();
                    break;

                default: List = Temp.OrderByDescending(o => o.Date).ToList(); break;
            }
            string DevLogString = "";
            foreach (var Log in List)
            {
                StringBuilder sb = new StringBuilder(DevLogString);
                sb.Append("<li class='well'><div class='row'><div class='col-sm-4'><p>");
                sb.Append(Log.Date.ToShortDateString());
                if (Log.IsPublished)
                {
                    sb.Append(" | Live on ");
                    sb.Append(Log.Site);
                    sb.Append(" | ");
                }
                else
                {
                    sb.Append(" | Draft for ");
                    sb.Append(Log.Site);
                    sb.Append(" | ");
                }
                sb.Append("<a href='/Home/EditDevLog/"); 
                sb.Append(Log.PKEY);
                sb.Append("'>Edit Post</a></p>");
                sb.Append("<i class='");
                sb.Append(Log.Icon);
                sb.Append("'></i></br><p><b>Icon Text:</b> ");
                sb.Append(Log.IconText);
                sb.Append("</br><b>Title:</b> ");
                sb.Append(Log.Title);
                sb.Append("</br><b>Summary:</b> ");
                sb.Append(Log.Summery);
                sb.Append("</p></div><div class='container DevLogDescription col-sm-8'>");
                sb.Append(Log.Description);
                sb.Append("</div></div></li>");
                DevLogString = sb.ToString();
            }
            return DevLogString;
        }

        public string LogEdit(long PKEY)
        {
            DevLogDBHelper DB = new DevLogDBHelper();
            List<DevLogsModel> Log = DB.SingleLog(PKEY);
            string DevLogString = "";

            StringBuilder sb = new StringBuilder(DevLogString);

            //Select site dropdown
            sb.Append("<div class='form-group'><label class='col-md-4 control-label' for='site'>Select Site</label><div class='col-md-4'><select id='site' name='site' class='form-control'>");

            //Manualy add each site line below as new sites are made
            sb.Append("<option value='Index'>Home Page</option>");
            sb.Append("<option value='WyrdOfStromgard'>Stromgard</option>");
            sb.Append("<option value='NiceBowling'>Nice Bowling</option>");

            sb.Append("</select></div></div>");

            //Glyph Icon text feild
            sb.Append("<div class='form-group'><label class='col-md-4 control-label' for='icon'>Glyph Icon</label><div class='col-md-4'><input id='icon' name='icon' type='text' value='");
            sb.Append(Log[0].Icon);
            sb.Append("' class='form-control input-md'></div></div>");

            //Glyph Icons subtitle feild
            sb.Append("<div class='form-group'><label class='col-md-4 control-label' for='iconText'>Icon Subtitle</label><div class='col-md-4'><input id='iconText' name='iconText' type='text'  value='");
            sb.Append(Log[0].IconText);
            sb.Append("' class='form-control input-md'></div></div>");

            //Title feild
            sb.Append("<div class='form-group'><label class='col-md-4 control-label' for='title'>Title</label><div class='col-md-4'><input id='title' name='title' type='text' value='");
            sb.Append(Log[0].Title);
            sb.Append("' class='form-control input-md'><span class='help-block'>Title of summery card</span></div></div>");

            //Summery feild
             sb.Append("<div class='form-group'><label class='col-md-4 control-label' for='summery'>Summery</label><div class='col-md-4'><input id='summery' name='summery' type='text' value='");
            sb.Append(Log[0].Summery);
            sb.Append("' class='form-control input-md'></div></div>");

            //Description feild
            sb.Append("<div class='form-group'><label class='col-md-4 control-label' for='description'>Modal Content</label><div class='col-md-4'><textarea class='form-control' id='description' name='description'>");
            sb.Append(Log[0].Description);
            sb.Append("</textarea></div></div>");

            //isPublished? radio buttons
            sb.Append("<div class='form-group'><label class='col-md-4 control-label' for='isPublished'></label><div class='col-md-4'><div class='radio'>");
            if (!Log[0].IsPublished)
            {
                sb.Append("<label for='isPublished-0'><input type='radio' name='isPublished' id='isPublished-0' value='0' checked='checked'>Draft</label></div><div class='radio'><label for='isPublished-1'><input type='radio' name='isPublished' id='isPublished-1' value='1'>Published</label>");
            }
            else
            {
                sb.Append("<label for='isPublished-0'><input type='radio' name='isPublished' id='isPublished-0' value='0'>Draft</label></div><div class='radio'><label for='isPublished-1'><input type='radio' name='isPublished' id='isPublished-1' value='1'checked='checked'>Published</label>");
            }
            sb.Append("</div><div class='radio'><label for='isPublished-2'><input type='radio' name='isPublished' id='isPublished-2' value='2'>Delete This</label>");
            sb.Append("</div></div></div>");

            //Primary Key hidden feild
            sb.Append("<input type='hidden' name='logID' id='logID' value='");
            sb.Append(Log[0].PKEY);
            sb.Append("'>");

            DevLogString = sb.ToString();

            //Select the correct site in the dropdown by default
            DevLogString = DevLogString.Insert(DevLogString.IndexOf(Log[0].Site) + Log[0].Site.Length + 1, " selected");

            return DevLogString;
        }

        public void DeleteLog(long PKEY)
        {
            DevLogDBHelper DB = new DevLogDBHelper();
            DB.Remove(PKEY);
        }

        public string GetLog(string WebPage)
        {
            if(WebPage == "") { WebPage = "Index"; }
            DevLogDBHelper DB = new DevLogDBHelper();
            var List = DB.PublishedLogs(WebPage);

            string DevLogString = "";
            foreach (var Log in List)
            {
                StringBuilder sb = new StringBuilder(DevLogString);
                sb.Append("<div class='container-fluid'><div class='row'><div class='col-sm-3'></div><div class='col-sm-3'><div class='devlog-item'><a class='devlog-link' data-toggle='modal' href='#DL");
                sb.Append(Log.PKEY);
                sb.Append("'><div class='devlog-hover'><div class='devlog-hover-content'><i class='fa fa-plus fa-3x'></i></div></div><i class='");
                sb.Append(Log.Icon);
                sb.Append("'></i><p>");
                sb.Append(Log.IconText);
                sb.Append("</p></a></div></div><div class='col-sm-5'><div class='devlog-item'><div class='devlog-caption'><h4>");
                sb.Append(Log.Title);
                sb.Append("</h4><p class='muted'>");
                sb.Append(Log.Summery);
                sb.Append("</p></div></div></div><div class='col-sm-1'></div></div></div>");
                DevLogString = sb.ToString();
            }
            return DevLogString;
        }

        public string GetLogModal(string WebPage)
        {
            if (WebPage == "") { WebPage = "Index"; }
            DevLogDBHelper DB = new DevLogDBHelper();
            var List = DB.PublishedLogs(WebPage);

            string DevLogString = "";
            foreach (var Log in List)
            {
                StringBuilder sb = new StringBuilder(DevLogString);
                sb.Append("<div class='devlog-modal modal fade' id='DL");
                sb.Append(Log.PKEY);
                sb.Append("' tabindex='-1' role='dialog' aria-hidden='true'><div class='devlog-modal-dialog'><div class='modal-content'><div class='close-modal' data-dismiss='modal'><div class='lr'><div class='rl'></div></div></div><div class='container'><div class='row'><div class='col-sm-12 mx-auto'><div class='modal-body'>");
                sb.Append(Log.Description);
                sb.Append("<button class='btn btn-primary' data-dismiss='modal' type='button'><i class='fa fa-times'></i>Close Devlog</button></div></div></div></div></div></div></div>");
                DevLogString = sb.ToString();
            }
            return DevLogString;
        }
    }
}