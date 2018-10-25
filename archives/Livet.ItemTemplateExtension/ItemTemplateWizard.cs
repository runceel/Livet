using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TemplateWizard;
using EnvDTE;


namespace Livet.ItemTemplateExtension
{
    public class ItemTemplateWizard : IWizard
    {
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            try
            {
                _DTE dte = (_DTE)automationObject;

                var project = (Project)((object[])dte.ActiveSolutionProjects)[0];

                string defaultNamespae = null;

                foreach (Property property in project.Properties)
                {
                    if (property.Name.ToLower() == "defaultnamespace")
                    {
                        defaultNamespae = (string)property.Value;
                    }
                }

                replacementsDictionary.Add("$projectrootnamespace$", defaultNamespae);
            }
            catch { }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
