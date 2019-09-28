//このコードはT4 Templateによって自動生成されています。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Controls.Primitives;
using System.ComponentModel;
using System.Windows.Interop;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Documents.Serialization;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using System.Windows.Annotations;
using System.Windows.Ink;
using System.Windows.Automation.Peers;
using System.Windows.Markup.Localizer;
using System.Windows.Media.Imaging;
using System.IO.Packaging;
using System.Security.RightsManagement;
using System.Windows.Threading;
using System.Windows.Media.Effects;
using System.Windows.Shell;
using System.Security.Permissions;
using System.Windows.Annotations.Storage;
using System.Diagnostics;

namespace Livet.Converters
{
	/// <summary>
    /// RightsManagementFailureCode列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class RightsManagementFailureCodeAndBooleanConverter : IValueConverter
    {
        //VM→View
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is bool)) throw new ArgumentException();

            if ((bool)value)
            {
                if (_isConvertWhenTrueSet)
                {
                    return ConvertWhenTrue;
                }
            }
            else
            {
                if (_isConvertWhenFalseSet)
                {
                    return ConvertWhenFalse;
                }
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertWhenTrueSet;
        private RightsManagementFailureCode _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのRightsManagementFailureCode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public RightsManagementFailureCode ConvertWhenTrue
        {
            get
            {
                return _convertWhenTrue;
            }
            set
            {
                _convertWhenTrue = value;
                _isConvertWhenTrueSet = true;
            }
        }

        private bool _isConvertWhenFalseSet;
        private RightsManagementFailureCode _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのRightsManagementFailureCode列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public RightsManagementFailureCode ConvertWhenFalse
        {
            get
            {
                return _convertWhenFalse;
            }
            set
            {
                _convertWhenFalse = value;
                _isConvertWhenFalseSet = true;
            }
        }

        //View→VM
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is RightsManagementFailureCode)) throw new ArgumentException();

            var enumValue = (RightsManagementFailureCode)value;

			switch(enumValue.ToString())
			{
				case "Success":
					if (_isConvertBackWhenSuccessSet)
					{
						return ConvertBackWhenSuccess;
					}
					break;
				case "ManifestPolicyViolation":
					if (_isConvertBackWhenManifestPolicyViolationSet)
					{
						return ConvertBackWhenManifestPolicyViolation;
					}
					break;
				case "InvalidLicense":
					if (_isConvertBackWhenInvalidLicenseSet)
					{
						return ConvertBackWhenInvalidLicense;
					}
					break;
				case "InfoNotInLicense":
					if (_isConvertBackWhenInfoNotInLicenseSet)
					{
						return ConvertBackWhenInfoNotInLicense;
					}
					break;
				case "InvalidLicenseSignature":
					if (_isConvertBackWhenInvalidLicenseSignatureSet)
					{
						return ConvertBackWhenInvalidLicenseSignature;
					}
					break;
				case "EncryptionNotPermitted":
					if (_isConvertBackWhenEncryptionNotPermittedSet)
					{
						return ConvertBackWhenEncryptionNotPermitted;
					}
					break;
				case "RightNotGranted":
					if (_isConvertBackWhenRightNotGrantedSet)
					{
						return ConvertBackWhenRightNotGranted;
					}
					break;
				case "InvalidVersion":
					if (_isConvertBackWhenInvalidVersionSet)
					{
						return ConvertBackWhenInvalidVersion;
					}
					break;
				case "InvalidEncodingType":
					if (_isConvertBackWhenInvalidEncodingTypeSet)
					{
						return ConvertBackWhenInvalidEncodingType;
					}
					break;
				case "InvalidNumericalValue":
					if (_isConvertBackWhenInvalidNumericalValueSet)
					{
						return ConvertBackWhenInvalidNumericalValue;
					}
					break;
				case "InvalidAlgorithmType":
					if (_isConvertBackWhenInvalidAlgorithmTypeSet)
					{
						return ConvertBackWhenInvalidAlgorithmType;
					}
					break;
				case "EnvironmentNotLoaded":
					if (_isConvertBackWhenEnvironmentNotLoadedSet)
					{
						return ConvertBackWhenEnvironmentNotLoaded;
					}
					break;
				case "EnvironmentCannotLoad":
					if (_isConvertBackWhenEnvironmentCannotLoadSet)
					{
						return ConvertBackWhenEnvironmentCannotLoad;
					}
					break;
				case "TooManyLoadedEnvironments":
					if (_isConvertBackWhenTooManyLoadedEnvironmentsSet)
					{
						return ConvertBackWhenTooManyLoadedEnvironments;
					}
					break;
				case "IncompatibleObjects":
					if (_isConvertBackWhenIncompatibleObjectsSet)
					{
						return ConvertBackWhenIncompatibleObjects;
					}
					break;
				case "LibraryFail":
					if (_isConvertBackWhenLibraryFailSet)
					{
						return ConvertBackWhenLibraryFail;
					}
					break;
				case "EnablingPrincipalFailure":
					if (_isConvertBackWhenEnablingPrincipalFailureSet)
					{
						return ConvertBackWhenEnablingPrincipalFailure;
					}
					break;
				case "InfoNotPresent":
					if (_isConvertBackWhenInfoNotPresentSet)
					{
						return ConvertBackWhenInfoNotPresent;
					}
					break;
				case "BadGetInfoQuery":
					if (_isConvertBackWhenBadGetInfoQuerySet)
					{
						return ConvertBackWhenBadGetInfoQuery;
					}
					break;
				case "KeyTypeUnsupported":
					if (_isConvertBackWhenKeyTypeUnsupportedSet)
					{
						return ConvertBackWhenKeyTypeUnsupported;
					}
					break;
				case "CryptoOperationUnsupported":
					if (_isConvertBackWhenCryptoOperationUnsupportedSet)
					{
						return ConvertBackWhenCryptoOperationUnsupported;
					}
					break;
				case "ClockRollbackDetected":
					if (_isConvertBackWhenClockRollbackDetectedSet)
					{
						return ConvertBackWhenClockRollbackDetected;
					}
					break;
				case "QueryReportsNoResults":
					if (_isConvertBackWhenQueryReportsNoResultsSet)
					{
						return ConvertBackWhenQueryReportsNoResults;
					}
					break;
				case "UnexpectedException":
					if (_isConvertBackWhenUnexpectedExceptionSet)
					{
						return ConvertBackWhenUnexpectedException;
					}
					break;
				case "BindValidityTimeViolated":
					if (_isConvertBackWhenBindValidityTimeViolatedSet)
					{
						return ConvertBackWhenBindValidityTimeViolated;
					}
					break;
				case "BrokenCertChain":
					if (_isConvertBackWhenBrokenCertChainSet)
					{
						return ConvertBackWhenBrokenCertChain;
					}
					break;
				case "BindPolicyViolation":
					if (_isConvertBackWhenBindPolicyViolationSet)
					{
						return ConvertBackWhenBindPolicyViolation;
					}
					break;
				case "BindRevokedLicense":
					if (_isConvertBackWhenBindRevokedLicenseSet)
					{
						return ConvertBackWhenBindRevokedLicense;
					}
					break;
				case "BindRevokedIssuer":
					if (_isConvertBackWhenBindRevokedIssuerSet)
					{
						return ConvertBackWhenBindRevokedIssuer;
					}
					break;
				case "BindRevokedPrincipal":
					if (_isConvertBackWhenBindRevokedPrincipalSet)
					{
						return ConvertBackWhenBindRevokedPrincipal;
					}
					break;
				case "BindRevokedResource":
					if (_isConvertBackWhenBindRevokedResourceSet)
					{
						return ConvertBackWhenBindRevokedResource;
					}
					break;
				case "BindRevokedModule":
					if (_isConvertBackWhenBindRevokedModuleSet)
					{
						return ConvertBackWhenBindRevokedModule;
					}
					break;
				case "BindContentNotInEndUseLicense":
					if (_isConvertBackWhenBindContentNotInEndUseLicenseSet)
					{
						return ConvertBackWhenBindContentNotInEndUseLicense;
					}
					break;
				case "BindAccessPrincipalNotEnabling":
					if (_isConvertBackWhenBindAccessPrincipalNotEnablingSet)
					{
						return ConvertBackWhenBindAccessPrincipalNotEnabling;
					}
					break;
				case "BindAccessUnsatisfied":
					if (_isConvertBackWhenBindAccessUnsatisfiedSet)
					{
						return ConvertBackWhenBindAccessUnsatisfied;
					}
					break;
				case "BindIndicatedPrincipalMissing":
					if (_isConvertBackWhenBindIndicatedPrincipalMissingSet)
					{
						return ConvertBackWhenBindIndicatedPrincipalMissing;
					}
					break;
				case "BindMachineNotFoundInGroupIdentity":
					if (_isConvertBackWhenBindMachineNotFoundInGroupIdentitySet)
					{
						return ConvertBackWhenBindMachineNotFoundInGroupIdentity;
					}
					break;
				case "LibraryUnsupportedPlugIn":
					if (_isConvertBackWhenLibraryUnsupportedPlugInSet)
					{
						return ConvertBackWhenLibraryUnsupportedPlugIn;
					}
					break;
				case "BindRevocationListStale":
					if (_isConvertBackWhenBindRevocationListStaleSet)
					{
						return ConvertBackWhenBindRevocationListStale;
					}
					break;
				case "BindNoApplicableRevocationList":
					if (_isConvertBackWhenBindNoApplicableRevocationListSet)
					{
						return ConvertBackWhenBindNoApplicableRevocationList;
					}
					break;
				case "InvalidHandle":
					if (_isConvertBackWhenInvalidHandleSet)
					{
						return ConvertBackWhenInvalidHandle;
					}
					break;
				case "BindIntervalTimeViolated":
					if (_isConvertBackWhenBindIntervalTimeViolatedSet)
					{
						return ConvertBackWhenBindIntervalTimeViolated;
					}
					break;
				case "BindNoSatisfiedRightsGroup":
					if (_isConvertBackWhenBindNoSatisfiedRightsGroupSet)
					{
						return ConvertBackWhenBindNoSatisfiedRightsGroup;
					}
					break;
				case "BindSpecifiedWorkMissing":
					if (_isConvertBackWhenBindSpecifiedWorkMissingSet)
					{
						return ConvertBackWhenBindSpecifiedWorkMissing;
					}
					break;
				case "NoMoreData":
					if (_isConvertBackWhenNoMoreDataSet)
					{
						return ConvertBackWhenNoMoreData;
					}
					break;
				case "LicenseAcquisitionFailed":
					if (_isConvertBackWhenLicenseAcquisitionFailedSet)
					{
						return ConvertBackWhenLicenseAcquisitionFailed;
					}
					break;
				case "IdMismatch":
					if (_isConvertBackWhenIdMismatchSet)
					{
						return ConvertBackWhenIdMismatch;
					}
					break;
				case "TooManyCertificates":
					if (_isConvertBackWhenTooManyCertificatesSet)
					{
						return ConvertBackWhenTooManyCertificates;
					}
					break;
				case "NoDistributionPointUrlFound":
					if (_isConvertBackWhenNoDistributionPointUrlFoundSet)
					{
						return ConvertBackWhenNoDistributionPointUrlFound;
					}
					break;
				case "AlreadyInProgress":
					if (_isConvertBackWhenAlreadyInProgressSet)
					{
						return ConvertBackWhenAlreadyInProgress;
					}
					break;
				case "GroupIdentityNotSet":
					if (_isConvertBackWhenGroupIdentityNotSetSet)
					{
						return ConvertBackWhenGroupIdentityNotSet;
					}
					break;
				case "RecordNotFound":
					if (_isConvertBackWhenRecordNotFoundSet)
					{
						return ConvertBackWhenRecordNotFound;
					}
					break;
				case "NoConnect":
					if (_isConvertBackWhenNoConnectSet)
					{
						return ConvertBackWhenNoConnect;
					}
					break;
				case "NoLicense":
					if (_isConvertBackWhenNoLicenseSet)
					{
						return ConvertBackWhenNoLicense;
					}
					break;
				case "NeedsMachineActivation":
					if (_isConvertBackWhenNeedsMachineActivationSet)
					{
						return ConvertBackWhenNeedsMachineActivation;
					}
					break;
				case "NeedsGroupIdentityActivation":
					if (_isConvertBackWhenNeedsGroupIdentityActivationSet)
					{
						return ConvertBackWhenNeedsGroupIdentityActivation;
					}
					break;
				case "ActivationFailed":
					if (_isConvertBackWhenActivationFailedSet)
					{
						return ConvertBackWhenActivationFailed;
					}
					break;
				case "Aborted":
					if (_isConvertBackWhenAbortedSet)
					{
						return ConvertBackWhenAborted;
					}
					break;
				case "OutOfQuota":
					if (_isConvertBackWhenOutOfQuotaSet)
					{
						return ConvertBackWhenOutOfQuota;
					}
					break;
				case "AuthenticationFailed":
					if (_isConvertBackWhenAuthenticationFailedSet)
					{
						return ConvertBackWhenAuthenticationFailed;
					}
					break;
				case "ServerError":
					if (_isConvertBackWhenServerErrorSet)
					{
						return ConvertBackWhenServerError;
					}
					break;
				case "InstallationFailed":
					if (_isConvertBackWhenInstallationFailedSet)
					{
						return ConvertBackWhenInstallationFailed;
					}
					break;
				case "HidCorrupted":
					if (_isConvertBackWhenHidCorruptedSet)
					{
						return ConvertBackWhenHidCorrupted;
					}
					break;
				case "InvalidServerResponse":
					if (_isConvertBackWhenInvalidServerResponseSet)
					{
						return ConvertBackWhenInvalidServerResponse;
					}
					break;
				case "ServiceNotFound":
					if (_isConvertBackWhenServiceNotFoundSet)
					{
						return ConvertBackWhenServiceNotFound;
					}
					break;
				case "UseDefault":
					if (_isConvertBackWhenUseDefaultSet)
					{
						return ConvertBackWhenUseDefault;
					}
					break;
				case "ServerNotFound":
					if (_isConvertBackWhenServerNotFoundSet)
					{
						return ConvertBackWhenServerNotFound;
					}
					break;
				case "InvalidEmail":
					if (_isConvertBackWhenInvalidEmailSet)
					{
						return ConvertBackWhenInvalidEmail;
					}
					break;
				case "ValidityTimeViolation":
					if (_isConvertBackWhenValidityTimeViolationSet)
					{
						return ConvertBackWhenValidityTimeViolation;
					}
					break;
				case "OutdatedModule":
					if (_isConvertBackWhenOutdatedModuleSet)
					{
						return ConvertBackWhenOutdatedModule;
					}
					break;
				case "NotSet":
					if (_isConvertBackWhenNotSetSet)
					{
						return ConvertBackWhenNotSet;
					}
					break;
				case "MetadataNotSet":
					if (_isConvertBackWhenMetadataNotSetSet)
					{
						return ConvertBackWhenMetadataNotSet;
					}
					break;
				case "RevocationInfoNotSet":
					if (_isConvertBackWhenRevocationInfoNotSetSet)
					{
						return ConvertBackWhenRevocationInfoNotSet;
					}
					break;
				case "InvalidTimeInfo":
					if (_isConvertBackWhenInvalidTimeInfoSet)
					{
						return ConvertBackWhenInvalidTimeInfo;
					}
					break;
				case "RightNotSet":
					if (_isConvertBackWhenRightNotSetSet)
					{
						return ConvertBackWhenRightNotSet;
					}
					break;
				case "LicenseBindingToWindowsIdentityFailed":
					if (_isConvertBackWhenLicenseBindingToWindowsIdentityFailedSet)
					{
						return ConvertBackWhenLicenseBindingToWindowsIdentityFailed;
					}
					break;
				case "InvalidIssuanceLicenseTemplate":
					if (_isConvertBackWhenInvalidIssuanceLicenseTemplateSet)
					{
						return ConvertBackWhenInvalidIssuanceLicenseTemplate;
					}
					break;
				case "InvalidKeyLength":
					if (_isConvertBackWhenInvalidKeyLengthSet)
					{
						return ConvertBackWhenInvalidKeyLength;
					}
					break;
				case "ExpiredOfficialIssuanceLicenseTemplate":
					if (_isConvertBackWhenExpiredOfficialIssuanceLicenseTemplateSet)
					{
						return ConvertBackWhenExpiredOfficialIssuanceLicenseTemplate;
					}
					break;
				case "InvalidClientLicensorCertificate":
					if (_isConvertBackWhenInvalidClientLicensorCertificateSet)
					{
						return ConvertBackWhenInvalidClientLicensorCertificate;
					}
					break;
				case "HidInvalid":
					if (_isConvertBackWhenHidInvalidSet)
					{
						return ConvertBackWhenHidInvalid;
					}
					break;
				case "EmailNotVerified":
					if (_isConvertBackWhenEmailNotVerifiedSet)
					{
						return ConvertBackWhenEmailNotVerified;
					}
					break;
				case "ServiceMoved":
					if (_isConvertBackWhenServiceMovedSet)
					{
						return ConvertBackWhenServiceMoved;
					}
					break;
				case "ServiceGone":
					if (_isConvertBackWhenServiceGoneSet)
					{
						return ConvertBackWhenServiceGone;
					}
					break;
				case "AdEntryNotFound":
					if (_isConvertBackWhenAdEntryNotFoundSet)
					{
						return ConvertBackWhenAdEntryNotFound;
					}
					break;
				case "NotAChain":
					if (_isConvertBackWhenNotAChainSet)
					{
						return ConvertBackWhenNotAChain;
					}
					break;
				case "RequestDenied":
					if (_isConvertBackWhenRequestDeniedSet)
					{
						return ConvertBackWhenRequestDenied;
					}
					break;
				case "DebuggerDetected":
					if (_isConvertBackWhenDebuggerDetectedSet)
					{
						return ConvertBackWhenDebuggerDetected;
					}
					break;
				case "InvalidLockboxType":
					if (_isConvertBackWhenInvalidLockboxTypeSet)
					{
						return ConvertBackWhenInvalidLockboxType;
					}
					break;
				case "InvalidLockboxPath":
					if (_isConvertBackWhenInvalidLockboxPathSet)
					{
						return ConvertBackWhenInvalidLockboxPath;
					}
					break;
				case "InvalidRegistryPath":
					if (_isConvertBackWhenInvalidRegistryPathSet)
					{
						return ConvertBackWhenInvalidRegistryPath;
					}
					break;
				case "NoAesCryptoProvider":
					if (_isConvertBackWhenNoAesCryptoProviderSet)
					{
						return ConvertBackWhenNoAesCryptoProvider;
					}
					break;
				case "GlobalOptionAlreadySet":
					if (_isConvertBackWhenGlobalOptionAlreadySetSet)
					{
						return ConvertBackWhenGlobalOptionAlreadySet;
					}
					break;
				case "OwnerLicenseNotFound":
					if (_isConvertBackWhenOwnerLicenseNotFoundSet)
					{
						return ConvertBackWhenOwnerLicenseNotFound;
					}
					break;
				default:
					throw new ArgumentException();
			}

            if (_isConvertBackDefaultBooleanValueSet)
            {
                return ConvertBackDefaultBooleanValue;
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertBackDefaultBooleanValueSet;
        private bool _convertBackDefaultBooleanValue;
		/// <summary>
        /// RightsManagementFailureCodeの値をbool値に変換する際のデフォルト値を指定、または取得します。
        /// </summary>
        public bool ConvertBackDefaultBooleanValue
        {
            get
            {
                return _convertBackDefaultBooleanValue;
            }
            set
            {
                _convertBackDefaultBooleanValue = value;
				_isConvertBackDefaultBooleanValueSet = true;
            }
        }

        private bool _isConvertBackWhenSuccessSet;
        private bool _convertBackWhenSuccess;
		/// <summary>
        /// RightsManagementFailureCodeの値がSuccessの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSuccess
        {
            get
            {
                return _convertBackWhenSuccess;
            }
            set
            {
                _convertBackWhenSuccess = value;
                _isConvertBackWhenSuccessSet = true;
            }
        }
        private bool _isConvertBackWhenManifestPolicyViolationSet;
        private bool _convertBackWhenManifestPolicyViolation;
		/// <summary>
        /// RightsManagementFailureCodeの値がManifestPolicyViolationの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenManifestPolicyViolation
        {
            get
            {
                return _convertBackWhenManifestPolicyViolation;
            }
            set
            {
                _convertBackWhenManifestPolicyViolation = value;
                _isConvertBackWhenManifestPolicyViolationSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidLicenseSet;
        private bool _convertBackWhenInvalidLicense;
		/// <summary>
        /// RightsManagementFailureCodeの値がInvalidLicenseの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidLicense
        {
            get
            {
                return _convertBackWhenInvalidLicense;
            }
            set
            {
                _convertBackWhenInvalidLicense = value;
                _isConvertBackWhenInvalidLicenseSet = true;
            }
        }
        private bool _isConvertBackWhenInfoNotInLicenseSet;
        private bool _convertBackWhenInfoNotInLicense;
		/// <summary>
        /// RightsManagementFailureCodeの値がInfoNotInLicenseの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInfoNotInLicense
        {
            get
            {
                return _convertBackWhenInfoNotInLicense;
            }
            set
            {
                _convertBackWhenInfoNotInLicense = value;
                _isConvertBackWhenInfoNotInLicenseSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidLicenseSignatureSet;
        private bool _convertBackWhenInvalidLicenseSignature;
		/// <summary>
        /// RightsManagementFailureCodeの値がInvalidLicenseSignatureの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidLicenseSignature
        {
            get
            {
                return _convertBackWhenInvalidLicenseSignature;
            }
            set
            {
                _convertBackWhenInvalidLicenseSignature = value;
                _isConvertBackWhenInvalidLicenseSignatureSet = true;
            }
        }
        private bool _isConvertBackWhenEncryptionNotPermittedSet;
        private bool _convertBackWhenEncryptionNotPermitted;
		/// <summary>
        /// RightsManagementFailureCodeの値がEncryptionNotPermittedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEncryptionNotPermitted
        {
            get
            {
                return _convertBackWhenEncryptionNotPermitted;
            }
            set
            {
                _convertBackWhenEncryptionNotPermitted = value;
                _isConvertBackWhenEncryptionNotPermittedSet = true;
            }
        }
        private bool _isConvertBackWhenRightNotGrantedSet;
        private bool _convertBackWhenRightNotGranted;
		/// <summary>
        /// RightsManagementFailureCodeの値がRightNotGrantedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRightNotGranted
        {
            get
            {
                return _convertBackWhenRightNotGranted;
            }
            set
            {
                _convertBackWhenRightNotGranted = value;
                _isConvertBackWhenRightNotGrantedSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidVersionSet;
        private bool _convertBackWhenInvalidVersion;
		/// <summary>
        /// RightsManagementFailureCodeの値がInvalidVersionの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidVersion
        {
            get
            {
                return _convertBackWhenInvalidVersion;
            }
            set
            {
                _convertBackWhenInvalidVersion = value;
                _isConvertBackWhenInvalidVersionSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidEncodingTypeSet;
        private bool _convertBackWhenInvalidEncodingType;
		/// <summary>
        /// RightsManagementFailureCodeの値がInvalidEncodingTypeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidEncodingType
        {
            get
            {
                return _convertBackWhenInvalidEncodingType;
            }
            set
            {
                _convertBackWhenInvalidEncodingType = value;
                _isConvertBackWhenInvalidEncodingTypeSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidNumericalValueSet;
        private bool _convertBackWhenInvalidNumericalValue;
		/// <summary>
        /// RightsManagementFailureCodeの値がInvalidNumericalValueの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidNumericalValue
        {
            get
            {
                return _convertBackWhenInvalidNumericalValue;
            }
            set
            {
                _convertBackWhenInvalidNumericalValue = value;
                _isConvertBackWhenInvalidNumericalValueSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidAlgorithmTypeSet;
        private bool _convertBackWhenInvalidAlgorithmType;
		/// <summary>
        /// RightsManagementFailureCodeの値がInvalidAlgorithmTypeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidAlgorithmType
        {
            get
            {
                return _convertBackWhenInvalidAlgorithmType;
            }
            set
            {
                _convertBackWhenInvalidAlgorithmType = value;
                _isConvertBackWhenInvalidAlgorithmTypeSet = true;
            }
        }
        private bool _isConvertBackWhenEnvironmentNotLoadedSet;
        private bool _convertBackWhenEnvironmentNotLoaded;
		/// <summary>
        /// RightsManagementFailureCodeの値がEnvironmentNotLoadedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEnvironmentNotLoaded
        {
            get
            {
                return _convertBackWhenEnvironmentNotLoaded;
            }
            set
            {
                _convertBackWhenEnvironmentNotLoaded = value;
                _isConvertBackWhenEnvironmentNotLoadedSet = true;
            }
        }
        private bool _isConvertBackWhenEnvironmentCannotLoadSet;
        private bool _convertBackWhenEnvironmentCannotLoad;
		/// <summary>
        /// RightsManagementFailureCodeの値がEnvironmentCannotLoadの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEnvironmentCannotLoad
        {
            get
            {
                return _convertBackWhenEnvironmentCannotLoad;
            }
            set
            {
                _convertBackWhenEnvironmentCannotLoad = value;
                _isConvertBackWhenEnvironmentCannotLoadSet = true;
            }
        }
        private bool _isConvertBackWhenTooManyLoadedEnvironmentsSet;
        private bool _convertBackWhenTooManyLoadedEnvironments;
		/// <summary>
        /// RightsManagementFailureCodeの値がTooManyLoadedEnvironmentsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTooManyLoadedEnvironments
        {
            get
            {
                return _convertBackWhenTooManyLoadedEnvironments;
            }
            set
            {
                _convertBackWhenTooManyLoadedEnvironments = value;
                _isConvertBackWhenTooManyLoadedEnvironmentsSet = true;
            }
        }
        private bool _isConvertBackWhenIncompatibleObjectsSet;
        private bool _convertBackWhenIncompatibleObjects;
		/// <summary>
        /// RightsManagementFailureCodeの値がIncompatibleObjectsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenIncompatibleObjects
        {
            get
            {
                return _convertBackWhenIncompatibleObjects;
            }
            set
            {
                _convertBackWhenIncompatibleObjects = value;
                _isConvertBackWhenIncompatibleObjectsSet = true;
            }
        }
        private bool _isConvertBackWhenLibraryFailSet;
        private bool _convertBackWhenLibraryFail;
		/// <summary>
        /// RightsManagementFailureCodeの値がLibraryFailの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLibraryFail
        {
            get
            {
                return _convertBackWhenLibraryFail;
            }
            set
            {
                _convertBackWhenLibraryFail = value;
                _isConvertBackWhenLibraryFailSet = true;
            }
        }
        private bool _isConvertBackWhenEnablingPrincipalFailureSet;
        private bool _convertBackWhenEnablingPrincipalFailure;
		/// <summary>
        /// RightsManagementFailureCodeの値がEnablingPrincipalFailureの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEnablingPrincipalFailure
        {
            get
            {
                return _convertBackWhenEnablingPrincipalFailure;
            }
            set
            {
                _convertBackWhenEnablingPrincipalFailure = value;
                _isConvertBackWhenEnablingPrincipalFailureSet = true;
            }
        }
        private bool _isConvertBackWhenInfoNotPresentSet;
        private bool _convertBackWhenInfoNotPresent;
		/// <summary>
        /// RightsManagementFailureCodeの値がInfoNotPresentの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInfoNotPresent
        {
            get
            {
                return _convertBackWhenInfoNotPresent;
            }
            set
            {
                _convertBackWhenInfoNotPresent = value;
                _isConvertBackWhenInfoNotPresentSet = true;
            }
        }
        private bool _isConvertBackWhenBadGetInfoQuerySet;
        private bool _convertBackWhenBadGetInfoQuery;
		/// <summary>
        /// RightsManagementFailureCodeの値がBadGetInfoQueryの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBadGetInfoQuery
        {
            get
            {
                return _convertBackWhenBadGetInfoQuery;
            }
            set
            {
                _convertBackWhenBadGetInfoQuery = value;
                _isConvertBackWhenBadGetInfoQuerySet = true;
            }
        }
        private bool _isConvertBackWhenKeyTypeUnsupportedSet;
        private bool _convertBackWhenKeyTypeUnsupported;
		/// <summary>
        /// RightsManagementFailureCodeの値がKeyTypeUnsupportedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenKeyTypeUnsupported
        {
            get
            {
                return _convertBackWhenKeyTypeUnsupported;
            }
            set
            {
                _convertBackWhenKeyTypeUnsupported = value;
                _isConvertBackWhenKeyTypeUnsupportedSet = true;
            }
        }
        private bool _isConvertBackWhenCryptoOperationUnsupportedSet;
        private bool _convertBackWhenCryptoOperationUnsupported;
		/// <summary>
        /// RightsManagementFailureCodeの値がCryptoOperationUnsupportedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCryptoOperationUnsupported
        {
            get
            {
                return _convertBackWhenCryptoOperationUnsupported;
            }
            set
            {
                _convertBackWhenCryptoOperationUnsupported = value;
                _isConvertBackWhenCryptoOperationUnsupportedSet = true;
            }
        }
        private bool _isConvertBackWhenClockRollbackDetectedSet;
        private bool _convertBackWhenClockRollbackDetected;
		/// <summary>
        /// RightsManagementFailureCodeの値がClockRollbackDetectedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenClockRollbackDetected
        {
            get
            {
                return _convertBackWhenClockRollbackDetected;
            }
            set
            {
                _convertBackWhenClockRollbackDetected = value;
                _isConvertBackWhenClockRollbackDetectedSet = true;
            }
        }
        private bool _isConvertBackWhenQueryReportsNoResultsSet;
        private bool _convertBackWhenQueryReportsNoResults;
		/// <summary>
        /// RightsManagementFailureCodeの値がQueryReportsNoResultsの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenQueryReportsNoResults
        {
            get
            {
                return _convertBackWhenQueryReportsNoResults;
            }
            set
            {
                _convertBackWhenQueryReportsNoResults = value;
                _isConvertBackWhenQueryReportsNoResultsSet = true;
            }
        }
        private bool _isConvertBackWhenUnexpectedExceptionSet;
        private bool _convertBackWhenUnexpectedException;
		/// <summary>
        /// RightsManagementFailureCodeの値がUnexpectedExceptionの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUnexpectedException
        {
            get
            {
                return _convertBackWhenUnexpectedException;
            }
            set
            {
                _convertBackWhenUnexpectedException = value;
                _isConvertBackWhenUnexpectedExceptionSet = true;
            }
        }
        private bool _isConvertBackWhenBindValidityTimeViolatedSet;
        private bool _convertBackWhenBindValidityTimeViolated;
		/// <summary>
        /// RightsManagementFailureCodeの値がBindValidityTimeViolatedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBindValidityTimeViolated
        {
            get
            {
                return _convertBackWhenBindValidityTimeViolated;
            }
            set
            {
                _convertBackWhenBindValidityTimeViolated = value;
                _isConvertBackWhenBindValidityTimeViolatedSet = true;
            }
        }
        private bool _isConvertBackWhenBrokenCertChainSet;
        private bool _convertBackWhenBrokenCertChain;
		/// <summary>
        /// RightsManagementFailureCodeの値がBrokenCertChainの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBrokenCertChain
        {
            get
            {
                return _convertBackWhenBrokenCertChain;
            }
            set
            {
                _convertBackWhenBrokenCertChain = value;
                _isConvertBackWhenBrokenCertChainSet = true;
            }
        }
        private bool _isConvertBackWhenBindPolicyViolationSet;
        private bool _convertBackWhenBindPolicyViolation;
		/// <summary>
        /// RightsManagementFailureCodeの値がBindPolicyViolationの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBindPolicyViolation
        {
            get
            {
                return _convertBackWhenBindPolicyViolation;
            }
            set
            {
                _convertBackWhenBindPolicyViolation = value;
                _isConvertBackWhenBindPolicyViolationSet = true;
            }
        }
        private bool _isConvertBackWhenBindRevokedLicenseSet;
        private bool _convertBackWhenBindRevokedLicense;
		/// <summary>
        /// RightsManagementFailureCodeの値がBindRevokedLicenseの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBindRevokedLicense
        {
            get
            {
                return _convertBackWhenBindRevokedLicense;
            }
            set
            {
                _convertBackWhenBindRevokedLicense = value;
                _isConvertBackWhenBindRevokedLicenseSet = true;
            }
        }
        private bool _isConvertBackWhenBindRevokedIssuerSet;
        private bool _convertBackWhenBindRevokedIssuer;
		/// <summary>
        /// RightsManagementFailureCodeの値がBindRevokedIssuerの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBindRevokedIssuer
        {
            get
            {
                return _convertBackWhenBindRevokedIssuer;
            }
            set
            {
                _convertBackWhenBindRevokedIssuer = value;
                _isConvertBackWhenBindRevokedIssuerSet = true;
            }
        }
        private bool _isConvertBackWhenBindRevokedPrincipalSet;
        private bool _convertBackWhenBindRevokedPrincipal;
		/// <summary>
        /// RightsManagementFailureCodeの値がBindRevokedPrincipalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBindRevokedPrincipal
        {
            get
            {
                return _convertBackWhenBindRevokedPrincipal;
            }
            set
            {
                _convertBackWhenBindRevokedPrincipal = value;
                _isConvertBackWhenBindRevokedPrincipalSet = true;
            }
        }
        private bool _isConvertBackWhenBindRevokedResourceSet;
        private bool _convertBackWhenBindRevokedResource;
		/// <summary>
        /// RightsManagementFailureCodeの値がBindRevokedResourceの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBindRevokedResource
        {
            get
            {
                return _convertBackWhenBindRevokedResource;
            }
            set
            {
                _convertBackWhenBindRevokedResource = value;
                _isConvertBackWhenBindRevokedResourceSet = true;
            }
        }
        private bool _isConvertBackWhenBindRevokedModuleSet;
        private bool _convertBackWhenBindRevokedModule;
		/// <summary>
        /// RightsManagementFailureCodeの値がBindRevokedModuleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBindRevokedModule
        {
            get
            {
                return _convertBackWhenBindRevokedModule;
            }
            set
            {
                _convertBackWhenBindRevokedModule = value;
                _isConvertBackWhenBindRevokedModuleSet = true;
            }
        }
        private bool _isConvertBackWhenBindContentNotInEndUseLicenseSet;
        private bool _convertBackWhenBindContentNotInEndUseLicense;
		/// <summary>
        /// RightsManagementFailureCodeの値がBindContentNotInEndUseLicenseの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBindContentNotInEndUseLicense
        {
            get
            {
                return _convertBackWhenBindContentNotInEndUseLicense;
            }
            set
            {
                _convertBackWhenBindContentNotInEndUseLicense = value;
                _isConvertBackWhenBindContentNotInEndUseLicenseSet = true;
            }
        }
        private bool _isConvertBackWhenBindAccessPrincipalNotEnablingSet;
        private bool _convertBackWhenBindAccessPrincipalNotEnabling;
		/// <summary>
        /// RightsManagementFailureCodeの値がBindAccessPrincipalNotEnablingの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBindAccessPrincipalNotEnabling
        {
            get
            {
                return _convertBackWhenBindAccessPrincipalNotEnabling;
            }
            set
            {
                _convertBackWhenBindAccessPrincipalNotEnabling = value;
                _isConvertBackWhenBindAccessPrincipalNotEnablingSet = true;
            }
        }
        private bool _isConvertBackWhenBindAccessUnsatisfiedSet;
        private bool _convertBackWhenBindAccessUnsatisfied;
		/// <summary>
        /// RightsManagementFailureCodeの値がBindAccessUnsatisfiedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBindAccessUnsatisfied
        {
            get
            {
                return _convertBackWhenBindAccessUnsatisfied;
            }
            set
            {
                _convertBackWhenBindAccessUnsatisfied = value;
                _isConvertBackWhenBindAccessUnsatisfiedSet = true;
            }
        }
        private bool _isConvertBackWhenBindIndicatedPrincipalMissingSet;
        private bool _convertBackWhenBindIndicatedPrincipalMissing;
		/// <summary>
        /// RightsManagementFailureCodeの値がBindIndicatedPrincipalMissingの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBindIndicatedPrincipalMissing
        {
            get
            {
                return _convertBackWhenBindIndicatedPrincipalMissing;
            }
            set
            {
                _convertBackWhenBindIndicatedPrincipalMissing = value;
                _isConvertBackWhenBindIndicatedPrincipalMissingSet = true;
            }
        }
        private bool _isConvertBackWhenBindMachineNotFoundInGroupIdentitySet;
        private bool _convertBackWhenBindMachineNotFoundInGroupIdentity;
		/// <summary>
        /// RightsManagementFailureCodeの値がBindMachineNotFoundInGroupIdentityの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBindMachineNotFoundInGroupIdentity
        {
            get
            {
                return _convertBackWhenBindMachineNotFoundInGroupIdentity;
            }
            set
            {
                _convertBackWhenBindMachineNotFoundInGroupIdentity = value;
                _isConvertBackWhenBindMachineNotFoundInGroupIdentitySet = true;
            }
        }
        private bool _isConvertBackWhenLibraryUnsupportedPlugInSet;
        private bool _convertBackWhenLibraryUnsupportedPlugIn;
		/// <summary>
        /// RightsManagementFailureCodeの値がLibraryUnsupportedPlugInの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLibraryUnsupportedPlugIn
        {
            get
            {
                return _convertBackWhenLibraryUnsupportedPlugIn;
            }
            set
            {
                _convertBackWhenLibraryUnsupportedPlugIn = value;
                _isConvertBackWhenLibraryUnsupportedPlugInSet = true;
            }
        }
        private bool _isConvertBackWhenBindRevocationListStaleSet;
        private bool _convertBackWhenBindRevocationListStale;
		/// <summary>
        /// RightsManagementFailureCodeの値がBindRevocationListStaleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBindRevocationListStale
        {
            get
            {
                return _convertBackWhenBindRevocationListStale;
            }
            set
            {
                _convertBackWhenBindRevocationListStale = value;
                _isConvertBackWhenBindRevocationListStaleSet = true;
            }
        }
        private bool _isConvertBackWhenBindNoApplicableRevocationListSet;
        private bool _convertBackWhenBindNoApplicableRevocationList;
		/// <summary>
        /// RightsManagementFailureCodeの値がBindNoApplicableRevocationListの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBindNoApplicableRevocationList
        {
            get
            {
                return _convertBackWhenBindNoApplicableRevocationList;
            }
            set
            {
                _convertBackWhenBindNoApplicableRevocationList = value;
                _isConvertBackWhenBindNoApplicableRevocationListSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidHandleSet;
        private bool _convertBackWhenInvalidHandle;
		/// <summary>
        /// RightsManagementFailureCodeの値がInvalidHandleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidHandle
        {
            get
            {
                return _convertBackWhenInvalidHandle;
            }
            set
            {
                _convertBackWhenInvalidHandle = value;
                _isConvertBackWhenInvalidHandleSet = true;
            }
        }
        private bool _isConvertBackWhenBindIntervalTimeViolatedSet;
        private bool _convertBackWhenBindIntervalTimeViolated;
		/// <summary>
        /// RightsManagementFailureCodeの値がBindIntervalTimeViolatedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBindIntervalTimeViolated
        {
            get
            {
                return _convertBackWhenBindIntervalTimeViolated;
            }
            set
            {
                _convertBackWhenBindIntervalTimeViolated = value;
                _isConvertBackWhenBindIntervalTimeViolatedSet = true;
            }
        }
        private bool _isConvertBackWhenBindNoSatisfiedRightsGroupSet;
        private bool _convertBackWhenBindNoSatisfiedRightsGroup;
		/// <summary>
        /// RightsManagementFailureCodeの値がBindNoSatisfiedRightsGroupの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBindNoSatisfiedRightsGroup
        {
            get
            {
                return _convertBackWhenBindNoSatisfiedRightsGroup;
            }
            set
            {
                _convertBackWhenBindNoSatisfiedRightsGroup = value;
                _isConvertBackWhenBindNoSatisfiedRightsGroupSet = true;
            }
        }
        private bool _isConvertBackWhenBindSpecifiedWorkMissingSet;
        private bool _convertBackWhenBindSpecifiedWorkMissing;
		/// <summary>
        /// RightsManagementFailureCodeの値がBindSpecifiedWorkMissingの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBindSpecifiedWorkMissing
        {
            get
            {
                return _convertBackWhenBindSpecifiedWorkMissing;
            }
            set
            {
                _convertBackWhenBindSpecifiedWorkMissing = value;
                _isConvertBackWhenBindSpecifiedWorkMissingSet = true;
            }
        }
        private bool _isConvertBackWhenNoMoreDataSet;
        private bool _convertBackWhenNoMoreData;
		/// <summary>
        /// RightsManagementFailureCodeの値がNoMoreDataの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNoMoreData
        {
            get
            {
                return _convertBackWhenNoMoreData;
            }
            set
            {
                _convertBackWhenNoMoreData = value;
                _isConvertBackWhenNoMoreDataSet = true;
            }
        }
        private bool _isConvertBackWhenLicenseAcquisitionFailedSet;
        private bool _convertBackWhenLicenseAcquisitionFailed;
		/// <summary>
        /// RightsManagementFailureCodeの値がLicenseAcquisitionFailedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLicenseAcquisitionFailed
        {
            get
            {
                return _convertBackWhenLicenseAcquisitionFailed;
            }
            set
            {
                _convertBackWhenLicenseAcquisitionFailed = value;
                _isConvertBackWhenLicenseAcquisitionFailedSet = true;
            }
        }
        private bool _isConvertBackWhenIdMismatchSet;
        private bool _convertBackWhenIdMismatch;
		/// <summary>
        /// RightsManagementFailureCodeの値がIdMismatchの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenIdMismatch
        {
            get
            {
                return _convertBackWhenIdMismatch;
            }
            set
            {
                _convertBackWhenIdMismatch = value;
                _isConvertBackWhenIdMismatchSet = true;
            }
        }
        private bool _isConvertBackWhenTooManyCertificatesSet;
        private bool _convertBackWhenTooManyCertificates;
		/// <summary>
        /// RightsManagementFailureCodeの値がTooManyCertificatesの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenTooManyCertificates
        {
            get
            {
                return _convertBackWhenTooManyCertificates;
            }
            set
            {
                _convertBackWhenTooManyCertificates = value;
                _isConvertBackWhenTooManyCertificatesSet = true;
            }
        }
        private bool _isConvertBackWhenNoDistributionPointUrlFoundSet;
        private bool _convertBackWhenNoDistributionPointUrlFound;
		/// <summary>
        /// RightsManagementFailureCodeの値がNoDistributionPointUrlFoundの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNoDistributionPointUrlFound
        {
            get
            {
                return _convertBackWhenNoDistributionPointUrlFound;
            }
            set
            {
                _convertBackWhenNoDistributionPointUrlFound = value;
                _isConvertBackWhenNoDistributionPointUrlFoundSet = true;
            }
        }
        private bool _isConvertBackWhenAlreadyInProgressSet;
        private bool _convertBackWhenAlreadyInProgress;
		/// <summary>
        /// RightsManagementFailureCodeの値がAlreadyInProgressの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAlreadyInProgress
        {
            get
            {
                return _convertBackWhenAlreadyInProgress;
            }
            set
            {
                _convertBackWhenAlreadyInProgress = value;
                _isConvertBackWhenAlreadyInProgressSet = true;
            }
        }
        private bool _isConvertBackWhenGroupIdentityNotSetSet;
        private bool _convertBackWhenGroupIdentityNotSet;
		/// <summary>
        /// RightsManagementFailureCodeの値がGroupIdentityNotSetの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenGroupIdentityNotSet
        {
            get
            {
                return _convertBackWhenGroupIdentityNotSet;
            }
            set
            {
                _convertBackWhenGroupIdentityNotSet = value;
                _isConvertBackWhenGroupIdentityNotSetSet = true;
            }
        }
        private bool _isConvertBackWhenRecordNotFoundSet;
        private bool _convertBackWhenRecordNotFound;
		/// <summary>
        /// RightsManagementFailureCodeの値がRecordNotFoundの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRecordNotFound
        {
            get
            {
                return _convertBackWhenRecordNotFound;
            }
            set
            {
                _convertBackWhenRecordNotFound = value;
                _isConvertBackWhenRecordNotFoundSet = true;
            }
        }
        private bool _isConvertBackWhenNoConnectSet;
        private bool _convertBackWhenNoConnect;
		/// <summary>
        /// RightsManagementFailureCodeの値がNoConnectの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNoConnect
        {
            get
            {
                return _convertBackWhenNoConnect;
            }
            set
            {
                _convertBackWhenNoConnect = value;
                _isConvertBackWhenNoConnectSet = true;
            }
        }
        private bool _isConvertBackWhenNoLicenseSet;
        private bool _convertBackWhenNoLicense;
		/// <summary>
        /// RightsManagementFailureCodeの値がNoLicenseの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNoLicense
        {
            get
            {
                return _convertBackWhenNoLicense;
            }
            set
            {
                _convertBackWhenNoLicense = value;
                _isConvertBackWhenNoLicenseSet = true;
            }
        }
        private bool _isConvertBackWhenNeedsMachineActivationSet;
        private bool _convertBackWhenNeedsMachineActivation;
		/// <summary>
        /// RightsManagementFailureCodeの値がNeedsMachineActivationの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNeedsMachineActivation
        {
            get
            {
                return _convertBackWhenNeedsMachineActivation;
            }
            set
            {
                _convertBackWhenNeedsMachineActivation = value;
                _isConvertBackWhenNeedsMachineActivationSet = true;
            }
        }
        private bool _isConvertBackWhenNeedsGroupIdentityActivationSet;
        private bool _convertBackWhenNeedsGroupIdentityActivation;
		/// <summary>
        /// RightsManagementFailureCodeの値がNeedsGroupIdentityActivationの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNeedsGroupIdentityActivation
        {
            get
            {
                return _convertBackWhenNeedsGroupIdentityActivation;
            }
            set
            {
                _convertBackWhenNeedsGroupIdentityActivation = value;
                _isConvertBackWhenNeedsGroupIdentityActivationSet = true;
            }
        }
        private bool _isConvertBackWhenActivationFailedSet;
        private bool _convertBackWhenActivationFailed;
		/// <summary>
        /// RightsManagementFailureCodeの値がActivationFailedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenActivationFailed
        {
            get
            {
                return _convertBackWhenActivationFailed;
            }
            set
            {
                _convertBackWhenActivationFailed = value;
                _isConvertBackWhenActivationFailedSet = true;
            }
        }
        private bool _isConvertBackWhenAbortedSet;
        private bool _convertBackWhenAborted;
		/// <summary>
        /// RightsManagementFailureCodeの値がAbortedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAborted
        {
            get
            {
                return _convertBackWhenAborted;
            }
            set
            {
                _convertBackWhenAborted = value;
                _isConvertBackWhenAbortedSet = true;
            }
        }
        private bool _isConvertBackWhenOutOfQuotaSet;
        private bool _convertBackWhenOutOfQuota;
		/// <summary>
        /// RightsManagementFailureCodeの値がOutOfQuotaの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOutOfQuota
        {
            get
            {
                return _convertBackWhenOutOfQuota;
            }
            set
            {
                _convertBackWhenOutOfQuota = value;
                _isConvertBackWhenOutOfQuotaSet = true;
            }
        }
        private bool _isConvertBackWhenAuthenticationFailedSet;
        private bool _convertBackWhenAuthenticationFailed;
		/// <summary>
        /// RightsManagementFailureCodeの値がAuthenticationFailedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAuthenticationFailed
        {
            get
            {
                return _convertBackWhenAuthenticationFailed;
            }
            set
            {
                _convertBackWhenAuthenticationFailed = value;
                _isConvertBackWhenAuthenticationFailedSet = true;
            }
        }
        private bool _isConvertBackWhenServerErrorSet;
        private bool _convertBackWhenServerError;
		/// <summary>
        /// RightsManagementFailureCodeの値がServerErrorの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenServerError
        {
            get
            {
                return _convertBackWhenServerError;
            }
            set
            {
                _convertBackWhenServerError = value;
                _isConvertBackWhenServerErrorSet = true;
            }
        }
        private bool _isConvertBackWhenInstallationFailedSet;
        private bool _convertBackWhenInstallationFailed;
		/// <summary>
        /// RightsManagementFailureCodeの値がInstallationFailedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInstallationFailed
        {
            get
            {
                return _convertBackWhenInstallationFailed;
            }
            set
            {
                _convertBackWhenInstallationFailed = value;
                _isConvertBackWhenInstallationFailedSet = true;
            }
        }
        private bool _isConvertBackWhenHidCorruptedSet;
        private bool _convertBackWhenHidCorrupted;
		/// <summary>
        /// RightsManagementFailureCodeの値がHidCorruptedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHidCorrupted
        {
            get
            {
                return _convertBackWhenHidCorrupted;
            }
            set
            {
                _convertBackWhenHidCorrupted = value;
                _isConvertBackWhenHidCorruptedSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidServerResponseSet;
        private bool _convertBackWhenInvalidServerResponse;
		/// <summary>
        /// RightsManagementFailureCodeの値がInvalidServerResponseの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidServerResponse
        {
            get
            {
                return _convertBackWhenInvalidServerResponse;
            }
            set
            {
                _convertBackWhenInvalidServerResponse = value;
                _isConvertBackWhenInvalidServerResponseSet = true;
            }
        }
        private bool _isConvertBackWhenServiceNotFoundSet;
        private bool _convertBackWhenServiceNotFound;
		/// <summary>
        /// RightsManagementFailureCodeの値がServiceNotFoundの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenServiceNotFound
        {
            get
            {
                return _convertBackWhenServiceNotFound;
            }
            set
            {
                _convertBackWhenServiceNotFound = value;
                _isConvertBackWhenServiceNotFoundSet = true;
            }
        }
        private bool _isConvertBackWhenUseDefaultSet;
        private bool _convertBackWhenUseDefault;
		/// <summary>
        /// RightsManagementFailureCodeの値がUseDefaultの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUseDefault
        {
            get
            {
                return _convertBackWhenUseDefault;
            }
            set
            {
                _convertBackWhenUseDefault = value;
                _isConvertBackWhenUseDefaultSet = true;
            }
        }
        private bool _isConvertBackWhenServerNotFoundSet;
        private bool _convertBackWhenServerNotFound;
		/// <summary>
        /// RightsManagementFailureCodeの値がServerNotFoundの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenServerNotFound
        {
            get
            {
                return _convertBackWhenServerNotFound;
            }
            set
            {
                _convertBackWhenServerNotFound = value;
                _isConvertBackWhenServerNotFoundSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidEmailSet;
        private bool _convertBackWhenInvalidEmail;
		/// <summary>
        /// RightsManagementFailureCodeの値がInvalidEmailの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidEmail
        {
            get
            {
                return _convertBackWhenInvalidEmail;
            }
            set
            {
                _convertBackWhenInvalidEmail = value;
                _isConvertBackWhenInvalidEmailSet = true;
            }
        }
        private bool _isConvertBackWhenValidityTimeViolationSet;
        private bool _convertBackWhenValidityTimeViolation;
		/// <summary>
        /// RightsManagementFailureCodeの値がValidityTimeViolationの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenValidityTimeViolation
        {
            get
            {
                return _convertBackWhenValidityTimeViolation;
            }
            set
            {
                _convertBackWhenValidityTimeViolation = value;
                _isConvertBackWhenValidityTimeViolationSet = true;
            }
        }
        private bool _isConvertBackWhenOutdatedModuleSet;
        private bool _convertBackWhenOutdatedModule;
		/// <summary>
        /// RightsManagementFailureCodeの値がOutdatedModuleの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOutdatedModule
        {
            get
            {
                return _convertBackWhenOutdatedModule;
            }
            set
            {
                _convertBackWhenOutdatedModule = value;
                _isConvertBackWhenOutdatedModuleSet = true;
            }
        }
        private bool _isConvertBackWhenNotSetSet;
        private bool _convertBackWhenNotSet;
		/// <summary>
        /// RightsManagementFailureCodeの値がNotSetの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNotSet
        {
            get
            {
                return _convertBackWhenNotSet;
            }
            set
            {
                _convertBackWhenNotSet = value;
                _isConvertBackWhenNotSetSet = true;
            }
        }
        private bool _isConvertBackWhenMetadataNotSetSet;
        private bool _convertBackWhenMetadataNotSet;
		/// <summary>
        /// RightsManagementFailureCodeの値がMetadataNotSetの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenMetadataNotSet
        {
            get
            {
                return _convertBackWhenMetadataNotSet;
            }
            set
            {
                _convertBackWhenMetadataNotSet = value;
                _isConvertBackWhenMetadataNotSetSet = true;
            }
        }
        private bool _isConvertBackWhenRevocationInfoNotSetSet;
        private bool _convertBackWhenRevocationInfoNotSet;
		/// <summary>
        /// RightsManagementFailureCodeの値がRevocationInfoNotSetの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRevocationInfoNotSet
        {
            get
            {
                return _convertBackWhenRevocationInfoNotSet;
            }
            set
            {
                _convertBackWhenRevocationInfoNotSet = value;
                _isConvertBackWhenRevocationInfoNotSetSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidTimeInfoSet;
        private bool _convertBackWhenInvalidTimeInfo;
		/// <summary>
        /// RightsManagementFailureCodeの値がInvalidTimeInfoの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidTimeInfo
        {
            get
            {
                return _convertBackWhenInvalidTimeInfo;
            }
            set
            {
                _convertBackWhenInvalidTimeInfo = value;
                _isConvertBackWhenInvalidTimeInfoSet = true;
            }
        }
        private bool _isConvertBackWhenRightNotSetSet;
        private bool _convertBackWhenRightNotSet;
		/// <summary>
        /// RightsManagementFailureCodeの値がRightNotSetの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRightNotSet
        {
            get
            {
                return _convertBackWhenRightNotSet;
            }
            set
            {
                _convertBackWhenRightNotSet = value;
                _isConvertBackWhenRightNotSetSet = true;
            }
        }
        private bool _isConvertBackWhenLicenseBindingToWindowsIdentityFailedSet;
        private bool _convertBackWhenLicenseBindingToWindowsIdentityFailed;
		/// <summary>
        /// RightsManagementFailureCodeの値がLicenseBindingToWindowsIdentityFailedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLicenseBindingToWindowsIdentityFailed
        {
            get
            {
                return _convertBackWhenLicenseBindingToWindowsIdentityFailed;
            }
            set
            {
                _convertBackWhenLicenseBindingToWindowsIdentityFailed = value;
                _isConvertBackWhenLicenseBindingToWindowsIdentityFailedSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidIssuanceLicenseTemplateSet;
        private bool _convertBackWhenInvalidIssuanceLicenseTemplate;
		/// <summary>
        /// RightsManagementFailureCodeの値がInvalidIssuanceLicenseTemplateの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidIssuanceLicenseTemplate
        {
            get
            {
                return _convertBackWhenInvalidIssuanceLicenseTemplate;
            }
            set
            {
                _convertBackWhenInvalidIssuanceLicenseTemplate = value;
                _isConvertBackWhenInvalidIssuanceLicenseTemplateSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidKeyLengthSet;
        private bool _convertBackWhenInvalidKeyLength;
		/// <summary>
        /// RightsManagementFailureCodeの値がInvalidKeyLengthの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidKeyLength
        {
            get
            {
                return _convertBackWhenInvalidKeyLength;
            }
            set
            {
                _convertBackWhenInvalidKeyLength = value;
                _isConvertBackWhenInvalidKeyLengthSet = true;
            }
        }
        private bool _isConvertBackWhenExpiredOfficialIssuanceLicenseTemplateSet;
        private bool _convertBackWhenExpiredOfficialIssuanceLicenseTemplate;
		/// <summary>
        /// RightsManagementFailureCodeの値がExpiredOfficialIssuanceLicenseTemplateの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenExpiredOfficialIssuanceLicenseTemplate
        {
            get
            {
                return _convertBackWhenExpiredOfficialIssuanceLicenseTemplate;
            }
            set
            {
                _convertBackWhenExpiredOfficialIssuanceLicenseTemplate = value;
                _isConvertBackWhenExpiredOfficialIssuanceLicenseTemplateSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidClientLicensorCertificateSet;
        private bool _convertBackWhenInvalidClientLicensorCertificate;
		/// <summary>
        /// RightsManagementFailureCodeの値がInvalidClientLicensorCertificateの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidClientLicensorCertificate
        {
            get
            {
                return _convertBackWhenInvalidClientLicensorCertificate;
            }
            set
            {
                _convertBackWhenInvalidClientLicensorCertificate = value;
                _isConvertBackWhenInvalidClientLicensorCertificateSet = true;
            }
        }
        private bool _isConvertBackWhenHidInvalidSet;
        private bool _convertBackWhenHidInvalid;
		/// <summary>
        /// RightsManagementFailureCodeの値がHidInvalidの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHidInvalid
        {
            get
            {
                return _convertBackWhenHidInvalid;
            }
            set
            {
                _convertBackWhenHidInvalid = value;
                _isConvertBackWhenHidInvalidSet = true;
            }
        }
        private bool _isConvertBackWhenEmailNotVerifiedSet;
        private bool _convertBackWhenEmailNotVerified;
		/// <summary>
        /// RightsManagementFailureCodeの値がEmailNotVerifiedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenEmailNotVerified
        {
            get
            {
                return _convertBackWhenEmailNotVerified;
            }
            set
            {
                _convertBackWhenEmailNotVerified = value;
                _isConvertBackWhenEmailNotVerifiedSet = true;
            }
        }
        private bool _isConvertBackWhenServiceMovedSet;
        private bool _convertBackWhenServiceMoved;
		/// <summary>
        /// RightsManagementFailureCodeの値がServiceMovedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenServiceMoved
        {
            get
            {
                return _convertBackWhenServiceMoved;
            }
            set
            {
                _convertBackWhenServiceMoved = value;
                _isConvertBackWhenServiceMovedSet = true;
            }
        }
        private bool _isConvertBackWhenServiceGoneSet;
        private bool _convertBackWhenServiceGone;
		/// <summary>
        /// RightsManagementFailureCodeの値がServiceGoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenServiceGone
        {
            get
            {
                return _convertBackWhenServiceGone;
            }
            set
            {
                _convertBackWhenServiceGone = value;
                _isConvertBackWhenServiceGoneSet = true;
            }
        }
        private bool _isConvertBackWhenAdEntryNotFoundSet;
        private bool _convertBackWhenAdEntryNotFound;
		/// <summary>
        /// RightsManagementFailureCodeの値がAdEntryNotFoundの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAdEntryNotFound
        {
            get
            {
                return _convertBackWhenAdEntryNotFound;
            }
            set
            {
                _convertBackWhenAdEntryNotFound = value;
                _isConvertBackWhenAdEntryNotFoundSet = true;
            }
        }
        private bool _isConvertBackWhenNotAChainSet;
        private bool _convertBackWhenNotAChain;
		/// <summary>
        /// RightsManagementFailureCodeの値がNotAChainの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNotAChain
        {
            get
            {
                return _convertBackWhenNotAChain;
            }
            set
            {
                _convertBackWhenNotAChain = value;
                _isConvertBackWhenNotAChainSet = true;
            }
        }
        private bool _isConvertBackWhenRequestDeniedSet;
        private bool _convertBackWhenRequestDenied;
		/// <summary>
        /// RightsManagementFailureCodeの値がRequestDeniedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRequestDenied
        {
            get
            {
                return _convertBackWhenRequestDenied;
            }
            set
            {
                _convertBackWhenRequestDenied = value;
                _isConvertBackWhenRequestDeniedSet = true;
            }
        }
        private bool _isConvertBackWhenDebuggerDetectedSet;
        private bool _convertBackWhenDebuggerDetected;
		/// <summary>
        /// RightsManagementFailureCodeの値がDebuggerDetectedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenDebuggerDetected
        {
            get
            {
                return _convertBackWhenDebuggerDetected;
            }
            set
            {
                _convertBackWhenDebuggerDetected = value;
                _isConvertBackWhenDebuggerDetectedSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidLockboxTypeSet;
        private bool _convertBackWhenInvalidLockboxType;
		/// <summary>
        /// RightsManagementFailureCodeの値がInvalidLockboxTypeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidLockboxType
        {
            get
            {
                return _convertBackWhenInvalidLockboxType;
            }
            set
            {
                _convertBackWhenInvalidLockboxType = value;
                _isConvertBackWhenInvalidLockboxTypeSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidLockboxPathSet;
        private bool _convertBackWhenInvalidLockboxPath;
		/// <summary>
        /// RightsManagementFailureCodeの値がInvalidLockboxPathの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidLockboxPath
        {
            get
            {
                return _convertBackWhenInvalidLockboxPath;
            }
            set
            {
                _convertBackWhenInvalidLockboxPath = value;
                _isConvertBackWhenInvalidLockboxPathSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidRegistryPathSet;
        private bool _convertBackWhenInvalidRegistryPath;
		/// <summary>
        /// RightsManagementFailureCodeの値がInvalidRegistryPathの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidRegistryPath
        {
            get
            {
                return _convertBackWhenInvalidRegistryPath;
            }
            set
            {
                _convertBackWhenInvalidRegistryPath = value;
                _isConvertBackWhenInvalidRegistryPathSet = true;
            }
        }
        private bool _isConvertBackWhenNoAesCryptoProviderSet;
        private bool _convertBackWhenNoAesCryptoProvider;
		/// <summary>
        /// RightsManagementFailureCodeの値がNoAesCryptoProviderの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNoAesCryptoProvider
        {
            get
            {
                return _convertBackWhenNoAesCryptoProvider;
            }
            set
            {
                _convertBackWhenNoAesCryptoProvider = value;
                _isConvertBackWhenNoAesCryptoProviderSet = true;
            }
        }
        private bool _isConvertBackWhenGlobalOptionAlreadySetSet;
        private bool _convertBackWhenGlobalOptionAlreadySet;
		/// <summary>
        /// RightsManagementFailureCodeの値がGlobalOptionAlreadySetの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenGlobalOptionAlreadySet
        {
            get
            {
                return _convertBackWhenGlobalOptionAlreadySet;
            }
            set
            {
                _convertBackWhenGlobalOptionAlreadySet = value;
                _isConvertBackWhenGlobalOptionAlreadySetSet = true;
            }
        }
        private bool _isConvertBackWhenOwnerLicenseNotFoundSet;
        private bool _convertBackWhenOwnerLicenseNotFound;
		/// <summary>
        /// RightsManagementFailureCodeの値がOwnerLicenseNotFoundの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenOwnerLicenseNotFound
        {
            get
            {
                return _convertBackWhenOwnerLicenseNotFound;
            }
            set
            {
                _convertBackWhenOwnerLicenseNotFound = value;
                _isConvertBackWhenOwnerLicenseNotFoundSet = true;
            }
        }
    }
}