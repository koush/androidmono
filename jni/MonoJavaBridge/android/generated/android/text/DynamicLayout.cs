namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DynamicLayout : android.text.Layout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DynamicLayout()
		{
			InitJNI();
		}
		protected DynamicLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLineCount7636;
		public override int getLineCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getLineCount7636);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineCount7636);
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsizedWidth7637;
		public override int getEllipsizedWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getEllipsizedWidth7637);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getEllipsizedWidth7637);
		}
		internal static global::MonoJavaBridge.MethodId _getLineTop7638;
		public override int getLineTop(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getLineTop7638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineTop7638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDescent7639;
		public override int getLineDescent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getLineDescent7639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineDescent7639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineStart7640;
		public override int getLineStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getLineStart7640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineStart7640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphDirection7641;
		public override int getParagraphDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getParagraphDirection7641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getParagraphDirection7641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineContainsTab7642;
		public override bool getLineContainsTab(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.DynamicLayout._getLineContainsTab7642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineContainsTab7642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDirections7643;
		public sealed override global::android.text.Layout.Directions getLineDirections(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.DynamicLayout._getLineDirections7643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineDirections7643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
		}
		internal static global::MonoJavaBridge.MethodId _getTopPadding7644;
		public override int getTopPadding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getTopPadding7644);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getTopPadding7644);
		}
		internal static global::MonoJavaBridge.MethodId _getBottomPadding7645;
		public override int getBottomPadding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getBottomPadding7645);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getBottomPadding7645);
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisStart7646;
		public override int getEllipsisStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getEllipsisStart7646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getEllipsisStart7646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisCount7647;
		public override int getEllipsisCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getEllipsisCount7647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getEllipsisCount7647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DynamicLayout7648;
		public DynamicLayout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, bool arg6)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._DynamicLayout7648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DynamicLayout7649;
		public DynamicLayout(java.lang.CharSequence arg0, java.lang.CharSequence arg1, android.text.TextPaint arg2, int arg3, android.text.Layout.Alignment arg4, float arg5, float arg6, bool arg7)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._DynamicLayout7649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DynamicLayout7650;
		public DynamicLayout(java.lang.CharSequence arg0, java.lang.CharSequence arg1, android.text.TextPaint arg2, int arg3, android.text.Layout.Alignment arg4, float arg5, float arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._DynamicLayout7650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.DynamicLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/DynamicLayout"));
			global::android.text.DynamicLayout._getLineCount7636 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getLineCount", "()I");
			global::android.text.DynamicLayout._getEllipsizedWidth7637 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getEllipsizedWidth", "()I");
			global::android.text.DynamicLayout._getLineTop7638 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getLineTop", "(I)I");
			global::android.text.DynamicLayout._getLineDescent7639 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getLineDescent", "(I)I");
			global::android.text.DynamicLayout._getLineStart7640 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getLineStart", "(I)I");
			global::android.text.DynamicLayout._getParagraphDirection7641 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getParagraphDirection", "(I)I");
			global::android.text.DynamicLayout._getLineContainsTab7642 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getLineContainsTab", "(I)Z");
			global::android.text.DynamicLayout._getLineDirections7643 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;");
			global::android.text.DynamicLayout._getTopPadding7644 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getTopPadding", "()I");
			global::android.text.DynamicLayout._getBottomPadding7645 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getBottomPadding", "()I");
			global::android.text.DynamicLayout._getEllipsisStart7646 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getEllipsisStart", "(I)I");
			global::android.text.DynamicLayout._getEllipsisCount7647 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getEllipsisCount", "(I)I");
			global::android.text.DynamicLayout._DynamicLayout7648 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V");
			global::android.text.DynamicLayout._DynamicLayout7649 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V");
			global::android.text.DynamicLayout._DynamicLayout7650 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZLandroid/text/TextUtils$TruncateAt;I)V");
		}
	}
}
