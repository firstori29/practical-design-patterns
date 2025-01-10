namespace Builder;

/// <summary>
/// Represents the mechanical keyboard builder.
/// </summary>
internal sealed class MechanicalKeyboardBuilder : IMechanicalKeyboardBuilder
{
    /// <summary>
    /// The instance of <see cref="MechanicalKeyboard"/> class.
    /// </summary>
    private MechanicalKeyboard _mechanicalKeyboard = new();

    /// <summary>
    /// Initializes a new instance of <see cref="MechanicalKeyboardBuilder"/> class.
    /// </summary>
    internal MechanicalKeyboardBuilder()
    {
        Reset();
    }

    /// <summary>
    /// Resets the <see cref="MechanicalKeyboard"/> instance to default value.
    /// </summary>
    private void Reset()
    {
        _mechanicalKeyboard = new MechanicalKeyboard();
    }

    /// <inheritdoc />
    public MechanicalKeyboardBuilder SetCase(Case? @case)
    {
        _mechanicalKeyboard.Case = @case;

        return this;
    }

    /// <inheritdoc />
    public MechanicalKeyboardBuilder SetPCB(PCB? pcb)
    {
        _mechanicalKeyboard.PCB = pcb;

        return this;
    }

    /// <inheritdoc />
    public MechanicalKeyboardBuilder SetColor(string? color)
    {
        _mechanicalKeyboard.Color = color;

        return this;
    }

    /// <inheritdoc />
    public MechanicalKeyboardBuilder SetPlate(Plate? plate)
    {
        _mechanicalKeyboard.Plate = plate;

        return this;
    }

    /// <inheritdoc />
    public MechanicalKeyboardBuilder SetSwitch(Switch? @switch)
    {
        _mechanicalKeyboard.Switch = @switch;

        return this;
    }

    /// <inheritdoc />
    public MechanicalKeyboardBuilder SetKeycap(Keycap? keycap)
    {
        _mechanicalKeyboard.Keycap = keycap;

        return this;
    }

    /// <inheritdoc />
    public MechanicalKeyboardBuilder SetKeycapProfile(KeycapProfile? keycapProfile)
    {
        _mechanicalKeyboard.KeycapProfile = keycapProfile;

        return this;
    }

    /// <inheritdoc />
    public MechanicalKeyboardBuilder SetStabilizer(Stabilizer? stabilizer)
    {
        _mechanicalKeyboard.Stabilizer = stabilizer;

        return this;
    }

    /// <inheritdoc />
    public MechanicalKeyboardBuilder SetLed(Led? led)
    {
        _mechanicalKeyboard.Led = led;

        return this;
    }

    /// <inheritdoc />
    public MechanicalKeyboardBuilder SetConnectionSupport(ConnectionSupport? connectionSupport)
    {
        _mechanicalKeyboard.ConnectionSupport = connectionSupport;

        return this;
    }

    /// <inheritdoc />
    public MechanicalKeyboardBuilder SetLayout(Layout? layout)
    {
        _mechanicalKeyboard.Layout = layout;

        return this;
    }

    /// <inheritdoc />
    public MechanicalKeyboardBuilder SetIsHaveKnob(bool isHaveKnob)
    {
        _mechanicalKeyboard.IsHaveKnob = isHaveKnob;

        return this;
    }

    /// <inheritdoc />
    public string GenerateRandomCode()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        var code = new StringBuilder(6);

        var random = new Random();

        for (var i = 0; i < 6; i++)
        {
            var index = random.Next(chars.Length);

            code.Append(chars[index]);
        }

        return code.ToString();
    }

    /// <summary>
    /// Initializes a new instance of <see cref="MechanicalKeyboard"/> class with values
    /// assigned to the specified properties.
    /// </summary>
    /// <returns>
    /// A new instance of <see cref="MechanicalKeyboard"/> class with values assigned to the specified properties.
    /// </returns>
    internal MechanicalKeyboard GetResult()
    {
        var mechanicalKeyboard = new MechanicalKeyboard(_mechanicalKeyboard);

        Reset();

        return mechanicalKeyboard;
    }
}