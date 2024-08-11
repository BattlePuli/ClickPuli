using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using ClickPuli.Properties;

namespace ClickPuli
{
    public partial class ThisAddIn
    {
        Word.Application application;
        const double lookAheadLimit = 100;
        const double lookBehindLimit = 100;
        static List<string> defaultLimitChars = new List<string>() { " ", ",", ";", "\n", "\t", "¶", "(", ")", "[", "]", "{", "}", ".", Environment.NewLine };
        public List<string> limitChars = new List<string>(defaultLimitChars);
        public FrmAbout aboutForm = new FrmAbout();

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            application = this.Application;
            application.WindowBeforeDoubleClick += new Word.ApplicationEvents4_WindowBeforeDoubleClickEventHandler(application_WindowBeforeDoubleClick);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        private void AddLimitChar(string str)
        {
            if (!limitChars.Contains(str))
            {
                limitChars.Add(str);
            }
        }

        // This is where the magic happens.
        public void application_WindowBeforeDoubleClick(Word.Selection selection, ref bool Cancel)
        {
            Cancel = true;

            string limitCharsString = "";
            foreach (string item in limitChars) limitCharsString += item;
            selection.MoveStartUntil(limitCharsString, -lookBehindLimit);
            selection.MoveEndUntil(limitCharsString, lookAheadLimit);

            if (Settings1.Default.includeTrailingSpace)
            {
                selection.MoveEndWhile(" ", 1);
            }

            if (Settings1.Default.autoCopy)
            {
                selection.Copy();
            }
        }

        public void UpdateLimitChars()
        {
            // Stop on underscore.
            if (Settings1.Default.stopOnUnderscore)
            {
                AddLimitChar("_");
            }
            else
            {
                limitChars.Remove("_");
            }

            // Stop on colon.
            if (Settings1.Default.stopOnColon)
            {
                AddLimitChar(":");
            }
            else
            {
                limitChars.Remove(":");
            }

            // Stop on semicolon.
            if (Settings1.Default.stopOnSemicolon)
            {
                AddLimitChar(";");
            }
            else
            {
                limitChars.Remove(";");
            }

            // Stop on period.
            if (Settings1.Default.stopOnPeriod)
            {
                AddLimitChar(".");
            }
            else
            {
                limitChars.Remove(".");
            }

            // Stop on comma.
            if (Settings1.Default.stopOnComma)
            {
                AddLimitChar(",");
            }
            else
            {
                limitChars.Remove(",");
            }

            // Stop on exclamation-mark.
            if (Settings1.Default.stopOnExclamationMark)
            {
                AddLimitChar("!");
            }
            else
            {
                limitChars.Remove("!");
            }

            // Stop on question-mark.
            if (Settings1.Default.stopOnQuestionMark)
            {
                AddLimitChar("?");
            }
            else
            {
                limitChars.Remove("?");
            }

            // Stop on hyphen.
            if (Settings1.Default.stopOnHyphen)
            {
                AddLimitChar("-");
            }
            else
            {
                limitChars.Remove("-");
            }

            // Stop on quotes.
            if (Settings1.Default.stopOnQuotes)
            {
                AddLimitChar("\'");
                AddLimitChar("’");
            }
            else
            {
                limitChars.Remove("\'");
                limitChars.Remove("’");
            }

            // Stop on doublequotes.
            if (Settings1.Default.stopOnDoubleQuotes)
            {
                AddLimitChar("\"");
                AddLimitChar("“");
                AddLimitChar("”");
            }
            else
            {
                limitChars.Remove("\"");
                limitChars.Remove("“");
                limitChars.Remove("”");
            }

            // Stop on parenteses.
            if (Settings1.Default.stopOnParentheses)
            {
                AddLimitChar("(");
                AddLimitChar(")");
            }
            else
            {
                limitChars.Remove("(");
                limitChars.Remove(")");
            }

            // Stop on squarebrackets.
            if (Settings1.Default.stopOnSquareBrackets)
            {
                AddLimitChar("[");
                AddLimitChar("]");
            }
            else
            {
                limitChars.Remove("[");
                limitChars.Remove("]");
            }

            // Stop on braces.
            if (Settings1.Default.stopOnBraces)
            {
                AddLimitChar("{");
                AddLimitChar("}");
            }
            else
            {
                limitChars.Remove("{");
                limitChars.Remove("}");
            }

            // Stop on chevrons.
            if (Settings1.Default.stopOnChevrons)
            {
                AddLimitChar("<");
                AddLimitChar(">");
            }
            else
            {
                limitChars.Remove("<");
                limitChars.Remove(">");
            }

            // Stop on hash.
            if (Settings1.Default.stopOnHash)
            {
                AddLimitChar("#");
            }
            else
            {
                limitChars.Remove("#");
            }
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
