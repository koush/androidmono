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
			internal static global::MonoJavaBridge.MethodId _values8242;
			public static global::android.text.Layout.Alignment[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.Layout.Alignment>(@__env.CallStaticObjectMethod(android.text.Layout.Alignment.staticClass, global::android.text.Layout.Alignment._values8242)) as android.text.Layout.Alignment[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf8243;
			public static global::android.text.Layout.Alignment valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.Layout.Alignment.staticClass, global::android.text.Layout.Alignment._valueOf8243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Alignment;
			}
			internal static global::MonoJavaBridge.FieldId _ALIGN_CENTER8244;
			public static global::android.text.Layout.Alignment ALIGN_CENTER
			{
				get
				{
					return default(global::android.text.Layout.Alignment);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ALIGN_NORMAL8245;
			public static global::android.text.Layout.Alignment ALIGN_NORMAL
			{
				get
				{
					return default(global::android.text.Layout.Alignment);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ALIGN_OPPOSITE8246;
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
				global::android.text.Layout.Alignment._values8242 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.Alignment.staticClass, "values", "()[Landroid/text/Layout/Alignment;");
				global::android.text.Layout.Alignment._valueOf8243 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.Alignment.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/text/Layout$Alignment;");
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
		internal static global::MonoJavaBridge.MethodId _getLineWidth8247;
		public virtual float getLineWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getLineWidth8247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineWidth8247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getText8248;
		public virtual global::java.lang.CharSequence getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout._getText8248)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getText8248)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _draw8249;
		public virtual void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._draw8249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._draw8249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _draw8250;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Path arg1, android.graphics.Paint arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._draw8250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._draw8250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getWidth8251;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getWidth8251);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getWidth8251);
		}
		internal static global::MonoJavaBridge.MethodId _getHeight8252;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getHeight8252);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getHeight8252);
		}
		internal static global::MonoJavaBridge.MethodId _getPaint8253;
		public virtual global::android.text.TextPaint getPaint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout._getPaint8253)) as android.text.TextPaint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getPaint8253)) as android.text.TextPaint;
		}
		internal static global::MonoJavaBridge.MethodId _getLineCount8254;
		public abstract int getLineCount();
		internal static global::MonoJavaBridge.MethodId _getLineBounds8255;
		public virtual int getLineBounds(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineBounds8255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineBounds8255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDesiredWidth8256;
		public static float getDesiredWidth(java.lang.CharSequence arg0, int arg1, int arg2, android.text.TextPaint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.text.Layout.staticClass, global::android.text.Layout._getDesiredWidth8256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getDesiredWidth8257;
		public static float getDesiredWidth(java.lang.CharSequence arg0, android.text.TextPaint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.text.Layout.staticClass, global::android.text.Layout._getDesiredWidth8257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsizedWidth8258;
		public virtual int getEllipsizedWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getEllipsizedWidth8258);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getEllipsizedWidth8258);
		}
		internal static global::MonoJavaBridge.MethodId _increaseWidthTo8259;
		public virtual void increaseWidthTo(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._increaseWidthTo8259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._increaseWidthTo8259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAlignment8260;
		public virtual global::android.text.Layout.Alignment getAlignment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout._getAlignment8260)) as android.text.Layout.Alignment;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getAlignment8260)) as android.text.Layout.Alignment;
		}
		internal static global::MonoJavaBridge.MethodId _getSpacingMultiplier8261;
		public virtual float getSpacingMultiplier() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getSpacingMultiplier8261);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getSpacingMultiplier8261);
		}
		internal static global::MonoJavaBridge.MethodId _getSpacingAdd8262;
		public virtual float getSpacingAdd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getSpacingAdd8262);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getSpacingAdd8262);
		}
		internal static global::MonoJavaBridge.MethodId _getLineTop8263;
		public abstract int getLineTop(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLineDescent8264;
		public abstract int getLineDescent(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLineStart8265;
		public abstract int getLineStart(int arg0);
		internal static global::MonoJavaBridge.MethodId _getParagraphDirection8266;
		public abstract int getParagraphDirection(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLineContainsTab8267;
		public abstract bool getLineContainsTab(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLineDirections8268;
		public abstract global::android.text.Layout.Directions getLineDirections(int arg0);
		internal static global::MonoJavaBridge.MethodId _getTopPadding8269;
		public abstract int getTopPadding();
		internal static global::MonoJavaBridge.MethodId _getBottomPadding8270;
		public abstract int getBottomPadding();
		internal static global::MonoJavaBridge.MethodId _getPrimaryHorizontal8271;
		public virtual float getPrimaryHorizontal(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getPrimaryHorizontal8271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getPrimaryHorizontal8271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSecondaryHorizontal8272;
		public virtual float getSecondaryHorizontal(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getSecondaryHorizontal8272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getSecondaryHorizontal8272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineLeft8273;
		public virtual float getLineLeft(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getLineLeft8273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineLeft8273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineRight8274;
		public virtual float getLineRight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getLineRight8274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineRight8274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineMax8275;
		public virtual float getLineMax(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getLineMax8275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineMax8275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineForVertical8276;
		public virtual int getLineForVertical(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineForVertical8276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineForVertical8276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineForOffset8277;
		public virtual int getLineForOffset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineForOffset8277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineForOffset8277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOffsetForHorizontal8278;
		public virtual int getOffsetForHorizontal(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getOffsetForHorizontal8278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getOffsetForHorizontal8278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLineEnd8279;
		public virtual int getLineEnd(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineEnd8279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineEnd8279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineVisibleEnd8280;
		public virtual int getLineVisibleEnd(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineVisibleEnd8280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineVisibleEnd8280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineBottom8281;
		public virtual int getLineBottom(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineBottom8281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineBottom8281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineBaseline8282;
		public virtual int getLineBaseline(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineBaseline8282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineBaseline8282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineAscent8283;
		public virtual int getLineAscent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineAscent8283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineAscent8283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOffsetToLeftOf8284;
		public virtual int getOffsetToLeftOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getOffsetToLeftOf8284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getOffsetToLeftOf8284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOffsetToRightOf8285;
		public virtual int getOffsetToRightOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getOffsetToRightOf8285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getOffsetToRightOf8285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCursorPath8286;
		public virtual void getCursorPath(int arg0, android.graphics.Path arg1, java.lang.CharSequence arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._getCursorPath8286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getCursorPath8286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void getCursorPath(int arg0, android.graphics.Path arg1, string arg2)
		{
			getCursorPath(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2);
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionPath8287;
		public virtual void getSelectionPath(int arg0, int arg1, android.graphics.Path arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._getSelectionPath8287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getSelectionPath8287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphAlignment8288;
		public virtual global::android.text.Layout.Alignment getParagraphAlignment(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout._getParagraphAlignment8288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Alignment;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getParagraphAlignment8288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Alignment;
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphLeft8289;
		public virtual int getParagraphLeft(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getParagraphLeft8289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getParagraphLeft8289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphRight8290;
		public virtual int getParagraphRight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getParagraphRight8290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getParagraphRight8290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpanned8291;
		protected virtual bool isSpanned() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.Layout._isSpanned8291);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._isSpanned8291);
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisStart8292;
		public abstract int getEllipsisStart(int arg0);
		internal static global::MonoJavaBridge.MethodId _getEllipsisCount8293;
		public abstract int getEllipsisCount(int arg0);
		internal static global::MonoJavaBridge.MethodId _Layout8294;
		protected Layout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.Layout.staticClass, global::android.text.Layout._Layout8294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
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
			global::android.text.Layout._getLineWidth8247 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineWidth", "(I)F");
			global::android.text.Layout._getText8248 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getText", "()Ljava/lang/CharSequence;");
			global::android.text.Layout._draw8249 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.text.Layout._draw8250 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Path;Landroid/graphics/Paint;I)V");
			global::android.text.Layout._getWidth8251 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getWidth", "()I");
			global::android.text.Layout._getHeight8252 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getHeight", "()I");
			global::android.text.Layout._getPaint8253 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getPaint", "()Landroid/text/TextPaint;");
			global::android.text.Layout._getLineCount8254 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineCount", "()I");
			global::android.text.Layout._getLineBounds8255 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineBounds", "(ILandroid/graphics/Rect;)I");
			global::android.text.Layout._getDesiredWidth8256 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.staticClass, "getDesiredWidth", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;)F");
			global::android.text.Layout._getDesiredWidth8257 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.staticClass, "getDesiredWidth", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;)F");
			global::android.text.Layout._getEllipsizedWidth8258 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getEllipsizedWidth", "()I");
			global::android.text.Layout._increaseWidthTo8259 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "increaseWidthTo", "(I)V");
			global::android.text.Layout._getAlignment8260 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getAlignment", "()Landroid/text/Layout$Alignment;");
			global::android.text.Layout._getSpacingMultiplier8261 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getSpacingMultiplier", "()F");
			global::android.text.Layout._getSpacingAdd8262 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getSpacingAdd", "()F");
			global::android.text.Layout._getLineTop8263 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineTop", "(I)I");
			global::android.text.Layout._getLineDescent8264 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineDescent", "(I)I");
			global::android.text.Layout._getLineStart8265 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineStart", "(I)I");
			global::android.text.Layout._getParagraphDirection8266 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getParagraphDirection", "(I)I");
			global::android.text.Layout._getLineContainsTab8267 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineContainsTab", "(I)Z");
			global::android.text.Layout._getLineDirections8268 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;");
			global::android.text.Layout._getTopPadding8269 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getTopPadding", "()I");
			global::android.text.Layout._getBottomPadding8270 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getBottomPadding", "()I");
			global::android.text.Layout._getPrimaryHorizontal8271 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getPrimaryHorizontal", "(I)F");
			global::android.text.Layout._getSecondaryHorizontal8272 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getSecondaryHorizontal", "(I)F");
			global::android.text.Layout._getLineLeft8273 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineLeft", "(I)F");
			global::android.text.Layout._getLineRight8274 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineRight", "(I)F");
			global::android.text.Layout._getLineMax8275 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineMax", "(I)F");
			global::android.text.Layout._getLineForVertical8276 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineForVertical", "(I)I");
			global::android.text.Layout._getLineForOffset8277 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineForOffset", "(I)I");
			global::android.text.Layout._getOffsetForHorizontal8278 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getOffsetForHorizontal", "(IF)I");
			global::android.text.Layout._getLineEnd8279 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineEnd", "(I)I");
			global::android.text.Layout._getLineVisibleEnd8280 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineVisibleEnd", "(I)I");
			global::android.text.Layout._getLineBottom8281 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineBottom", "(I)I");
			global::android.text.Layout._getLineBaseline8282 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineBaseline", "(I)I");
			global::android.text.Layout._getLineAscent8283 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineAscent", "(I)I");
			global::android.text.Layout._getOffsetToLeftOf8284 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getOffsetToLeftOf", "(I)I");
			global::android.text.Layout._getOffsetToRightOf8285 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getOffsetToRightOf", "(I)I");
			global::android.text.Layout._getCursorPath8286 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getCursorPath", "(ILandroid/graphics/Path;Ljava/lang/CharSequence;)V");
			global::android.text.Layout._getSelectionPath8287 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getSelectionPath", "(IILandroid/graphics/Path;)V");
			global::android.text.Layout._getParagraphAlignment8288 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getParagraphAlignment", "(I)Landroid/text/Layout$Alignment;");
			global::android.text.Layout._getParagraphLeft8289 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getParagraphLeft", "(I)I");
			global::android.text.Layout._getParagraphRight8290 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getParagraphRight", "(I)I");
			global::android.text.Layout._isSpanned8291 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "isSpanned", "()Z");
			global::android.text.Layout._getEllipsisStart8292 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getEllipsisStart", "(I)I");
			global::android.text.Layout._getEllipsisCount8293 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getEllipsisCount", "(I)I");
			global::android.text.Layout._Layout8294 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FF)V");
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
		internal static global::MonoJavaBridge.MethodId _getLineCount8295;
		public override int getLineCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getLineCount8295);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineCount8295);
		}
		internal static global::MonoJavaBridge.MethodId _getLineTop8296;
		public override int getLineTop(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getLineTop8296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineTop8296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDescent8297;
		public override int getLineDescent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getLineDescent8297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineDescent8297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineStart8298;
		public override int getLineStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getLineStart8298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineStart8298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphDirection8299;
		public override int getParagraphDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getParagraphDirection8299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getParagraphDirection8299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineContainsTab8300;
		public override bool getLineContainsTab(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.Layout_._getLineContainsTab8300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineContainsTab8300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDirections8301;
		public override global::android.text.Layout.Directions getLineDirections(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout_._getLineDirections8301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineDirections8301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
		}
		internal static global::MonoJavaBridge.MethodId _getTopPadding8302;
		public override int getTopPadding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getTopPadding8302);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getTopPadding8302);
		}
		internal static global::MonoJavaBridge.MethodId _getBottomPadding8303;
		public override int getBottomPadding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getBottomPadding8303);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getBottomPadding8303);
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisStart8304;
		public override int getEllipsisStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getEllipsisStart8304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getEllipsisStart8304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisCount8305;
		public override int getEllipsisCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getEllipsisCount8305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getEllipsisCount8305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Layout_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Layout"));
			global::android.text.Layout_._getLineCount8295 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineCount", "()I");
			global::android.text.Layout_._getLineTop8296 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineTop", "(I)I");
			global::android.text.Layout_._getLineDescent8297 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineDescent", "(I)I");
			global::android.text.Layout_._getLineStart8298 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineStart", "(I)I");
			global::android.text.Layout_._getParagraphDirection8299 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getParagraphDirection", "(I)I");
			global::android.text.Layout_._getLineContainsTab8300 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineContainsTab", "(I)Z");
			global::android.text.Layout_._getLineDirections8301 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;");
			global::android.text.Layout_._getTopPadding8302 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getTopPadding", "()I");
			global::android.text.Layout_._getBottomPadding8303 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getBottomPadding", "()I");
			global::android.text.Layout_._getEllipsisStart8304 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getEllipsisStart", "(I)I");
			global::android.text.Layout_._getEllipsisCount8305 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getEllipsisCount", "(I)I");
		}
	}
}
