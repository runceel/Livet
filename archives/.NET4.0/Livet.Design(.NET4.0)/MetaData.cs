using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Windows.Design;
using Microsoft.Windows.Design.Metadata;

using Livet;
using System.ComponentModel;
using Livet.Behaviors;
using Livet.Behaviors.Messaging;
using Livet.Design.Properties;
using Livet.Behaviors.Messaging.Windows;
using Livet.Behaviors.Messaging.IO;
using Livet.Behaviors.ControlBinding;
using Livet.Messaging;
using Livet.Messaging.Windows;
using Livet.Messaging.IO;

[assembly: ProvideMetadata(typeof(Livet.Design.MetaData))]
namespace Livet.Design
{
    public partial class MetaData : IProvideAttributeTable
    {
        public AttributeTable AttributeTable
        {
            get 
            {
                var builder = new AttributeTableBuilder();

                #region Behaviors.Messaging

                //InteractionMessageTrigger
                builder.AddCustomAttributes(
                    typeof(InteractionMessageTrigger),
                    new DescriptionAttribute(Resources.InteractionMessageTrigger_Description));

                builder.AddCustomAttributes(
                    typeof(InteractionMessageTrigger),
                    "MessageKey",
                    new DescriptionAttribute(Resources.InteractionMessageTrigger_MessageKey_Description));

                builder.AddCustomAttributes(
                    typeof(InteractionMessageTrigger),
                    "InvokeActionsOnlyWhileAttatchedObjectLoaded",
                    new DescriptionAttribute(Resources.InteractionMessageTrigger_InvokeActionsOnlyWhileAttatchedObjectLoaded_Description));

                builder.AddCustomAttributes(
                    typeof(InteractionMessageTrigger),
                    "IsEnable",
                    new DescriptionAttribute(Resources.InteractionMessageTrigger_IsEnable_Description));

                //DirectInteractionMessage
                builder.AddCustomAttributes(
                    typeof(DirectInteractionMessage),
                    new DescriptionAttribute(Resources.DirectInteractionMessage_Description));

                builder.AddCustomAttributes(
                    typeof(DirectInteractionMessage),
                    "Message",
                    new DescriptionAttribute(Resources.DirectInteractionMessage_Message_Description));

                builder.AddCustomAttributes(
                    typeof(Livet.Behaviors.Messaging.DirectInteractionMessage),
                    "Message",
                    new TypeConverterAttribute(typeof(ExpandableObjectConverter)));

                builder.AddCustomAttributes(
                    typeof(DirectInteractionMessage),
                    "CallbackCommand",
                    new DescriptionAttribute(Resources.DirectInteractionMessage_CallbackCommand_Description));


                //InteractionMessageAction
                builder.AddCustomAttributes(
                    typeof(Livet.Behaviors.Messaging.InteractionMessageAction<>),
                    "DirectInteractionMessage",
                    new TypeConverterAttribute(typeof(ExpandableObjectConverter)));

                builder.AddCustomAttributes(
                    typeof(Livet.Behaviors.Messaging.InteractionMessageAction<>),
                    "InvokeActionOnlyWhenWindowIsActive",
                    new DescriptionAttribute(Resources.InteractionMessageAction_InvokeActionOnlyWhenWindowIsActive_Description));


                //InformationDialogInteractionMessageAction
                builder.AddCustomAttributes(
                    typeof(InformationDialogInteractionMessageAction),
                    new DescriptionAttribute(Resources.InformationDialogInteractionMessageAction_Description));
                builder.AddCustomAttributes(
                    typeof(InformationDialogInteractionMessageAction),
                    new ToolboxCategoryAttribute(Resources.ToolBoxCategory_Messaging));


                //ConfirmationDialogInteractionMessageAction
                builder.AddCustomAttributes(
                    typeof(ConfirmationDialogInteractionMessageAction),
                    new DescriptionAttribute(Resources.ConfirmDialogInteractionMessageAction_Description));
                builder.AddCustomAttributes(
                    typeof(ConfirmationDialogInteractionMessageAction),
                    new ToolboxCategoryAttribute(Resources.ToolBoxCategory_Messaging));


                //TransitionInteractionMessageAction
                builder.AddCustomAttributes(
                    typeof(TransitionInteractionMessageAction),
                    new DescriptionAttribute(Resources.InteractionTransitionAction_Description));
                builder.AddCustomAttributes(
                    typeof(TransitionInteractionMessageAction),
                    new ToolboxCategoryAttribute(Resources.ToolBoxCategory_Messaging));

                builder.AddCustomAttributes(
                    typeof(TransitionInteractionMessageAction),
                    "WindowType",
                    new DescriptionAttribute(Resources.TransitionInteractionMessageAction_WindowType_Description));

                builder.AddCustomAttributes(
                    typeof(TransitionInteractionMessageAction),
                    "Mode",
                    new DescriptionAttribute(Resources.TransitionInteractionMessageAction_Mode_Description));

                builder.AddCustomAttributes(
                    typeof(TransitionInteractionMessageAction),
                    "IsOwned",
                    new DescriptionAttribute(Resources.TransitionInteractionMessageAction_IsOwned_Description));


                //WindowInteractionMessageAction
                builder.AddCustomAttributes(
                    typeof(WindowInteractionMessageAction),
                    new DescriptionAttribute(Resources.WindowInteractionMessageAction_Description));
                builder.AddCustomAttributes(
                    typeof(WindowInteractionMessageAction),
                    new ToolboxCategoryAttribute(Resources.ToolBoxCategory_Messaging));

                //OpenFileDialogInteractionMessageAction
                builder.AddCustomAttributes(
                    typeof(OpenFileDialogInteractionMessageAction),
                    new DescriptionAttribute(Resources.OpenFileDialogInteractionMessageAction_Description));
                builder.AddCustomAttributes(
                    typeof(OpenFileDialogInteractionMessageAction),
                    new ToolboxCategoryAttribute(Resources.ToolBoxCategory_Messaging));

                //SaveFileDialogInteractionMessageAction
                builder.AddCustomAttributes(
                    typeof(SaveFileDialogInteractionMessageAction),
                    new DescriptionAttribute(Resources.SaveFileDialogInteractionMessageAction_Description));
                builder.AddCustomAttributes(
                    typeof(SaveFileDialogInteractionMessageAction),
                    new ToolboxCategoryAttribute(Resources.ToolBoxCategory_Messaging));

                #endregion

                //InteractionMessage
                builder.AddCustomAttributes(
                    typeof(InteractionMessage),
                    new DescriptionAttribute(Resources.InteractionMessage_Description));

                builder.AddCustomAttributes(
                    typeof(InteractionMessage),
                    "MessageKey",
                    new EditorBrowsableAttribute(EditorBrowsableState.Never));

                //ResponsiveInteractionMessage
                builder.AddCustomAttributes(
                    typeof(ResponsiveInteractionMessage<>),
                    new DescriptionAttribute(Resources.ResponsiveInteractionMessage_Description));

                //InformationMessage
                builder.AddCustomAttributes(
                    typeof(InformationMessage),
                    new DescriptionAttribute(Resources.InformationMessage_Description));

                builder.AddCustomAttributes(
                    typeof(InformationMessage),
                    "Caption",
                    new DescriptionAttribute(Resources.InformationMessage_Caption_Description));

                builder.AddCustomAttributes(
                    typeof(InformationMessage),
                    "Image",
                    new DescriptionAttribute(Resources.InformationMessage_Image_Description));

                builder.AddCustomAttributes(
                    typeof(InformationMessage),
                    "Text",
                    new DescriptionAttribute(Resources.InformationMessage_Text_Description));

                //ConfirmMessage
                builder.AddCustomAttributes(
                    typeof(ConfirmationMessage),
                    new DescriptionAttribute(Resources.ConfirmMessage_Description));

                builder.AddCustomAttributes(
                    typeof(ConfirmationMessage),
                    "Caption",
                    new DescriptionAttribute(Resources.ConfirmMessage_Caption_Description));

                builder.AddCustomAttributes(
                    typeof(ConfirmationMessage),
                    "Image",
                    new DescriptionAttribute(Resources.ConfirmMessage_Image_Description));

                builder.AddCustomAttributes(
                    typeof(ConfirmationMessage),
                    "Text",
                    new DescriptionAttribute(Resources.ConfirmMessage_Text_Description));

                builder.AddCustomAttributes(
                    typeof(ConfirmationMessage),
                    "Button",
                    new DescriptionAttribute(Resources.ConfirmMessage_Button_Description));

                builder.AddCustomAttributes(
                    typeof(ConfirmationMessage),
                    "Response",
                    new EditorBrowsableAttribute(EditorBrowsableState.Never));

                //TransitionMessage
                builder.AddCustomAttributes(
                    typeof(TransitionMessage),
                    new DescriptionAttribute(Resources.TransitionMessage_Description));

                builder.AddCustomAttributes(
                    typeof(TransitionMessage),
                    "Mode",
                    new DescriptionAttribute(Resources.TransitionMessage_Mode_Description));

                builder.AddCustomAttributes(
                    typeof(TransitionMessage),
                    "TransitionViewModel",
                    new DescriptionAttribute(Resources.TransitionMessage_TransitionViewModel_Description));

                builder.AddCustomAttributes(
                    typeof(Livet.Messaging.TransitionMessage),
                    "TransitionViewModel",
                    new TypeConverterAttribute(typeof(ExpandableObjectConverter)));

                //WindowActionMessage
                builder.AddCustomAttributes(
                    typeof(WindowActionMessage),
                    new DescriptionAttribute(Resources.WindowActionMessage_Description));

                builder.AddCustomAttributes(
                    typeof(WindowActionMessage),
                    "Action",
                    new DescriptionAttribute(Resources.WindowActionMessage_Action_Description));

                //FileSelectionMessage
                builder.AddCustomAttributes(
                    typeof(FileSelectionMessage),
                    "Title",
                    new DescriptionAttribute(Resources.FileSelectionMessage_Title_Description));

                builder.AddCustomAttributes(
                    typeof(FileSelectionMessage),
                    "Filter",
                    new DescriptionAttribute(Resources.FileSelectionMessage_Filter_Description));

                builder.AddCustomAttributes(
                    typeof(FileSelectionMessage),
                    "AddExtension",
                    new DescriptionAttribute(Resources.FileSelectionMessage_AddExtension_Description));

                builder.AddCustomAttributes(
                    typeof(FileSelectionMessage),
                    "InitialDirectory",
                    new DescriptionAttribute(Resources.FileSelectionMessage_InitialDirectory_Description));

                builder.AddCustomAttributes(
                    typeof(FileSelectionMessage),
                    "Response",
                    new EditorBrowsableAttribute(EditorBrowsableState.Never));

                //OpeningFileSelectionMessage
                builder.AddCustomAttributes(
                    typeof(OpeningFileSelectionMessage),
                    new DescriptionAttribute(Resources.OpeningFileSelectionMessage_Description));

                builder.AddCustomAttributes(
                    typeof(OpeningFileSelectionMessage),
                    "MultiSelect",
                    new DescriptionAttribute(Resources.OpeningFileSelectionMessage_MultiSelect_Description));

                //SavingFileSelectionMessage
                builder.AddCustomAttributes(
                    typeof(SavingFileSelectionMessage),
                    new DescriptionAttribute(Resources.SavingFileSelectionMessage_Description));

                builder.AddCustomAttributes(
                    typeof(SavingFileSelectionMessage),
                    "OverwritePrompt",
                    new DescriptionAttribute(Resources.SavingFileSelectionMessage_OverwritePrompt_Description));

                builder.AddCustomAttributes(
                    typeof(SavingFileSelectionMessage),
                    "CreatePrompt",
                    new DescriptionAttribute(Resources.SavingFileSelectionMessage_CreatePrompt_Description));

                //SetFocusAction
                builder.AddCustomAttributes(
                    typeof(SetFocusAction),
                    new DescriptionAttribute(Resources.SetFocusAction_Description));
                builder.AddCustomAttributes(
                    typeof(SetFocusAction),
                    new ToolboxCategoryAttribute(Resources.ToolBoxCategory_Root));

                //DataContextDisposeAction
                builder.AddCustomAttributes(
                    typeof(DataContextDisposeAction),
                    new DescriptionAttribute(Resources.DataContextDisposeAction_Description));

                builder.AddCustomAttributes(
                    typeof(DataContextDisposeAction),
                    new ToolboxCategoryAttribute(Resources.ToolBoxCategory_Root));

                //LivetCallMethodAction
                builder.AddCustomAttributes(
                    typeof(LivetCallMethodAction),
                    new DescriptionAttribute(Resources.LivetCallMethodAction_Description));

                builder.AddCustomAttributes(
                    typeof(LivetCallMethodAction),
                    new ToolboxCategoryAttribute(Resources.ToolBoxCategory_Root));

                //LivetDataTrigger
                builder.AddCustomAttributes(
                    typeof(LivetDataTrigger),
                    new DescriptionAttribute(Resources.LivetDataTrigger_Description));

                //RoutedEventTrigger
                builder.AddCustomAttributes(
                    typeof(RoutedEventTrigger),
                    new DescriptionAttribute(Resources.RoutedEventTrigger_Description));

                //WindowCloseCancelBehavior
                builder.AddCustomAttributes(
                    typeof(WindowCloseCancelBehavior),
                    new DescriptionAttribute(Resources.WindowCloseCancelBehavior_Description));

                builder.AddCustomAttributes(
                    typeof(WindowCloseCancelBehavior),
                    "CanClose",
                    new DescriptionAttribute(Resources.WindowCloseCancelBehavior_CanClose_Description));

                builder.AddCustomAttributes(
                    typeof(WindowCloseCancelBehavior),
                    "CallbackCommand",
                    new DescriptionAttribute(Resources.WindowCloseCancelBehavior_CallbackCommand_Description));

                builder.AddCustomAttributes(
                    typeof(WindowCloseCancelBehavior),
                    "CallbackMethodTarget",
                    new DescriptionAttribute(Resources.WindowCloseCancelBehavior_CallbackMethodTarget_Description));

                builder.AddCustomAttributes(
                    typeof(WindowCloseCancelBehavior),
                    "CallbackMethodName",
                    new DescriptionAttribute(Resources.WindowCloseCancelBehavior_CallbackMethodName_Description));

                builder.AddCustomAttributes(
                    typeof(WindowCloseCancelBehavior),
                    new ToolboxCategoryAttribute(Resources.ToolBoxCategory_Root));

                //TextBoxBindingSupportBehavior
                builder.AddCustomAttributes(
                    typeof(TextBoxBindingSupportBehavior),
                    new DescriptionAttribute(Resources.TextBoxBindingSupportBehavior_Description));

                builder.AddCustomAttributes(
                    typeof(TextBoxBindingSupportBehavior),
                    "SelectedText",
                    new DescriptionAttribute(Resources.TextBoxBindingSupportBehavior_SelectedText_Description));

                builder.AddCustomAttributes(
                    typeof(TextBoxBindingSupportBehavior),
                    "SelectionLength",
                    new DescriptionAttribute(Resources.TextBoxBindingSupportBehavior_SelectedLength_Description));

                builder.AddCustomAttributes(
                    typeof(TextBoxBindingSupportBehavior),
                    "SelectionStart",
                    new DescriptionAttribute(Resources.TextBoxBindingSupportBehavior_SelectedStart_Description));

                builder.AddCustomAttributes(
                    typeof(TextBoxBindingSupportBehavior),
                    new ToolboxCategoryAttribute(Resources.ToolBoxCategory_ControlBindingSupport));

                //PasswordBoxBindingSupportBehavior
                builder.AddCustomAttributes(
                    typeof(PasswordBoxBindingSupportBehavior),
                    new DescriptionAttribute(Resources.PasswordBoxBindingSupportBehavior_Description));

                builder.AddCustomAttributes(
                    typeof(PasswordBoxBindingSupportBehavior),
                    "Password",
                    new DescriptionAttribute(Resources.PasswordBoxBindingSupportBehavior_Password_Description));

                builder.AddCustomAttributes(
                    typeof(PasswordBoxBindingSupportBehavior),
                    new ToolboxCategoryAttribute(Resources.ToolBoxCategory_ControlBindingSupport));

                AddGenerateCodeAttributes(ref builder);

                return builder.CreateTable();
            }
        }
    }
}
