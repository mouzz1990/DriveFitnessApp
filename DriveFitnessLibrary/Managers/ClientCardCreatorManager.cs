using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DriveFitnessLibrary.DriveInterfaces;
using ZXing.QrCode;
using ZXing;
using ZXing.Common;
using System.Drawing;
using System.IO;

namespace DriveFitnessLibrary.Managers
{
    public class ClientCardCreatorManager : IClientCardCreator
    {
        public void MakeClientCard(Client client)
        {
            string filename = string.Format("{0}.jpeg", client);

            try
            {
                if (File.Exists(filename))
                    File.Delete(filename);

                QRCodeWriter qrEncode = new QRCodeWriter();

                string encString = string.Format("{0}:{1} {2}", client.ID, client.Name, client.LastName);

                Dictionary<EncodeHintType, object> hints = new Dictionary<EncodeHintType, object>();    //для колекции поведений
                hints.Add(EncodeHintType.CHARACTER_SET, "utf-8");

                BitMatrix qrMatrix = qrEncode.encode(
                    encString,
                    BarcodeFormat.QR_CODE,
                    300,
                    300,
                    hints
                    );

                BarcodeWriter qrWriter = new BarcodeWriter();

                Bitmap qrImage = qrWriter.Write(qrMatrix);

                qrImage.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
                qrImage.Dispose();
            }
            catch
            {
                throw new Exception("Невозможно создать карту клиента. Пожалуйста попробуйте позже или перезапустите приложение");
            }
        }
    }
}
