namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StaticLayout : android.text.Layout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StaticLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int LineCount
		{
			get
			{
				return getLineCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int getLineCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.StaticLayout.staticClass, "getLineCount", "()I", ref global::android.text.StaticLayout._m0);
		}
		public new int EllipsizedWidth
		{
			get
			{
				return getEllipsizedWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int getEllipsizedWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.StaticLayout.staticClass, "getEllipsizedWidth", "()I", ref global::android.text.StaticLayout._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int getLineTop(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.StaticLayout.staticClass, "getLineTop", "(I)I", ref global::android.text.StaticLayout._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int getLineDescent(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.StaticLayout.staticClass, "getLineDescent", "(I)I", ref global::android.text.StaticLayout._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int getLineStart(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.StaticLayout.staticClass, "getLineStart", "(I)I", ref global::android.text.StaticLayout._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int getParagraphDirection(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.StaticLayout.staticClass, "getParagraphDirection", "(I)I", ref global::android.text.StaticLayout._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool getLineContainsTab(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.StaticLayout.staticClass, "getLineContainsTab", "(I)Z", ref global::android.text.StaticLayout._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public sealed override global::android.text.Layout.Directions getLineDirections(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.StaticLayout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;", ref global::android.text.StaticLayout._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.text.Layout.Directions;
		}
		public new int TopPadding
		{
			get
			{
				return getTopPadding();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override int getTopPadding()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.StaticLayout.staticClass, "getTopPadding", "()I", ref global::android.text.StaticLayout._m8);
		}
		public new int BottomPadding
		{
			get
			{
				return getBottomPadding();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override int getBottomPadding()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.StaticLayout.staticClass, "getBottomPadding", "()I", ref global::android.text.StaticLayout._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override int getLineForVertical(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.StaticLayout.staticClass, "getLineForVertical", "(I)I", ref global::android.text.StaticLayout._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override int getEllipsisStart(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.StaticLayout.staticClass, "getEllipsisStart", "(I)I", ref global::android.text.StaticLayout._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override int getEllipsisCount(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.StaticLayout.staticClass, "getEllipsisCount", "(I)I", ref global::android.text.StaticLayout._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public StaticLayout(java.lang.CharSequence arg0, int arg1, int arg2, android.text.TextPaint arg3, int arg4, android.text.Layout.Alignment arg5, float arg6, float arg7, bool arg8) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.StaticLayout._m13.native == global::System.IntPtr.Zero)
				global::android.text.StaticLayout._m13 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.StaticLayout.staticClass, global::android.text.StaticLayout._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public StaticLayout(java.lang.CharSequence arg0, int arg1, int arg2, android.text.TextPaint arg3, int arg4, android.text.Layout.Alignment arg5, float arg6, float arg7, bool arg8, android.text.TextUtils.TruncateAt arg9, int arg10) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.StaticLayout._m14.native == global::System.IntPtr.Zero)
				global::android.text.StaticLayout._m14 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZLandroid/text/TextUtils$TruncateAt;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.StaticLayout.staticClass, global::android.text.StaticLayout._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public StaticLayout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, bool arg6) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.StaticLayout._m15.native == global::System.IntPtr.Zero)
				global::android.text.StaticLayout._m15 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.StaticLayout.staticClass, global::android.text.StaticLayout._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		static StaticLayout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.StaticLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/StaticLayout"));
		}
	}
}
