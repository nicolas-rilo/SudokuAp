﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Es.Udc.DotNet.SudokuApp.Web.HTTP.View
{
    public class Languages
    {
        private static readonly ArrayList languages_es = new ArrayList();
        private static readonly ArrayList languages_en = new ArrayList();
        private static readonly ArrayList languages_gl = new ArrayList();
        private static readonly Hashtable languages = new Hashtable();

        private Languages() { }

        static Languages()
        {
            #region set the languages

            languages_es.Add(new ListItem("Español", "es"));
            languages_es.Add(new ListItem("Gallego", "gl"));
            languages_es.Add(new ListItem("Inglés", "en"));

            languages_en.Add(new ListItem("English", "en"));
            languages_en.Add(new ListItem("Galician", "gl"));
            languages_en.Add(new ListItem("Spanish", "es"));

            languages_gl.Add(new ListItem("Español", "es"));
            languages_gl.Add(new ListItem("Galego", "gl"));
            languages_gl.Add(new ListItem("Inglés", "en"));

            languages.Add("es", languages_es);
            languages.Add("en", languages_en);
            languages.Add("gl", languages_gl);

            #endregion
        }

        public static ICollection GetLaguageCodes()
        {
            return languages.Keys;
        }

        public static ArrayList GetLanguages(String languageCode)
        {
            ArrayList lang = (ArrayList)languages[languageCode];

            if (lang != null)
            {
                return lang;
            }
            else
            {
                return (ArrayList)languages["en"];
            }
        }
    }
}