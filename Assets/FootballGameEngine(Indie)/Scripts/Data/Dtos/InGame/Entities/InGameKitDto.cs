using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.FootballGameEngine_Indie_.Scripts.Data.Dtos.InGame.Entities
{
    [Serializable]
    public class InGameKitDto
    {
        [SerializeField]
        Color _color;
        
        
        [SerializeField]
        int _teamNumber;



        [SerializeField]
        Texture _goalKeeperKit;

        [SerializeField]
        Texture _inFieldPlayerKit;

        [SerializeField]
        Texture _bodyTextureKit;

        public Color Color { get => _color; set => _color = value; }
        public Texture GoalKeeperKit { get => _goalKeeperKit; set => _goalKeeperKit = value; }
        public Texture InFieldPlayerKit { get => _inFieldPlayerKit; set => _inFieldPlayerKit = value; }
        public Texture BodyPlayerKit { get => _bodyTextureKit; set => _bodyTextureKit = value; }
        public int TeamNumber { get => _teamNumber; set => _teamNumber = value; }

        public InGameKitDto(Dtos.Entities.KitDto kitDto)
        {
            _teamNumber = kitDto.TeamNumber;
            _color = kitDto.Color;
            _goalKeeperKit = kitDto.GoalKeeperKit;
            _inFieldPlayerKit = kitDto.InFieldPlayerKit;
            _bodyTextureKit = kitDto.BodyPlayerKit;
        }

    }
}
