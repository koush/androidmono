namespace android.text
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class Layout : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Layout()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.Layout), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected Layout(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class Alignment : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static Alignment()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.Layout.Alignment), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.text.Layout.Alignment(@__env);
				}
			}
			internal Alignment(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values7416;
			public static global::android.text.Layout.Alignment[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.text.Layout.Alignment.staticClass, global::android.text.Layout.Alignment._values7416));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf7417;
			public static global::android.text.Layout.Alignment valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Alignment>(@__env, @__env.CallStaticObjectMethodPtr(android.text.Layout.Alignment.staticClass, global::android.text.Layout.Alignment._valueOf7417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _ALIGN_CENTER7418;
			public static global::android.text.Layout.Alignment ALIGN_CENTER
			{
				get
				{
					return default(global::android.text.Layout.Alignment);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _ALIGN_NORMAL7419;
			public static global::android.text.Layout.Alignment ALIGN_NORMAL
			{
				get
				{
					return default(global::android.text.Layout.Alignment);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _ALIGN_OPPOSITE7420;
			public static global::android.text.Layout.Alignment ALIGN_OPPOSITE
			{
				get
				{
					return default(global::android.text.Layout.Alignment);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.text.Layout.Alignment.staticClass = @__class;
				global::android.text.Layout.Alignment._values7416 = @__env.GetStaticMethodID(global::android.text.Layout.Alignment.staticClass, "values", "()[Landroid/text/Layout/Alignment;");
				global::android.text.Layout.Alignment._valueOf7417 = @__env.GetStaticMethodID(global::android.text.Layout.Alignment.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/text/Layout$Alignment;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class Directions : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Directions()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.Layout.Directions), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.text.Layout.Directions(@__env);
				}
			}
			protected Directions(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.text.Layout.Directions.staticClass = @__class;
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineWidth7421;
		public virtual float getLineWidth(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.text.Layout._getLineWidth7421, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getLineWidth7421, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getText7422;
		public virtual global::java.lang.CharSequence getText() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.Layout._getText7422));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.Layout.staticClass, global::android.text.Layout._getText7422));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw7423;
		public virtual void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.Layout._draw7423, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._draw7423, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw7424;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Path arg1, android.graphics.Paint arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.Layout._draw7424, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._draw7424, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWidth7425;
		public virtual int getWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.Layout._getWidth7425);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getWidth7425);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeight7426;
		public virtual int getHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.Layout._getHeight7426);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getHeight7426);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPaint7427;
		public virtual global::android.text.TextPaint getPaint() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.TextPaint>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.Layout._getPaint7427));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.TextPaint>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.Layout.staticClass, global::android.text.Layout._getPaint7427));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineCount7428;
		public abstract int getLineCount();
		internal static global::net.sf.jni4net.jni.MethodId _getLineBounds7429;
		public virtual int getLineBounds(int arg0, android.graphics.Rect arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.Layout._getLineBounds7429, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getLineBounds7429, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDesiredWidth7430;
		public static float getDesiredWidth(java.lang.CharSequence arg0, int arg1, int arg2, android.text.TextPaint arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.text.Layout.staticClass, global::android.text.Layout._getDesiredWidth7430, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDesiredWidth7431;
		public static float getDesiredWidth(java.lang.CharSequence arg0, android.text.TextPaint arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.text.Layout.staticClass, global::android.text.Layout._getDesiredWidth7431, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsizedWidth7432;
		public virtual int getEllipsizedWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.Layout._getEllipsizedWidth7432);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getEllipsizedWidth7432);
		}
		internal static global::net.sf.jni4net.jni.MethodId _increaseWidthTo7433;
		public virtual void increaseWidthTo(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.Layout._increaseWidthTo7433, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._increaseWidthTo7433, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAlignment7434;
		public virtual global::android.text.Layout.Alignment getAlignment() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Alignment>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.Layout._getAlignment7434));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Alignment>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.Layout.staticClass, global::android.text.Layout._getAlignment7434));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpacingMultiplier7435;
		public virtual float getSpacingMultiplier() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.text.Layout._getSpacingMultiplier7435);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getSpacingMultiplier7435);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpacingAdd7436;
		public virtual float getSpacingAdd() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.text.Layout._getSpacingAdd7436);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getSpacingAdd7436);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineTop7437;
		public abstract int getLineTop(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getLineDescent7438;
		public abstract int getLineDescent(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getLineStart7439;
		public abstract int getLineStart(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getParagraphDirection7440;
		public abstract int getParagraphDirection(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getLineContainsTab7441;
		public abstract bool getLineContainsTab(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getLineDirections7442;
		public abstract global::android.text.Layout.Directions getLineDirections(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getTopPadding7443;
		public abstract int getTopPadding();
		internal static global::net.sf.jni4net.jni.MethodId _getBottomPadding7444;
		public abstract int getBottomPadding();
		internal static global::net.sf.jni4net.jni.MethodId _getPrimaryHorizontal7445;
		public virtual float getPrimaryHorizontal(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.text.Layout._getPrimaryHorizontal7445, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getPrimaryHorizontal7445, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSecondaryHorizontal7446;
		public virtual float getSecondaryHorizontal(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.text.Layout._getSecondaryHorizontal7446, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getSecondaryHorizontal7446, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineLeft7447;
		public virtual float getLineLeft(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.text.Layout._getLineLeft7447, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getLineLeft7447, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineRight7448;
		public virtual float getLineRight(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.text.Layout._getLineRight7448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getLineRight7448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineMax7449;
		public virtual float getLineMax(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.text.Layout._getLineMax7449, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getLineMax7449, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineForVertical7450;
		public virtual int getLineForVertical(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.Layout._getLineForVertical7450, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getLineForVertical7450, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineForOffset7451;
		public virtual int getLineForOffset(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.Layout._getLineForOffset7451, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getLineForOffset7451, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOffsetForHorizontal7452;
		public virtual int getOffsetForHorizontal(int arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.Layout._getOffsetForHorizontal7452, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getOffsetForHorizontal7452, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineEnd7453;
		public virtual int getLineEnd(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.Layout._getLineEnd7453, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getLineEnd7453, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineVisibleEnd7454;
		public virtual int getLineVisibleEnd(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.Layout._getLineVisibleEnd7454, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getLineVisibleEnd7454, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineBottom7455;
		public virtual int getLineBottom(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.Layout._getLineBottom7455, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getLineBottom7455, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineBaseline7456;
		public virtual int getLineBaseline(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.Layout._getLineBaseline7456, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getLineBaseline7456, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineAscent7457;
		public virtual int getLineAscent(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.Layout._getLineAscent7457, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getLineAscent7457, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOffsetToLeftOf7458;
		public virtual int getOffsetToLeftOf(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.Layout._getOffsetToLeftOf7458, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getOffsetToLeftOf7458, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOffsetToRightOf7459;
		public virtual int getOffsetToRightOf(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.Layout._getOffsetToRightOf7459, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getOffsetToRightOf7459, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCursorPath7460;
		public virtual void getCursorPath(int arg0, android.graphics.Path arg1, java.lang.CharSequence arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.Layout._getCursorPath7460, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getCursorPath7460, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		public void getCursorPath(int arg0, android.graphics.Path arg1, string arg2)
		{
			getCursorPath(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectionPath7461;
		public virtual void getSelectionPath(int arg0, int arg1, android.graphics.Path arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.Layout._getSelectionPath7461, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getSelectionPath7461, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParagraphAlignment7462;
		public virtual global::android.text.Layout.Alignment getParagraphAlignment(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Alignment>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.Layout._getParagraphAlignment7462, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Alignment>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.Layout.staticClass, global::android.text.Layout._getParagraphAlignment7462, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParagraphLeft7463;
		public virtual int getParagraphLeft(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.Layout._getParagraphLeft7463, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getParagraphLeft7463, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParagraphRight7464;
		public virtual int getParagraphRight(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.Layout._getParagraphRight7464, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._getParagraphRight7464, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSpanned7465;
		protected virtual bool isSpanned() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.Layout._isSpanned7465);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.Layout.staticClass, global::android.text.Layout._isSpanned7465);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsisStart7466;
		public abstract int getEllipsisStart(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsisCount7467;
		public abstract int getEllipsisCount(int arg0);
		internal static global::net.sf.jni4net.jni.MethodId _Layout7468;
		protected Layout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.Layout.staticClass, global::android.text.Layout._Layout7468, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		public static int DIR_LEFT_TO_RIGHT
		{
			get
			{
				return 1;
			}
		}
		public static int DIR_RIGHT_TO_LEFT
		{
			get
			{
				return -1;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.Layout.staticClass = @__class;
			global::android.text.Layout._getLineWidth7421 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineWidth", "(I)F");
			global::android.text.Layout._getText7422 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getText", "()Ljava/lang/CharSequence;");
			global::android.text.Layout._draw7423 = @__env.GetMethodID(global::android.text.Layout.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.text.Layout._draw7424 = @__env.GetMethodID(global::android.text.Layout.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Path;Landroid/graphics/Paint;I)V");
			global::android.text.Layout._getWidth7425 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getWidth", "()I");
			global::android.text.Layout._getHeight7426 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getHeight", "()I");
			global::android.text.Layout._getPaint7427 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getPaint", "()Landroid/text/TextPaint;");
			global::android.text.Layout._getLineCount7428 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineCount", "()I");
			global::android.text.Layout._getLineBounds7429 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineBounds", "(ILandroid/graphics/Rect;)I");
			global::android.text.Layout._getDesiredWidth7430 = @__env.GetStaticMethodID(global::android.text.Layout.staticClass, "getDesiredWidth", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;)F");
			global::android.text.Layout._getDesiredWidth7431 = @__env.GetStaticMethodID(global::android.text.Layout.staticClass, "getDesiredWidth", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;)F");
			global::android.text.Layout._getEllipsizedWidth7432 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getEllipsizedWidth", "()I");
			global::android.text.Layout._increaseWidthTo7433 = @__env.GetMethodID(global::android.text.Layout.staticClass, "increaseWidthTo", "(I)V");
			global::android.text.Layout._getAlignment7434 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getAlignment", "()Landroid/text/Layout$Alignment;");
			global::android.text.Layout._getSpacingMultiplier7435 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getSpacingMultiplier", "()F");
			global::android.text.Layout._getSpacingAdd7436 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getSpacingAdd", "()F");
			global::android.text.Layout._getLineTop7437 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineTop", "(I)I");
			global::android.text.Layout._getLineDescent7438 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineDescent", "(I)I");
			global::android.text.Layout._getLineStart7439 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineStart", "(I)I");
			global::android.text.Layout._getParagraphDirection7440 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getParagraphDirection", "(I)I");
			global::android.text.Layout._getLineContainsTab7441 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineContainsTab", "(I)Z");
			global::android.text.Layout._getLineDirections7442 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;");
			global::android.text.Layout._getTopPadding7443 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getTopPadding", "()I");
			global::android.text.Layout._getBottomPadding7444 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getBottomPadding", "()I");
			global::android.text.Layout._getPrimaryHorizontal7445 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getPrimaryHorizontal", "(I)F");
			global::android.text.Layout._getSecondaryHorizontal7446 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getSecondaryHorizontal", "(I)F");
			global::android.text.Layout._getLineLeft7447 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineLeft", "(I)F");
			global::android.text.Layout._getLineRight7448 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineRight", "(I)F");
			global::android.text.Layout._getLineMax7449 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineMax", "(I)F");
			global::android.text.Layout._getLineForVertical7450 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineForVertical", "(I)I");
			global::android.text.Layout._getLineForOffset7451 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineForOffset", "(I)I");
			global::android.text.Layout._getOffsetForHorizontal7452 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getOffsetForHorizontal", "(IF)I");
			global::android.text.Layout._getLineEnd7453 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineEnd", "(I)I");
			global::android.text.Layout._getLineVisibleEnd7454 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineVisibleEnd", "(I)I");
			global::android.text.Layout._getLineBottom7455 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineBottom", "(I)I");
			global::android.text.Layout._getLineBaseline7456 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineBaseline", "(I)I");
			global::android.text.Layout._getLineAscent7457 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getLineAscent", "(I)I");
			global::android.text.Layout._getOffsetToLeftOf7458 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getOffsetToLeftOf", "(I)I");
			global::android.text.Layout._getOffsetToRightOf7459 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getOffsetToRightOf", "(I)I");
			global::android.text.Layout._getCursorPath7460 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getCursorPath", "(ILandroid/graphics/Path;Ljava/lang/CharSequence;)V");
			global::android.text.Layout._getSelectionPath7461 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getSelectionPath", "(IILandroid/graphics/Path;)V");
			global::android.text.Layout._getParagraphAlignment7462 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getParagraphAlignment", "(I)Landroid/text/Layout$Alignment;");
			global::android.text.Layout._getParagraphLeft7463 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getParagraphLeft", "(I)I");
			global::android.text.Layout._getParagraphRight7464 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getParagraphRight", "(I)I");
			global::android.text.Layout._isSpanned7465 = @__env.GetMethodID(global::android.text.Layout.staticClass, "isSpanned", "()Z");
			global::android.text.Layout._getEllipsisStart7466 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getEllipsisStart", "(I)I");
			global::android.text.Layout._getEllipsisCount7467 = @__env.GetMethodID(global::android.text.Layout.staticClass, "getEllipsisCount", "(I)I");
			global::android.text.Layout._Layout7468 = @__env.GetMethodID(global::android.text.Layout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FF)V");
		}
	}
}
