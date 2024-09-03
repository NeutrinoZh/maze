using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using Maze.GSM;

namespace Maze
{
    public class Game : MonoBehaviour
    {
        private GameStateMachine _stateMachine;

        private void Awake()
        {
            _stateMachine = new GameStateMachine();
        }

        private void Update() {
            _stateMachine.Update();
        }
    }
}