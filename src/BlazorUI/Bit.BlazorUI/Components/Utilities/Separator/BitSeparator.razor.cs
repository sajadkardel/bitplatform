﻿namespace Bit.BlazorUI;

public partial class BitSeparator : BitComponentBase
{
    /// <summary>
    /// Where the content should be aligned in the separator.
    /// </summary>
    [Parameter, ResetClassBuilder]
    public BitSeparatorAlignContent AlignContent { get; set; } = BitSeparatorAlignContent.Center;

    /// <summary>
    /// The content of the Separator, it can be any custom tag or text.
    /// </summary>
    [Parameter] public RenderFragment? ChildContent { get; set; }

    /// <summary>
    /// Whether the element is a vertical separator.
    /// </summary>
    [Parameter, ResetClassBuilder]
    public bool IsVertical { get; set; }



    protected override string RootElementClass => "bit-spr";

    protected override void RegisterCssClasses()
    {
        ClassBuilder.Register(() => IsVertical ? "bit-spr-vrt" : "bit-spr-hrz");

        ClassBuilder.Register(() => AlignContent switch
        {
            BitSeparatorAlignContent.Start => "bit-spr-srt",
            BitSeparatorAlignContent.End => "bit-spr-end",
            _ => "bit-spr-ctr"
        });
    }
}
