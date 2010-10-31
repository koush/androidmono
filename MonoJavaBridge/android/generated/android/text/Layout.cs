namespace android.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.Layout_))]
	public abstract partial class Layout : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Layout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Alignment : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Alignment(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.text.Layout.Alignment[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.text.Layout.Alignment._m0.native == global::System.IntPtr.Zero)
					global::android.text.Layout.Alignment._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.Alignment.staticClass, "values", "()[Landroid/text/Layout/Alignment;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.Layout.Alignment>(@__env.CallStaticObjectMethod(android.text.Layout.Alignment.staticClass, global::android.text.Layout.Alignment._m0)) as android.text.Layout.Alignment[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.text.Layout.Alignment valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.text.Layout.Alignment._m1.native == global::System.IntPtr.Zero)
					global::android.text.Layout.Alignment._m1 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.Alignment.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/text/Layout$Alignment;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.CallStaticObjectMethod(android.text.Layout.Alignment.staticClass, global::android.text.Layout.Alignment._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Alignment;
			}
			internal static global::MonoJavaBridge.FieldId _ALIGN_CENTER5223;
			public static global::android.text.Layout.Alignment ALIGN_CENTER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.GetStaticObjectField(global::android.text.Layout.Alignment.staticClass, _ALIGN_CENTER5223)) as android.text.Layout.Alignment;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ALIGN_NORMAL5224;
			public static global::android.text.Layout.Alignment ALIGN_NORMAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.GetStaticObjectField(global::android.text.Layout.Alignment.staticClass, _ALIGN_NORMAL5224)) as android.text.Layout.Alignment;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ALIGN_OPPOSITE5225;
			public static global::android.text.Layout.Alignment ALIGN_OPPOSITE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.text.Layout.Alignment>(@__env.GetStaticObjectField(global::android.text.Layout.Alignment.staticClass, _ALIGN_OPPOSITE5225)) as android.text.Layout.Alignment;
				}
			}
			static Alignment()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.Layout.Alignment.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Layout$Alignment"));
				global::android.text.Layout.Alignment._ALIGN_CENTER5223 = @__env.GetStaticFieldIDNoThrow(global::android.text.Layout.Alignment.staticClass, "ALIGN_CENTER", "Landroid/text/Layout$Alignment;");
				global::android.text.Layout.Alignment._ALIGN_NORMAL5224 = @__env.GetStaticFieldIDNoThrow(global::android.text.Layout.Alignment.staticClass, "ALIGN_NORMAL", "Landroid/text/Layout$Alignment;");
				global::android.text.Layout.Alignment._ALIGN_OPPOSITE5225 = @__env.GetStaticFieldIDNoThrow(global::android.text.Layout.Alignment.staticClass, "ALIGN_OPPOSITE", "Landroid/text/Layout$Alignment;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Directions : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Directions(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			static Directions()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.Layout.Directions.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Layout$Directions"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual float getLineWidth(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.text.Layout.staticClass, "getLineWidth", "(I)F", ref global::android.text.Layout._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.CharSequence getText()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.text.Layout.staticClass, "getText", "()Ljava/lang/CharSequence;", ref global::android.text.Layout._m1) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Layout.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.text.Layout._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Path arg1, android.graphics.Paint arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Layout.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Path;Landroid/graphics/Paint;I)V", ref global::android.text.Layout._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout.staticClass, "getWidth", "()I", ref global::android.text.Layout._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout.staticClass, "getHeight", "()I", ref global::android.text.Layout._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::android.text.TextPaint getPaint()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.Layout.staticClass, "getPaint", "()Landroid/text/TextPaint;", ref global::android.text.Layout._m6) as android.text.TextPaint;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract int getLineCount();
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int getLineBounds(int arg0, android.graphics.Rect arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout.staticClass, "getLineBounds", "(ILandroid/graphics/Rect;)I", ref global::android.text.Layout._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static float getDesiredWidth(java.lang.CharSequence arg0, int arg1, int arg2, android.text.TextPaint arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Layout._m9.native == global::System.IntPtr.Zero)
				global::android.text.Layout._m9 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.staticClass, "getDesiredWidth", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;)F");
			return @__env.CallStaticFloatMethod(android.text.Layout.staticClass, global::android.text.Layout._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public static float getDesiredWidth(string arg0, int arg1, int arg2, android.text.TextPaint arg3)
		{
			return getDesiredWidth((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static float getDesiredWidth(java.lang.CharSequence arg0, android.text.TextPaint arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Layout._m10.native == global::System.IntPtr.Zero)
				global::android.text.Layout._m10 = @__env.GetStaticMethodIDNoThrow(global::android.text.Layout.staticClass, "getDesiredWidth", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;)F");
			return @__env.CallStaticFloatMethod(android.text.Layout.staticClass, global::android.text.Layout._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static float getDesiredWidth(string arg0, android.text.TextPaint arg1)
		{
			return getDesiredWidth((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getEllipsizedWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout.staticClass, "getEllipsizedWidth", "()I", ref global::android.text.Layout._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void increaseWidthTo(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Layout.staticClass, "increaseWidthTo", "(I)V", ref global::android.text.Layout._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::android.text.Layout.Alignment getAlignment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.text.Layout.Alignment>(this, global::android.text.Layout.staticClass, "getAlignment", "()Landroid/text/Layout$Alignment;", ref global::android.text.Layout._m13) as android.text.Layout.Alignment;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual float getSpacingMultiplier()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.text.Layout.staticClass, "getSpacingMultiplier", "()F", ref global::android.text.Layout._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual float getSpacingAdd()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.text.Layout.staticClass, "getSpacingAdd", "()F", ref global::android.text.Layout._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public abstract int getLineTop(int arg0);
		private static global::MonoJavaBridge.MethodId _m17;
		public abstract int getLineDescent(int arg0);
		private static global::MonoJavaBridge.MethodId _m18;
		public abstract int getLineStart(int arg0);
		private static global::MonoJavaBridge.MethodId _m19;
		public abstract int getParagraphDirection(int arg0);
		private static global::MonoJavaBridge.MethodId _m20;
		public abstract bool getLineContainsTab(int arg0);
		private static global::MonoJavaBridge.MethodId _m21;
		public abstract global::android.text.Layout.Directions getLineDirections(int arg0);
		private static global::MonoJavaBridge.MethodId _m22;
		public abstract int getTopPadding();
		private static global::MonoJavaBridge.MethodId _m23;
		public abstract int getBottomPadding();
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual float getPrimaryHorizontal(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.text.Layout.staticClass, "getPrimaryHorizontal", "(I)F", ref global::android.text.Layout._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual float getSecondaryHorizontal(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.text.Layout.staticClass, "getSecondaryHorizontal", "(I)F", ref global::android.text.Layout._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual float getLineLeft(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.text.Layout.staticClass, "getLineLeft", "(I)F", ref global::android.text.Layout._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual float getLineRight(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.text.Layout.staticClass, "getLineRight", "(I)F", ref global::android.text.Layout._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual float getLineMax(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.text.Layout.staticClass, "getLineMax", "(I)F", ref global::android.text.Layout._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual int getLineForVertical(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout.staticClass, "getLineForVertical", "(I)I", ref global::android.text.Layout._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual int getLineForOffset(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout.staticClass, "getLineForOffset", "(I)I", ref global::android.text.Layout._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual int getOffsetForHorizontal(int arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout.staticClass, "getOffsetForHorizontal", "(IF)I", ref global::android.text.Layout._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual int getLineEnd(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout.staticClass, "getLineEnd", "(I)I", ref global::android.text.Layout._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual int getLineVisibleEnd(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout.staticClass, "getLineVisibleEnd", "(I)I", ref global::android.text.Layout._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual int getLineBottom(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout.staticClass, "getLineBottom", "(I)I", ref global::android.text.Layout._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual int getLineBaseline(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout.staticClass, "getLineBaseline", "(I)I", ref global::android.text.Layout._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual int getLineAscent(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout.staticClass, "getLineAscent", "(I)I", ref global::android.text.Layout._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual int getOffsetToLeftOf(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout.staticClass, "getOffsetToLeftOf", "(I)I", ref global::android.text.Layout._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual int getOffsetToRightOf(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout.staticClass, "getOffsetToRightOf", "(I)I", ref global::android.text.Layout._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual void getCursorPath(int arg0, android.graphics.Path arg1, java.lang.CharSequence arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Layout.staticClass, "getCursorPath", "(ILandroid/graphics/Path;Ljava/lang/CharSequence;)V", ref global::android.text.Layout._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void getCursorPath(int arg0, android.graphics.Path arg1, string arg2)
		{
			getCursorPath(arg0, arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual void getSelectionPath(int arg0, int arg1, android.graphics.Path arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Layout.staticClass, "getSelectionPath", "(IILandroid/graphics/Path;)V", ref global::android.text.Layout._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual global::android.text.Layout.Alignment getParagraphAlignment(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.text.Layout.Alignment>(this, global::android.text.Layout.staticClass, "getParagraphAlignment", "(I)Landroid/text/Layout$Alignment;", ref global::android.text.Layout._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.text.Layout.Alignment;
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual int getParagraphLeft(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout.staticClass, "getParagraphLeft", "(I)I", ref global::android.text.Layout._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual int getParagraphRight(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout.staticClass, "getParagraphRight", "(I)I", ref global::android.text.Layout._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		protected virtual bool isSpanned()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.Layout.staticClass, "isSpanned", "()Z", ref global::android.text.Layout._m44);
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public abstract int getEllipsisStart(int arg0);
		private static global::MonoJavaBridge.MethodId _m46;
		public abstract int getEllipsisCount(int arg0);
		private static global::MonoJavaBridge.MethodId _m47;
		protected Layout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Layout._m47.native == global::System.IntPtr.Zero)
				global::android.text.Layout._m47 = @__env.GetMethodIDNoThrow(global::android.text.Layout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FF)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.Layout.staticClass, global::android.text.Layout._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
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
		static Layout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Layout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Layout"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.Layout))]
	internal sealed partial class Layout_ : android.text.Layout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Layout_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int getLineCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout_.staticClass, "getLineCount", "()I", ref global::android.text.Layout_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int getLineTop(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout_.staticClass, "getLineTop", "(I)I", ref global::android.text.Layout_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int getLineDescent(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout_.staticClass, "getLineDescent", "(I)I", ref global::android.text.Layout_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int getLineStart(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout_.staticClass, "getLineStart", "(I)I", ref global::android.text.Layout_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int getParagraphDirection(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout_.staticClass, "getParagraphDirection", "(I)I", ref global::android.text.Layout_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool getLineContainsTab(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.Layout_.staticClass, "getLineContainsTab", "(I)Z", ref global::android.text.Layout_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::android.text.Layout.Directions getLineDirections(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.Layout_.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;", ref global::android.text.Layout_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.text.Layout.Directions;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override int getTopPadding()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout_.staticClass, "getTopPadding", "()I", ref global::android.text.Layout_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override int getBottomPadding()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout_.staticClass, "getBottomPadding", "()I", ref global::android.text.Layout_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override int getEllipsisStart(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout_.staticClass, "getEllipsisStart", "(I)I", ref global::android.text.Layout_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override int getEllipsisCount(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Layout_.staticClass, "getEllipsisCount", "(I)I", ref global::android.text.Layout_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Layout_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Layout_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Layout"));
		}
	}
}
