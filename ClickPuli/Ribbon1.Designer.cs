namespace ClickPuli
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.grpStopOnCharacter = this.Factory.CreateRibbonGroup();
            this.cbStopOnUnderscore = this.Factory.CreateRibbonCheckBox();
            this.cbStopOnColon = this.Factory.CreateRibbonCheckBox();
            this.cbStopOnComma = this.Factory.CreateRibbonCheckBox();
            this.cbStopOnSemicolon = this.Factory.CreateRibbonCheckBox();
            this.cbStopOnExclamationMark = this.Factory.CreateRibbonCheckBox();
            this.cbStopOnQuestionMark = this.Factory.CreateRibbonCheckBox();
            this.cbStopOnParentheses = this.Factory.CreateRibbonCheckBox();
            this.cbStopOnSquareBrackets = this.Factory.CreateRibbonCheckBox();
            this.cbStopOnBraces = this.Factory.CreateRibbonCheckBox();
            this.cbStopOnChevrons = this.Factory.CreateRibbonCheckBox();
            this.cbStopOnQuotes = this.Factory.CreateRibbonCheckBox();
            this.cbStopOnDoubleQuotes = this.Factory.CreateRibbonCheckBox();
            this.cbStopOnHyphen = this.Factory.CreateRibbonCheckBox();
            this.cbStopOnPeriod = this.Factory.CreateRibbonCheckBox();
            this.cbStopOnHash = this.Factory.CreateRibbonCheckBox();
            this.grpMisc = this.Factory.CreateRibbonGroup();
            this.cbIncludeTrailingSpace = this.Factory.CreateRibbonCheckBox();
            this.cbAutoCopy = this.Factory.CreateRibbonCheckBox();
            this.btnAbout = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.grpStopOnCharacter.SuspendLayout();
            this.grpMisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.grpStopOnCharacter);
            this.tab1.Groups.Add(this.grpMisc);
            this.tab1.Label = "ClickPuli";
            this.tab1.Name = "tab1";
            // 
            // grpStopOnCharacter
            // 
            this.grpStopOnCharacter.Items.Add(this.cbStopOnUnderscore);
            this.grpStopOnCharacter.Items.Add(this.cbStopOnColon);
            this.grpStopOnCharacter.Items.Add(this.cbStopOnComma);
            this.grpStopOnCharacter.Items.Add(this.cbStopOnSemicolon);
            this.grpStopOnCharacter.Items.Add(this.cbStopOnExclamationMark);
            this.grpStopOnCharacter.Items.Add(this.cbStopOnQuestionMark);
            this.grpStopOnCharacter.Items.Add(this.cbStopOnParentheses);
            this.grpStopOnCharacter.Items.Add(this.cbStopOnSquareBrackets);
            this.grpStopOnCharacter.Items.Add(this.cbStopOnBraces);
            this.grpStopOnCharacter.Items.Add(this.cbStopOnChevrons);
            this.grpStopOnCharacter.Items.Add(this.cbStopOnQuotes);
            this.grpStopOnCharacter.Items.Add(this.cbStopOnDoubleQuotes);
            this.grpStopOnCharacter.Items.Add(this.cbStopOnHyphen);
            this.grpStopOnCharacter.Items.Add(this.cbStopOnPeriod);
            this.grpStopOnCharacter.Items.Add(this.cbStopOnHash);
            this.grpStopOnCharacter.Label = "Stop Selection On Character";
            this.grpStopOnCharacter.Name = "grpStopOnCharacter";
            // 
            // cbStopOnUnderscore
            // 
            this.cbStopOnUnderscore.Label = "_";
            this.cbStopOnUnderscore.Name = "cbStopOnUnderscore";
            this.cbStopOnUnderscore.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbStopOnUnderscore_Click);
            // 
            // cbStopOnColon
            // 
            this.cbStopOnColon.Label = ":";
            this.cbStopOnColon.Name = "cbStopOnColon";
            this.cbStopOnColon.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbStopOnColon_Click);
            // 
            // cbStopOnComma
            // 
            this.cbStopOnComma.Label = ",";
            this.cbStopOnComma.Name = "cbStopOnComma";
            this.cbStopOnComma.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbStopOnComma_Click);
            // 
            // cbStopOnSemicolon
            // 
            this.cbStopOnSemicolon.Label = ";";
            this.cbStopOnSemicolon.Name = "cbStopOnSemicolon";
            this.cbStopOnSemicolon.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbStopOnSemicolon_Click);
            // 
            // cbStopOnExclamationMark
            // 
            this.cbStopOnExclamationMark.Label = "!";
            this.cbStopOnExclamationMark.Name = "cbStopOnExclamationMark";
            this.cbStopOnExclamationMark.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbStopOnExclamationMark_Click);
            // 
            // cbStopOnQuestionMark
            // 
            this.cbStopOnQuestionMark.Label = "?";
            this.cbStopOnQuestionMark.Name = "cbStopOnQuestionMark";
            this.cbStopOnQuestionMark.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbStopOnQuestionMark_Click);
            // 
            // cbStopOnParentheses
            // 
            this.cbStopOnParentheses.Label = "( )";
            this.cbStopOnParentheses.Name = "cbStopOnParentheses";
            this.cbStopOnParentheses.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbStopOnParentheses_Click);
            // 
            // cbStopOnSquareBrackets
            // 
            this.cbStopOnSquareBrackets.Label = "[ ]";
            this.cbStopOnSquareBrackets.Name = "cbStopOnSquareBrackets";
            this.cbStopOnSquareBrackets.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbStopOnSquareBrackets_Click);
            // 
            // cbStopOnBraces
            // 
            this.cbStopOnBraces.Label = "{ }";
            this.cbStopOnBraces.Name = "cbStopOnBraces";
            this.cbStopOnBraces.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbStopOnBraces_Click);
            // 
            // cbStopOnChevrons
            // 
            this.cbStopOnChevrons.Label = "< >";
            this.cbStopOnChevrons.Name = "cbStopOnChevrons";
            this.cbStopOnChevrons.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbStopOnChevrons_Click);
            // 
            // cbStopOnQuotes
            // 
            this.cbStopOnQuotes.Label = "\'";
            this.cbStopOnQuotes.Name = "cbStopOnQuotes";
            this.cbStopOnQuotes.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbStopOnQuotes_Click);
            // 
            // cbStopOnDoubleQuotes
            // 
            this.cbStopOnDoubleQuotes.Label = "\"";
            this.cbStopOnDoubleQuotes.Name = "cbStopOnDoubleQuotes";
            this.cbStopOnDoubleQuotes.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbStopOnDoubleQuotes_Click);
            // 
            // cbStopOnHyphen
            // 
            this.cbStopOnHyphen.Label = "-";
            this.cbStopOnHyphen.Name = "cbStopOnHyphen";
            this.cbStopOnHyphen.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbStopOnHyphen_Click);
            // 
            // cbStopOnPeriod
            // 
            this.cbStopOnPeriod.Label = ".";
            this.cbStopOnPeriod.Name = "cbStopOnPeriod";
            this.cbStopOnPeriod.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbStopOnPeriod_Click);
            // 
            // cbStopOnHash
            // 
            this.cbStopOnHash.Label = "#";
            this.cbStopOnHash.Name = "cbStopOnHash";
            this.cbStopOnHash.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbStopOnHash_Click);
            // 
            // grpMisc
            // 
            this.grpMisc.Items.Add(this.cbIncludeTrailingSpace);
            this.grpMisc.Items.Add(this.cbAutoCopy);
            this.grpMisc.Items.Add(this.btnAbout);
            this.grpMisc.Label = "Misc";
            this.grpMisc.Name = "grpMisc";
            // 
            // cbIncludeTrailingSpace
            // 
            this.cbIncludeTrailingSpace.Label = "Select trailing space";
            this.cbIncludeTrailingSpace.Name = "cbIncludeTrailingSpace";
            this.cbIncludeTrailingSpace.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbIncludeTrailingSpace_Click);
            // 
            // cbAutoCopy
            // 
            this.cbAutoCopy.Label = "auto-copy";
            this.cbAutoCopy.Name = "cbAutoCopy";
            this.cbAutoCopy.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbAutoCopy_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Image = global::ClickPuli.Properties.Resources.info;
            this.btnAbout.Label = "About";
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ShowImage = true;
            this.btnAbout.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAbout_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.grpStopOnCharacter.ResumeLayout(false);
            this.grpStopOnCharacter.PerformLayout();
            this.grpMisc.ResumeLayout(false);
            this.grpMisc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpMisc;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpStopOnCharacter;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbIncludeTrailingSpace;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbAutoCopy;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbStopOnUnderscore;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbStopOnColon;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbStopOnComma;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbStopOnSemicolon;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbStopOnExclamationMark;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbStopOnHash;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbStopOnParentheses;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbStopOnSquareBrackets;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbStopOnBraces;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbStopOnChevrons;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbStopOnQuotes;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbStopOnDoubleQuotes;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbStopOnHyphen;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbStopOnPeriod;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbStopOnQuestionMark;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAbout;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
