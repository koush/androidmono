namespace android.text
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class DynamicLayout : android.text.Layout
	{
		internal new static global::java.lang.Class staticClass;
		static DynamicLayout()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.DynamicLayout), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.DynamicLayout(@__env);
			}
		}
		protected DynamicLayout(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineCount7356;
		public override int getLineCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.DynamicLayout._getLineCount7356);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineCount7356);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsizedWidth7357;
		public override int getEllipsizedWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.DynamicLayout._getEllipsizedWidth7357);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getEllipsizedWidth7357);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineTop7358;
		public override int getLineTop(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.DynamicLayout._getLineTop7358, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineTop7358, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineDescent7359;
		public override int getLineDescent(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.DynamicLayout._getLineDescent7359, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineDescent7359, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineStart7360;
		public override int getLineStart(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.DynamicLayout._getLineStart7360, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineStart7360, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParagraphDirection7361;
		public override int getParagraphDirection(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.DynamicLayout._getParagraphDirection7361, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getParagraphDirection7361, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineContainsTab7362;
		public override bool getLineContainsTab(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.DynamicLayout._getLineContainsTab7362, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineContainsTab7362, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineDirections7363;
		public sealed override global::android.text.Layout.Directions getLineDirections(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Directions>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.DynamicLayout._getLineDirections7363, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Directions>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getLineDirections7363, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTopPadding7364;
		public override int getTopPadding() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.DynamicLayout._getTopPadding7364);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getTopPadding7364);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBottomPadding7365;
		public override int getBottomPadding() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.DynamicLayout._getBottomPadding7365);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getBottomPadding7365);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsisStart7366;
		public override int getEllipsisStart(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.DynamicLayout._getEllipsisStart7366, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getEllipsisStart7366, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsisCount7367;
		public override int getEllipsisCount(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.DynamicLayout._getEllipsisCount7367, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._getEllipsisCount7367, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DynamicLayout7368;
		public DynamicLayout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, bool arg6)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._DynamicLayout7368, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DynamicLayout7369;
		public DynamicLayout(java.lang.CharSequence arg0, java.lang.CharSequence arg1, android.text.TextPaint arg2, int arg3, android.text.Layout.Alignment arg4, float arg5, float arg6, bool arg7)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._DynamicLayout7369, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DynamicLayout7370;
		public DynamicLayout(java.lang.CharSequence arg0, java.lang.CharSequence arg1, android.text.TextPaint arg2, int arg3, android.text.Layout.Alignment arg4, float arg5, float arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.DynamicLayout.staticClass, global::android.text.DynamicLayout._DynamicLayout7370, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.DynamicLayout.staticClass = @__class;
			global::android.text.DynamicLayout._getLineCount7356 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getLineCount", "()I");
			global::android.text.DynamicLayout._getEllipsizedWidth7357 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getEllipsizedWidth", "()I");
			global::android.text.DynamicLayout._getLineTop7358 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getLineTop", "(I)I");
			global::android.text.DynamicLayout._getLineDescent7359 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getLineDescent", "(I)I");
			global::android.text.DynamicLayout._getLineStart7360 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getLineStart", "(I)I");
			global::android.text.DynamicLayout._getParagraphDirection7361 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getParagraphDirection", "(I)I");
			global::android.text.DynamicLayout._getLineContainsTab7362 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getLineContainsTab", "(I)Z");
			global::android.text.DynamicLayout._getLineDirections7363 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;");
			global::android.text.DynamicLayout._getTopPadding7364 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getTopPadding", "()I");
			global::android.text.DynamicLayout._getBottomPadding7365 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getBottomPadding", "()I");
			global::android.text.DynamicLayout._getEllipsisStart7366 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getEllipsisStart", "(I)I");
			global::android.text.DynamicLayout._getEllipsisCount7367 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "getEllipsisCount", "(I)I");
			global::android.text.DynamicLayout._DynamicLayout7368 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V");
			global::android.text.DynamicLayout._DynamicLayout7369 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V");
			global::android.text.DynamicLayout._DynamicLayout7370 = @__env.GetMethodID(global::android.text.DynamicLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZLandroid/text/TextUtils$TruncateAt;I)V");
		}
	}
}
