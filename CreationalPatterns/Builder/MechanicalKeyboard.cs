namespace Builder;

/// <summary>
/// Represents the mechanical keyboard class.
/// </summary>
internal sealed class MechanicalKeyboard(
    Case @case,
    PCB pcb,
    string color,
    Plate plate,
    Switch @switch,
    Keycap keycap,
    KeycapProfile keycapProfile,
    Stabilizer stabilizer,
    Led led,
    ConnectionSupport connectionSupport,
    Layout layout,
    bool isHaveKnob)
{
    /// <summary>
    /// The keyboard case.
    /// </summary>
    public Case Case { get; set; } = @case;

    /// <summary>
    /// The keyboard PCB.
    /// </summary>
    public PCB PCB { get; set; } = pcb;

    /// <summary>
    /// The keyboard color.
    /// </summary>
    public string Color { get; set; } = color;

    /// <summary>
    /// The keyboard plate.
    /// </summary>
    public Plate Plate { get; set; } = plate;

    /// <summary>
    /// The keyboard switch.
    /// </summary>
    public Switch Switch { get; set; } = @switch;

    /// <summary>
    /// The keyboard keycap.
    /// </summary>
    public Keycap Keycap { get; set; } = keycap;

    /// <summary>
    /// The keyboard keycap profile.
    /// </summary>
    public KeycapProfile KeycapProfile { get; set; } = keycapProfile;

    /// <summary>
    /// The keyboard stabilizer.
    /// </summary>
    public Stabilizer Stabilizer { get; set; } = stabilizer;

    /// <summary>
    /// The keyboard led backlit.
    /// </summary>
    public Led Led { get; set; } = led;

    /// <summary>
    /// The keyboard connection support.
    /// </summary>
    public ConnectionSupport ConnectionSupport { get; set; } = connectionSupport;

    /// <summary>
    /// The keyboard layout.
    /// </summary>
    public Layout Layout { get; set; } = layout;

    /// <summary>
    /// The keyboard is have knob or not.
    /// </summary>
    public bool IsHaveKnob { get; set; } = isHaveKnob;

    public override string ToString()
    {
        var content = string.Empty;

        content += $"Case material: {Case}\n";

        content += $"PCB material: {PCB}\n";

        content += $"Color: {Color}\n";

        content += $"Plate material: {Plate}\n";

        content += $"Switch type: {Switch}\n";

        content += $"Keycap material: {Keycap}\n";

        content += $"Keycap profile: {KeycapProfile}\n";

        content += $"Stabilizer type: {Stabilizer}\n";

        content += $"Led type: {Led}\n";

        content += $"Connection support: {ConnectionSupport}\n";

        content += $"Layout: {Layout}\n";

        content += $"Knob support: {(IsHaveKnob ? "Yes" : "No")}\n";

        return content;
    }
}