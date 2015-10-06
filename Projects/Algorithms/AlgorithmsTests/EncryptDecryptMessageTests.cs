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
            
            Assert.IsTrue(decryptedMessage.StartsWith(message));
        }

        [TestMethod]
        public void EncryptionTest2()
        {
            string message = "Ana";
            ushort columns = 2;
            var encryptedMessage = EncryptDecryptMessage.EncryptMessage(message, columns);
            var decryptedMessage = EncryptDecryptMessage.DecryptMessage(encryptedMessage, columns);

            Assert.IsTrue(decryptedMessage.StartsWith(message));
        }

        [TestMethod]
        public void EncryptionTest3()
        {
            string message = "nicaierinuecaacasa";
            ushort columns = 4;
            var encryptedMessage = EncryptDecryptMessage.EncryptMessage(message, columns);
            var decryptedMessage = EncryptDecryptMessage.DecryptMessage(encryptedMessage, columns);

            Assert.IsTrue(decryptedMessage.StartsWith(message));
        }

        [TestMethod]
        public void EncryptionTest4()
        {
            string message = "nicaieri nu e ca acasa";
            ushort columns = 4;
            var encryptedMessage = EncryptDecryptMessage.EncryptMessage(message, columns);
            var decryptedMessage = EncryptDecryptMessage.DecryptMessage(encryptedMessage, columns);

            Assert.IsTrue(decryptedMessage.StartsWith("nicaierinuecaacasa"));
        }

        [TestMethod]
        public void EncryptionTest5()
        {
            string message = "Nu, inca nu am plecat!";
            ushort columns = 6;
            var encryptedMessage = EncryptDecryptMessage.EncryptMessage(message, columns);
            var decryptedMessage = EncryptDecryptMessage.DecryptMessage(encryptedMessage, columns);

            Assert.IsTrue(decryptedMessage.StartsWith("Nuincanuamplecat"));
        }
    }
}