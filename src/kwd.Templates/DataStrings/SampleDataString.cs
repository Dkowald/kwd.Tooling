using System;
using kwd.CoreUtil.Strings;

namespace kwd.Templates.DataStrings;

/// <summary>
/// A data string: SampleDataString 
/// <list type="bullet">
/// <item>Cannot be empty</item>
/// <item>Max length 20</item>
/// <item>trimmed</item>
/// </list>
/// </summary>
public record SampleDataString : IDataString<SampleDataString>
{
  private readonly string _value;

  private static (string? error, string? cleaned) TryRead(string? value) 
  {
    value = value?.Trim();

    if (string.IsNullOrEmpty(value))
      return ("Cannot be empty", null);

    if (value.Length > 20)
      return ("Max length 20", null);

    return (null, value);
  }

  private SampleDataString(string value, bool isChecked) 
  {
    if (!isChecked)
    {
      var (error, cleaned) = TryRead(value);

      if (cleaned is null)
        throw new ArgumentException(error, nameof(value));

      value = cleaned;
    }

    _value = value;
  }

  /// <summary>
  /// Try parse <paramref name="value"/> as a <see cref="SampleDataString"/>
  /// </summary>
  public static SampleDataString? TryParse(string? value)
  {
    var (_, cleaned) = TryRead(value);

    return cleaned is null ? null : new SampleDataString(cleaned, true);
  }

  /// <summary>
  /// Cast a <see cref="SampleDataString"/> to its raw <see langword="string"/>.
  /// </summary>
  public static implicit operator string?(SampleDataString? item) => item?._value;

  /// <summary>
  /// Create a new <see cref="SampleDataString"/> where <paramref name="value"/>
  /// <inheritdoc cref="SampleDataString" path="//summary/list"/>
  /// </summary>
  /// <exception cref="ArgumentException">
  /// Raised if <paramref name="value"/> is not a
  /// valid <see cref="SampleDataString"/>.
  /// </exception>
  public SampleDataString(string value):this(value, false){}

  /// <inheritdoc />
  public override string ToString() => _value;
}
