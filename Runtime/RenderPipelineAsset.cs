using UnityEngine;
using UnityEngine.Rendering;

namespace PsyKai.Rendering {

[CreateAssetMenu(menuName = "Rendering/PsyKai RP Asset")]
public class PsyKaiRenderPipelineAsset : RenderPipelineAsset {
    protected override RenderPipeline CreatePipeline() {
        return new PsyKaiRenderPipeline();
    }
} 

}