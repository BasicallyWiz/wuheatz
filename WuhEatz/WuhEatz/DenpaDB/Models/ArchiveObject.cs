﻿using MongoDB.Bson;

namespace WuhEatz.DenpaDB.Models
{
  public class ArchiveObject
  {
    ObjectId _id { get; set; }
    public string ResourceUrl { get; set; } = "";
    public string ResourceType { get; set; } = "";
  }
}
