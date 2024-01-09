public record Debate(
  string id,
  Debater pm,
  Debater lo,
  Debater dpm,
  Debater dlo,
  Debater? mg,
  Debater? mo,
  Debater? gw,
  Debater? ow,
  int? pmSp,
  int? loSp,
  int? dpmSp,
  int? dloSp,
  int? mgSp,
  int? moSp,
  int? gwSp,
  int? owSp,
  Duo og,
  Duo oo,
  Duo cg,
  Duo co,
  Judge chair,
  List<Judge>? wings,
  string motion,
  List<string>? infoSlides,
  string date,
  string thematic,
  string prefix,
  string? tournament
);
