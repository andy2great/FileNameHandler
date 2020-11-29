using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using Microsoft.WindowsAPICodePack.Shell;
using System.Globalization;

namespace mppFileHandler
{
    class Pipeline
    {
        private bool _withCreationDate = false;
        private bool _withCustomText = false;
        private String _customText = "";
        private Label _previsualisationLabel = null;

        public Pipeline(Label currentForm)
        {
            _previsualisationLabel = currentForm;

            adjustPrevisualisation();
        }

        public String CustomText
        {
            get { return _customText; }
            set { 
                _customText = value;
                adjustPrevisualisation();
            }
        }

        public bool WithCreationDate
        {
            get { return _withCreationDate; }
            set
            {
                _withCreationDate = value;
                adjustPrevisualisation();
            }
        }

        public bool WithCustomText
        {
            get { return _withCustomText; }
            set
            {
                _withCustomText = value;
                adjustPrevisualisation();
            }
        }

        private void adjustPrevisualisation()
        {
            String previsualisation = "";
            if (WithCreationDate)
            {
                previsualisation += "{AAAA-MM-DD}-";
            }
            previsualisation += "{ORIGINAL NAME}";

            if (WithCustomText)
            {
                previsualisation += "-{"+ CustomText +"}";
            }

            previsualisation += ".{EXTENSION}";

            _previsualisationLabel.Text = previsualisation;
        }

        public String transformText(FileInfo file)
        {
            var fileElements = file.Name.Split('.');
            
            var pipedName = "";

            if (fileElements.Length > 1)
            {
                if (WithCreationDate)
                {
                    var date = getDateTakenFromFile(file);

                    if (date != null && date.Length != 0)
                    {
                        pipedName += date + "-";
                    }
                }

                for (int i = 0; i < fileElements.Length - 1; i++)
                {
                    if (i != 0)
                    {
                        pipedName += ".";
                    }
                    pipedName += fileElements[i];
                }

                if (WithCustomText && _customText != null && _customText.Length > 0)
                {
                    pipedName += "-" + _customText;
                }

                pipedName += "." + fileElements[fileElements.Length - 1];
            }
            else
            {
                pipedName = file.Name;
            }


            return pipedName;
        }

        private String getDateTakenFromFile(FileInfo file)
        {
            var dateTaken = "";
            
            try {
                ShellObject picture = ShellObject.FromParsingName(file.FullName);

                if (picture != null)
                {
                    String date = GetValue(picture.Properties.GetProperty(SystemProperties.System.Photo.DateTaken));
 
                    if (date != null && date.Length > 0)
                    {
                        date = date.Split(' ')[0];

                        var values = date.Split(new string[] { "/","-" }, StringSplitOptions.None);

                        if (values[0].Length < 2)
                        {
                            values[0] = "0" + values[0];
                        }

                        if (values[1].Length < 2)
                        {
                            values[1] = "0" + values[1];
                        }

                        if (values[0].Length > 2)
                        {
                            dateTaken = DateTime.ParseExact(values[0] + "/" + values[1] + "/" + values[2], "yyyy/MM/dd", null).ToString("yyyyMMdd");
                        }
                        else
                        {
                            dateTaken = DateTime.ParseExact(values[0] + "/" + values[1] + "/" + values[2], "MM/dd/yyyy", null).ToString("yyyyMMdd");
                        }
                    }
                }
            } catch {}

            return dateTaken;
        }

        private static string GetValue(IShellProperty value)
        {
            if (value == null || value.ValueAsObject == null)
            {
                return String.Empty;
            }
            return value.ValueAsObject.ToString();
        }
    }
}
