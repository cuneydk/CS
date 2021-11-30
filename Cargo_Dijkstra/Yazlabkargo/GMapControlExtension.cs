using GMap.NET.WindowsForms;

namespace Yazlabkargo
{
    public static class GMapControlExtension
    {
        public static void RefreshMap(this GMapControl map)
        {
            map.Zoom--;
            map.Zoom++;
        }
    }
}
