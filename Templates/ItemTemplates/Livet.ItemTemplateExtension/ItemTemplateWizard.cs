using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System.Collections.Generic;

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
                var dte = (_DTE)automationObject;
                var project = (Project)((object[])dte.ActiveSolutionProjects)[0];
                string defaultNamespace = null;

                foreach (Property property in project.Properties)
                {
                    if (property.Name.ToLower() == "defaultnamespace")
                    {
                        defaultNamespace = (string)property.Value;
                    }
                }

                replacementsDictionary.Add("$projectrootnamespace$", defaultNamespace);
            }
            catch { }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
