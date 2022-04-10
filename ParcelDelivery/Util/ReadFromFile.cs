using ParcelDelivery.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace ParcelDelivery.DataLayer.Util
{
    public static class ReadFromFile
    {
        /// <summary>
        /// Read parcel data from xml file
        /// </summary>
        /// <param name="filePath">Path of the file to read</param>
        /// <returns>List of Parcels</returns>
        public static IEnumerable<Parcel>  ReadParcelXml(string filePath)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(filePath))
                {
                    return null;
                }

                List<Parcel> parcels = new List<Parcel>();
                var file = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                if (file != null && file.Length > 0)
                {
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load(file);
                    Parcel parcel;
                    XmlNodeList usernodes = xmldoc.SelectNodes("Container/parcels/Parcel");
                    foreach (XmlNode usr in usernodes)
                    {
                        parcel = new Parcel();

                        XmlNodeList senderNodes = usr.SelectNodes("Sender");
                        XmlNodeList recipientNodes = usr.SelectNodes("Receipient");

                        foreach (XmlNode sender in senderNodes)
                        {
                            parcel.Sender.Name = sender["Name"].InnerText;
                            XmlNodeList addressNodes = usr.SelectNodes("Sender/Address");

                            foreach (XmlNode address in addressNodes)
                            {
                                parcel.Sender.Address.Street = address["Street"].InnerText;
                                parcel.Sender.Address.HouseNo = address["HouseNumber"].InnerText;
                                parcel.Sender.Address.City = address["City"].InnerText;
                                parcel.Sender.Address.PostalCode = address["PostalCode"].InnerText;
                            }
                        }

                        foreach (XmlNode recipient in recipientNodes)
                        {
                            parcel.Recipient.Name = recipient["Name"].InnerText;
                            XmlNodeList recipientAddressNodes = usr.SelectNodes("Receipient/Address");

                            foreach (XmlNode address in recipientAddressNodes)
                            {
                                parcel.Recipient.Address.Street = address["Street"].InnerText;
                                parcel.Recipient.Address.HouseNo = address["HouseNumber"].InnerText;
                                parcel.Recipient.Address.City = address["City"].InnerText;
                                parcel.Recipient.Address.PostalCode = address["PostalCode"].InnerText;
                            }
                        }
                        parcel.Value = Convert.ToDouble(usr["Value"].InnerText);
                        parcel.Weight = Convert.ToDouble(usr["Weight"].InnerText);

                        parcels.Add(parcel);
                    }
                }
                return parcels;
            }
            catch
            {
                throw new Exception("Something go wrong while reading file!");
            }
        }

    }
}
