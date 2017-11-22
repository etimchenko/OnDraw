using Android.Content;
using Android.Util;
using Android.Views;
using OnDraw.Droid.Tools.Brushes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Graphics;

namespace OnDraw.Droid.Editor
{
	public class OnDrawCanvas : View
	{

		#region .ctors

		public OnDrawCanvas(Context context) : this(context, null)
		{
		}

		public OnDrawCanvas(Context context, IAttributeSet attrs) : this(context, attrs, 0)
		{
		}

		public OnDrawCanvas(Context context, IAttributeSet attrs, int defStyleAttr) : this(context, attrs, defStyleAttr, 0)
		{
		}

		public OnDrawCanvas(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
		{
		}

		#endregion

		#region Fields

		private IBrush _brush;

		private List<Point> circlePoints = new List<Point>();

		#endregion

		#region Public methods and Properties

		public void SetBrush(IBrush brush)
		{
			if (brush == null)
				throw new ArgumentNullException(nameof(brush));

			_brush = brush;
		}

		protected override void OnDraw(Canvas canvas)
		{
			base.OnDraw(canvas);

			foreach (var p in circlePoints)
			{
				_brush.Draw(canvas, p.X, p.Y);

			}
		}

		public override bool OnTouchEvent(MotionEvent e)
		{
			float touchX = e.GetX();
			float touchY = e.GetY();
			circlePoints.Add(new Point((int)Math.Round(touchX), (int)Math.Round(touchY)));

			// indicate view should be redrawn
			PostInvalidate();

			return true;
		}

		#endregion

	}
}
