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
		internal static global::MonoJavaBridge.MethodId _getLineCount8182;
		public override int getLineCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getLineCount8182);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineCount8182);
		}
		public new int EllipsizedWidth
		{
			get
			{
				return getEllipsizedWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsizedWidth8183;
		public override int getEllipsizedWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getEllipsizedWidth8183);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getEllipsizedWidth8183);
		}
		internal static global::MonoJavaBridge.MethodId _getLineTop8184;
		public override int getLineTop(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getLineTop8184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineTop8184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDescent8185;
		public override int getLineDescent(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getLineDescent8185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineDescent8185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineStart8186;
		public override int getLineStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getLineStart8186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineStart8186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getParagraphDirection8187;
		public override int getParagraphDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getParagraphDirection8187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getParagraphDirection8187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineContainsTab8188;
		public override bool getLineContainsTab(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.DynamicLayout._getLineContainsTab8188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineContainsTab8188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLineDirections8189;
		public sealed override global::android.text.Layout.Directions getLineDirections(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.DynamicLayout._getLineDirections8189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineDirections8189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Layout.Directions;
		}
		public new int TopPadding
		{
			get
			{
				return getTopPadding();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTopPadding8190;
		public override int getTopPadding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getTopPadding8190);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getTopPadding8190);
		}
		public new int BottomPadding
		{
			get
			{
				return getBottomPadding();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBottomPadding8191;
		public override int getBottomPadding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getBottomPadding8191);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getBottomPadding8191);
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisStart8192;
		public override int getEllipsisStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getEllipsisStart8192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getEllipsisStart8192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEllipsisCount8193;
		public override int getEllipsisCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.DynamicLayout._getEllipsisCount8193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getEllipsisCount8193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DynamicLayout8194;
		public DynamicLayout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, bool arg6)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._DynamicLayout8194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DynamicLayout8195;
		public DynamicLayout(java.lang.CharSequence arg0, java.lang.CharSequence arg1, android.text.TextPaint arg2, int arg3, android.text.Layout.Alignment arg4, float arg5, float arg6, bool arg7)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._DynamicLayout8195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DynamicLayout8196;
		public DynamicLayout(java.lang.CharSequence arg0, java.lang.CharSequence arg1, android.text.TextPaint arg2, int arg3, android.text.Layout.Alignment arg4, float arg5, float arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._DynamicLayout8196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.DynamicLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/DynamicLayout"));
			global::android.text.DynamicLayout._getLineCount8182 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getLineCount", "()I");
			global::android.text.DynamicLayout._getEllipsizedWidth8183 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getEllipsizedWidth", "()I");
			global::android.text.DynamicLayout._getLineTop8184 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getLineTop", "(I)I");
			global::android.text.DynamicLayout._getLineDescent8185 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getLineDescent", "(I)I");
			global::android.text.DynamicLayout._getLineStart8186 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getLineStart", "(I)I");
			global::android.text.DynamicLayout._getParagraphDirection8187 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getParagraphDirection", "(I)I");
			global::android.text.DynamicLayout._getLineContainsTab8188 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getLineContainsTab", "(I)Z");
			global::android.text.DynamicLayout._getLineDirections8189 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;");
			global::android.text.DynamicLayout._getTopPadding8190 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getTopPadding", "()I");
			global::android.text.DynamicLayout._getBottomPadding8191 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getBottomPadding", "()I");
			global::android.text.DynamicLayout._getEllipsisStart8192 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getEllipsisStart", "(I)I");
			global::android.text.DynamicLayout._getEllipsisCount8193 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "getEllipsisCount", "(I)I");
			global::android.text.DynamicLayout._DynamicLayout8194 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V");
			global::android.text.DynamicLayout._DynamicLayout8195 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V");
			global::android.text.DynamicLayout._DynamicLayout8196 = @__env.GetMethodIDNoThrow(global::android.text.DynamicLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZLandroid/text/TextUtils$TruncateAt;I)V");
		}
	}
}
