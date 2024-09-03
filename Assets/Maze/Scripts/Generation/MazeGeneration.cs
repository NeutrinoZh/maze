using UnityEngine;

using Zenject;

namespace Maze
{
    public class MazeGeneration : IInitializable
    {
        private MazeGenerationConfiguration _configuration;

        public MazeGeneration(MazeGenerationConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Initialize()
        {
            Debug.Log(_configuration.test);
        }
    }
}
