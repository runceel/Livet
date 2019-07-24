using System;
using System.Collections.Generic;
using System.Linq;
using EnvDTE;
using Livet.Annotations;
using Microsoft.VisualStudio.TemplateWizard;

namespace Livet.ItemTemplateExtension
{
    public class ItemTemplateWizard : IWizard
    {
        public void BeforeOpeningFile(ProjectItem projectItem) { }

        public void ProjectFinishedGenerating(Project project) { }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem) { }

        public void RunFinished() { }

        public void RunStarted([NotNull] object automationObject,
            [NotNull] Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, [NotNull] object[] customParams)
        {
            if (automationObject == null) throw new ArgumentNullException(nameof(automationObject));
            if (replacementsDictionary == null) throw new ArgumentNullException(nameof(replacementsDictionary));
            if (customParams == null) throw new ArgumentNullException(nameof(customParams));

            try
            {
                var dte = (_DTE) automationObject;
                var project = (Project) ((object[]) dte.ActiveSolutionProjects)?[0];
                string defaultNamespace = null;

                if (project?.Properties != null)
                {
                    foreach (var property in project.Properties?.OfType<Property>())
                    {
                        if (property.Name?.ToLower() == "defaultnamespace")
                            defaultNamespace = (string) property.Value;
                    }
                }

                replacementsDictionary.Add("$projectrootnamespace$", defaultNamespace);
            }
            catch
            {
                // ignored
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}