using UnityEngine;

using Zenject;

namespace Maze
{
    public class GamePlayInstaller : MonoInstaller
    {
        [SerializeField] private MazeGenerationConfiguration _mazeGenerationConfiguration;

        public override void InstallBindings()
        {
            Container.Bind<MazeGenerationConfiguration>().FromInstance(_mazeGenerationConfiguration).AsSingle();
            Container.BindInterfacesAndSelfTo<MazeGeneration>().AsSingle().NonLazy();
        }
    }
}