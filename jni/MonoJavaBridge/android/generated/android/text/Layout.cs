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
			internal static global::MonoJavaBridge.MethodId _values12760;
			public static global::android.text.Layout.Alignment[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.Layout.Alignment>(@__env.CallStaticObjectMethod(android.text.Layout.Alignment.staticClass, global::android.text.Layout.Alignment._values12760)) as android.text.Layout.Alignment[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf12761;
			public static global::android.text.Layout.Alignment valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.CallStaticObjectMethod(android.text.Layout.Alignment.staticClass, global::android.text.Layout.Alignment._valueOf12761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Alignment;
			}
			internal static global::MonoJavaBridge.FieldId _ALIGN_CENTER12762;
			public static global::android.text.Layout.Alignment ALIGN_CENTER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.GetStaticObjectField(global::android.text.Layout.Alignment.staticClass, _ALIGN_CENTER12762)) as android.text.Layout.Alignment;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ALIGN_NORMAL12763;
			public static global::android.text.Layout.Alignment ALIGN_NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.GetStaticObjectField(global::android.text.Layout.Alignment.staticClass, _ALIGN_NORMAL12763)) as android.text.Layout.Alignment;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ALIGN_OPPOSITE12764;
			public static global::android.text.Layout.Alignment ALIGN_OPPOSITE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.GetStaticObjectField(global::android.text.Layout.Alignment.staticClass, _ALIGN_OPPOSITE12764)) as android.text.Layout.Alignment;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.Layout.Alignment.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Layout$Alignment"));
				global::android.text.Layout.Alignment._values12760 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.Alignment.staticClass, "values", "()[Landroid/text/Layout/Alignment;");
				global::android.text.Layout.Alignment._valueOf12761 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.Alignment.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/text/Layout$Alignment;");
				global::android.text.Layout.Alignment._ALIGN_CENTER12762 = @__env.GetStaticFieldIDNoThrow(global::android.text.Layout.Alignment.staticClass, "ALIGN_CENTER", "Landroid/text/Layout$Alignment;");
				global::android.text.Layout.Alignment._ALIGN_NORMAL12763 = @__env.GetStaticFieldIDNoThrow(global::android.text.Layout.Alignment.staticClass, "ALIGN_NORMAL", "Landroid/text/Layout$Alignment;");
				global::android.text.Layout.Alignment._ALIGN_OPPOSITE12764 = @__env.GetStaticFieldIDNoThrow(global::android.text.Layout.Alignment.staticClass, "ALIGN_OPPOSITE", "Landroid/text/Layout$Alignment;");
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
		internal static global::MonoJavaBridge.MethodId _getLineWidth12765;
		public virtual float getLineWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getLineWidth12765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineWidth12765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getText12766;
		public virtual global::java.lang.CharSequence getText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout._getText12766)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getText12766)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _draw12767;
		public virtual void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._draw12767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._draw12767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _draw12768;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Path arg1, android.graphics.Paint arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._draw12768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._draw12768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getWidth12769;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getWidth12769);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getWidth12769);
		}
		internal static global::MonoJavaBridge.MethodId _getHeight12770;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getHeight12770);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getHeight12770);
		}
		internal static global::MonoJavaBridge.MethodId _getPaint12771;
		public virtual global::android.text.TextPaint getPaint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout._getPaint12771)) as android.text.TextPaint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getPaint12771)) as android.text.TextPaint;
		}
		internal static global::MonoJavaBridge.MethodId _getLineCount12772;
		public abstract int getLineCount();
		internal static global::MonoJavaBridge.MethodId _getLineBounds12773;
		public virtual int getLineBounds(int arg0, android.graphics.Rect arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineBounds12773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineBounds12773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDesiredWidth12774;
		public static float getDesiredWidth(java.lang.CharSequence arg0, int arg1, int arg2, android.text.TextPaint arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.text.Layout.staticClass, global::android.text.Layout._getDesiredWidth12774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getDesiredWidth12775;
		public static float getDesiredWidth(java.lang.CharSequence arg0, android.text.TextPaint arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.text.Layout.staticClass, global::android.text.Layout._getDesiredWidth12775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsizedWidth12776;
		public virtual int getEllipsizedWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getEllipsizedWidth12776);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getEllipsizedWidth12776);
		}
		internal static global::MonoJavaBridge.MethodId _increaseWidthTo12777;
		public virtual void increaseWidthTo(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._increaseWidthTo12777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._increaseWidthTo12777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAlignment12778;
		public virtual global::android.text.Layout.Alignment getAlignment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout._getAlignment12778)) as android.text.Layout.Alignment;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getAlignment12778)) as android.text.Layout.Alignment;
		}
		internal static global::MonoJavaBridge.MethodId _getSpacingMultiplier12779;
		public virtual float getSpacingMultiplier() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getSpacingMultiplier12779);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getSpacingMultiplier12779);
		}
		internal static global::MonoJavaBridge.MethodId _getSpacingAdd12780;
		public virtual float getSpacingAdd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getSpacingAdd12780);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getSpacingAdd12780);
		}
		internal static global::MonoJavaBridge.MethodId _getLineTop12781;
		public abstract int getLineTop(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLineDescent12782;
		public abstract int getLineDescent(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLineStart12783;
		public abstract int getLineStart(int arg0);
		internal static global::MonoJavaBridge.MethodId _getParagraphDirection12784;
		public abstract int getParagraphDirection(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLineContainsTab12785;
		public abstract bool getLineContainsTab(int arg0);
		internal static global::MonoJavaBridge.MethodId _getLineDirections12786;
		public abstract global::android.text.Layout.Directions getLineDirections(int arg0);
		internal static global::MonoJavaBridge.MethodId _getTopPadding12787;
		public abstract int getTopPadding();
		internal static global::MonoJavaBridge.MethodId _getBottomPadding12788;
		public abstract int getBottomPadding();
		internal static global::MonoJavaBridge.MethodId _getPrimaryHorizontal12789;
		public virtual float getPrimaryHorizontal(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getPrimaryHorizontal12789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getPrimaryHorizontal12789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSecondaryHorizontal12790;
		public virtual float getSecondaryHorizontal(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getSecondaryHorizontal12790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getSecondaryHorizontal12790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineLeft12791;
		public virtual float getLineLeft(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getLineLeft12791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineLeft12791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineRight12792;
		public virtual float getLineRight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getLineRight12792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineRight12792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineMax12793;
		public virtual float getLineMax(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.Layout._getLineMax12793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineMax12793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineForVertical12794;
		public virtual int getLineForVertical(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineForVertical12794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineForVertical12794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineForOffset12795;
		public virtual int getLineForOffset(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineForOffset12795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineForOffset12795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOffsetForHorizontal12796;
		public virtual int getOffsetForHorizontal(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getOffsetForHorizontal12796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getOffsetForHorizontal12796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLineEnd12797;
		public virtual int getLineEnd(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineEnd12797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineEnd12797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineVisibleEnd12798;
		public virtual int getLineVisibleEnd(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineVisibleEnd12798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineVisibleEnd12798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineBottom12799;
		public virtual int getLineBottom(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineBottom12799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineBottom12799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineBaseline12800;
		public virtual int getLineBaseline(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineBaseline12800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineBaseline12800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineAscent12801;
		public virtual int getLineAscent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getLineAscent12801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getLineAscent12801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOffsetToLeftOf12802;
		public virtual int getOffsetToLeftOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getOffsetToLeftOf12802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getOffsetToLeftOf12802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOffsetToRightOf12803;
		public virtual int getOffsetToRightOf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getOffsetToRightOf12803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getOffsetToRightOf12803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCursorPath12804;
		public virtual void getCursorPath(int arg0, android.graphics.Path arg1, java.lang.CharSequence arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._getCursorPath12804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getCursorPath12804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void getCursorPath(int arg0, android.graphics.Path arg1, string arg2)
		{
			getCursorPath(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2);
		}
		internal static global::MonoJavaBridge.MethodId _getSelectionPath12805;
		public virtual void getSelectionPath(int arg0, int arg1, android.graphics.Path arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Layout._getSelectionPath12805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getSelectionPath12805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphAlignment12806;
		public virtual global::android.text.Layout.Alignment getParagraphAlignment(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout._getParagraphAlignment12806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Alignment;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getParagraphAlignment12806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Alignment;
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphLeft12807;
		public virtual int getParagraphLeft(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getParagraphLeft12807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getParagraphLeft12807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphRight12808;
		public virtual int getParagraphRight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout._getParagraphRight12808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._getParagraphRight12808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpanned12809;
		protected virtual bool isSpanned() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.Layout._isSpanned12809);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.Layout.staticClass, global::android.text.Layout._isSpanned12809);
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisStart12810;
		public abstract int getEllipsisStart(int arg0);
		internal static global::MonoJavaBridge.MethodId _getEllipsisCount12811;
		public abstract int getEllipsisCount(int arg0);
		internal static global::MonoJavaBridge.MethodId _Layout12812;
		protected Layout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.Layout.staticClass, global::android.text.Layout._Layout12812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
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
			global::android.text.Layout._getLineWidth12765 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineWidth", "(I)F");
			global::android.text.Layout._getText12766 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getText", "()Ljava/lang/CharSequence;");
			global::android.text.Layout._draw12767 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.text.Layout._draw12768 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Path;Landroid/graphics/Paint;I)V");
			global::android.text.Layout._getWidth12769 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getWidth", "()I");
			global::android.text.Layout._getHeight12770 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getHeight", "()I");
			global::android.text.Layout._getPaint12771 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getPaint", "()Landroid/text/TextPaint;");
			global::android.text.Layout._getLineCount12772 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineCount", "()I");
			global::android.text.Layout._getLineBounds12773 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineBounds", "(ILandroid/graphics/Rect;)I");
			global::android.text.Layout._getDesiredWidth12774 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.staticClass, "getDesiredWidth", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;)F");
			global::android.text.Layout._getDesiredWidth12775 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.staticClass, "getDesiredWidth", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;)F");
			global::android.text.Layout._getEllipsizedWidth12776 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getEllipsizedWidth", "()I");
			global::android.text.Layout._increaseWidthTo12777 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "increaseWidthTo", "(I)V");
			global::android.text.Layout._getAlignment12778 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getAlignment", "()Landroid/text/Layout$Alignment;");
			global::android.text.Layout._getSpacingMultiplier12779 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getSpacingMultiplier", "()F");
			global::android.text.Layout._getSpacingAdd12780 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getSpacingAdd", "()F");
			global::android.text.Layout._getLineTop12781 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineTop", "(I)I");
			global::android.text.Layout._getLineDescent12782 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineDescent", "(I)I");
			global::android.text.Layout._getLineStart12783 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineStart", "(I)I");
			global::android.text.Layout._getParagraphDirection12784 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getParagraphDirection", "(I)I");
			global::android.text.Layout._getLineContainsTab12785 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineContainsTab", "(I)Z");
			global::android.text.Layout._getLineDirections12786 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;");
			global::android.text.Layout._getTopPadding12787 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getTopPadding", "()I");
			global::android.text.Layout._getBottomPadding12788 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getBottomPadding", "()I");
			global::android.text.Layout._getPrimaryHorizontal12789 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getPrimaryHorizontal", "(I)F");
			global::android.text.Layout._getSecondaryHorizontal12790 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getSecondaryHorizontal", "(I)F");
			global::android.text.Layout._getLineLeft12791 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineLeft", "(I)F");
			global::android.text.Layout._getLineRight12792 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineRight", "(I)F");
			global::android.text.Layout._getLineMax12793 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineMax", "(I)F");
			global::android.text.Layout._getLineForVertical12794 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineForVertical", "(I)I");
			global::android.text.Layout._getLineForOffset12795 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineForOffset", "(I)I");
			global::android.text.Layout._getOffsetForHorizontal12796 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getOffsetForHorizontal", "(IF)I");
			global::android.text.Layout._getLineEnd12797 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineEnd", "(I)I");
			global::android.text.Layout._getLineVisibleEnd12798 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineVisibleEnd", "(I)I");
			global::android.text.Layout._getLineBottom12799 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineBottom", "(I)I");
			global::android.text.Layout._getLineBaseline12800 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineBaseline", "(I)I");
			global::android.text.Layout._getLineAscent12801 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getLineAscent", "(I)I");
			global::android.text.Layout._getOffsetToLeftOf12802 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getOffsetToLeftOf", "(I)I");
			global::android.text.Layout._getOffsetToRightOf12803 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getOffsetToRightOf", "(I)I");
			global::android.text.Layout._getCursorPath12804 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getCursorPath", "(ILandroid/graphics/Path;Ljava/lang/CharSequence;)V");
			global::android.text.Layout._getSelectionPath12805 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getSelectionPath", "(IILandroid/graphics/Path;)V");
			global::android.text.Layout._getParagraphAlignment12806 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getParagraphAlignment", "(I)Landroid/text/Layout$Alignment;");
			global::android.text.Layout._getParagraphLeft12807 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getParagraphLeft", "(I)I");
			global::android.text.Layout._getParagraphRight12808 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getParagraphRight", "(I)I");
			global::android.text.Layout._isSpanned12809 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "isSpanned", "()Z");
			global::android.text.Layout._getEllipsisStart12810 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getEllipsisStart", "(I)I");
			global::android.text.Layout._getEllipsisCount12811 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "getEllipsisCount", "(I)I");
			global::android.text.Layout._Layout12812 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FF)V");
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
		internal static global::MonoJavaBridge.MethodId _getLineCount12815;
		public override int getLineCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getLineCount12815);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineCount12815);
		}
		internal static global::MonoJavaBridge.MethodId _getLineTop12816;
		public override int getLineTop(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getLineTop12816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineTop12816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDescent12817;
		public override int getLineDescent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getLineDescent12817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineDescent12817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineStart12818;
		public override int getLineStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getLineStart12818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineStart12818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphDirection12819;
		public override int getParagraphDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getParagraphDirection12819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getParagraphDirection12819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineContainsTab12820;
		public override bool getLineContainsTab(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.Layout_._getLineContainsTab12820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineContainsTab12820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDirections12821;
		public override global::android.text.Layout.Directions getLineDirections(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Layout_._getLineDirections12821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getLineDirections12821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
		}
		internal static global::MonoJavaBridge.MethodId _getTopPadding12822;
		public override int getTopPadding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getTopPadding12822);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getTopPadding12822);
		}
		internal static global::MonoJavaBridge.MethodId _getBottomPadding12823;
		public override int getBottomPadding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getBottomPadding12823);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getBottomPadding12823);
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisStart12824;
		public override int getEllipsisStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getEllipsisStart12824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getEllipsisStart12824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisCount12825;
		public override int getEllipsisCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Layout_._getEllipsisCount12825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Layout_.staticClass, global::android.text.Layout_._getEllipsisCount12825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Layout_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Layout"));
			global::android.text.Layout_._getLineCount12815 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineCount", "()I");
			global::android.text.Layout_._getLineTop12816 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineTop", "(I)I");
			global::android.text.Layout_._getLineDescent12817 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineDescent", "(I)I");
			global::android.text.Layout_._getLineStart12818 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineStart", "(I)I");
			global::android.text.Layout_._getParagraphDirection12819 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getParagraphDirection", "(I)I");
			global::android.text.Layout_._getLineContainsTab12820 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineContainsTab", "(I)Z");
			global::android.text.Layout_._getLineDirections12821 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;");
			global::android.text.Layout_._getTopPadding12822 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getTopPadding", "()I");
			global::android.text.Layout_._getBottomPadding12823 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getBottomPadding", "()I");
			global::android.text.Layout_._getEllipsisStart12824 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getEllipsisStart", "(I)I");
			global::android.text.Layout_._getEllipsisCount12825 = @__env.GetMethodIDNoThrow(global::android.text.Layout_.staticClass, "getEllipsisCount", "(I)I");
		}
	}
}
