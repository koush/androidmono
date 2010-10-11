namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StaticLayout : android.text.Layout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StaticLayout()
		{
			InitJNI();
		}
		protected StaticLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLineCount7874;
		public override int getLineCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getLineCount7874);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineCount7874);
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsizedWidth7875;
		public override int getEllipsizedWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getEllipsizedWidth7875);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getEllipsizedWidth7875);
		}
		internal static global::MonoJavaBridge.MethodId _getLineTop7876;
		public override int getLineTop(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getLineTop7876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineTop7876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDescent7877;
		public override int getLineDescent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getLineDescent7877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineDescent7877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineStart7878;
		public override int getLineStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getLineStart7878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineStart7878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphDirection7879;
		public override int getParagraphDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getParagraphDirection7879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getParagraphDirection7879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineContainsTab7880;
		public override bool getLineContainsTab(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.StaticLayout._getLineContainsTab7880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineContainsTab7880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDirections7881;
		public sealed override global::android.text.Layout.Directions getLineDirections(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.StaticLayout._getLineDirections7881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineDirections7881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
		}
		internal static global::MonoJavaBridge.MethodId _getTopPadding7882;
		public override int getTopPadding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getTopPadding7882);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getTopPadding7882);
		}
		internal static global::MonoJavaBridge.MethodId _getBottomPadding7883;
		public override int getBottomPadding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getBottomPadding7883);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getBottomPadding7883);
		}
		internal static global::MonoJavaBridge.MethodId _getLineForVertical7884;
		public override int getLineForVertical(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getLineForVertical7884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineForVertical7884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisStart7885;
		public override int getEllipsisStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getEllipsisStart7885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getEllipsisStart7885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisCount7886;
		public override int getEllipsisCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.StaticLayout._getEllipsisCount7886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getEllipsisCount7886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _StaticLayout7887;
		public StaticLayout(java.lang.CharSequence arg0, int arg1, int arg2, android.text.TextPaint arg3, int arg4, android.text.Layout.Alignment arg5, float arg6, float arg7, bool arg8)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.StaticLayout.staticClass, global::android.text.StaticLayout._StaticLayout7887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StaticLayout7888;
		public StaticLayout(java.lang.CharSequence arg0, int arg1, int arg2, android.text.TextPaint arg3, int arg4, android.text.Layout.Alignment arg5, float arg6, float arg7, bool arg8, android.text.TextUtils.TruncateAt arg9, int arg10)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.StaticLayout.staticClass, global::android.text.StaticLayout._StaticLayout7888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StaticLayout7889;
		public StaticLayout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, bool arg6)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.StaticLayout.staticClass, global::android.text.StaticLayout._StaticLayout7889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.StaticLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/StaticLayout"));
			global::android.text.StaticLayout._getLineCount7874 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getLineCount", "()I");
			global::android.text.StaticLayout._getEllipsizedWidth7875 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getEllipsizedWidth", "()I");
			global::android.text.StaticLayout._getLineTop7876 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getLineTop", "(I)I");
			global::android.text.StaticLayout._getLineDescent7877 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getLineDescent", "(I)I");
			global::android.text.StaticLayout._getLineStart7878 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getLineStart", "(I)I");
			global::android.text.StaticLayout._getParagraphDirection7879 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getParagraphDirection", "(I)I");
			global::android.text.StaticLayout._getLineContainsTab7880 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getLineContainsTab", "(I)Z");
			global::android.text.StaticLayout._getLineDirections7881 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;");
			global::android.text.StaticLayout._getTopPadding7882 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getTopPadding", "()I");
			global::android.text.StaticLayout._getBottomPadding7883 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getBottomPadding", "()I");
			global::android.text.StaticLayout._getLineForVertical7884 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getLineForVertical", "(I)I");
			global::android.text.StaticLayout._getEllipsisStart7885 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getEllipsisStart", "(I)I");
			global::android.text.StaticLayout._getEllipsisCount7886 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "getEllipsisCount", "(I)I");
			global::android.text.StaticLayout._StaticLayout7887 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V");
			global::android.text.StaticLayout._StaticLayout7888 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZLandroid/text/TextUtils$TruncateAt;I)V");
			global::android.text.StaticLayout._StaticLayout7889 = @__env.GetMethodIDNoThrow(global::android.text.StaticLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V");
		}
	}
}
