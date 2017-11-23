using Android.Graphics;

namespace OnDraw.Droid.Tools.Brushes.Interfaces
{
	public interface IBrush
	{
		float Thickness { get; set; }

		void Draw(Canvas canvas, float x, float y);
	}
}