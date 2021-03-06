// <copyright file="PexAssemblyInfo.cs">Copyright ©  2019</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("Couche.Winforms")]
[assembly: PexInstrumentAssembly("System.Drawing")]
[assembly: PexInstrumentAssembly("TransFlash.BLL")]
[assembly: PexInstrumentAssembly("Tulpep.NotificationWindow")]
[assembly: PexInstrumentAssembly("Guna.UI")]
[assembly: PexInstrumentAssembly("System.Windows.Forms")]
[assembly: PexInstrumentAssembly("TransFlash.Winforms.Fonctions")]
[assembly: PexInstrumentAssembly("TransFlash.BO")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Drawing")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "TransFlash.BLL")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Tulpep.NotificationWindow")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Guna.UI")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Windows.Forms")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "TransFlash.Winforms.Fonctions")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "TransFlash.BO")]

