using System.Text.Json.Serialization;

namespace chorescore.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ChoreDay
{
  Sunday,
  Monday,
  Tuesday,
  Wednesday,
  Thursday,
  Friday,
  Saturday
}
