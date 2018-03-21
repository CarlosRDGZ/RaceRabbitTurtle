namespace Race
{
    public class Turtle : Animal
    {
        public override void MakeStep()
        {
            int step = random.Next(10);
            // Paso Rapido
            if (step < 5)
                _steps += 3;
            // Resbalon
            else if (step < 7)
                _steps -= 6;
            // Paso Lento
            else
                _steps += 1;
        }
    }
}