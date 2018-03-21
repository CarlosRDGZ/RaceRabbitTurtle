namespace Race
{
    public class Wabbit : Animal
    {
        public override void MakeStep()
        {
            int step = random.Next(10);
            // Salto Grande
            if (step < 2)
                _steps += 9;
            // Resbalon Grande
            else if (step < 3)
                _steps -= 12;
            // Salto Pequeño
            else if (step < 6)
                _steps += 1;
            // Resbalon Pequeño
            else if (step < 8)
                _steps -= 2;
        }
    }
}