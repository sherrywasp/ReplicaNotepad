using System;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Text;

namespace ReplicaNotepad
{
    public class Settings
    {
        private const int DEFAULT_LEFT = 50;
        private const int DEFAULT_TOP = 20;
        private const int DEFAULT_WIDTH = 800;
        private const int DEFAULT_HEIGHT = 500;
        private const bool DEFAULT_WORD_WRAP = false;
        private const bool DEFAULT_STATUS_BAR_VISIBLE = false;
        private const string DEFAULT_FONT_NAME = "Microsoft YaHei";
        private const FontStyle DEFAULT_FONT_STYLE = FontStyle.Regular;
        private const int DEFAULT_FONT_SIZE = 10;
        private readonly Color defaultBackColor = Color.WhiteSmoke;
        private readonly string settingsFileName;

        private XmlDocument xmlSettings;

        private int positionLeft;        
        private int positionTop;
        private int startWidth;
        private int startHeight;
        private bool wordWrap;
        private Font font;
        private bool statusBarVisible;
        private Color backColor;

        public int PositionLeft
        {
            get { return positionLeft; }
            set { positionLeft = value; }
        }

        public int PositionTop
        {
            get { return positionTop; }
            set { positionTop = value; }
        }

        public int StartWidth
        {
            get { return startWidth; }
            set { startWidth = value; }
        }

        public int StartHeight
        {
            get { return startHeight; }
            set { startHeight = value; }
        }

        public bool WordWrap
        {
            get { return wordWrap; }
            set { wordWrap = value; }
        }

        public Color BackColor
        {
            get { return backColor; }
            set { backColor = value; }
        }

        public Font Font
        {
            get { return font; }
            set { font = value; }
        }

        public bool StatusBarVisible
        {
            get { return statusBarVisible; }
            set { statusBarVisible = value; }
        }

        public Settings()
        {
            string processName = Environment.GetCommandLineArgs()[0];
            string processPath = processName.Substring(0, processName.LastIndexOf('\\'));
            settingsFileName = string.Format("{0}\\settings.xml", processPath);

            Init();
        }

        public void Set(string tagName, string value)
        {
            if (!File.Exists(settingsFileName))
            {
                CreateSettingsXml(settingsFileName);
            }

            if (xmlSettings != null)
            {
                xmlSettings.SelectSingleNode(string.Format("Settings/{0}", tagName)).FirstChild.Value = value;
                xmlSettings.Save(settingsFileName);
            }
        }

        private void Init()
        {
            if (!File.Exists(settingsFileName))
            {
                CreateSettingsXml(settingsFileName);
            }

            if (File.Exists(settingsFileName))
            {
                xmlSettings = new XmlDocument();
                xmlSettings.Load(settingsFileName);

                int result_int;
                XmlNode node;

                node = GetSettingNode(xmlSettings, "PositionLeft");
                this.positionLeft =
                    node != null && int.TryParse(node.Value, out result_int)
                    ? result_int
                    : DEFAULT_LEFT;

                node = GetSettingNode(xmlSettings, "PositionTop");
                this.positionTop =
                    node != null && int.TryParse(node.Value, out result_int)
                    ? result_int
                    : DEFAULT_TOP;

                node = GetSettingNode(xmlSettings, "StartWidth");
                this.startWidth =
                    node != null && int.TryParse(node.Value, out result_int)
                    ? result_int
                    : DEFAULT_WIDTH;

                node = GetSettingNode(xmlSettings, "StartHeight");
                this.startHeight =
                    node != null && int.TryParse(node.Value, out result_int)
                    ? result_int
                    : DEFAULT_HEIGHT;

                node = GetSettingNode(xmlSettings, "WordWrap");
                this.wordWrap = node.Value != "0";

                node = GetSettingNode(xmlSettings, "FontName");
                string fontName = node != null ? node.Value : DEFAULT_FONT_NAME;

                node = GetSettingNode(xmlSettings, "FontStyle");
                FontStyle fontStyle = node != null ? GetFontStyleByName(node.Value) : DEFAULT_FONT_STYLE;

                node = GetSettingNode(xmlSettings, "FontSize");
                int fontSize =
                    node != null && int.TryParse(node.Value, out result_int)
                    ? result_int
                    : DEFAULT_FONT_SIZE;

                this.font = new Font(fontName, fontSize, fontStyle);

                node = GetSettingNode(xmlSettings, "StatusBarVisible");
                this.statusBarVisible = node.Value != "0";

                node = GetSettingNode(xmlSettings, "BackColor");
                this.BackColor = node != null
                    ? ColorTranslator.FromHtml(node.Value)
                    : defaultBackColor;
            }
            else
            {
                this.positionLeft = DEFAULT_LEFT;
                this.positionTop = DEFAULT_TOP;
                this.startWidth = DEFAULT_WIDTH;
                this.startHeight = DEFAULT_HEIGHT;
                this.wordWrap = DEFAULT_WORD_WRAP;
                this.font = new Font(DEFAULT_FONT_NAME, DEFAULT_FONT_SIZE, DEFAULT_FONT_STYLE);
                this.statusBarVisible = DEFAULT_STATUS_BAR_VISIBLE;
                this.backColor = defaultBackColor;               
            }
        }

        private FontStyle GetFontStyleByName(string fontStyle)
        {
            fontStyle = fontStyle.ToLower();
            switch (fontStyle)
            {
                case "regular":
                    return FontStyle.Regular;
                case "italic":
                    return FontStyle.Italic;
                case "bold":
                    return FontStyle.Bold;
                case "bold, italic":
                    return FontStyle.Bold | FontStyle.Italic;
                default:
                    return FontStyle.Regular;
            }
        }

        // 获取设置项节点
        private XmlNode GetSettingNode(XmlDocument xmlDoc, string tagName)
        {
            XmlNode node = null;

            if (xmlDoc != null)
            {
                try
                {
                    node = xmlDoc.SelectSingleNode(string.Format("Settings/{0}", tagName));
                    if (node != null)
                    {
                        node = node.FirstChild;
                    }
                }
                catch (XPathException) { }
            }

            return node;
        }

        private void CreateSettingsXml(string fileName)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
                {
                    string content =
                        @"<?xml version=""1.0"" encoding=""utf-8"" ?>
<Settings>
    <PositionLeft>50</PositionLeft>
    <PositionTop>20</PositionTop>
    <StartWidth>700</StartWidth>
    <StartHeight>500</StartHeight>
    <WordWrap>0</WordWrap>
    <FontName>Microsoft YaHei</FontName>
    <FontStyle>Regular</FontStyle>
    <FontSize>12</FontSize>
    <StatusBarVisible>0</StatusBarVisible>
    <BackColor>#FFFFFF</BackColor>
</Settings>";

                    sw.Write(content);
                }
            }
            catch { }
        }
    }
}
