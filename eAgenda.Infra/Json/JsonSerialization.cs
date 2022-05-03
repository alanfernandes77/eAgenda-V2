﻿using eAgenda.Infra.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace eAgenda.Infra.Json
{
    public class JsonSerialization<T> : ISerializator<T> where T : class
    {
        private readonly string _path;
        private readonly JsonSerializerSettings _jsonSettings;

        public JsonSerialization(string path)
        {
            _path = path + ".json";
            _jsonSettings = new();
            _jsonSettings.Formatting = Formatting.Indented;
        }

        public List<T> Load()
        {
            if (File.Exists(_path) == false)
                return new List<T>();

            string json = File.ReadAllText(_path);

            return JsonConvert.DeserializeObject<List<T>>(json, _jsonSettings);
        }

        public void Save(List<T> t)
        {
            string json = JsonConvert.SerializeObject(t, _jsonSettings);

            File.WriteAllText(_path, json);
        }
    }
}