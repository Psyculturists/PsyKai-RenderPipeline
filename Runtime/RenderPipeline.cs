using UnityEngine;
using UnityEngine.Rendering;

namespace PsyKai.Rendering {

public class PsyKaiRenderPipeline : RenderPipeline {
    public PsyKaiRenderPipeline() {
    }

    protected override void Render (ScriptableRenderContext context, Camera[] cameras) {
        var cmd = new CommandBuffer();
        cmd.ClearRenderTarget(true, true, Color.magenta);
        context.ExecuteCommandBuffer(cmd);
        cmd.Release();

        context.Submit();
    }
}

}