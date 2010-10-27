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
		public new int LineCount
		{
			get
			{
				return getLineCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineCount12724;
		public override int getLineCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getLineCount12724);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineCount12724);
		}
		public new int EllipsizedWidth
		{
			get
			{
				return getEllipsizedWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsizedWidth12725;
		public override int getEllipsizedWidth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getEllipsizedWidth12725);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getEllipsizedWidth12725);
		}
		internal static global::MonoJavaBridge.MethodId _getLineTop12726;
		public override int getLineTop(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getLineTop12726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineTop12726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDescent12727;
		public override int getLineDescent(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getLineDescent12727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineDescent12727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineStart12728;
		public override int getLineStart(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getLineStart12728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineStart12728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphDirection12729;
		public override int getParagraphDirection(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getParagraphDirection12729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getParagraphDirection12729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineContainsTab12730;
		public override bool getLineContainsTab(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.DynamicLayout._getLineContainsTab12730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineContainsTab12730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDirections12731;
		public sealed override global::android.text.Layout.Directions getLineDirections(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.DynamicLayout._getLineDirections12731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineDirections12731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
		}
		public new int TopPadding
		{
			get
			{
				return getTopPadding();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTopPadding12732;
		public override int getTopPadding()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getTopPadding12732);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getTopPadding12732);
		}
		public new int BottomPadding
		{
			get
			{
				return getBottomPadding();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottomPadding12733;
		public override int getBottomPadding()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getBottomPadding12733);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getBottomPadding12733);
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisStart12734;
		public override int getEllipsisStart(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getEllipsisStart12734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getEllipsisStart12734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisCount12735;
		public override int getEllipsisCount(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getEllipsisCount12735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getEllipsisCount12735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DynamicLayout12736;
		public DynamicLayout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, bool arg6) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._DynamicLayout12736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DynamicLayout12737;
		public DynamicLayout(java.lang.CharSequence arg0, java.lang.CharSequence arg1, android.text.TextPaint arg2, int arg3, android.text.Layout.Alignment arg4, float arg5, float arg6, bool arg7) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._DynamicLayout12737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DynamicLayout12738;
		public DynamicLayout(java.lang.CharSequence arg0, java.lang.CharSequence arg1, android.text.TextPaint arg2, int arg3, android.text.Layout.Alignment arg4, float arg5, float arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._DynamicLayout12738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.DynamicLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/DynamicLayout"));
			global::android.text.DynamicLayout._getLineCount12724 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getLineCount", "()I");
			global::android.text.DynamicLayout._getEllipsizedWidth12725 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getEllipsizedWidth", "()I");
			global::android.text.DynamicLayout._getLineTop12726 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getLineTop", "(I)I");
			global::android.text.DynamicLayout._getLineDescent12727 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getLineDescent", "(I)I");
			global::android.text.DynamicLayout._getLineStart12728 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getLineStart", "(I)I");
			global::android.text.DynamicLayout._getParagraphDirection12729 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getParagraphDirection", "(I)I");
			global::android.text.DynamicLayout._getLineContainsTab12730 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getLineContainsTab", "(I)Z");
			global::android.text.DynamicLayout._getLineDirections12731 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;");
			global::android.text.DynamicLayout._getTopPadding12732 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getTopPadding", "()I");
			global::android.text.DynamicLayout._getBottomPadding12733 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getBottomPadding", "()I");
			global::android.text.DynamicLayout._getEllipsisStart12734 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getEllipsisStart", "(I)I");
			global::android.text.DynamicLayout._getEllipsisCount12735 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getEllipsisCount", "(I)I");
			global::android.text.DynamicLayout._DynamicLayout12736 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V");
			global::android.text.DynamicLayout._DynamicLayout12737 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V");
			global::android.text.DynamicLayout._DynamicLayout12738 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZLandroid/text/TextUtils$TruncateAt;I)V");
		}
	}
}
