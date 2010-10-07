namespace android.text
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class StaticLayout : android.text.Layout
	{
		internal new static global::java.lang.Class staticClass;
		static StaticLayout()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.StaticLayout), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.StaticLayout(@__env);
			}
		}
		protected StaticLayout(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineCount7582;
		public override int getLineCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.StaticLayout._getLineCount7582);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineCount7582);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsizedWidth7583;
		public override int getEllipsizedWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.StaticLayout._getEllipsizedWidth7583);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getEllipsizedWidth7583);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineTop7584;
		public override int getLineTop(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.StaticLayout._getLineTop7584, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineTop7584, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineDescent7585;
		public override int getLineDescent(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.StaticLayout._getLineDescent7585, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineDescent7585, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineStart7586;
		public override int getLineStart(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.StaticLayout._getLineStart7586, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineStart7586, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParagraphDirection7587;
		public override int getParagraphDirection(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.StaticLayout._getParagraphDirection7587, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getParagraphDirection7587, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineContainsTab7588;
		public override bool getLineContainsTab(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.StaticLayout._getLineContainsTab7588, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineContainsTab7588, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineDirections7589;
		public sealed override global::android.text.Layout.Directions getLineDirections(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Directions>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.StaticLayout._getLineDirections7589, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Directions>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineDirections7589, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTopPadding7590;
		public override int getTopPadding() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.StaticLayout._getTopPadding7590);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getTopPadding7590);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBottomPadding7591;
		public override int getBottomPadding() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.StaticLayout._getBottomPadding7591);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getBottomPadding7591);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLineForVertical7592;
		public override int getLineForVertical(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.StaticLayout._getLineForVertical7592, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getLineForVertical7592, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsisStart7593;
		public override int getEllipsisStart(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.StaticLayout._getEllipsisStart7593, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getEllipsisStart7593, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsisCount7594;
		public override int getEllipsisCount(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.StaticLayout._getEllipsisCount7594, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.StaticLayout.staticClass, global::android.text.StaticLayout._getEllipsisCount7594, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _StaticLayout7595;
		public StaticLayout(java.lang.CharSequence arg0, int arg1, int arg2, android.text.TextPaint arg3, int arg4, android.text.Layout.Alignment arg5, float arg6, float arg7, bool arg8)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.StaticLayout.staticClass, global::android.text.StaticLayout._StaticLayout7595, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8));
		}
		internal static global::net.sf.jni4net.jni.MethodId _StaticLayout7596;
		public StaticLayout(java.lang.CharSequence arg0, int arg1, int arg2, android.text.TextPaint arg3, int arg4, android.text.Layout.Alignment arg5, float arg6, float arg7, bool arg8, android.text.TextUtils.TruncateAt arg9, int arg10)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.StaticLayout.staticClass, global::android.text.StaticLayout._StaticLayout7596, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10));
		}
		internal static global::net.sf.jni4net.jni.MethodId _StaticLayout7597;
		public StaticLayout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, bool arg6)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.StaticLayout.staticClass, global::android.text.StaticLayout._StaticLayout7597, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.StaticLayout.staticClass = @__class;
			global::android.text.StaticLayout._getLineCount7582 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getLineCount", "()I");
			global::android.text.StaticLayout._getEllipsizedWidth7583 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getEllipsizedWidth", "()I");
			global::android.text.StaticLayout._getLineTop7584 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getLineTop", "(I)I");
			global::android.text.StaticLayout._getLineDescent7585 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getLineDescent", "(I)I");
			global::android.text.StaticLayout._getLineStart7586 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getLineStart", "(I)I");
			global::android.text.StaticLayout._getParagraphDirection7587 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getParagraphDirection", "(I)I");
			global::android.text.StaticLayout._getLineContainsTab7588 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getLineContainsTab", "(I)Z");
			global::android.text.StaticLayout._getLineDirections7589 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;");
			global::android.text.StaticLayout._getTopPadding7590 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getTopPadding", "()I");
			global::android.text.StaticLayout._getBottomPadding7591 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getBottomPadding", "()I");
			global::android.text.StaticLayout._getLineForVertical7592 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getLineForVertical", "(I)I");
			global::android.text.StaticLayout._getEllipsisStart7593 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getEllipsisStart", "(I)I");
			global::android.text.StaticLayout._getEllipsisCount7594 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getEllipsisCount", "(I)I");
			global::android.text.StaticLayout._StaticLayout7595 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V");
			global::android.text.StaticLayout._StaticLayout7596 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZLandroid/text/TextUtils$TruncateAt;I)V");
			global::android.text.StaticLayout._StaticLayout7597 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V");
		}
	}
}
