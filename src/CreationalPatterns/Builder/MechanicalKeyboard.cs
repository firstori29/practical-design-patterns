namespace Builder;

/// <summary>
/// Represents the mechanical keyboard class.
/// </summary>
internal sealed class MechanicalKeyboard
{
    /// Initializes a new instance of <see cref="MechanicalKeyboard"/> class with properties parameter.
    internal MechanicalKeyboard(MechanicalKeyboard mechanicalKeyboard)
    {
        Case = mechanicalKeyboard.Case;
        PCB = mechanicalKeyboard.PCB;
        Color = mechanicalKeyboard.Color;
        Plate = mechanicalKeyboard.Plate;
        Switch = mechanicalKeyboard.Switch;
        Keycap = mechanicalKeyboard.Keycap;
        KeycapProfile = mechanicalKeyboard.KeycapProfile;
        Stabilizer = mechanicalKeyboard.Stabilizer;
        Led = mechanicalKeyboard.Led;
        ConnectionSupport = mechanicalKeyboard.ConnectionSupport;
        Layout = mechanicalKeyboard.Layout;
        IsHaveKnob = mechanicalKeyboard.IsHaveKnob;
    }

    /// <summary>
    /// The default constructor.
    /// </summary>
    internal MechanicalKeyboard() { }

    /// <summary>
    /// The keyboard case.
    /// </summary>
    internal Case? Case { get; set; }

    /// <summary>
    /// The keyboard PCB.
    /// </summary>
    internal Pcb? PCB { get; set; }

    /// <summary>
    /// The keyboard color.
    /// </summary>
    internal string? Color { get; set; }

    /// <summary>
    /// The keyboard plate.
    /// </summary>
    internal Plate? Plate { get; set; }

    /// <summary>
    /// The keyboard switch.
    /// </summary>
    internal Switch? Switch { get; set; }

    /// <summary>
    /// The keyboard keycap.
    /// </summary>
    internal Keycap? Keycap { get; set; }

    /// <summary>
    /// The keyboard keycap profile.
    /// </summary>
    internal KeycapProfile? KeycapProfile { get; set; }

    /// <summary>
    /// The keyboard stabilizer.
    /// </summary>
    internal Stabilizer? Stabilizer { get; set; }

    /// <summary>
    /// The keyboard led backlit.
    /// </summary>
    internal Led? Led { get; set; }

    /// <summary>
    /// The keyboard connection support.
    /// </summary>
    internal ConnectionSupport? ConnectionSupport { get; set; }

    /// <summary>
    /// The keyboard layout.
    /// </summary>
    internal Layout? Layout { get; set; }

    /// <summary>
    /// The keyboard is had knob or not.
    /// </summary>
    internal bool IsHaveKnob { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return AssembledKeyboardComponentsReport();
    }

    /// <summary>
    /// Print the mechanical keyboard assembled components.
    /// </summary>
    /// <returns>The string content of assembled mechanical keyboard components.</returns>
    private string AssembledKeyboardComponentsReport()
    {
        var content = string.Empty;

        if (Case is not null)
            content += $"\t- Case material: {Case.Name} (Code: {Case.Code}).\n";

        if (PCB is not null)
            content += $"\t- PCB material: {PCB.Name} (Code: {PCB.Code}).\n";

        if (Color is not null)
            content += $"\t- Color: {Color}.\n";

        if (Plate is not null)
            content += $"\t- Plate material: {Plate.Name} (Code: {Plate.Code}).\n";

        if (Switch is not null)
            content += $"\t- Switch type: {Switch.Name} (Code: {Switch.Code}).\n";

        if (Keycap is not null)
            content += $"\t- Keycap material: {Keycap.Name} (Code: {Keycap.Code}).\n";

        if (KeycapProfile is not null)
            content += $"\t- Keycap profile: {KeycapProfile.Name} (Code: {KeycapProfile.Code}).\n";

        if (Stabilizer is not null)
            content += $"\t- Stabilizer type: {Stabilizer.Name} (Code: {Stabilizer.Code}).\n";

        if (Led is not null)
            content += $"\t- LED type: {Led.Name} (Code: {Led.Code}).\n";

        if (ConnectionSupport is not null)
            content += $"\t- Connection support: {ConnectionSupport.Name} (Code: {ConnectionSupport.Code}).\n";

        if (Layout is not null)
            content += $"\t- Layout: {Layout.Name} (Code: {Layout.Code}).\n";

        content += $"\t- Knob support: {(IsHaveKnob ? "Yes." : "No.")}\n";

        return content;
    }
}
