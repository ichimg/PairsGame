﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PairsGame
{
    [Serializable]
    internal class ObjectToSerialize : ISerializable
    {
        public List<List<string>> Cards;
        public int CurrentLevel;

        public ObjectToSerialize() { }

        public ObjectToSerialize(SerializationInfo info, StreamingContext ctxt)
        {
            Cards = (List<List<string>>)info.GetValue("savedCards", typeof(List<List<string>>));
            CurrentLevel = (int)info.GetValue("currentLevel", typeof(int));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("savedCards", Cards);
            info.AddValue("currentLevel", CurrentLevel);
        }
    }
}
