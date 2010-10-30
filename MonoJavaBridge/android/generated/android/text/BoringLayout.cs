namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BoringLayout : android.text.Layout, android.text.TextUtils.EllipsizeCallback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BoringLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Metrics : android.graphics.Paint.FontMetricsInt
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Metrics(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.BoringLayout.Metrics.staticClass, "toString", "()Ljava/lang/String;", ref global::android.text.BoringLayout.Metrics._m0) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public Metrics() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.text.BoringLayout.Metrics._m1.native == global::System.IntPtr.Zero)
					global::android.text.BoringLayout.Metrics._m1 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.Metrics.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.BoringLayout.Metrics.staticClass, global::android.text.BoringLayout.Metrics._m1);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _width5188;
			public int width
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _width5188);
				}
				set
				{
				}
			}
			static Metrics()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.BoringLayout.Metrics.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/BoringLayout$Metrics"));
				global::android.text.BoringLayout.Metrics._width5188 = @__env.GetFieldIDNoThrow(global::android.text.BoringLayout.Metrics.staticClass, "width", "I");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.text.BoringLayout make(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.BoringLayout._m0.native == global::System.IntPtr.Zero)
				global::android.text.BoringLayout._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "make", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;ZLandroid/text/TextUtils$TruncateAt;I)Landroid/text/BoringLayout;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.BoringLayout.staticClass, global::android.text.BoringLayout._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9))) as android.text.BoringLayout;
		}
		public static android.text.BoringLayout make(string arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9)
		{
			return make((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.text.BoringLayout make(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.BoringLayout._m1.native == global::System.IntPtr.Zero)
				global::android.text.BoringLayout._m1 = @__env.GetStaticMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "make", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;Z)Landroid/text/BoringLayout;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.BoringLayout.staticClass, global::android.text.BoringLayout._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as android.text.BoringLayout;
		}
		public static android.text.BoringLayout make(string arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7)
		{
			return make((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void draw(android.graphics.Canvas arg0, android.graphics.Path arg1, android.graphics.Paint arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.BoringLayout.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Path;Landroid/graphics/Paint;I)V", ref global::android.text.BoringLayout._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int getHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.BoringLayout.staticClass, "getHeight", "()I", ref global::android.text.BoringLayout._m3);
		}
		public new int LineCount
		{
			get
			{
				return getLineCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int getLineCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.BoringLayout.staticClass, "getLineCount", "()I", ref global::android.text.BoringLayout._m4);
		}
		public new int EllipsizedWidth
		{
			get
			{
				return getEllipsizedWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int getEllipsizedWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.BoringLayout.staticClass, "getEllipsizedWidth", "()I", ref global::android.text.BoringLayout._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int getLineTop(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.BoringLayout.staticClass, "getLineTop", "(I)I", ref global::android.text.BoringLayout._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override int getLineDescent(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.BoringLayout.staticClass, "getLineDescent", "(I)I", ref global::android.text.BoringLayout._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override int getLineStart(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.BoringLayout.staticClass, "getLineStart", "(I)I", ref global::android.text.BoringLayout._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override int getParagraphDirection(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.BoringLayout.staticClass, "getParagraphDirection", "(I)I", ref global::android.text.BoringLayout._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override bool getLineContainsTab(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.BoringLayout.staticClass, "getLineContainsTab", "(I)Z", ref global::android.text.BoringLayout._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public sealed override global::android.text.Layout.Directions getLineDirections(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.BoringLayout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;", ref global::android.text.BoringLayout._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.text.Layout.Directions;
		}
		public new int TopPadding
		{
			get
			{
				return getTopPadding();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override int getTopPadding()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.BoringLayout.staticClass, "getTopPadding", "()I", ref global::android.text.BoringLayout._m12);
		}
		public new int BottomPadding
		{
			get
			{
				return getBottomPadding();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override int getBottomPadding()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.BoringLayout.staticClass, "getBottomPadding", "()I", ref global::android.text.BoringLayout._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override float getLineMax(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.text.BoringLayout.staticClass, "getLineMax", "(I)F", ref global::android.text.BoringLayout._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override int getEllipsisStart(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.BoringLayout.staticClass, "getEllipsisStart", "(I)I", ref global::android.text.BoringLayout._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override int getEllipsisCount(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.BoringLayout.staticClass, "getEllipsisCount", "(I)I", ref global::android.text.BoringLayout._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::android.text.BoringLayout replaceOrMake(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.BoringLayout.staticClass, "replaceOrMake", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;Z)Landroid/text/BoringLayout;", ref global::android.text.BoringLayout._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7)) as android.text.BoringLayout;
		}
		public android.text.BoringLayout replaceOrMake(string arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7)
		{
			return replaceOrMake((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::android.text.BoringLayout replaceOrMake(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.BoringLayout.staticClass, "replaceOrMake", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;ZLandroid/text/TextUtils$TruncateAt;I)Landroid/text/BoringLayout;", ref global::android.text.BoringLayout._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9)) as android.text.BoringLayout;
		}
		public android.text.BoringLayout replaceOrMake(string arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9)
		{
			return replaceOrMake((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static global::android.text.BoringLayout.Metrics isBoring(java.lang.CharSequence arg0, android.text.TextPaint arg1, android.text.BoringLayout.Metrics arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.BoringLayout._m19.native == global::System.IntPtr.Zero)
				global::android.text.BoringLayout._m19 = @__env.GetStaticMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "isBoring", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;Landroid/text/BoringLayout$Metrics;)Landroid/text/BoringLayout$Metrics;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.BoringLayout.staticClass, global::android.text.BoringLayout._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.BoringLayout.Metrics;
		}
		public static android.text.BoringLayout.Metrics isBoring(string arg0, android.text.TextPaint arg1, android.text.BoringLayout.Metrics arg2)
		{
			return isBoring((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static global::android.text.BoringLayout.Metrics isBoring(java.lang.CharSequence arg0, android.text.TextPaint arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.BoringLayout._m20.native == global::System.IntPtr.Zero)
				global::android.text.BoringLayout._m20 = @__env.GetStaticMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "isBoring", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;)Landroid/text/BoringLayout$Metrics;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.BoringLayout.staticClass, global::android.text.BoringLayout._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.BoringLayout.Metrics;
		}
		public static android.text.BoringLayout.Metrics isBoring(string arg0, android.text.TextPaint arg1)
		{
			return isBoring((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void ellipsized(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.BoringLayout.staticClass, "ellipsized", "(II)V", ref global::android.text.BoringLayout._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public BoringLayout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.BoringLayout._m22.native == global::System.IntPtr.Zero)
				global::android.text.BoringLayout._m22 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;ZLandroid/text/TextUtils$TruncateAt;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.BoringLayout.staticClass, global::android.text.BoringLayout._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public BoringLayout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.BoringLayout._m23.native == global::System.IntPtr.Zero)
				global::android.text.BoringLayout._m23 = @__env.GetMethodIDNoThrow(global::android.text.BoringLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.BoringLayout.staticClass, global::android.text.BoringLayout._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			Init(@__env, handle);
		}
		static BoringLayout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.BoringLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/BoringLayout"));
		}
		internal static void InitJNI()
		{
		}
	}
}
