namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DynamicLayout : android.text.Layout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DynamicLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.DynamicLayout.staticClass, "getLineCount", "()I", ref global::android.text.DynamicLayout._m0);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.DynamicLayout.staticClass, "getEllipsizedWidth", "()I", ref global::android.text.DynamicLayout._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int getLineTop(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.DynamicLayout.staticClass, "getLineTop", "(I)I", ref global::android.text.DynamicLayout._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int getLineDescent(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.DynamicLayout.staticClass, "getLineDescent", "(I)I", ref global::android.text.DynamicLayout._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int getLineStart(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.DynamicLayout.staticClass, "getLineStart", "(I)I", ref global::android.text.DynamicLayout._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int getParagraphDirection(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.DynamicLayout.staticClass, "getParagraphDirection", "(I)I", ref global::android.text.DynamicLayout._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool getLineContainsTab(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.DynamicLayout.staticClass, "getLineContainsTab", "(I)Z", ref global::android.text.DynamicLayout._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public sealed override global::android.text.Layout.Directions getLineDirections(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.DynamicLayout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;", ref global::android.text.DynamicLayout._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.text.Layout.Directions;
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.DynamicLayout.staticClass, "getTopPadding", "()I", ref global::android.text.DynamicLayout._m8);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.DynamicLayout.staticClass, "getBottomPadding", "()I", ref global::android.text.DynamicLayout._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override int getEllipsisStart(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.DynamicLayout.staticClass, "getEllipsisStart", "(I)I", ref global::android.text.DynamicLayout._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override int getEllipsisCount(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.DynamicLayout.staticClass, "getEllipsisCount", "(I)I", ref global::android.text.DynamicLayout._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public DynamicLayout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, bool arg6) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.DynamicLayout._m12.native == global::System.IntPtr.Zero)
				global::android.text.DynamicLayout._m12 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public DynamicLayout(java.lang.CharSequence arg0, java.lang.CharSequence arg1, android.text.TextPaint arg2, int arg3, android.text.Layout.Alignment arg4, float arg5, float arg6, bool arg7) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.DynamicLayout._m13.native == global::System.IntPtr.Zero)
				global::android.text.DynamicLayout._m13 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public DynamicLayout(java.lang.CharSequence arg0, java.lang.CharSequence arg1, android.text.TextPaint arg2, int arg3, android.text.Layout.Alignment arg4, float arg5, float arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.DynamicLayout._m14.native == global::System.IntPtr.Zero)
				global::android.text.DynamicLayout._m14 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZLandroid/text/TextUtils$TruncateAt;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9));
			Init(@__env, handle);
		}
		static DynamicLayout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.DynamicLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/DynamicLayout"));
		}
		internal static void InitJNI()
		{
		}
	}
}
