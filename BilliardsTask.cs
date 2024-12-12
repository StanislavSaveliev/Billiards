using System;

namespace Billiards
{
    public static class BilliardsTask
    {
        public static double BounceWall(double incidentAngle, double wallAngle)
        {
            // Преобразование углов из радиан в градусы
            double incidentInDegrees = ConvertRadiansToDegrees(incidentAngle);
            double wallInDegrees = ConvertRadiansToDegrees(wallAngle);

            // Расчёт угла отражения
            double reflectionAngleDegrees = 2 * wallInDegrees - incidentInDegrees;

            // Угол отражения должен быть в пределах от -180 до 180 градусов
            reflectionAngleDegrees = NormalizeAngle(reflectionAngleDegrees);

            // Возвращаем угол отражения в радианах
            return ConvertDegreesToRadians(reflectionAngleDegrees);
        }

        private static double ConvertRadiansToDegrees(double radians)
        {
            return radians * (180.0 / Math.PI);
        }

        private static double ConvertDegreesToRadians(double degrees)
        {
            return degrees * (Math.PI / 180.0);
        }

        private static double NormalizeAngle(double angle)
        {
            // Нормализация угла в диапазоне от -180 до 180 градусов
            while (angle <= -180)
                angle += 360;
            while (angle > 180)
                angle -= 360;
            return angle;
        }
    }
}
