﻿using System.Xml.Serialization;

namespace ProductShop.DTOs.Export;

[XmlType("User")]
public class UserWithProductsExportDTO
{
    [XmlElement("firstName")]
    public string FirstName { get; set; }

    [XmlElement("lastName")]
    public string LastName { get; set; }

    [XmlElement("age")]
    public int? Age { get; set; }

    [XmlElement("SoldProducts")]
    public SoldProductsDTO SoldProducts { get; set; }
}