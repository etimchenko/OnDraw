using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using OnDraw.Droid.Tools.Brushes.Interfaces;

namespace OnDraw.Droid.Tools.Brushes
{
	public class Pencil : IBrush
	{
		public float Thickness { get; set; } = 1.0f;

		public void Draw(Canvas canvas, float x, float y)
		{
			Paint drawPaint = new Paint();
			drawPaint.Color = Color.Black;
			drawPaint.AntiAlias = true;
			drawPaint.StrokeWidth = Thickness;
			drawPaint.SetStyle(Paint.Style.Stroke);
			drawPaint.StrokeJoin = Paint.Join.Round;
			drawPaint.StrokeCap = Paint.Cap.Round;

			canvas.DrawCircle(x, y, 1, drawPaint);
		}
	}
}