
using static System.Console;

WriteLine("Put your num");
string? input = ReadLine();

if (input != null) {
  int num = int.Parse(input);

  int[] numbers = new int[num];

  Random r = new Random();

  for (int i = 0; i < num - 1; i++) {
    numbers[i] = r.Next(0, 500);
  }



  for (int i = 0; i < num; i++) {
    bool div = false;
    if (numbers[i] % 3 == 0) {
      Write("FIZZ");
      div = true;
    }

    if (numbers[i] % 5 == 0) {
      Write("BUZZ");
      div = true;
    }

    if (!div)
      WriteLine(numbers[i]);
    else
      WriteLine();
  }
} else {
  WriteLine("Input is null.");
}
