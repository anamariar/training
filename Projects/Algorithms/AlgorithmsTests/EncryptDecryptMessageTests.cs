﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace AlgorithmsTests
{
    [TestClass]
    public class EncryptDecryptMessageTests
    {
        [TestMethod]
        public void EncryptionTest1()
        {
            string message = "Anaaremere";
            ushort columns = 3;
            var encryptedMessage = EncryptDecryptMessage.EncryptMessage(message, columns);
            var decryptedMessage = EncryptDecryptMessage.DecryptMessage(encryptedMessage, columns);

            Assert.AreEqual(message, decryptedMessage);
        }

        [TestMethod]
        public void EncryptionTest2()
        {
            string message = "Ana";
            ushort columns = 2;
            var encryptedMessage = EncryptDecryptMessage.EncryptMessage(message, columns);
            var decryptedMessage = EncryptDecryptMessage.DecryptMessage(encryptedMessage, columns);

            Assert.AreEqual(message, decryptedMessage);
        }

        [TestMethod]
        public void EncryptionTest3()
        {
            string message = "nicaierinuecaacasa";
            ushort columns = 4;
            var encryptedMessage = EncryptDecryptMessage.EncryptMessage(message, columns);
            var decryptedMessage = EncryptDecryptMessage.DecryptMessage(encryptedMessage, columns);

            Assert.AreEqual(message, decryptedMessage);
        }

        [TestMethod]
        public void EncryptionTest4()
        {
            string message = "nicaieri nu e ca acasa";
            ushort columns = 4;
            var encryptedMessage = EncryptDecryptMessage.EncryptMessage(message, columns);
            var decryptedMessage = EncryptDecryptMessage.DecryptMessage(encryptedMessage, columns);

            Assert.AreEqual("nicaierinuecaacasa", decryptedMessage);
        }

        [TestMethod]
        public void EncryptionTest5()
        {
            string message = "Nu, inca nu am plecat!";
            ushort columns = 6;
            var encryptedMessage = EncryptDecryptMessage.EncryptMessage(message, columns);
            var decryptedMessage = EncryptDecryptMessage.DecryptMessage(encryptedMessage, columns);

            Assert.AreEqual("Nuincanuamplecat", decryptedMessage);
        }

        [TestMethod]
        public void EncryptionTest6()
        {
            string message = "E joi";
            ushort columns = 2;
            var encryptedMessage = EncryptDecryptMessage.EncryptMessage(message, columns);
            var decryptedMessage = EncryptDecryptMessage.DecryptMessage(encryptedMessage, columns);

            Assert.AreEqual("Ejoi", decryptedMessage);
        }

        [TestMethod]
        public void EncryptionTest7()
        {
            string message = "Fara criptare";
            ushort columns = 1;
            var encryptedMessage = EncryptDecryptMessage.EncryptMessage(message, columns);
            var decryptedMessage = EncryptDecryptMessage.DecryptMessage(encryptedMessage, columns);

            Assert.AreEqual("Faracriptare", decryptedMessage);
        }
    }
}
