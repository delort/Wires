namespace Wires
{
	using System;
	using System.Linq.Expressions;
	using CoreGraphics;
	using UIKit;

	public static partial class UIExtensions
	{
		#region Hidden property

		public static Binder<TSource, TView> Visible<TSource, TView, TPropertyType>(this Binder<TSource, TView> binder, Expression<Func<TSource, TPropertyType>> property, IConverter<TPropertyType, bool> converter = null)
			where TSource : class
			where TView : UIView
		{
			converter = converter ?? Converters.Default<TPropertyType, bool>();
			return binder.Hidden(property, converter.Chain(Converters.Invert));
		}

		public static Binder<TSource, TView> Hidden<TSource, TView, TPropertyType>(this Binder<TSource, TView> binder, Expression<Func<TSource, TPropertyType>> property, IConverter<TPropertyType, bool> converter = null)
			where TSource : class
			where TView : UIView
		{
			return binder.Property(property, b => b.Hidden, converter);
		}

		#endregion

		#region UserInteractionEnabled property

		public static Binder<TSource, TView> UserInteractionEnabled<TSource, TView, TPropertyType>(this Binder<TSource, TView> binder, Expression<Func<TSource, TPropertyType>> property, IConverter<TPropertyType, bool> converter = null)
			where TSource : class
			where TView : UIView
		{
			return binder.Property(property, b => b.UserInteractionEnabled, converter);
		}

		#endregion

		#region TintColor property

		public static Binder<TSource, TView> TintColor<TSource, TView, TPropertyType>(this Binder<TSource, TView> binder, Expression<Func<TSource, TPropertyType>> property, IConverter<TPropertyType, UIColor> converter = null)
			where TSource : class
			where TView : UIView
		{
			return binder.Property(property, b => b.TintColor, converter);
		}

		#endregion

		#region BackgroundColor property

		public static Binder<TSource, TView> BackgroundColor<TSource, TView, TPropertyType>(this Binder<TSource, TView> binder, Expression<Func<TSource, TPropertyType>> property, IConverter<TPropertyType, UIColor> converter = null)
			where TSource : class
			where TView : UIView
		{
			return binder.Property(property, b => b.BackgroundColor, converter);
		}

		#endregion

		#region Alpha property

		public static Binder<TSource, TView> Alpha<TSource, TView, TPropertyType>(this Binder<TSource, TView> binder, Expression<Func<TSource, TPropertyType>> property, IConverter<TPropertyType, nfloat> converter = null)
			where TSource : class
			where TView : UIView
		{
			return binder.Property(property, b => b.Alpha, converter);
		}

		#endregion

		#region Frame property

		public static Binder<TSource, TView> Frame<TSource, TView, TPropertyType>(this Binder<TSource, TView> binder, Expression<Func<TSource, TPropertyType>> property, IConverter<TPropertyType, CGRect> converter = null)
			where TSource : class
			where TView : UIView
		{
			return binder.Property(property, b => b.Frame, converter);
		}

		#endregion

	}
}
