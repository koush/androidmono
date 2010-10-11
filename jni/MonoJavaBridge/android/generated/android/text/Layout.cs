namespace android.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.Layout_))]
	public abstract partial class Layout : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Layout()
		{
			InitJNI();
		}
		protected Layout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Alignment : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Alignment()
			{
				InitJNI();
			}
			internal Alignment(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values7696;
			public static global::android.text.Layout.Alignment[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.Layout.Alignment>(@__env.CallStaticObjectMethod(android.text.Layout.Alignment.staticClass, global::android.text.Layout.Alignment._values7696)) as android.text.Layout.Alignment[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf7697;
			public static global::android.text.Layout.Alignment valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.Layout.Alignment.staticClass, global::android.text.Layout.Alignment._valueOf7697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Alignment;
			}
			internal static global::MonoJavaBridge.FieldId _ALIGN_CENTER7698;
			public static global::android.text.Layout.Alignment ALIGN_CENTER
			{
				get
				{
					return default(global::android.text.Layout.Alignment);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ALIGN_NORMAL7699;
			public static global::android.text.Layout.Alignment ALIGN_NORMAL
			{
				get
				{
					return default(global::android.text.Layout.Alignment);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ALIGN_OPPOSITE7700;
			public static global::android.text.Layout.Alignment ALIGN_OPPOSITE
			{
				get
				{
					return default(global::android.text.Layout.Alignment);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.Layout.Alignment.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Layout$Alignment"));
				global::android.text.Layout.Alignment._values7696 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.Alignment.staticClass, "values", "()[Landroid/text/Layout/Alignment;");
				global::android.text.Layout.Alignment._valueOf7697 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.Alignment.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/text/Layout$Alignment;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Directions : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Directions()
			{
				InitJNI();
			}
			protected Directions(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.Layout.Directions.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Layout$Directions"));
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineWidth7701;
		public virtual float getLineWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getLineWidth7701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineWidth7701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getText7702;
		public virtual global::java.lang.CharSequence getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout._getText7702)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getText7702)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _draw7703;
		public virtual void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._draw7703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._draw7703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _draw7704;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Path arg1, android.graphics.Paint arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._draw7704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._draw7704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getWidth7705;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getWidth7705);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getWidth7705);
		}
		internal static global::MonoJavaBridge.MethodId _getHeight7706;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getHeight7706);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getHeight7706);
		}
		internal static global::MonoJavaBridge.MethodId _getPaint7707;
		public virtual global::android.text.TextPaint getPaint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout._getPaint7707)) as android.text.TextPaint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getPaint7707)) as android.text.TextPaint;
		}
		internal static global::MonoJavaBridge.MethodId _getLineCount7708;
		public abstract int getLineCount();
		internal static global::MonoJavaBridge.MethodId _getLineBounds7709;
		public virtual int getLineBounds(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineBounds7709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineBounds7709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDesiredWidth7710;
		public static float getDesiredWidth(java.lang.CharSequence arg0, int arg1, int arg2, android.text.TextPaint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.text.Layout.staticClass, global::android.text.Layout._getDesiredWidth7710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getDesiredWidth7711;
		public static float getDesiredWidth(java.lang.CharSequence arg0, android.text.TextPaint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.text.Layout.staticClass, global::android.text.Layout._getDesiredWidth7711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsizedWidth7712;
		public virtual int getEllipsizedWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getEllipsizedWidth7712);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getEllipsizedWidth7712);
		}
		internal static global::MonoJavaBridge.MethodId _increaseWidthTo7713;
		public virtual void increaseWidthTo(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._increaseWidthTo7713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._increaseWidthTo7713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAlignment7714;
		public virtual global::android.text.Layout.Alignment getAlignment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout._getAlignment7714)) as android.text.Layout.Alignment;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getAlignment7714)) as android.text.Layout.Alignment;
		}
		internal static global::MonoJavaBridge.MethodId _getSpacingMultiplier7715;
		public virtual float getSpacingMultiplier() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getSpacingMultiplier7715);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getSpacingMultiplier7715);
		}
		internal static global::MonoJavaBridge.MethodId _getSpacingAdd7716;
		public virtual float getSpacingAdd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getSpacingAdd7716);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getSpacingAdd7716);
		}
		internal static global::MonoJavaBridge.MethodId _getLineTop7717;
		public abstract int getLineTop(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLineDescent7718;
		public abstract int getLineDescent(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLineStart7719;
		public abstract int getLineStart(int arg0);
		internal static global::MonoJavaBridge.MethodId _getParagraphDirection7720;
		public abstract int getParagraphDirection(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLineContainsTab7721;
		public abstract bool getLineContainsTab(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLineDirections7722;
		public abstract global::android.text.Layout.Directions getLineDirections(int arg0);
		internal static global::MonoJavaBridge.MethodId _getTopPadding7723;
		public abstract int getTopPadding();
		internal static global::MonoJavaBridge.MethodId _getBottomPadding7724;
		public abstract int getBottomPadding();
		internal static global::MonoJavaBridge.MethodId _getPrimaryHorizontal7725;
		public virtual float getPrimaryHorizontal(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getPrimaryHorizontal7725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getPrimaryHorizontal7725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSecondaryHorizontal7726;
		public virtual float getSecondaryHorizontal(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getSecondaryHorizontal7726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getSecondaryHorizontal7726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineLeft7727;
		public virtual float getLineLeft(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getLineLeft7727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineLeft7727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineRight7728;
		public virtual float getLineRight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getLineRight7728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineRight7728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineMax7729;
		public virtual float getLineMax(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getLineMax7729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineMax7729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineForVertical7730;
		public virtual int getLineForVertical(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineForVertical7730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineForVertical7730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineForOffset7731;
		public virtual int getLineForOffset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineForOffset7731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineForOffset7731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOffsetForHorizontal7732;
		public virtual int getOffsetForHorizontal(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getOffsetForHorizontal7732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getOffsetForHorizontal7732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLineEnd7733;
		public virtual int getLineEnd(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineEnd7733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineEnd7733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineVisibleEnd7734;
		public virtual int getLineVisibleEnd(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineVisibleEnd7734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineVisibleEnd7734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineBottom7735;
		public virtual int getLineBottom(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineBottom7735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineBottom7735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineBaseline7736;
		public virtual int getLineBaseline(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineBaseline7736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineBaseline7736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineAscent7737;
		public virtual int getLineAscent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineAscent7737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineAscent7737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOffsetToLeftOf7738;
		public virtual int getOffsetToLeftOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getOffsetToLeftOf7738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getOffsetToLeftOf7738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOffsetToRightOf7739;
		public virtual int getOffsetToRightOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getOffsetToRightOf7739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getOffsetToRightOf7739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCursorPath7740;
		public virtual void getCursorPath(int arg0, android.graphics.Path arg1, java.lang.CharSequence arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._getCursorPath7740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getCursorPath7740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void getCursorPath(int arg0, android.graphics.Path arg1, string arg2)
		{
			getCursorPath(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2);
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionPath7741;
		public virtual void getSelectionPath(int arg0, int arg1, android.graphics.Path arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._getSelectionPath7741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getSelectionPath7741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphAlignment7742;
		public virtual global::android.text.Layout.Alignment getParagraphAlignment(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout._getParagraphAlignment7742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Alignment;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getParagraphAlignment7742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Alignment;
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphLeft7743;
		public virtual int getParagraphLeft(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getParagraphLeft7743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getParagraphLeft7743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphRight7744;
		public virtual int getParagraphRight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getParagraphRight7744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getParagraphRight7744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpanned7745;
		protected virtual bool isSpanned() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.Layout._isSpanned7745);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._isSpanned7745);
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisStart7746;
		public abstract int getEllipsisStart(int arg0);
		internal static global::MonoJavaBridge.MethodId _getEllipsisCount7747;
		public abstract int getEllipsisCount(int arg0);
		internal static global::MonoJavaBridge.MethodId _Layout7748;
		protected Layout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.Layout.staticClass, global::android.text.Layout._Layout7748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Layout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Layout"));
			global::android.text.Layout._getLineWidth7701 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineWidth", "(I)F");
			global::android.text.Layout._getText7702 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getText", "()Ljava/lang/CharSequence;");
			global::android.text.Layout._draw7703 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.text.Layout._draw7704 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Path;Landroid/graphics/Paint;I)V");
			global::android.text.Layout._getWidth7705 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getWidth", "()I");
			global::android.text.Layout._getHeight7706 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getHeight", "()I");
			global::android.text.Layout._getPaint7707 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getPaint", "()Landroid/text/TextPaint;");
			global::android.text.Layout._getLineCount7708 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineCount", "()I");
			global::android.text.Layout._getLineBounds7709 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineBounds", "(ILandroid/graphics/Rect;)I");
			global::android.text.Layout._getDesiredWidth7710 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.staticClass, "getDesiredWidth", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;)F");
			global::android.text.Layout._getDesiredWidth7711 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.staticClass, "getDesiredWidth", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;)F");
			global::android.text.Layout._getEllipsizedWidth7712 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getEllipsizedWidth", "()I");
			global::android.text.Layout._increaseWidthTo7713 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "increaseWidthTo", "(I)V");
			global::android.text.Layout._getAlignment7714 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getAlignment", "()Landroid/text/Layout$Alignment;");
			global::android.text.Layout._getSpacingMultiplier7715 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getSpacingMultiplier", "()F");
			global::android.text.Layout._getSpacingAdd7716 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getSpacingAdd", "()F");
			global::android.text.Layout._getLineTop7717 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineTop", "(I)I");
			global::android.text.Layout._getLineDescent7718 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineDescent", "(I)I");
			global::android.text.Layout._getLineStart7719 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineStart", "(I)I");
			global::android.text.Layout._getParagraphDirection7720 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getParagraphDirection", "(I)I");
			global::android.text.Layout._getLineContainsTab7721 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineContainsTab", "(I)Z");
			global::android.text.Layout._getLineDirections7722 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;");
			global::android.text.Layout._getTopPadding7723 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getTopPadding", "()I");
			global::android.text.Layout._getBottomPadding7724 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getBottomPadding", "()I");
			global::android.text.Layout._getPrimaryHorizontal7725 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getPrimaryHorizontal", "(I)F");
			global::android.text.Layout._getSecondaryHorizontal7726 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getSecondaryHorizontal", "(I)F");
			global::android.text.Layout._getLineLeft7727 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineLeft", "(I)F");
			global::android.text.Layout._getLineRight7728 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineRight", "(I)F");
			global::android.text.Layout._getLineMax7729 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineMax", "(I)F");
			global::android.text.Layout._getLineForVertical7730 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineForVertical", "(I)I");
			global::android.text.Layout._getLineForOffset7731 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineForOffset", "(I)I");
			global::android.text.Layout._getOffsetForHorizontal7732 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getOffsetForHorizontal", "(IF)I");
			global::android.text.Layout._getLineEnd7733 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineEnd", "(I)I");
			global::android.text.Layout._getLineVisibleEnd7734 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineVisibleEnd", "(I)I");
			global::android.text.Layout._getLineBottom7735 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineBottom", "(I)I");
			global::android.text.Layout._getLineBaseline7736 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineBaseline", "(I)I");
			global::android.text.Layout._getLineAscent7737 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineAscent", "(I)I");
			global::android.text.Layout._getOffsetToLeftOf7738 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getOffsetToLeftOf", "(I)I");
			global::android.text.Layout._getOffsetToRightOf7739 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getOffsetToRightOf", "(I)I");
			global::android.text.Layout._getCursorPath7740 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getCursorPath", "(ILandroid/graphics/Path;Ljava/lang/CharSequence;)V");
			global::android.text.Layout._getSelectionPath7741 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getSelectionPath", "(IILandroid/graphics/Path;)V");
			global::android.text.Layout._getParagraphAlignment7742 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getParagraphAlignment", "(I)Landroid/text/Layout$Alignment;");
			global::android.text.Layout._getParagraphLeft7743 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getParagraphLeft", "(I)I");
			global::android.text.Layout._getParagraphRight7744 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getParagraphRight", "(I)I");
			global::android.text.Layout._isSpanned7745 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "isSpanned", "()Z");
			global::android.text.Layout._getEllipsisStart7746 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getEllipsisStart", "(I)I");
			global::android.text.Layout._getEllipsisCount7747 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getEllipsisCount", "(I)I");
			global::android.text.Layout._Layout7748 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FF)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.Layout))]
	public sealed partial class Layout_ : android.text.Layout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Layout_()
		{
			InitJNI();
		}
		internal Layout_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLineCount7749;
		public override int getLineCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getLineCount7749);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineCount7749);
		}
		internal static global::MonoJavaBridge.MethodId _getLineTop7750;
		public override int getLineTop(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getLineTop7750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineTop7750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDescent7751;
		public override int getLineDescent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getLineDescent7751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineDescent7751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineStart7752;
		public override int getLineStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getLineStart7752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineStart7752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphDirection7753;
		public override int getParagraphDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getParagraphDirection7753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getParagraphDirection7753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineContainsTab7754;
		public override bool getLineContainsTab(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.Layout_._getLineContainsTab7754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineContainsTab7754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDirections7755;
		public override global::android.text.Layout.Directions getLineDirections(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout_._getLineDirections7755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineDirections7755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
		}
		internal static global::MonoJavaBridge.MethodId _getTopPadding7756;
		public override int getTopPadding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getTopPadding7756);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getTopPadding7756);
		}
		internal static global::MonoJavaBridge.MethodId _getBottomPadding7757;
		public override int getBottomPadding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getBottomPadding7757);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getBottomPadding7757);
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisStart7758;
		public override int getEllipsisStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getEllipsisStart7758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getEllipsisStart7758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisCount7759;
		public override int getEllipsisCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getEllipsisCount7759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getEllipsisCount7759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Layout_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Layout"));
			global::android.text.Layout_._getLineCount7749 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineCount", "()I");
			global::android.text.Layout_._getLineTop7750 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineTop", "(I)I");
			global::android.text.Layout_._getLineDescent7751 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineDescent", "(I)I");
			global::android.text.Layout_._getLineStart7752 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineStart", "(I)I");
			global::android.text.Layout_._getParagraphDirection7753 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getParagraphDirection", "(I)I");
			global::android.text.Layout_._getLineContainsTab7754 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineContainsTab", "(I)Z");
			global::android.text.Layout_._getLineDirections7755 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;");
			global::android.text.Layout_._getTopPadding7756 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getTopPadding", "()I");
			global::android.text.Layout_._getBottomPadding7757 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getBottomPadding", "()I");
			global::android.text.Layout_._getEllipsisStart7758 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getEllipsisStart", "(I)I");
			global::android.text.Layout_._getEllipsisCount7759 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getEllipsisCount", "(I)I");
		}
	}
}
