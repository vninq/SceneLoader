using System;
using System.Collections.Generic;
using lstwoMODS_WobblyLife;
using lstwoMODS_Core;
using lstwoMODS_Core.Hacks;
using lstwoMODS_Core.UI.TabMenus;
using lstwoMODS_Core.UI.Elements;
using lstwoMODS_WobblyLife.UI.TabMenus;

namespace SceneLoader

public class SceneLoader : BaseMod
 {
      public override string Name => "Scene Loader";
     public override string Description => "instantly load scenes";
      public override ModsWindow ModsWindow => lstwoMODS_WobblyLife.Plugin.ServerModsWindow;

      public override Container BuildPanel(string id)
      {
          return new Container(id,

             new Button("WobblyIsland", () => LoadS(LoadScene.WobblyIsland)
             ).WithContentWidth(),
             new Button("Arcade_Lobby", () => LoadS(LoadScene.Arcade_Lobby)
             ).WithContentWidth(),
             new Button("MainMenu", () => LoadS(LoadScene.MainMenu)
             ).WithContentWidth(),
             new Button("Space", () => LoadS(LoadScene.Space)
             ).WithContentWidth(),
             new Button("Invalid", () => LoadS(LoadScene.Invaild)
            ).WithContentWidth()

            );
        }

      private void LoadS(LoadScene scene)
      {
          GameInstance.Instance?.Load(scene, null);
      }
      
    }
}
