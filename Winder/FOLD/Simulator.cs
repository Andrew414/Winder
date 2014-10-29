using System;
using System.Collections.Generic;
using System.Text;

namespace FOLD
{
    class Simulator
    {
        public GlobalState state { get; set; }

        public void ProcessLowTemperature()
        {
            state.rotor.CheckLowTemp();

            if (state.rotor.temperature < 1)
            {
                state.rotor.ReportLowTemp();
            }
        }

        public void ProcessHighSpeed()
        {
            state.rotor.CheckHighSpeed();

            if (state.rotor.speed > 3.5)
            {
                state.rotor.ReportHighSpeed();
            }
        }

        public void ProcessFire()
        {
            if (state.generator.temperature > 500)
            {
                state.generator.FireSystemActive = true;
                state.generator.Active = false;
            }
        }

        public void ProcessTornado()
        {
            if (state.env.WindSpeed > 30)
            {
                state.generator.Active = false;
                state.rotor.Active = false;
                state.rotor.speed = 0;
            }
        }

        public void ProcessLowSpeed()
        {
            if (state.rotor.speed < 0.01)
            {
                state.generator.Stop();
            }
        }

        public void ProcessSignals()
        {
            ProcessLowTemperature();
            ProcessHighSpeed();
            
            ProcessFire();

            ProcessTornado();
        }

        private Random rand = new Random(DateTime.Now.Millisecond);

        public int NormalRand(int deltas)
        {
            int total = 3;

            int sum = 0;

            for (int i = 0; i < total; i++)
            {
                sum += rand.Next(2 * deltas);
            }

            sum /= total;

            return sum - deltas;
        }

        public void DoOneStep()
        {
            // rotor temperature

            if (state.rotor.temperature > state.env.Temperature)
            {
                state.rotor.temperature -= Constants.TEMP_DELTA;
            }

            if (state.rotor.temperature < state.env.Temperature)
            {
                state.rotor.temperature += Constants.TEMP_DELTA;
            }

            if (state.rotor.heaterEnabled)
            {
                state.rotor.temperature += Constants.HEAT_DELTA;
            }

            // real wind speed

            state.env.WindSpeed = state.env.WindSpeedAvg + NormalRand(10);

            // rotor speed

            if (state.rotor.Active)
            {
                if (state.env.WindSpeed > Constants.WIND_AVG)
                {
                    state.rotor.speed += Constants.SPEED_COEF;
                }

                if (state.env.WindSpeed < Constants.WIND_AVG)
                {
                    state.rotor.speed -= Constants.SPEED_COEF;
                }

                if (state.rotor.brakeEnabled)
                {
                    state.rotor.speed -= Constants.BRAKE_COEF;
                }

                if (state.rotor.speed < 0)
                {
                    state.rotor.speed = 0;
                }
            }

            // generator temperature

            if (state.generator.FireSystemActive)
            {
                if (state.generator.temperature < 180)
                {
                    state.generator.temperature = 190;
                    state.generator.FireSystemActive = false;
                }

                state.generator.temperature -= 10;
            }

            ProcessSignals();
        }
    }
}
