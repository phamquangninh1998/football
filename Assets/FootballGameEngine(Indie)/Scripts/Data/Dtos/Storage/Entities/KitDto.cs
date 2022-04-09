﻿using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.FootballGameEngine_Indie_.Scripts.Data.Dtos.Entities
{
    [Serializable]
    public class KitDto
    {
        [SerializeField]
        Color _color;
        
        [SerializeField]
        int _teamNumber;

        [SerializeField]
        string _name;

        [SerializeField]
        Sprite _imgIcon;

        [SerializeField]
        Texture _goalKeeperKit;

        [SerializeField]
        Texture _inFieldPlayerKit;

        [SerializeField]
        Texture _bodyPlayerKit;

        public string Name { get => _name; set => _name = value; }
        public Sprite ImgIcon { get => _imgIcon; set => _imgIcon = value; }
        public Texture GoalKeeperKit { get => _goalKeeperKit; set => _goalKeeperKit = value; }
        public Texture InFieldPlayerKit { get => _inFieldPlayerKit; set => _inFieldPlayerKit = value; }
        public Texture BodyPlayerKit { get => _bodyPlayerKit; set => _bodyPlayerKit = value; }
        public Color Color { get => _color; set => _color = value; }
        public int TeamNumber { get => _teamNumber; set => _teamNumber = value; }
    }
}
