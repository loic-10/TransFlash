// <copyright file="Frm_EditerEmployeTest.cs">Copyright ©  2019</copyright>
using System;
using Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Couche.Winforms.ControlsUtilisateurs.Postes.Fonctionnalites.Forms.Tests
{
    /// <summary>Cette classe contient des tests unitaires paramétrables pour Frm_EditerEmploye</summary>
    [PexClass(typeof(Frm_EditerEmploye))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class Frm_EditerEmployeTest
    {
    }
}
