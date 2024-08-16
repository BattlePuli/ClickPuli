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

        public void AddLimitChar(string str)
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

        public void updateUnderscoreLimitChar()
        {
            if (Settings1.Default.stopOnUnderscore)
            {
                AddLimitChar("_");
            }
            else
            {
                limitChars.Remove("_");
            }
        }

        public void updateColonLimitChar()
        {
            if (Settings1.Default.stopOnColon)
            {
                AddLimitChar(":");
            }
            else
            {
                limitChars.Remove(":");
            }
        }

        public void updateSemicolonLimitChar()
        {
            if (Settings1.Default.stopOnSemicolon)
            {
                AddLimitChar(";");
            }
            else
            {
                limitChars.Remove(";");
            }
        }

        public void updatePeriodLimitChar()
        {
            if (Settings1.Default.stopOnPeriod)
            {
                AddLimitChar(".");
            }
            else
            {
                limitChars.Remove(".");
            }
        }

        public void updateCommaLimitChar()
        {
            if (Settings1.Default.stopOnComma)
            {
                AddLimitChar(",");
            }
            else
            {
                limitChars.Remove(",");
            }
        }

        public void updateExclamationMarkLimitChar()
        {
            if (Settings1.Default.stopOnExclamationMark)
            {
                AddLimitChar("!");
            }
            else
            {
                limitChars.Remove("!");
            }
        }

        public void updateQuestionMarkLimitChar()
        {
            if (Settings1.Default.stopOnQuestionMark)
            {
                AddLimitChar("?");
            }
            else
            {
                limitChars.Remove("?");
            }
        }

        public void updateHyphenLimitChar()
        {
            if (Settings1.Default.stopOnHyphen)
            {
                AddLimitChar("-");
            }
            else
            {
                limitChars.Remove("-");
            }
        }

        public void updateQuotesLimitChar()
        {
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
        }

        public void updateDoubleQuotesLimitChar()
        {
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
        }

        public void updateParenthesisLimitChar()
        {
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
        }

        public void updateSquareBracketsLimitChar()
        {
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
        }

        public void updateBracesLimitChar()
        {
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
        }

        public void updateChevronsLimitChar()
        {
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
        }

        public void updateHashLimitChar()
        {
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
