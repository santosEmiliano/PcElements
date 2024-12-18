using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPcElements
{
    public class AppTheme
    {
        // ----------------------------- PALETA DE COLORES -----------------------------

        public static bool LM;

        public static List<Color> paleta = [

            Color.FromArgb(13, 20, 31),            // Indice 0 -> SKY 1
            Color.FromArgb(17, 26, 39),            // Indice 1 -> SKY 2
            Color.FromArgb(17, 40, 64),            // Indice 2 -> SKY 3
            Color.FromArgb(17, 53, 85),            // Indice 3 -> SKY 4
            Color.FromArgb(21, 68, 103),           // Indice 4 -> SKY 5
            Color.FromArgb(27, 83, 123),           // Indice 5 -> SKY 6
            Color.FromArgb(31, 102, 146),          // Indice 6 -> SKY 7
            Color.FromArgb(25, 124, 174),          // Indice 7 -> SKY 8
            Color.FromArgb(124, 226, 254),         // Indice 8 -> SKY 9
            Color.FromArgb(168, 238, 255),         // Indice 9 -> SKY 10
            Color.FromArgb(117, 199, 240),         // Indice 10 -> SKY 11
            Color.FromArgb(194, 243, 255),         // Indice 11 -> SKY 12
        ];

        // --------------------------------- COLORES -----------------------------------


        // ----------------------- PANELES PRINCIPALES -------------------------

        static public Color header = paleta[4];
        static public Color footer = header;
        static public Color sideBar = header;
        static public Color background = paleta[1];
        static public Color extremo = paleta[0];

        // ----------------------------- FUENTES -------------------------------

        static public Color font = paleta[10];
        static public Color buttonsFont = font;

        // ----------------------------- BUTTONS -------------------------------

        static public Color button = paleta[3];

        // ----------------------------- TEXTBOX -------------------------------

        static public Color textBox = paleta[3];

        // ----------------------------- DGVPRODUCTOS --------------------------

        static public Color filaImpar = paleta[7];


        // --------------------------------- BITMAPS -----------------------------------


        // ---------------------------- GENERALES ------------------------------

        static public Bitmap themeIcon = Properties.Resources.Moon;
        static public Bitmap helpIcon = Properties.Resources.Help_circleDM;
        static public Bitmap teamLogo = Properties.Resources.circleTeamLogoDM;
        static public Bitmap arrowLeft = Properties.Resources.Arrow_left_circleDM;
        static public Bitmap arrowRight = Properties.Resources.Arrow_right_circleDM;
        static public Bitmap arrowBack = Properties.Resources.arrow_backDM;
        static public Bitmap settingsIcon = Properties.Resources.settingsDM;
        static public Bitmap backgroundInfo = Properties.Resources.BackgroundInfoDM;
        static public Bitmap backgroundInfoInv = Properties.Resources.BackgroundInfoLM;
        static public Bitmap backgroundAgotado = Properties.Resources.BackgroundAgotado;


        // --------------------------- FORMPORTADA -----------------------------

        static public Bitmap instagramIcon = Properties.Resources.InstagramDM;
        static public Bitmap twitterIcon = Properties.Resources.TwitterDM;
        static public Bitmap youtubeIcon = Properties.Resources.YoutubeDM;

        // --------------------------- FORMPASSWORD ----------------------------

        static public Bitmap passwordEyeC = Properties.Resources.Eye_offDM;
        static public Bitmap passwordEyeO = Properties.Resources.EyeDM;

        // --------------------------- FORMUSER ----------------------------

        static public Bitmap bdIcon = Properties.Resources.bdIconDM;
        static public Bitmap user = Properties.Resources.UserDM;

        // --------------------------- FORMADMIN ----------------------------

        static public Bitmap addIcon = Properties.Resources.add_circleDM;
        static public Bitmap clipBoard = Properties.Resources.ClipboardDM;
        static public Bitmap editIcon = Properties.Resources.EditDM;
        static public Bitmap deleteIcon = Properties.Resources.deleteDM;
        static public Bitmap statsIcon = Properties.Resources.EstadisticasDM;
        static public Bitmap ventas = Properties.Resources.Shopping_bagDM;

        // --------------------------- FORMADMIN ALTAS Y MODIFICACIONES ----------------------------
        static public Bitmap addFIleIcon = Properties.Resources.File_plusDM;


        // <--------------------------------------------------------------------------->



        public static void DarkMode()
        {
            LM = false;

            // COLORES

            sideBar = footer = header = paleta[4];
            background = paleta[1];
            font = paleta[10];
            textBox = button = paleta[3];
            extremo = paleta[0];
            filaImpar = paleta[7];

            // BITMAPS

            // OPTIONSMENU
            themeIcon = Properties.Resources.Moon;
            helpIcon = Properties.Resources.Help_circleDM;
            settingsIcon = Properties.Resources.settingsDM;

            // EXITMENU
            arrowLeft = Properties.Resources.Arrow_left_circleDM;
            arrowRight = Properties.Resources.Arrow_right_circleDM;

            // SOCIAL MEDIA
            instagramIcon = Properties.Resources.InstagramDM;
            twitterIcon = Properties.Resources.TwitterDM;
            youtubeIcon = Properties.Resources.YoutubeDM;

            // LOGOS
            teamLogo = Properties.Resources.circleTeamLogoDM;

            // PASSWORD
            passwordEyeC = Properties.Resources.Eye_offDM;
            passwordEyeO = Properties.Resources.EyeDM;

            // INFO BACKGROUNDS
            backgroundInfoInv = Properties.Resources.BackgroundInfoLM;
            backgroundInfo = Properties.Resources.BackgroundInfoDM;

            // RETURN
            arrowBack = Properties.Resources.arrow_backDM;

            // USER
            bdIcon = Properties.Resources.bdIconDM;
            user = Properties.Resources.UserDM;

            // ADMIN
            clipBoard = Properties.Resources.ClipboardDM;
            addIcon = Properties.Resources.add_circleDM;
            editIcon = Properties.Resources.EditDM;
            deleteIcon = Properties.Resources.deleteDM;
            statsIcon = Properties.Resources.EstadisticasDM;
            ventas = Properties.Resources.Shopping_bagDM;

            addFIleIcon = Properties.Resources.File_plusDM;
        }

        public static void LightMode()
        {
            LM = true;

            // COLORES

            sideBar = footer = header = paleta[6];
            background = paleta[10];
            font = paleta[1];
            buttonsFont = paleta[9];
            textBox = button = paleta[7];
            extremo = paleta[11];


            // BITMAPS

            // OPTIONS MENU
            themeIcon = Properties.Resources.Sun;
            helpIcon = Properties.Resources.Help_circleLM;
            settingsIcon = Properties.Resources.settingsLM;

            // EXIT MENU
            arrowLeft = Properties.Resources.Arrow_left_circleLM;
            arrowRight = Properties.Resources.Arrow_right_circleLM;

            // SOCIAL MEDIA
            instagramIcon = Properties.Resources.InstagramLM;
            twitterIcon = Properties.Resources.TwitterLM;
            youtubeIcon = Properties.Resources.YoutubeLM;

            // LOGOS
            teamLogo = Properties.Resources.circleTeamLogoLM;

            // PASSWORD
            passwordEyeC = Properties.Resources.Eye_offLM;
            passwordEyeO = Properties.Resources.EyeLM;

            //INFO BACKGROUNDS
            backgroundInfo = Properties.Resources.BackgroundInfoLM;
            backgroundInfoInv = Properties.Resources.BackgroundInfoDM;

            // RETURN
            arrowBack = Properties.Resources.arrow_backDM;

            // USER
            bdIcon = Properties.Resources.bdIconLM;
            user = Properties.Resources.UserLM;

            // ADMIN
            clipBoard = Properties.Resources.ClipboardLM;
            addIcon = Properties.Resources.add_circleLM;
            editIcon = Properties.Resources.EditLM;
            deleteIcon = Properties.Resources.deleteLM;
            statsIcon = Properties.Resources.EstadisticasLM;
            ventas = Properties.Resources.Shopping_bagLM;

            addFIleIcon = Properties.Resources.File_plusLM;
        }
    }
}